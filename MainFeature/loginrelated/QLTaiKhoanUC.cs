using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymManagerment_MVP.MainFeature.Main
{
    public partial class QLTaiKhoanUC : UserControl
    {
        private string connectionString = Config.connection;
        public QLTaiKhoanUC()
        {
            InitializeComponent();
        }

        private void QLTaiKhoanUC_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        // Load dữ liệu người dùng từ cơ sở dữ liệu và hiển thị trong DataGridView
        private void LoadUserData(string searchKeyword = "")
        {
            string keyword = searchKeyword.Trim();
            bool hasSearch = !string.IsNullOrEmpty(keyword);

            
            string query = "SELECT ID, TenTK, MatKhau, email, TrangThai FROM Users";

            
            if (hasSearch)
            {
                
                query += " WHERE TenTK LIKE @Keyword OR email LIKE @Keyword";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                
                if (hasSearch)
                {
                    command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Xử lý sự kiện tìm kiếm khi người dùng nhập từ khóa
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadUserData(txtTimKiem.Text);
        }

        // Xử lý sự kiện khóa/mở tài khoản
        private void bntKhoaMo_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy ID và Trạng Thái hiện tại
            int selectedID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID"].Value);
            int currentStatus = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["TrangThai"].Value);

            // Đảo trạng thái: 1 -> 0 (Khóa) hoặc 0 -> 1 (Mở khóa)
            int newStatus = (currentStatus == 1) ? 0 : 1;
            string action = (newStatus == 0) ? "khóa" : "mở khóa";

            if (MessageBox.Show($"Bạn có chắc chắn muốn {action} tài khoản ID {selectedID}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "UPDATE Users SET TrangThai = @NewStatus WHERE ID = @SelectedID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewStatus", newStatus);
                    command.Parameters.AddWithValue("@SelectedID", selectedID);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show($"Đã {action} tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUserData(); // Tải lại dữ liệu
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thao tác CSDL: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Xử lý sự kiện thêm, sửa tài khoản 
        // Xử lý sự kiện thêm tài khoản mới
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            UserCreationForm creationForm = new UserCreationForm(0);
            if (creationForm.ShowDialog() == DialogResult.OK)
            {
                LoadUserData(); // Tải lại dữ liệu sau khi Thêm mới thành công
            }
        }

        // Xử lý sự kiện sửa tài khoản
        private void bntSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //  Đảm bảo tên cột trong DataGridView là "ID"
                int selectedID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID"].Value);

                // Truyền ID sang Form Sửa
                UserCreationForm editForm = new UserCreationForm(selectedID);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUserData(); // Tải lại dữ liệu sau khi Cập nhật thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy ID: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
