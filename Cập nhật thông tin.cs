using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DemoThao
{
    public partial class frmCapNhatThongTin : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=NGUYENTRANHIEUT\HIEUTHAO;Initial Catalog=CEO1310;Integrated Security=True");
        public int userId; // Lưu trữ ID người dùng cần chỉnh sửa
        public frmCapNhatThongTin(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadUserData();
        }


        private void LoadUserData()
        {
            try
            {
                connection.Open();

                string query = "SELECT HoTen, NgaySinh, GioiTinh, SoDienThoai, TenDangNhap, MatKhau FROM ThongTinNguoiDung WHERE Id = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtHoTen.Text = reader["HoTen"].ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(reader["NgaySinh"]);
                    string gioiTinh = reader["GioiTinh"].ToString();
                    if (gioiTinh == "Nam")
                        rbNam.Checked = true;
                    else if (gioiTinh == "Nữ")
                        rbNu.Checked = true;
                    else
                        rbNu.Checked = true;
                    txtSoDienThoai.Text = reader["SoDienThoai"].ToString();
                    txtTenDangNhap.Text = reader["TenDangNhap"].ToString();
                    txtMatKhau.Text = reader["MatKhau"].ToString();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private bool ValidateRegistration()
        {


            string matKhauMoi = txtMatKhauMoi.Text;
            string xacNhanMatKhau = txtConfirmPassword.Text;
            string hoTen=txtHoTen.Text;
            if(!string.IsNullOrEmpty(hoTen))
            {
                if (hoTen.Length < 3 || hoTen.Length > 100 | !IsAlphabetic(hoTen))
                {
                    MessageBox.Show("Vui lòng nhập họ tên chỉ chứa chứ cái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            DateTime selectedDate = dtpNgaySinh.Value;
            if (DateTime.Compare(selectedDate, DateTime.Today) > 0)
            {
                MessageBox.Show("Ngày nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (!string.IsNullOrEmpty(matKhauMoi) || !string.IsNullOrEmpty(xacNhanMatKhau))
            {

                if (matKhauMoi != xacNhanMatKhau)
                {
                    MessageBox.Show("Xác nhận mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (matKhauMoi.Length < 6 || matKhauMoi.Length > 24 || !IsAlphanumeric(matKhauMoi))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới hợp lệ (độ dài 6-24, chỉ chứa chữ và số).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            return true;
        }

        private void UpdateRegistration()
        {
          
            if (string.IsNullOrEmpty(txtHoTen.Text) || (!rbNam.Checked && !rbNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                try
                {
                    connection.Open();

                    string hoTen = txtHoTen.Text;
                    DateTime ngaySinh = dtpNgaySinh.Value;
                    string gioiTinh = GetSelectedGender();
                    string matKhau = txtMatKhau.Text;
                    string matKhauMoi = txtMatKhauMoi.Text;

                    string query = "UPDATE ThongTinNguoiDung SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh ";

                    if (!string.IsNullOrEmpty(matKhauMoi))
                    {
                        query += ", MatKhau = @MatKhauMoi";
                    }

                    query += " WHERE Id = @UserId";
                 //   MessageBox.Show(query);

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@UserId", userId);

                    if (!string.IsNullOrEmpty(matKhauMoi))
                    {
                        command.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
                    }

                    command.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
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

        private bool IsAlphanumeric(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
        }

        private void SuaThongTin_Load(object sender, EventArgs e)
        {

        }

        private bool IsAlphabetic(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, "^[ a-zA-Z]+$");
        }
        private void Sua_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmCapNhatThongTin_Load(object sender, EventArgs e)
        {

        }

        private void Luu_Click_1(object sender, EventArgs e)
        {
            if (ValidateRegistration())
            {
                UpdateRegistration();
            }
        }
    }
}

