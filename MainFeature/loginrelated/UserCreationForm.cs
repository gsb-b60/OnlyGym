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
    public partial class UserCreationForm : Form
    {
        private string connectionString = Config.connection;
        private int userID;

        private int UserID { get; set; }

        public UserCreationForm(int UserID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Load += UserCreationForm_Load;
            chkTrangThai1.CheckedChanged += chkTrangThai1_CheckedChanged;
            chkTrangThai2.CheckedChanged += chkTrangThai2_CheckedChanged;
        }
        private void chkTrangThai1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrangThai1.Checked)
            {
                chkTrangThai2.Checked = false;
            }
        }

        private void chkTrangThai2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrangThai2.Checked)
            {
                chkTrangThai1.Checked = false;
            }
        }

        private void UserCreationForm_Load(object sender, EventArgs e)
        {
            if (UserID > 0)
            {
                this.Text = "CẬP NHẬT TÀI KHOẢN";
                LoadAccountDetails(); // Tải dữ liệu cũ nếu là chế độ Sửa
                                      // Cấm sửa Tên tài khoản khi ở chế độ Sửa
                txtTenTK.ReadOnly = true;
            }
            else
            {
                this.Text = "THÊM TÀI KHOẢN MỚI";
                // Mật khẩu bắt buộc khi Thêm mới
            }
        }
        private void LoadAccountDetails()
        {
            string query = "SELECT TenTK, email, TrangThai FROM Users WHERE ID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", UserID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read()) // KIỂM TRA: reader.Read() có trả về TRUE không?
                    {
                        // 1. Gán TextBox
                        txtTenTK.Text = reader["TenTK"].ToString();
                        txtEmail.Text = reader["email"].ToString();

                        // 2. Gán CheckBox
                        int trangThaiDB = Convert.ToInt32(reader["TrangThai"]);

                        if (trangThaiDB == 1) // Hoạt động
                        {
                            chkTrangThai1.Checked = true;
                            chkTrangThai2.Checked = false; // Tắt cái còn lại
                        }
                        else // Khóa (0)
                        {
                            chkTrangThai1.Checked = false; // Tắt cái còn lại
                            chkTrangThai2.Checked = true;
                        }
                    }
                    else
                    {
                        // Thông báo nếu không tìm thấy User với ID này
                        MessageBox.Show("Không tìm thấy dữ liệu tài khoản ID: " + UserID, "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Lỗi khi tải dữ liệu chi tiết từ DB: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ cơ bản
            if (string.IsNullOrEmpty(txtTenTK.Text) || (UserID == 0 && string.IsNullOrEmpty(txtMatKhau.Text)))
            {
                MessageBox.Show("Vui lòng nhập Tên TK và Mật Khẩu (khi Thêm mới).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác định trạng thái mới (1 hoặc 0)
            int newTrangThai;
            if (chkTrangThai1.Checked)
            {
                newTrangThai = 1;
            }
            else if (chkTrangThai2.Checked)
            {
                newTrangThai = 0;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trạng thái tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác định Query
            string query;
            string passwordToSave = txtMatKhau.Text;

            if (UserID == 0) // THÊM MỚI (INSERT)
            {
                query = "INSERT INTO Users (TenTK, MatKhau, email, TrangThai) VALUES (@TenTK, @MatKhau, @Email, @TrangThai)";
            }
            else // SỬA (UPDATE)
            {
                if (string.IsNullOrEmpty(txtMatKhau.Text)) // Không đổi mật khẩu
                {
                    query = "UPDATE Users SET email=@Email, TrangThai=@TrangThai WHERE ID=@UserID";
                }
                else // Cập nhật mật khẩu
                {
                    query = "UPDATE Users SET MatKhau=@MatKhau, email=@Email, TrangThai=@TrangThai WHERE ID=@UserID";
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Gán tham số
                command.Parameters.AddWithValue("@TenTK", txtTenTK.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@TrangThai", newTrangThai);

                if (UserID > 0)
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                }

                // Gán mật khẩu chỉ khi cần
                if (!string.IsNullOrEmpty(txtMatKhau.Text) || UserID == 0)
                {
                    command.Parameters.AddWithValue("@MatKhau", passwordToSave);
                }

                // Thực thi và xử lý lỗi
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show((UserID == 0) ? "Thêm tài khoản thành công!" : "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Tên tài khoản hoặc Email đã tồn tại.", "Lỗi Trùng Lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi CSDL: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

