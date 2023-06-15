using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVay
{
    public partial class Frm5 : Form
    {
        public static string connectionString = "data source = NHUNGOC\\NHUNGOC; " +
            "Initial catalog= QLTCCaNhan; user id = sa; password= Nhungoc123#";
        DataSet ds = new DataSet();
        public Frm5()
        {
            InitializeComponent();
            BindingData();
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
                string query = " SELECT * FROM QLChiBanThan WHERE TenLoaiChi = 'An uong' UNION SELECT * FROM QLChiNguoiThan WHERE TenLoaiChi = 'An uong' ;";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvAnUong.DataSource = ds.Tables[0];

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm5_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Bạn chưa điền thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTimKiem.Focus();
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM dbo.QLChiBanThan WHERE TenLoaiChi = 'An uong' AND GhiChu LIKE N'%" + txtTimKiem.Text.Trim() + "%' UNION SELECT * FROM dbo.QLChiBanThan WHERE TenLoaiChi = 'An uong' AND GhiChu LIKE N'%" + txtTimKiem.Text.Trim() + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvAnUong.DataSource = ds.Tables[0];

                }
                else
                {
                    dgvAnUong.DataSource = null;
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
