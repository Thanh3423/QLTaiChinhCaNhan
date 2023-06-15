namespace MucTieu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNoiDung=new TextBox();
            dtpNBD=new DateTimePicker();
            dtpNKT=new DateTimePicker();
            cboTinhTrang=new ComboBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            dgvMain=new DataGridView();
            btnThem=new Button();
            btnSua=new Button();
            btnXoa=new Button();
            btnThoat=new Button();
            btnGhi=new Button();
            btnHuy=new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location=new Point(513, 36);
            txtNoiDung.Multiline=true;
            txtNoiDung.Name="txtNoiDung";
            txtNoiDung.Size=new Size(220, 134);
            txtNoiDung.TabIndex=0;
            // 
            // dtpNBD
            // 
            dtpNBD.Location=new Point(126, 36);
            dtpNBD.Name="dtpNBD";
            dtpNBD.Size=new Size(250, 27);
            dtpNBD.TabIndex=1;
            dtpNBD.ValueChanged+=dateTimePicker1_ValueChanged;
            // 
            // dtpNKT
            // 
            dtpNKT.Location=new Point(126, 99);
            dtpNKT.Name="dtpNKT";
            dtpNKT.Size=new Size(250, 27);
            dtpNKT.TabIndex=2;
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.FormattingEnabled=true;
            cboTinhTrang.Items.AddRange(new object[] { "Hoan thanh", "Chua hoan thanh" });
            cboTinhTrang.Location=new Point(126, 165);
            cboTinhTrang.Name="cboTinhTrang";
            cboTinhTrang.Size=new Size(170, 28);
            cboTinhTrang.TabIndex=3;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(21, 36);
            label1.Name="label1";
            label1.Size=new Size(99, 20);
            label1.TabIndex=4;
            label1.Text="Ngay bat dau";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(21, 99);
            label2.Name="label2";
            label2.Size=new Size(100, 20);
            label2.TabIndex=5;
            label2.Text="Ngay ket thuc";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(21, 168);
            label3.Name="label3";
            label3.Size=new Size(76, 20);
            label3.TabIndex=6;
            label3.Text="Tinh trang";
            label3.Click+=label3_Click;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(436, 36);
            label4.Name="label4";
            label4.Size=new Size(71, 20);
            label4.TabIndex=7;
            label4.Text="Noi dung";
            // 
            // dgvMain
            // 
            dgvMain.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Location=new Point(35, 212);
            dgvMain.Name="dgvMain";
            dgvMain.RowHeadersWidth=51;
            dgvMain.RowTemplate.Height=29;
            dgvMain.Size=new Size(712, 148);
            dgvMain.TabIndex=8;
            dgvMain.CellContentClick+=dgvMain_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location=new Point(35, 398);
            btnThem.Name="btnThem";
            btnThem.Size=new Size(94, 29);
            btnThem.TabIndex=9;
            btnThem.Text="Thêm";
            btnThem.UseVisualStyleBackColor=true;
            btnThem.Click+=btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location=new Point(163, 398);
            btnSua.Name="btnSua";
            btnSua.Size=new Size(94, 29);
            btnSua.TabIndex=10;
            btnSua.Text="Sửa";
            btnSua.UseVisualStyleBackColor=true;
            btnSua.Click+=btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location=new Point(282, 398);
            btnXoa.Name="btnXoa";
            btnXoa.Size=new Size(94, 29);
            btnXoa.TabIndex=11;
            btnXoa.Text="Xóa";
            btnXoa.UseVisualStyleBackColor=true;
            btnXoa.Click+=btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location=new Point(694, 398);
            btnThoat.Name="btnThoat";
            btnThoat.Size=new Size(94, 29);
            btnThoat.TabIndex=12;
            btnThoat.Text="Thoát";
            btnThoat.UseVisualStyleBackColor=true;
            // 
            // btnGhi
            // 
            btnGhi.Location=new Point(413, 398);
            btnGhi.Name="btnGhi";
            btnGhi.Size=new Size(94, 29);
            btnGhi.TabIndex=13;
            btnGhi.Text="Ghi";
            btnGhi.UseVisualStyleBackColor=true;
            btnGhi.Click+=btnGhi_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location=new Point(540, 398);
            btnHuy.Name="btnHuy";
            btnHuy.Size=new Size(94, 29);
            btnHuy.TabIndex=14;
            btnHuy.Text="Hủy";
            btnHuy.UseVisualStyleBackColor=true;
            btnHuy.Click+=btnHuy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnGhi);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvMain);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboTinhTrang);
            Controls.Add(dtpNKT);
            Controls.Add(dtpNBD);
            Controls.Add(txtNoiDung);
            Name="Form1";
            Text="Mục tiêu";
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNoiDung;
        private DateTimePicker dtpNBD;
        private DateTimePicker dtpNKT;
        private ComboBox cboTinhTrang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvMain;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnGhi;
        private Button btnHuy;
    }
}