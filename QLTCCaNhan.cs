namespace QLTCCaNhan
{
    public partial class frmQLTCCaNhan : Form
    {
        public frmQLTCCaNhan()
        {
            InitializeComponent();
        }

        private void baoCaoThuToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBaoCaoThu frmThu = new frmBaoCaoThu();
            frmThu.Show();
        }

        private void baoCaoChiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBaoCaoChi frmChi = new frmBaoCaoChi();
            frmChi.Show();
        }

        private void baoCaoVayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBaoCaoVay frmVay = new frmBaoCaoVay();
            frmVay.Show();
        }

        private void BaoCaoChoVayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoChoVay frmChoVay = new frmBaoCaoChoVay();
            frmChoVay.Show();
        }
    }
}