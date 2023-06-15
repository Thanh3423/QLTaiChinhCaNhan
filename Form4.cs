using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVay
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAnUong_Click(object sender, EventArgs e)
        {
            Frm5 frm5 = new Frm5();
            frm5.ShowDialog();
        }

        private void btnDiLai_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void btnDienNuoc_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.ShowDialog();
        }

        private void btnQuanAo_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.ShowDialog();
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
