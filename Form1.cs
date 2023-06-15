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

namespace QuanLyThu
{
    public partial class Form1 : Form
    {

        public static string
            connectionString = "data source = localhost; database = QLTCCaNhan; user id = sa; password = 123";
        DataSet ds;

        public static string Status = "";
        public Form1()
        {
            InitializeComponent();
            Loadcboboxid("SELECT *FROM TaiKhoan", "id", "id");
            Status = "Reset";
            SetControlStatus("Status");
            BindingData();
        }

        public void Loadcboboxid(string query, string dis, string valu)
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
            cbo_id.DataSource = ds.Tables[0];
            cbo_id.DisplayMember = dis;
            cbo_id.ValueMember = valu;

        }

        public void SetControlStatus(string State)
        {
            switch (State)
            {
                case "Reset":
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;
                    btnTongThu.Enabled = false;

                    txt_mathu.Enabled = false;
                    txt_sotien.Enabled = false;
                    txt_ghichu.Enabled = false;
                    cbo_tenloaithu.Enabled = false;
                    dtp_ngaythu.Enabled = false;
                    cbo_id.Enabled = false;
                    break;

                case "Insert":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnTongThu.Enabled = true;

                    txt_mathu.Enabled = false;
                    txt_sotien.Enabled = true;
                    txt_ghichu.Enabled = true;
                    cbo_tenloaithu.Enabled = true;
                    dtp_ngaythu.Enabled = true;
                    cbo_id.Enabled = true;

                    txt_mathu.Text = "";
                    cbo_tenloaithu.Text = "";
                    cbo_tenloaithu.Focus();
                    txt_sotien.Text = "";
                    txt_ghichu.Text = "";
                    cbo_id.Text = "";
                    break;

                case "Edit":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    btnTongThu.Enabled = true;

                    txt_mathu.Enabled = false;
                    txt_sotien.Enabled = true;
                    txt_ghichu.Enabled = true;
                    cbo_tenloaithu.Enabled = true;
                    dtp_ngaythu.Enabled = true;
                    cbo_id.Enabled = true;
                    break;

                default:
                    break;
            }
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
                string query = "SELECT * FROM QLThu ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvMain.DataSource = ds.Tables[0];
                    txt_mathu.Text = ds.Tables[0].Rows[0]["MaThu"].ToString();
                    cbo_tenloaithu.SelectedItem = ds.Tables[0].Rows[0]["TenLoaiThu"].ToString();
                    txt_sotien.Text = ds.Tables[0].Rows[0]["SoTien"].ToString();
                    dtp_ngaythu.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgayThu"]);
                    txt_ghichu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
                    cbo_id.SelectedValue = ds.Tables[0].Rows[0]["id"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            btnHuy.Enabled = false;
            btnTongThu.Enabled = true;

            txt_mathu.Enabled = false;
            dtp_ngaythu.Enabled = false;
            cbo_tenloaithu.Enabled = false;
            txt_sotien.Enabled = false;
            txt_ghichu.Enabled = false;
            cbo_id.Enabled = false;
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvMain.Rows[e.RowIndex];
                //var row = (DataGridViewRow)dgv_main.Rows[e.RowIndex];
                txt_mathu.Text = row.Cells["MaThu"].Value.ToString();
                cbo_tenloaithu.SelectedItem = row.Cells["TenLoaiThu"].Value.ToString();
                txt_sotien.Text = row.Cells["SoTien"].Value.ToString();
                dtp_ngaythu.Value = Convert.ToDateTime(row.Cells["NgayThu"].Value);
                txt_ghichu.Text = row.Cells["GhiChu"].Value.ToString();
                cbo_id.SelectedValue = row.Cells["id"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      

        private void btnThem_Click(object sender, EventArgs e)
        {
            Status = "Insert";
            SetControlStatus(Status);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Status = "Edit";
            SetControlStatus(Status);

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {

         
            DateTime selectedDate = dtp_ngaythu.Value;
            if (DateTime.Compare(selectedDate, DateTime.Today) > 0)
            {
                MessageBox.Show("Ngày nhập không hợp lệ!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                //dtp_ngaythu.Value = DateTime.Today; // Khôi phục lại ngày hiện tại
            }


            if (cbo_tenloaithu.Text != "")
            {
            }
            else
            {
                MessageBox.Show("Tên loại thu đang để trống. Vui lòng nhập!","Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_tenloaithu.Focus();
                return;
            }

            if (txt_sotien.Text != "")
            {
            }
            else
            {
                MessageBox.Show("Số tiền đang để trống. Vui lòng nhập!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_sotien.Focus();
                return;
            }

            if (Status == "Insert")
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "INSERT INTO QLThu VALUES('" + txt_mathu.Text.Trim() + "', N'" + cbo_tenloaithu.Text.Trim() + "','" + dtp_ngaythu.Value.ToString("MM/dd/yyyy") + "','" + Convert.ToDecimal(txt_sotien.Text.Trim()).ToString() + "',N'" + txt_ghichu.Text.Trim() + "', '" + cbo_id.Text.Trim() + "')";

                //string query = "INSERT INTO QLThu VALUES('" + txt_mathu.Text.Trim() + "', N'" + cbo_tenloaithu.SelectedItem.ToString() + "','" + dtp_ngaythu.Value.ToString("MM/dd/yyyy") + "','" + Convert.ToDecimal(txt_sotien.Text.Trim()).ToString() + "',N'" + txt_ghichu.Text.Trim() + "', '"+cbo_id.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    Status = "Reset";
                    SetControlStatus(Status);
                    BindingData();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }


            else if (Status == "Edit")
            {

                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "UPDATE QLThu SET TenLoaiThu=N'" + cbo_tenloaithu.SelectedItem.ToString() + "', NgayThu= '" + dtp_ngaythu.Value.ToString("MM/dd/yyyy") + "',GhiChu= N'" + txt_ghichu.Text.Trim() + "',SoTien = '" + Convert.ToDecimal(txt_sotien.Text.Trim()).ToString("0,0") + "'  WHERE MaThu= '" + txt_mathu.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    Status = "Reset";
                    SetControlStatus(Status);
                    BindingData();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            Status = "Reset";
            SetControlStatus(Status);
            BindingData();
            DialogResult tb = MessageBox.Show("Bạn có muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                Form1 frmthu = new Form1();
                frmthu.Show();
                this.Hide();
            }
            else
            {
            }
        }

        private void btnTongThu_Click(object sender, EventArgs e)
        {
            // Tính tổng tiền thu trên cột số tiền
            decimal tongThu = 0;
            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                tongThu += Convert.ToDecimal(row.Cells["SoTien"].Value);

            }
            MessageBox.Show("Tổng số tiền thu là: " + tongThu.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "DELETE FROM QLThu WHERE MaChi= '" + txt_mathu.Text.Trim() + " '";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var resultDelete = cmd.ExecuteNonQuery();
                    if (resultDelete > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        Status = "Reset";
                        SetControlStatus(Status);
                        BindingData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
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
