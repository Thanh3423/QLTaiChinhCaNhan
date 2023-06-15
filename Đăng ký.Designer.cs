namespace DemoThao
{
    partial class frmDangKy
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
            dtpNgaySinh = new DateTimePicker();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            label1 = new Label();
            btnRegister = new Button();
            btnThoat = new Button();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(618, 448);
            dtpNgaySinh.Margin = new Padding(6);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(206, 50);
            dtpNgaySinh.TabIndex = 25;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.BackColor = SystemColors.ButtonHighlight;
            rbNu.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            rbNu.Location = new Point(849, 565);
            rbNu.Margin = new Padding(6);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(96, 46);
            rbNu.TabIndex = 24;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = false;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.BackColor = SystemColors.ButtonHighlight;
            rbNam.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            rbNam.Location = new Point(618, 563);
            rbNam.Margin = new Padding(6);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(121, 46);
            rbNam.TabIndex = 23;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(618, 781);
            txtMatKhau.Margin = new Padding(6);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(576, 50);
            txtMatKhau.TabIndex = 22;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(618, 678);
            txtTenDangNhap.Margin = new Padding(6);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(576, 50);
            txtTenDangNhap.TabIndex = 21;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoai.Location = new Point(618, 346);
            txtSoDienThoai.Margin = new Padding(6);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(576, 50);
            txtSoDienThoai.TabIndex = 20;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(618, 230);
            txtHoTen.Margin = new Padding(6);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(576, 50);
            txtHoTen.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(271, 233);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 42);
            label1.TabIndex = 13;
            label1.Text = "Họ tên";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ActiveCaption;
            btnRegister.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegister.Location = new Point(433, 881);
            btnRegister.Margin = new Padding(6);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(227, 62);
            btnRegister.TabIndex = 26;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Brown;
            btnThoat.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnThoat.Location = new Point(921, 879);
            btnThoat.Margin = new Padding(4, 2, 4, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(227, 66);
            btnThoat.TabIndex = 27;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonHighlight;
            label7.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(269, 683);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(238, 42);
            label7.TabIndex = 28;
            label7.Text = "Tên đăng nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(269, 789);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(158, 42);
            label5.TabIndex = 29;
            label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Times New Roman", 25.875F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(572, 77);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(358, 78);
            label6.TabIndex = 30;
            label6.Text = "ĐĂNG KÝ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(269, 457);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(166, 42);
            label2.TabIndex = 32;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(269, 567);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(148, 42);
            label3.TabIndex = 33;
            label3.Text = "Giới tính";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(269, 348);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(209, 42);
            label8.TabIndex = 31;
            label8.Text = "Số điện thoại";
            // 
            // frmDangKy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 1037);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(btnThoat);
            Controls.Add(btnRegister);
            Controls.Add(dtpNgaySinh);
            Controls.Add(rbNu);
            Controls.Add(rbNam);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "frmDangKy";
            Text = "Đăng ký";
            Load += frmDangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgaySinh;
        private RadioButton rbNu;
        private RadioButton rbNam;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private Label label1;
        private Button btnRegister;
        private Button btnThoat;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label8;
    }
}