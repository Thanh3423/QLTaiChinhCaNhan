namespace QLVay
{
    partial class Form9
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
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvKhac = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKhac).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(260, 39);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(878, 47);
            txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(53, 33);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(188, 58);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvKhac
            // 
            dgvKhac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhac.Location = new Point(21, 145);
            dgvKhac.Name = "dgvKhac";
            dgvKhac.RowHeadersWidth = 102;
            dgvKhac.RowTemplate.Height = 49;
            dgvKhac.Size = new Size(1215, 635);
            dgvKhac.TabIndex = 3;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 818);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvKhac);
            Name = "Form9";
            Text = "Khác";
            ((System.ComponentModel.ISupportInitialize)dgvKhac).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvKhac;
    }
}