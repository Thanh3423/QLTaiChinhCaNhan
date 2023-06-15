namespace QLVay
{
    partial class Form1
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
            btnQLVay = new Button();
            btnQLChoVay = new Button();
            btnDanhMucThu = new Button();
            SuspendLayout();
            // 
            // btnQLVay
            // 
            btnQLVay.Location = new Point(88, 166);
            btnQLVay.Name = "btnQLVay";
            btnQLVay.Size = new Size(269, 186);
            btnQLVay.TabIndex = 0;
            btnQLVay.Text = "Vay";
            btnQLVay.UseVisualStyleBackColor = true;
            btnQLVay.Click += btnQLVay_Click;
            // 
            // btnQLChoVay
            // 
            btnQLChoVay.Location = new Point(385, 166);
            btnQLChoVay.Name = "btnQLChoVay";
            btnQLChoVay.Size = new Size(272, 184);
            btnQLChoVay.TabIndex = 1;
            btnQLChoVay.Text = "Cho Vay";
            btnQLChoVay.UseVisualStyleBackColor = true;
            btnQLChoVay.Click += btnQLChoVay_Click;
            // 
            // btnDanhMucThu
            // 
            btnDanhMucThu.Location = new Point(698, 166);
            btnDanhMucThu.Name = "btnDanhMucThu";
            btnDanhMucThu.Size = new Size(269, 186);
            btnDanhMucThu.TabIndex = 2;
            btnDanhMucThu.Text = "Danh mục chi";
            btnDanhMucThu.UseVisualStyleBackColor = true;
            btnDanhMucThu.Click += btnDanhMucThu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 679);
            Controls.Add(btnDanhMucThu);
            Controls.Add(btnQLChoVay);
            Controls.Add(btnQLVay);
            Name = "Form1";
            Text = "Quản lý chi tiêu cá nhân";
            ResumeLayout(false);
        }

        #endregion

        private Button btnQLVay;
        private Button btnQLChoVay;
        private Button btnDanhMucThu;
    }
}