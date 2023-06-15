namespace QLVay
{
    partial class Form8
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
            dgvMuaSam = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMuaSam).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(307, 65);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(878, 47);
            txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(100, 59);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(188, 58);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvMuaSam
            // 
            dgvMuaSam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMuaSam.Location = new Point(54, 157);
            dgvMuaSam.Name = "dgvMuaSam";
            dgvMuaSam.RowHeadersWidth = 102;
            dgvMuaSam.RowTemplate.Height = 49;
            dgvMuaSam.Size = new Size(1215, 635);
            dgvMuaSam.TabIndex = 3;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 850);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvMuaSam);
            Name = "Form8";
            Text = "Mua sắm";
            ((System.ComponentModel.ISupportInitialize)dgvMuaSam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvMuaSam;
    }
}