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
using DataAccess.Object;

namespace GymManagerment_MVP.MainFeature.Main
{
    public partial class LOGIN : Form
    {
        public User user;
        // kết nối database
        private string connectionString = Config.connection;
        public LOGIN()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            // kiểm tra tài khoản và mật khẩu có trống  
            if (string.IsNullOrEmpty(txtTenTK.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //sql
            string username = txtTenTK.Text;
            string password = txtMatKhau.Text;

            string query = "SELECT ID, MatKhau, TrangThai FROM Users WHERE TenTK = @TenTK_Parameter";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số để chống SQL Injection
                    command.Parameters.AddWithValue("@TenTK_Parameter", username);


                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Tài khoản tồn tại, lấy thông tin
                        string matKhauHash = reader["MatKhau"].ToString();
                        int trangThai = Convert.ToInt32(reader["TrangThai"]);


                        //  Kiểm tra mật khẩu
                        if (password == matKhauHash)
                        {
                            // Mật khẩu đúng, kiểm tra trạng thái
                            if (trangThai == 1) // 1: Đang hoạt động
                            {
                                // Đăng nhập thành công!
                                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Chuyển Form
                                Mainfrm mainForm = new Mainfrm();
                                mainForm.Show();
                                this.Hide(); // Ẩn Form Login hiện tại
                            }
                            else // 0: Không hoạt động / Bị khóa
                            {
                                // 4. Tài khoản bị khóa
                                MessageBox.Show("TÀI KHOẢN CỦA BẠN ĐÃ BỊ KHÓA", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // 5. Sai mật khẩu
                            MessageBox.Show("SAI MẬT KHẨU HOẶC TÊN ĐĂNG NHẬP", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // 5. Sai tên tài khoản (Không tìm thấy)
                        MessageBox.Show("SAI MẬT KHẨU HOẶC TÊN ĐĂNG NHẬP", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                    //try
                    //{
                    //    connection.Open();
                    //    SqlDataReader reader = command.ExecuteReader();

                    //    if (reader.Read())
                    //    {
                    //        // Tài khoản tồn tại, lấy thông tin
                    //        string matKhauHash = reader["MatKhau"].ToString();
                    //        int trangThai = Convert.ToInt32(reader["TrangThai"]);


                    //        //  Kiểm tra mật khẩu
                    //        if (password == matKhauHash)
                    //        {
                    //            // Mật khẩu đúng, kiểm tra trạng thái
                    //            if (trangThai == 1) // 1: Đang hoạt động
                    //            {
                    //                // Đăng nhập thành công!
                    //                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //                // Chuyển Form
                    //                Mainfrm mainForm = new Mainfrm();
                    //                mainForm.Show();
                    //                this.Hide(); // Ẩn Form Login hiện tại
                    //            }
                    //            else // 0: Không hoạt động / Bị khóa
                    //            {
                    //                // 4. Tài khoản bị khóa
                    //                MessageBox.Show("TÀI KHOẢN CỦA BẠN ĐÃ BỊ KHÓA", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //            }
                    //        }
                    //        else
                    //        {
                    //            // 5. Sai mật khẩu
                    //            MessageBox.Show("SAI MẬT KHẨU HOẶC TÊN ĐĂNG NHẬP", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        }
                    //    }
                    //    else
                    //    {
                    //        // 5. Sai tên tài khoản (Không tìm thấy)
                    //        MessageBox.Show("SAI MẬT KHẨU HOẶC TÊN ĐĂNG NHẬP", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //    reader.Close();
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
            }

        }
        // checkbox hiển thị mật khẩu
        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = true; // Hiển thị mật khẩu
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false; // Ẩn mật khẩu
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                TenTK = "Teamate",
                TrangThai = TrangThaiTK.Admin,
                Create_At = DateTime.Now
            };
            this.user = user;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                TenTK = "Teamate",
                TrangThai = TrangThaiTK.Cashier,
                Create_At = DateTime.Now
            };
            this.user = user;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
