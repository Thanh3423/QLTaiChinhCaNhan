using System.Data;
using System.Data.SqlClient;

namespace MucTieu
{
    public partial class Form1 : Form
    {
        public static string connectionString
            = " data source = LAPTOP-P072H6I8\\SQLEXPRESS; database = QLTCCaNhan; user = sa; password = 1";
        DataSet ds = new DataSet();
        public static String status = "";
        public void BindingData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "SELECT * FROM MucTieu";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables[0].Rows.Count > 0 && ds.Tables.Count > 0)
            {
                dgvMain.DataSource = ds.Tables[0];
            }
            else
            {
                dgvMain.DataSource = null;

            }
            conn.Close();
        }
        /*private bool kiemTra()
        {
            if (txtNoiDung.Text == "")
            {
                MessageBox.Show("Chưa nhập nội dung", "Thông báo");
                txtNoiDung.Focus();

                return false;
            }
            return true;
        }*/
        public Form1()
        {
            InitializeComponent();
            status = "Reset";
            SetControlStatus("Reset");
            BindingData();
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

                    dtpNBD.Enabled = false;
                    dtpNKT.Enabled = false;
                    cboTinhTrang.Enabled = false;
                    txtNoiDung.Enabled = false;

                    break;

                case "Insert":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    dtpNBD.Enabled = true;
                    dtpNKT.Enabled = true;
                    cboTinhTrang.Enabled = true;
                    txtNoiDung.Enabled = true;

                    txtNoiDung.Text = "";
                    txtNoiDung.Focus();
                    break;

                case "Edit":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;

                    dtpNBD.Enabled = true;
                    dtpNKT.Enabled = true;
                    cboTinhTrang.Enabled = true;
                    txtNoiDung.Enabled = true;

                    txtNoiDung.Text = "";
                    txtNoiDung.Focus();
                    break;
                default:
                    break;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = "Edit";
            SetControlStatus("Edit");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Insert";
            SetControlStatus("Insert");
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtNoiDung.Text == "")
            {
                MessageBox.Show("Bạn chưa điền nội dung");
                txtNoiDung.Focus();
                return;
            }
            if (status == "Insert")
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "INSERT INTO dbo.MucTieu VALUES('"+ dtpNBD.Value.ToString("MM/dd/yyyy") +"','"+ dtpNKT.Value.ToString("MM/dd/yyyy") +"','"+txtNoiDung.Text.Trim()+"','"+cboTinhTrang.Text.Trim()+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Them thanh cong");
                    status = "Reset";
                    SetControlStatus(status);
                    BindingData();
                }
            }
            else
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "UPDATE dbo.MucTieu SET NgayBatDau = '"+dtpNBD.Value.ToString("MM/dd/yyyy")+"', NgayKetThuc = '"+dtpNKT.Value.ToString("MM/dd/yyyy")+"', NoiDung = '"+txtNoiDung.Text.Trim()+"', TinhTrang = '"+cboTinhTrang.Text.Trim()+"'";

                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sua thanh cong");
                    status = "Reset";
                    SetControlStatus(status);
                    BindingData();
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
                    string query = "DELETE FROM dbo.MucTieu WHERE NoiDung = '" + txtNoiDung.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var resultDelete = cmd.ExecuteNonQuery();
                    if (resultDelete > 0)

                    {
                        MessageBox.Show("Xoa thanh cong");
                        status = "Reset";
                        SetControlStatus(status);
                        BindingData();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = (DataGridViewRow)dgvMain.Rows[e.RowIndex];
                dtpNBD.Text = row.Cells["NgayBatDau"].Value.ToString();
                dtpNKT.Text = row.Cells["NgayKetThuc"].Value.ToString();
                txtNoiDung.Text = row.Cells["NoiDung"].Value.ToString();
                cboTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}