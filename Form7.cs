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

namespace QLVay
{
    public partial class Form7 : Form
    {
        public static string connectionString = "data source = NHUNGOC\\NHUNGOC; " +
            "Initial catalog= QLTCCaNhan; user id = sa; password= Nhungoc123#";
        DataSet ds = new DataSet();
        public Form7()
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
                string query = "SELECT * FROM QLChiBanThan WHERE TenLoaiChi = 'Dien nuoc' UNION SELECT * FROM QLChiNguoiThan  WHERE TenLoaiChi = 'Dien nuoc'; ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvDienNuoc.DataSource = ds.Tables[0];

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
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
                string query = "SELECT * FROM dbo.QLChiBanThan WHERE TenLoaiChi = 'Dien nuoc' AND GhiChu LIKE N'%" + txtTimKiem.Text.Trim() + "%' UNION SELECT * FROM dbo.QLChiBanThan WHERE TenLoaiChi = 'Dien nuoc' AND GhiChu LIKE N'%" + txtTimKiem.Text.Trim() + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvDienNuoc.DataSource = ds.Tables[0];

                }
                else
                {
                    dgvDienNuoc.DataSource = null;
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDienNuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
