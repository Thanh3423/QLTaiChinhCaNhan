namespace QLVay
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNgVay = new TextBox();
            txtMaChoVay = new TextBox();
            txtSoTien = new TextBox();
            txtLaiSuat = new TextBox();
            txtTienLai = new TextBox();
            dtpNgayVay = new DateTimePicker();
            dtpNgayTra = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnGhi = new Button();
            btnHuy = new Button();
            dgvChoVay = new DataGridView();
            label8 = new Label();
            cboId = new ComboBox();
            label9 = new Label();
            txtThanhTien = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvChoVay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 125);
            label1.Name = "label1";
            label1.Size = new Size(209, 41);
            label1.TabIndex = 0;
            label1.Text = "Tên người vay:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 202);
            label2.Name = "label2";
            label2.Size = new Size(176, 41);
            label2.TabIndex = 1;
            label2.Text = "Mã cho vay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 278);
            label3.Name = "label3";
            label3.Size = new Size(169, 41);
            label3.TabIndex = 2;
            label3.Text = "Số tiền vay:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(858, 48);
            label4.Name = "label4";
            label4.Size = new Size(155, 41);
            label4.TabIndex = 3;
            label4.Text = "Ngày vay: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(858, 125);
            label5.Name = "label5";
            label5.Size = new Size(245, 41);
            label5.TabIndex = 4;
            label5.Text = "Ngày trả dự kiến:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(858, 205);
            label6.Name = "label6";
            label6.Size = new Size(253, 41);
            label6.TabIndex = 5;
            label6.Text = "Lãi suất( %/năm) :";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(858, 284);
            label7.Name = "label7";
            label7.Size = new Size(126, 41);
            label7.TabIndex = 6;
            label7.Text = "Tiền lãi: ";
            // 
            // txtNgVay
            // 
            txtNgVay.Location = new Point(320, 119);
            txtNgVay.Name = "txtNgVay";
            txtNgVay.Size = new Size(500, 47);
            txtNgVay.TabIndex = 7;
            // 
            // txtMaChoVay
            // 
            txtMaChoVay.Location = new Point(320, 199);
            txtMaChoVay.Name = "txtMaChoVay";
            txtMaChoVay.Size = new Size(500, 47);
            txtMaChoVay.TabIndex = 8;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(320, 278);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(500, 47);
            txtSoTien.TabIndex = 9;
            // 
            // txtLaiSuat
            // 
            txtLaiSuat.Location = new Point(1137, 199);
            txtLaiSuat.Name = "txtLaiSuat";
            txtLaiSuat.Size = new Size(500, 47);
            txtLaiSuat.TabIndex = 10;
            // 
            // txtTienLai
            // 
            txtTienLai.Location = new Point(1137, 278);
            txtTienLai.Name = "txtTienLai";
            txtTienLai.Size = new Size(500, 47);
            txtTienLai.TabIndex = 11;
            // 
            // dtpNgayVay
            // 
            dtpNgayVay.Location = new Point(1137, 40);
            dtpNgayVay.Name = "dtpNgayVay";
            dtpNgayVay.Size = new Size(500, 47);
            dtpNgayVay.TabIndex = 12;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.Location = new Point(1137, 117);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(500, 47);
            dtpNgayTra.TabIndex = 13;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(98, 410);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(188, 58);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(375, 410);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(188, 58);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(651, 410);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(188, 58);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(895, 410);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(188, 58);
            btnGhi.TabIndex = 17;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(1158, 410);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(188, 58);
            btnHuy.TabIndex = 18;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // dgvChoVay
            // 
            dgvChoVay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChoVay.Location = new Point(109, 497);
            dgvChoVay.Name = "dgvChoVay";
            dgvChoVay.RowHeadersWidth = 102;
            dgvChoVay.RowTemplate.Height = 49;
            dgvChoVay.Size = new Size(1528, 375);
            dgvChoVay.TabIndex = 19;
            dgvChoVay.CellClick += dgvChoVay_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(94, 45);
            label8.Name = "label8";
            label8.Size = new Size(51, 41);
            label8.TabIndex = 20;
            label8.Text = "Id:";
            // 
            // cboId
            // 
            cboId.FormattingEnabled = true;
            cboId.Location = new Point(320, 42);
            cboId.Name = "cboId";
            cboId.Size = new Size(500, 49);
            cboId.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(858, 343);
            label9.Name = "label9";
            label9.Size = new Size(173, 41);
            label9.TabIndex = 22;
            label9.Text = "Thành tiền: ";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(1137, 343);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(500, 47);
            txtThanhTien.TabIndex = 23;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1673, 930);
            Controls.Add(txtThanhTien);
            Controls.Add(label9);
            Controls.Add(cboId);
            Controls.Add(label8);
            Controls.Add(dgvChoVay);
            Controls.Add(btnHuy);
            Controls.Add(btnGhi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dtpNgayTra);
            Controls.Add(dtpNgayVay);
            Controls.Add(txtTienLai);
            Controls.Add(txtLaiSuat);
            Controls.Add(txtSoTien);
            Controls.Add(txtMaChoVay);
            Controls.Add(txtNgVay);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Quản lý cho vay";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChoVay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNgVay;
        private TextBox txtMaChoVay;
        private TextBox txtSoTien;
        private TextBox txtLaiSuat;
        private TextBox txtTienLai;
        private DateTimePicker dtpNgayVay;
        private DateTimePicker dtpNgayTra;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnGhi;
        private Button btnHuy;
        private DataGridView dgvChoVay;
        private Label label8;
        private ComboBox cboId;
        private Label label9;
        private TextBox txtThanhTien;
    }
}