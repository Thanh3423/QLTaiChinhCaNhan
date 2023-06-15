
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DemoThao
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=NGUYENTRANHIEUT\HIEUTHAO;Initial Catalog=CEO1310;Integrated Security=True");
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private int GetUserId(string tenDangNhap, string matKhau)
        {
            try
            {
                connection.Open();

                string query = "SELECT Id FROM ThongTinNguoiDung WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                command.Parameters.AddWithValue("@MatKhau", matKhau);

                object result = command.ExecuteScalar();

                connection.Close();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

            return -1;
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;


            if ((tenDangNhap.Trim() == "") || (matKhau.Trim() == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int userId = GetUserId(tenDangNhap, matKhau);
                if (userId != -1)
                {
                    // Đăng nhập thành công
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển đến Form hoặc UserControl tiếp theo để sửa thông tin
                    frmCapNhatThongTin editForm = new frmCapNhatThongTin(userId);
                    editForm.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void llblDangKy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy frmdk = new frmDangKy();
            frmdk.Show();
            this.Hide();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {


            }
        }

        private void llblLayMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMK frmqmk = new frmQuenMK();
            frmqmk.Show();
            this.Hide();
        }
    }
}

