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

namespace DanhMucThu1
{
    public partial class Lương : Form
    {
        public static string connectionString
           = " data source = LAPTOP-P072H6I8\\SQLEXPRESS; database = QLTCCaNhan; user = sa; password = 1";

        public void BindingData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "SELECT * FROM QLThu WHERE TenLoaiThu = 'luong'";
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
        public Lương()
        {
            InitializeComponent();
            BindingData();
        }
        private bool kiemTraTimKiem()
        {
            if (txtTimGhiChu.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm", "Thông báo");
                txtTimGhiChu.Focus();
                return false;
            }

            return true;
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (kiemTraTimKiem() == true)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = @"SELECT * FROM QLThu WHERE TenLoaiThu = 'luong' AND GhiChu LIKE N'%" + txtTimGhiChu.Text.Trim() + "%'";
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
                    MessageBox.Show("Không tìm thấy dữ liệu!!!");
                }
                conn.Close();
            }
        }
    }
}
