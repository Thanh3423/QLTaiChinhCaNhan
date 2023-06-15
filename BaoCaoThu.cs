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
using static System.Windows.Forms.AxHost;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLTCCaNhan
{
    public partial class frmBaoCaoThu : Form
    {
        public static string ConnectionString = @"Data Source=DESKTOP-2B59G78\ABCD;Initial Catalog=QLTCCaNhan;Integrated Security=True";
        DataSet ds;
        public static String Status = "";
        public frmBaoCaoThu()
        {
            InitializeComponent();
            Status = "Reset";
            SetControlStatus("Reset");
        }

        public void SetControlStatus(String State)
        {
            switch (State)
            {
                case "Reset":
                    btnTaoThu.Enabled = true;
                    btnXuatThu.Enabled = false;
                    btnThoat.Enabled = true;
                    break;
                case "Tạo Báo Cáo":
                    btnTaoThu.Enabled = true;
                    btnXuatThu.Enabled = true;
                    btnThoat.Enabled = true;
                    break;
                case "Xuất Báo Cáo":
                    btnTaoThu.Enabled = true;
                    btnXuatThu.Enabled = true;
                    btnThoat.Enabled = true;
                    break;
                default:
                    break;

            }
        }

        private void btnTaoThu_Click(object sender, EventArgs e)
        {
            Status = "Tạo Báo Cáo";
            SetControlStatus("Tạo Báo Cáo");
            if (int.Parse(txtNamThu.Text) > 0 && int.Parse(txtNamThu.Text) < 9999)
            {

            }
            else
            {
                MessageBox.Show("Nhập lại năm");
            }
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                String query = "Select MaThu, TenLoaiThu, NgayThu, SoTien, GhiChu from QLThu where month(NgayThu) = " + cboThangThu.Text + " AND year(NgayThu) = " + txtNamThu.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                dgvThu.DataSource = ds.Tables[0];
                dgvThu.Refresh();
                int sc = dgvThu.Rows.Count;
                float TongTien = 0;
                for (int i = 0; i < sc - 1; i++)
                {
                    TongTien += float.Parse(dgvThu.Rows[i].Cells["SoTien"].Value.ToString());
                }
                txtTongThu.Text = TongTien.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XuatExcel(String path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvThu.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvThu.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvThu.Rows.Count; i++)
            {
                for (int j = 0; j < dgvThu.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvThu.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btnXuatThu_Click(object sender, EventArgs e)
        {

            Status = "Xuất Báo Cáo";
            SetControlStatus("Xuất Báo Cáo");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Báo Cáo Thu";
            saveFileDialog.Filter = "Excel(*.xlsx)| *.xlsx| Excel 2003(*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XuatExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thàng công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công" + ex.Message);
                }
            }
        }
    }
}
