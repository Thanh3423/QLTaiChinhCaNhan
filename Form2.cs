using System;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Text.RegularExpressions;

namespace QLVay
{
    public partial class Form2 : Form
    {
        public static string connectionString = "data source = NHUNGOC\\NHUNGOC; " +
            "Initial catalog= QLTCCaNhan; user id = sa; password= Nhungoc123#";
        DataSet ds = new DataSet();
        public static String status = "";

        public Form2()
        {
            InitializeComponent();
            status = "Reset";
            SetControlStatus("Reset");
            BindingData();
            LoadcboId("select *from TaiKhoan", "id", "id");

        }
        public void LoadcboId(string query, string dis, string valu)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            cboId.DataSource = ds.Tables[0];
            cboId.DisplayMember = dis;
            cboId.ValueMember = valu;

        }
        public void BindingData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM dbo.QLVay";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvVay.DataSource = ds.Tables[0];
                    cboId.Text = ds.Tables[0].Rows[0]["id"].ToString();
                    txtMaVay.Text = ds.Tables[0].Rows[0]["MaVay"].ToString();
                    txtNgChoVay.Text = ds.Tables[0].Rows[0]["TenNguoiChoVay"].ToString();
                    txtTienVay.Text = ds.Tables[0].Rows[0]["SoTien"].ToString();
                    dtpNgayVay.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgayVay"]);
                    dtpNgayTra.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgayTraDuKien"]);
                    txtLaiSuat.Text = ds.Tables[0].Rows[0]["LaiSuat"].ToString();
                    txtTienLai.Text = ds.Tables[0].Rows[0]["TienLaiDuKien"].ToString();
                    txtThanhTien.Text = ds.Tables[0].Rows[0]["ThanhTien"].ToString();

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void SetControlStatus(String State)
        {
            switch (State)
            {
                case "Reset":
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;

                    cboId.Enabled = false;
                    txtNgChoVay.Enabled = false;
                    txtMaVay.Enabled = false;
                    txtTienVay.Enabled = false;
                    dtpNgayVay.Enabled = false;
                    dtpNgayTra.Enabled = false;
                    txtLaiSuat.Enabled = false;
                    txtTienLai.Enabled = false;
                    txtThanhTien.Enabled = false;
                    break;
                case "Insert":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    cboId.Enabled = true;
                    txtNgChoVay.Enabled = true;
                    txtMaVay.Enabled = false;
                    txtTienVay.Enabled = true;
                    dtpNgayVay.Enabled = true;
                    dtpNgayTra.Enabled = true;
                    txtLaiSuat.Enabled = true;
                    txtTienLai.Enabled = false;
                    txtThanhTien.Enabled = false;

                    txtThanhTien.Text = "";
                    txtMaVay.Text = "";
                    txtNgChoVay.Text = "";
                    txtTienVay.Text = "";
                    txtLaiSuat.Text = "";
                    txtNgChoVay.Focus();
                    break;
                case "Edit":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    cboId.Enabled = true;
                    txtNgChoVay.Enabled = true;
                    txtMaVay.Enabled = false;
                    txtTienVay.Enabled = true;
                    dtpNgayVay.Enabled = true;
                    dtpNgayTra.Enabled = true;
                    txtLaiSuat.Enabled = true;
                    txtTienLai.Enabled = false;
                    txtThanhTien.Enabled= false;

                    txtNgChoVay.Focus();
                    break;
                default:
                    break;
            }
        }
        
        public bool checkName(string n)
        {

            return Regex.IsMatch(n, "^[ a-zA-Z]{2,50}$"); //CHECK ten

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dgvVay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvVay.Rows[e.RowIndex];
                cboId.Text = row.Cells["id"].Value.ToString();
                txtMaVay.Text = row.Cells["MaVay"].Value.ToString();
                txtNgChoVay.Text = row.Cells["TenNguoiChoVay"].Value.ToString();
                txtTienVay.Text = row.Cells["SoTien"].Value.ToString();
                dtpNgayVay.Value = Convert.ToDateTime(row.Cells["NgayVay"].Value);
                dtpNgayTra.Value = Convert.ToDateTime(row.Cells["NgayTraDuKien"].Value);
                txtLaiSuat.Text = row.Cells["LaiSuat"].Value.ToString();
                txtTienLai.Text = row.Cells["TienLaiDuKien"].Value.ToString();
                txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Insert";
            SetControlStatus("Insert");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = "Edit";
            SetControlStatus("Edit");
        }

        private void txtTienLai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string ten = txtNgChoVay.Text;
            if (!checkName(ten))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (dtpNgayVay.Value > dtpNgayTra.Value)
            {
                MessageBox.Show("Lỗi ngày tháng năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNgChoVay.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Bạn chưa điền tên người cho vay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgChoVay.Focus();
                return;
            }
            if (txtTienVay.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Bạn chưa điền số tiền vay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTienVay.Focus();
                return;
            }

            // Lấy thông tin về ngày tháng năm vay và ngày tháng năm trả
            DateTime ngayVay = dtpNgayVay.Value;
            DateTime ngayTra = dtpNgayTra.Value;
            // Lấy số tiền gốc
            double tienVay = double.Parse(txtTienVay.Text);
            // Tính tiền lãi
            TimeSpan timeSpan = ngayTra - ngayVay; //lưu trữ giá trị của khoảng thời gian này dưới dạng số nguyên, đại diện cho số ngày, giờ, phút, giây, và mili giây giữa hai ngày
            int totalDays = (int)timeSpan.TotalDays;
            int daysInYear = DateTime.IsLeapYear(ngayVay.Year) ? 366 : 365;
            double laiSuat = (double.Parse(txtLaiSuat.Text)) / 100;
            double laiHangNgay = laiSuat / daysInYear; // tỷ lệ lãi suất hàng ngày
            double tienLai = tienVay * laiHangNgay * totalDays;
            double thanhTien = tienVay + tienLai;
            if(tienVay <0)
            {
                MessageBox.Show("Số tiền phải lớn hơn không");
                return;
            }
            if (laiSuat<0)
            {
                MessageBox.Show("Lãi suất phải lớn hơn hoặc bằng không");
                return;
            }
            if (status == "Insert")
            {
                
                //insert data
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "INSERT INTO dbo.QLVay VALUES('" + txtMaVay.Text.Trim() + "', '" + txtNgChoVay.Text.Trim() + "', '" + txtTienVay.Text.Trim() + "','" + dtpNgayVay.Value.ToString("MM/dd/yyyy") + "', '" + dtpNgayTra.Value.ToString("MM/dd/yyyy") + "','" + txtLaiSuat.Text.Trim() + "','" + cboId.Text.Trim() + "','" + tienLai + "','" + thanhTien + "')";
                //string query = "INSERT INTO dbo.QLVay VALUES('" + txtMaVay.Text.Trim() + "','" + txtNgChoVay.Text.Trim() + "','" + txtTienVay.Text.Trim() + "','" + dtpNgayVay.Value.ToString("MM/dd/yyyy") + "','" + dtpNgayTra.Value.ToString("MM/dd/yyyy")+ "','" + txtLaiSuat.Text.Trim() + "','" + cboId.SelectedItem.ToString() + "','" + tienLai + "','" + thanhTien + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Them thanh cong");
                    status = "Reset";
                    SetControlStatus(status);
                    BindingData();
                }
                else
                {
                    MessageBox.Show("Loi");
                }
            }
            

            else
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "UPDATE dbo.QLVay SET TenNguoiChoVay = '" + txtNgChoVay.Text.Trim() +
                    "', SoTien = '" + txtTienVay.Text.Trim() + "', NgayVay = '" +
                    dtpNgayVay.Value.ToString("MM/dd/yyyy") + "', NgayTraDuKien = '" + dtpNgayTra.Value.ToString("MM/dd/yyyy") + "', LaiSuat = '" +
                    txtLaiSuat.Text.Trim() + "',id = '" + cboId.Text.Trim() + "', TienLaiDuKien = '" + tienLai + "', ThanhTien = '" + thanhTien + "' WHERE MaVay = '" + txtMaVay.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sua thanh cong");
                    status = "Reset";
                    SetControlStatus(status);
                    BindingData();
                }
                else
                {
                    MessageBox.Show("Loi");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            status = "Reset";
            SetControlStatus(status);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Ban co muon xoa du lieu khong?", "Thong bao",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "DELETE FROM dbo.QLVay WHERE MaVay = '" + txtMaVay.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var resultDelete = cmd.ExecuteNonQuery();
                    if (resultDelete > 0)
                    {
                        MessageBox.Show("Xoa thanh cong");
                        status = "Reset";
                        SetControlStatus(status);
                        BindingData();
                    }
                    else
                    {
                        MessageBox.Show("Loi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
