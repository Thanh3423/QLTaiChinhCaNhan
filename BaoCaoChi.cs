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
using Microsoft.Office.Interop.Excel;
using static OfficeOpenXml.ExcelErrorValue;

namespace QLTCCaNhan
{
    public partial class frmBaoCaoChi : Form
    {
        public static string ConnectionString = @"Data Source=DESKTOP-2B59G78\ABCD;Initial Catalog=QLTCCaNhan;Integrated Security=True";
        DataSet ds;
        public static String Status = "";
        public frmBaoCaoChi()
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
                    btnTaoChi.Enabled = true;
                    btnXuatChi.Enabled = false;
                    btnThoatChi.Enabled = true;
                    break;
                case "Tạo Báo Cáo":
                    btnTaoChi.Enabled = true;
                    btnXuatChi.Enabled = true;
                    btnThoatChi.Enabled = true;
                    break;
                case "Xuất Báo Cáo":
                    btnTaoChi.Enabled = true;
                    btnXuatChi.Enabled = true;
                    btnThoatChi.Enabled = true;
                    break;
                default:
                    break;

            }
        }

        private void btnTaoChi_Click(object sender, EventArgs e)
        {
            Status = "Tạo Báo Cáo";
            SetControlStatus("Tạo Báo Cáo");
            if (int.Parse(txtNamChi.Text) > 0 && int.Parse(txtNamChi.Text) < 9999)
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
                String query = "Select MaChi, TenLoaiChi, NgayChi, SoTien, GhiChu from QLChiNguoiThan  where month(NgayChi) = " + cboThangChi.Text + " AND year(NgayChi) = " + txtNamChi.Text + " union all Select MaChi, TenLoaiChi, NgayChi, SoTien, GhiChu from QLChiBanThan where month(NgayChi) = " + cboThangChi.Text + " AND year(NgayChi) = " + txtNamChi.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                dgvChi.DataSource = ds.Tables[0];
                dgvChi.Refresh();
                int sc = dgvChi.Rows.Count;
                float TongTien = 0;
                for (int i = 0; i < sc - 1; i++)
                {
                    TongTien += float.Parse(dgvChi.Rows[i].Cells["SoTien"].Value.ToString());
                }
                txtTongChi.Text = TongTien.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnThoatChi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XuatExcel(String path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvChi.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvChi.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvChi.Rows.Count; i++)
            {
                for (int j = 0; j < dgvChi.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvChi.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btnXuatChi_Click(object sender, EventArgs e)
        {
            Status = "Xuất Báo Cáo";
            SetControlStatus("Xuất Báo Cáo");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Báo Cáo Chi";
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

        private void txtNamChi_TextChanged(object sender, EventArgs e)
        {
            
        }
    }






}

