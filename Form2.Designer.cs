namespace QLVay
{
    partial class Form2
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
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnGhi = new Button();
            btnHuy = new Button();
            txtNgChoVay = new TextBox();
            txtTienVay = new TextBox();
            txtLaiSuat = new TextBox();
            txtTienLai = new TextBox();
            dtpNgayVay = new DateTimePicker();
            dtpNgayTra = new DateTimePicker();
            dgvVay = new DataGridView();
            label7 = new Label();
            txtMaVay = new TextBox();
            label8 = new Label();
            cboId = new ComboBox();
            label9 = new Label();
            txtThanhTien = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 126);
            label1.Name = "label1";
            label1.Size = new Size(266, 41);
            label1.TabIndex = 0;
            label1.Text = "Tên người cho vay:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 253);
            label2.Name = "label2";
            label2.Size = new Size(117, 41);
            label2.TabIndex = 1;
            label2.Text = "Số tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(909, 53);
            label3.Name = "label3";
            label3.Size = new Size(147, 41);
            label3.TabIndex = 2;
            label3.Text = "Ngày vay:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(909, 126);
            label4.Name = "label4";
            label4.Size = new Size(245, 41);
            label4.TabIndex = 3;
            label4.Text = "Ngày trả dự kiến:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(909, 191);
            label5.Name = "label5";
            label5.Size = new Size(253, 41);
            label5.TabIndex = 4;
            label5.Text = "Lãi suất (%/năm): ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(909, 253);
            label6.Name = "label6";
            label6.Size = new Size(225, 41);
            label6.TabIndex = 5;
            label6.Text = "Tiền lãi dự kiến:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(78, 381);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(188, 58);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(371, 381);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(188, 58);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(674, 381);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(188, 58);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(946, 381);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(188, 58);
            btnGhi.TabIndex = 9;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(1222, 381);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(188, 58);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtNgChoVay
            // 
            txtNgChoVay.Location = new Point(328, 117);
            txtNgChoVay.Name = "txtNgChoVay";
            txtNgChoVay.Size = new Size(534, 47);
            txtNgChoVay.TabIndex = 11;
            // 
            // txtTienVay
            // 
            txtTienVay.Location = new Point(328, 253);
            txtTienVay.Name = "txtTienVay";
            txtTienVay.Size = new Size(534, 47);
            txtTienVay.TabIndex = 12;
            // 
            // txtLaiSuat
            // 
            txtLaiSuat.Location = new Point(1179, 191);
            txtLaiSuat.Name = "txtLaiSuat";
            txtLaiSuat.Size = new Size(534, 47);
            txtLaiSuat.TabIndex = 13;
            // 
            // txtTienLai
            // 
            txtTienLai.Location = new Point(1179, 253);
            txtTienLai.Name = "txtTienLai";
            txtTienLai.Size = new Size(534, 47);
            txtTienLai.TabIndex = 14;
            txtTienLai.TextChanged += txtTienLai_TextChanged;
            // 
            // dtpNgayVay
            // 
            dtpNgayVay.Location = new Point(1179, 47);
            dtpNgayVay.Name = "dtpNgayVay";
            dtpNgayVay.Size = new Size(534, 47);
            dtpNgayVay.TabIndex = 15;
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.Location = new Point(1179, 120);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(534, 47);
            dtpNgayTra.TabIndex = 16;
            // 
            // dgvVay
            // 
            dgvVay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVay.Location = new Point(68, 488);
            dgvVay.Name = "dgvVay";
            dgvVay.RowHeadersWidth = 102;
            dgvVay.RowTemplate.Height = 49;
            dgvVay.Size = new Size(1649, 466);
            dgvVay.TabIndex = 17;
            dgvVay.CellClick += dgvVay_CellClick;
            dgvVay.CellContentClick += dgvVay_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 191);
            label7.Name = "label7";
            label7.Size = new Size(119, 41);
            label7.TabIndex = 18;
            label7.Text = "Mã vay:";
            // 
            // txtMaVay
            // 
            txtMaVay.Location = new Point(328, 191);
            txtMaVay.Name = "txtMaVay";
            txtMaVay.Size = new Size(534, 47);
            txtMaVay.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 56);
            label8.Name = "label8";
            label8.Size = new Size(51, 41);
            label8.TabIndex = 20;
            label8.Text = "Id:";
            // 
            // cboId
            // 
            cboId.FormattingEnabled = true;
            cboId.Location = new Point(328, 45);
            cboId.Name = "cboId";
            cboId.Size = new Size(534, 49);
            cboId.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(909, 323);
            label9.Name = "label9";
            label9.Size = new Size(165, 41);
            label9.TabIndex = 22;
            label9.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(1179, 320);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(534, 47);
            txtThanhTien.TabIndex = 23;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 1052);
            Controls.Add(txtThanhTien);
            Controls.Add(label9);
            Controls.Add(cboId);
            Controls.Add(label8);
            Controls.Add(txtMaVay);
            Controls.Add(label7);
            Controls.Add(dgvVay);
            Controls.Add(dtpNgayTra);
            Controls.Add(dtpNgayVay);
            Controls.Add(txtTienLai);
            Controls.Add(txtLaiSuat);
            Controls.Add(txtTienVay);
            Controls.Add(txtNgChoVay);
            Controls.Add(btnHuy);
            Controls.Add(btnGhi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Quản lý vay";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVay).EndInit();
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
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnGhi;
        private Button btnHuy;
        private TextBox txtNgChoVay;
        private TextBox txtTienVay;
        private TextBox txtLaiSuat;
        private TextBox txtTienLai;
        private DateTimePicker dtpNgayVay;
        private DateTimePicker dtpNgayTra;
        private DataGridView dgvVay;
        private Label label7;
        private TextBox txtMaVay;
        private Label label8;
        private ComboBox cboId;
        private Label label9;
        private TextBox txtThanhTien;
    }
}