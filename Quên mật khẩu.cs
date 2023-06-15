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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DemoThao
{
    public partial class frmQuenMK : Form
    {
        public frmQuenMK()
        {
            InitializeComponent();
            
        }

        private void btnLayMK_Click(object sender, EventArgs e)
        {
            string SoDienThoai = txtSoDienThoai.Text;
            if (string.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string connectionString = "Data Source=NGUYENTRANHIEUT\\HIEUTHAO;Initial Catalog=CEO1310;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT MatKhau FROM ThongTinNguoiDung WHERE SoDienThoai = @SoDienThoai";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string MatKhau = reader.GetString(0);
                                MessageBox.Show("Mật khẩu của bạn là: " + MatKhau, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmDangNhap frmdn = new frmDangNhap();
                                frmdn.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Số điện thoại chưa được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                    connection.Close();
                }
            }
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                frmDangNhap frmdn = new frmDangNhap();
                frmdn.Show();
                this.Hide();
            }
            else
            {


            }
        }
    }
}
