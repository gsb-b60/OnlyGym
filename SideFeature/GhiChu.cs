using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagerment_MVP.SideFeature
{
    public partial class frmGhiChu : Form
    {
        DanhSachThietBiUC DanhSachThietBiUC;
        private int _id;
        private string _tenTB;
        private string _tinhTrang;


        public frmGhiChu(int id, string tenTB, string tinhTrang)
        {
            InitializeComponent();
            _id = id;
            _tenTB = tenTB;
            _tinhTrang = tinhTrang;
        }

        private void ShowTBInformation()
        {
            tbBDID.Text = _id.ToString();
            tbBDTenTB.Text = _tenTB;
            tbBDTinhTrang.Text = _tinhTrang;
        }
        private void frmGhiChu_Load(object sender, EventArgs e)
        {
            TaoTextInput();
            ShowTBInformation();
        }



        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Picture";
            dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
                         + "*.jpg;*.jpeg;*.gif;*.bmp;"
                         + "*.tif;*.tiff;*.png|"
                         + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
                         + "GIF files (*.gif)|*.gif|"
                         + "BMP files (*.bmp)|*.bmp|"
                         + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
                         + "PNG files (*.png)|*.png|"
                         + "All files (*.*)|*.*";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var fileName = dlg.FileName;
                pbHInhHuHai.Load(fileName);
                tbURL.Text = fileName;
            }
        }

        private void TaoTextInput()
        {
            tbThemVanDe.Text = "Nhập vấn đề của thiết bị";

            tbThemVanDe.GotFocus += TbThemVanDeOnGotFocus;
            //tbThemVanDe.LostFocus += TbThemVanDeOnLostFocus;

            tbHuongDan.GotFocus += TbHuongDanOnGotFocus;
            //tbHuongDan.LostFocus += TbHuongDanOnLostFocus;
        }

        //private void TbThemVanDeOnLostFocus(object sender, EventArgs e)
        //{
        //    tbThemVanDe.Text = "Nhập vấn đề của thiết bị";

        //}

        private void TbThemVanDeOnGotFocus(object sender, EventArgs e)
        {
            tbThemVanDe.Text = "";


        }
        //private void TbHuongDanOnLostFocus(object sender, EventArgs e)
        //{
        //    tbHuongDan.Text = "Nhập hướng dẫn sửa chữa";

        //}

        private void TbHuongDanOnGotFocus(object sender, EventArgs e)
        {
            tbHuongDan.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ThemGhiChu()
        {
            int id;
            if (!int.TryParse(tbBDID.Text, out id))
            {
                MessageBox.Show("ID thiết bị không hợp lệ.", "Thông báo");
                return;
            }
            string vanDe = tbThemVanDe.Text;
            string ngayGhiChu = dtpNgayGhiChu.Text;
            string baoDuong = tbHuongDan.Text;

            if (string.IsNullOrWhiteSpace(vanDe) || vanDe == "Nhập vấn đề của thiết bị" ||
                string.IsNullOrWhiteSpace(baoDuong) || baoDuong == "Nhập hướng dẫn sửa chữa")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi tạo", "Thông báo");
                return;
            }

            var connectionString = "server=LAPTOP-470KBPRO; database=GymManagement; integrated security = true";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO DanhSachGhiChu (ID, VanDe, ThoiGian, BaoDuong) VALUES (@id, @vanDe, @thoiGian, @baoDuong)";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@vanDe", vanDe);
                cmd.Parameters.AddWithValue("@thoiGian", ngayGhiChu);
                cmd.Parameters.AddWithValue("@baoDuong", baoDuong);

                try
                {
                    sqlConnection.Open();
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK);


                        //if (this.Owner is danhSachThietBiUC thietBiForm)
                        //{
                        //    thietBiForm.DocDuLieuGCTuDB();
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra khi thêm mới.", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi chú: " + ex.Message, "Thông báo");
                }
            }
        }
    }
}
