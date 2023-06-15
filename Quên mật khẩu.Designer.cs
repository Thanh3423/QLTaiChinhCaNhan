namespace DemoThao
{
    partial class frmQuenMK
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
            label6 = new Label();
            label8 = new Label();
            txtSoDienThoai = new TextBox();
            btnLayMK = new Button();
            hienthi = new Label();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Times New Roman", 25.875F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(182, 104);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(719, 78);
            label6.TabIndex = 31;
            label6.Text = "LẤY LẠI MẬT KHẨU";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonHighlight;
            label8.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(206, 312);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(209, 42);
            label8.TabIndex = 32;
            label8.Text = "Số điện thoại";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoDienThoai.Location = new Point(512, 309);
            txtSoDienThoai.Margin = new Padding(6);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(339, 50);
            txtSoDienThoai.TabIndex = 36;
            // 
            // btnLayMK
            // 
            btnLayMK.BackColor = SystemColors.ActiveCaption;
            btnLayMK.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLayMK.Location = new Point(168, 510);
            btnLayMK.Margin = new Padding(6);
            btnLayMK.Name = "btnLayMK";
            btnLayMK.Size = new Size(305, 60);
            btnLayMK.TabIndex = 42;
            btnLayMK.Text = "Lấy lại mật khẩu";
            btnLayMK.UseVisualStyleBackColor = false;
            btnLayMK.Click += btnLayMK_Click;
            // 
            // hienthi
            // 
            hienthi.AutoSize = true;
            hienthi.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            hienthi.Location = new Point(206, 400);
            hienthi.Name = "hienthi";
            hienthi.Size = new Size(0, 43);
            hienthi.TabIndex = 37;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Brown;
            btnThoat.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnThoat.Location = new Point(649, 507);
            btnThoat.Margin = new Padding(4, 2, 4, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(227, 66);
            btnThoat.TabIndex = 44;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmQuenMK
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 684);
            Controls.Add(btnThoat);
            Controls.Add(btnLayMK);
            Controls.Add(hienthi);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label8);
            Controls.Add(label6);
            Name = "frmQuenMK";
            Text = "Quên_mật_khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label8;
        private TextBox txtSoDienThoai;
        private Button btnLayMK;
        private Label hienthi;
        private Button btnThoat;
    }
}