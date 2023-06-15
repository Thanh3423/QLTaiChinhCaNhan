namespace DemoThao
{
    partial class frmDangNhap
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
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            label3 = new Label();
            llblDangKy = new LinkLabel();
            label4 = new Label();
            llblLayMK = new LinkLabel();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(299, 346);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 42);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(299, 476);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 42);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenDangNhap.Location = new Point(652, 341);
            txtTenDangNhap.Margin = new Padding(6, 6, 6, 6);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(489, 50);
            txtTenDangNhap.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(652, 474);
            txtMatKhau.Margin = new Padding(6, 6, 6, 6);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(489, 50);
            txtMatKhau.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.ActiveCaption;
            btnDangNhap.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDangNhap.Location = new Point(409, 628);
            btnDangNhap.Margin = new Padding(6, 6, 6, 6);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(227, 70);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Brown;
            btnThoat.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnThoat.Location = new Point(875, 630);
            btnThoat.Margin = new Padding(4, 2, 4, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(227, 66);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Times New Roman", 25.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(537, 141);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(450, 78);
            label3.TabIndex = 6;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // llblDangKy
            // 
            llblDangKy.AutoSize = true;
            llblDangKy.Font = new Font("Times New Roman", 13.875F, FontStyle.Italic, GraphicsUnit.Point);
            llblDangKy.Location = new Point(528, 771);
            llblDangKy.Margin = new Padding(4, 0, 4, 0);
            llblDangKy.Name = "llblDangKy";
            llblDangKy.Size = new Size(144, 43);
            llblDangKy.TabIndex = 7;
            llblDangKy.TabStop = true;
            llblDangKy.Text = "Đăng ký";
            llblDangKy.LinkClicked += llblDangKy_LinkClicked_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.875F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(115, 771);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(422, 43);
            label4.TabIndex = 8;
            label4.Text = "Bạn đã có tài khoản chưa?";
            // 
            // llblLayMK
            // 
            llblLayMK.AutoSize = true;
            llblLayMK.Font = new Font("Times New Roman", 13.875F, FontStyle.Italic, GraphicsUnit.Point);
            llblLayMK.Location = new Point(1094, 771);
            llblLayMK.Margin = new Padding(4, 0, 4, 0);
            llblLayMK.Name = "llblLayMK";
            llblLayMK.Size = new Size(270, 43);
            llblLayMK.TabIndex = 9;
            llblLayMK.TabStop = true;
            llblLayMK.Text = "Lấy lại mật khẩu";
            llblLayMK.LinkClicked += llblLayMK_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.875F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(836, 771);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(266, 43);
            label5.TabIndex = 10;
            label5.Text = "Quên mật khẩu?";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 960);
            Controls.Add(label5);
            Controls.Add(llblLayMK);
            Controls.Add(label4);
            Controls.Add(llblDangKy);
            Controls.Add(label3);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "frmDangNhap";
            Text = "Đăng nhập";
            Load += frmDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
        private Label label3;
        private LinkLabel llblDangKy;
        private Label label4;
        private LinkLabel llblLayMK;
        private Label label5;
    }
}