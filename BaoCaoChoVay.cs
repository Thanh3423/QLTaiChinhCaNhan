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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLTCCaNhan
{
    public partial class frmBaoCaoChoVay : Form
    {
        public static string ConnectionString = @"Data Source=DESKTOP-2B59G78\ABCD;Initial Catalog=QLTCCaNhan;Integrated Security=True";
        DataSet ds;
        public static String Status = "";


        public frmBaoCaoChoVay()
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
                    btnTaoChoVay.Enabled = true;
                    btnXuatChoVay.Enabled = false;
                    btnThoatChoVay.Enabled = true;
                    break;
                case "Tạo Báo Cáo":
                    btnTaoChoVay.Enabled = true;
                    btnXuatChoVay.Enabled = true;
                    btnThoatChoVay.Enabled = true;
                    break;
                case "Xuất Báo Cáo":
                    btnTaoChoVay.Enabled = true;
                    btnXuatChoVay.Enabled = true;
                    btnThoatChoVay.Enabled = true;
                    break;
                default:
                    break;

            }
        }




        private void btnThoatChoVay_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XuatExcel(String path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvChoVay.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvChoVay.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvChoVay.Rows.Count; i++)
            {
                for (int j = 0; j < dgvChoVay.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvChoVay.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btnXuatChoVay_Click_1(object sender, EventArgs e)
        {
            Status = "Xuất Báo Cáo";
            SetControlStatus("Xuất Báo Cáo");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Báo Cáo Cho Vay";
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

        private void btnTaoChoVay_Click(object sender, EventArgs e)
        {
            Status = "Tạo Báo Cáo";
            SetControlStatus("Tạo Báo Cáo");
            if (int.Parse(txtNamChoVay.Text) > 0 && int.Parse(txtNamChoVay.Text) < 9999)
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
                String query = "Select MaChoVay, TenNguoiVay, SoTien, NgayVay,NgayTraDuKien,LaiSuat, TienLaiDuKien, ThanhTien  from QLChoVay where month(NgayVay) = " + cboThangChoVay.Text + " AND year(NgayVay) = " + txtNamChoVay.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                dgvChoVay.DataSource = ds.Tables[0];
                dgvChoVay.Refresh();
                int sc = dgvChoVay.Rows.Count;
                float TongTien = 0;
                for (int i = 0; i < sc - 1; i++)
                {
                    TongTien += float.Parse(dgvChoVay.Rows[i].Cells["ThanhTien"].Value.ToString());
                }
                txtTongChoVay.Text = TongTien.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}






