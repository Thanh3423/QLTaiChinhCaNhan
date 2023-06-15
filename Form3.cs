using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLVay
{
    public partial class Form3 : Form
    {
        public static string connectionSring = "data source = NHUNGOC\\NHUNGOC; " + "Initial catalog= QLTCCaNhan; user id = sa; password= Nhungoc123#";
        DataSet ds = new DataSet();
        public static String status = "";

        public Form3()
        {
            InitializeComponent();
            status = "Reset";
            SetControlStatus("Reset");
            BindingData();
            LoadcboId("select *from TaiKhoan", "id", "id");
        }
        public void LoadcboId(string query, string dis, string valu)
        {
            SqlConnection conn = new SqlConnection(connectionSring);
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
                SqlConnection conn = new SqlConnection(connectionSring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM dbo.QLChoVay";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvChoVay.DataSource = ds.Tables[0];
                    cboId.Text = ds.Tables[0].Rows[0]["id"].ToString();
                    txtNgVay.Text = ds.Tables[0].Rows[0]["TenNguoiVay"].ToString();
                    txtSoTien.Text = ds.Tables[0].Rows[0]["SoTien"].ToString();
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
        public bool checkName(string n)
        {

            return Regex.IsMatch(n, "^[ a-zA-Z]{2,50}$"); //CHECK ten

        }
        private void SetControlStatus(String status)
        {
            switch (status)
            {
                case "Reset":
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;

                    cboId.Enabled = false;
                    txtNgVay.Enabled = false;
                    txtMaChoVay.Enabled = false;
                    txtSoTien.Enabled = false;
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
                    txtNgVay.Enabled = true;
                    txtMaChoVay.Enabled = false;
                    txtSoTien.Enabled = true;
                    dtpNgayVay.Enabled = true;
                    dtpNgayTra.Enabled = true;
                    txtLaiSuat.Enabled = true;
                    txtTienLai.Enabled = false;

                    txtThanhTien.Text = "";
                    txtMaChoVay.Text = "";
                    txtNgVay.Text = "";
                    txtSoTien.Text = "";
                    txtLaiSuat.Text = "";
                    txtNgVay.Focus();
                    break;
                case "Edit":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    cboId.Enabled = true;
                    txtNgVay.Enabled = true;
                    txtMaChoVay.Enabled = false;
                    txtSoTien.Enabled = true;
                    dtpNgayVay.Enabled = true;
                    dtpNgayTra.Enabled = true;
                    txtLaiSuat.Enabled = true;
                    txtTienLai.Enabled = false;
                    txtThanhTien.Enabled= false;

                    txtNgVay.Focus();
                    break;
                default:
                    break;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Insert";
            SetControlStatus(status);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            status = "Reset";
            SetControlStatus(status);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = "Edit";
            SetControlStatus(status);
        }

        private void dgvChoVay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvChoVay.Rows[e.RowIndex];
                cboId.Text = row.Cells["id"].Value.ToString();
                txtMaChoVay.Text = row.Cells["MaChoVay"].Value.ToString();
                txtNgVay.Text = row.Cells["TenNguoiVay"].Value.ToString();
                txtSoTien.Text = row.Cells["SoTien"].Value.ToString();
                dtpNgayVay.Value = Convert.ToDateTime(row.Cells["NgayVay"].Value);
                dtpNgayTra.Value = Convert.ToDateTime(row.Cells["NgayTraDuKien"].Value);
                txtLaiSuat.Text = row.Cells["LaiSuat"].Value.ToString();
                txtTienLai.Text = row.Cells["TienLaiDuKien"].Value.ToString();
                txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string ten = txtNgVay.Text;
            if (!checkName(ten))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNgVay.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Bạn chưa điền tên người vay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgVay.Focus();
                return;
            }
            if (txtSoTien.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Bạn chưa điền số tiền vay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTien.Focus();
                return;
            }

            DateTime ngayvay = dtpNgayVay.Value;
            DateTime ngaytra = dtpNgayTra.Value;

            double sotien = double.Parse(txtSoTien.Text);

            TimeSpan time = ngaytra - ngayvay;
            int totalDays = (int)time.TotalDays;
            int daysInYear = DateTime.IsLeapYear(ngayvay.Year) ? 366 : 365;
            double laisuat = (double.Parse(txtLaiSuat.Text)) / 100;
            double laihangngay = laisuat / daysInYear;
            double tienlai = sotien * laihangngay * totalDays;
            double thanhtien = sotien + tienlai;
            if (dtpNgayVay.Value > dtpNgayTra.Value)
            {
                MessageBox.Show("Lỗi ngày tháng năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (sotien < 0)
            {
                MessageBox.Show("Số tiền phải lớn hơn không", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (laisuat < 0)
            {
                MessageBox.Show("Lãi suất phải lớn hơn hoặc bằng không", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (status == "Insert")
            {
                SqlConnection conn = new SqlConnection(connectionSring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "INSERT INTO dbo.QLChoVay VALUES('" + txtMaChoVay.Text.Trim() + "', '" + txtNgVay.Text.Trim() + "', '" + txtSoTien.Text.Trim() + "','" + dtpNgayVay.Value.ToString("MM/dd/yyyy") + "', '" + dtpNgayTra.Value.ToString("MM/dd/yyyy") + "','" + txtLaiSuat.Text.Trim() + "','" + cboId.Text.Trim() + "','" + tienlai + "','" + thanhtien + "')";
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
                SqlConnection conn = new SqlConnection(connectionSring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "UPDATE dbo.QLChoVay SET TenNguoiVay = '" + txtNgVay.Text.Trim() +
                    "', SoTien = '" + txtSoTien.Text.Trim() + "', NgayVay = '" +
                    dtpNgayVay.Value.ToString("MM/dd/yyyy") + "', NgayTraDuKien = '" + dtpNgayTra.Value.ToString("MM/dd/yyyy") + "', LaiSuat = '" +
                    txtLaiSuat.Text.Trim() + "', id ='" + cboId.Text.Trim() + "' TienLaiDuKien = '" + tienlai + "' ThanhTien = '" + thanhtien + "' WHERE MaChoVay = '" + txtMaChoVay.Text.Trim() + "'";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Ban co muon xoa du lieu khong?", "Thong bao",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(connectionSring);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "DELETE FROM dbo.QLChoVay WHERE MaChoVay = '" + txtMaChoVay.Text.Trim() + "'";
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
