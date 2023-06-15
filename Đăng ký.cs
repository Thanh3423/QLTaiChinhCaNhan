using System;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DemoThao
{
    public partial class frmDangKy : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=NGUYENTRANHIEUT\HIEUTHAO;Initial Catalog=CEO1310;Integrated Security=True");

        public frmDangKy()
        {
            InitializeComponent();
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateRegistration()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text) ||
                string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text) || (!rbNam.Checked && !rbNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            DateTime selectedDate = dtpNgaySinh.Value;
            if (DateTime.Compare(selectedDate, DateTime.Today) > 0)
            {
                MessageBox.Show("Ngày nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
            


            string soDienThoai = txtSoDienThoai.Text;
            if (soDienThoai.Length < 7 || soDienThoai.Length > 11 || !IsNumeric(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ (độ dài 7-11 số).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            string tenDangNhap = txtTenDangNhap.Text;
            if (tenDangNhap.Length < 6 || tenDangNhap.Length > 24 || !IsAlphanumeric(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập hợp lệ (độ dài 6-24, chỉ chứa chữ và số).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            string matKhau = txtMatKhau.Text;
            if (matKhau.Length < 6 || matKhau.Length > 24 || !IsAlphanumeric(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hợp lệ (độ dài 6-24, chỉ chứa chữ và số).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            string hoTen = txtHoTen.Text;

            if (hoTen.Length < 3 || hoTen.Length > 100 || !IsAlphabetic(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng họ tên (độ dài 3-100, chỉ chứa chữ)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
      
        private bool CheckDuplicateAccounts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=NGUYENTRANHIEUT\HIEUTHAO;Initial Catalog=CEO1310;Integrated Security=True"))
                {
                    connection.Open();

                    string tenDangNhap = txtTenDangNhap.Text;
                    string soDienThoai = txtSoDienThoai.Text;

                    // Check for duplicate username
                    string queryTenDangNhap = "SELECT COUNT(*) FROM ThongTinNguoiDung WHERE TenDangNhap = @TenDangNhap";
                    SqlCommand commandTenDangNhap = new SqlCommand(queryTenDangNhap, connection);
                    commandTenDangNhap.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    int countTenDangNhap = (int)commandTenDangNhap.ExecuteScalar();

                    if (countTenDangNhap > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Check for duplicate phone number
                    string querySoDienThoai = "SELECT COUNT(*) FROM ThongTinNguoiDung WHERE SoDienThoai = @SoDienThoai";
                    SqlCommand commandSoDienThoai = new SqlCommand(querySoDienThoai, connection);
                    commandSoDienThoai.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    int countSoDienThoai = (int)commandSoDienThoai.ExecuteScalar();

                    if (countSoDienThoai > 0)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                return false;
            }
        }


        private void SaveRegistration()
        {
            try
            {
                connection.Open();

                string hoTen = txtHoTen.Text;
                DateTime ngaySinh = DateTime.Parse(dtpNgaySinh.Text);
                string gioiTinh = GetSelectedGender();
                string soDienThoai = txtSoDienThoai.Text;
                string tenDangNhap = txtTenDangNhap.Text;
                string matKhau = txtMatKhau.Text;

                string query = "INSERT INTO ThongTinNguoiDung (HoTen, NgaySinh, GioiTinh, SoDienThoai, TenDangNhap, MatKhau) " +
                               "VALUES (@HoTen, @NgaySinh, @GioiTinh, @SoDienThoai, @TenDangNhap, @MatKhau)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HoTen", hoTen);
                command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                command.Parameters.AddWithValue("@MatKhau", matKhau);

                command.ExecuteNonQuery();

                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmDangNhap frmdn = new frmDangNhap();
                frmdn.Show();
                this.Hide();


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private string GetSelectedGender()
        {
            if (rbNam.Checked)
            {
                return "Nam";
            }
            else if (rbNu.Checked)
            {
                return "Nữ";
            }
            else
            {
                return "Khác";
            }
        }


        private bool IsNumeric(string input)
        {
            return long.TryParse(input, out _);
        }

        private bool IsAlphanumeric(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
        }

        private bool IsAlphabetic(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, "^[ a-zA-Z]+$");
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }
        

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (ValidateRegistration() && CheckDuplicateAccounts())
            {
                SaveRegistration();
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
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



