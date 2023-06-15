namespace QLVay
{
    partial class Frm5
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
            dgvAnUong = new DataGridView();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAnUong).BeginInit();
            SuspendLayout();
            // 
            // dgvAnUong
            // 
            dgvAnUong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnUong.Location = new Point(12, 175);
            dgvAnUong.Name = "dgvAnUong";
            dgvAnUong.RowHeadersWidth = 102;
            dgvAnUong.RowTemplate.Height = 49;
            dgvAnUong.Size = new Size(1215, 635);
            dgvAnUong.TabIndex = 0;
            dgvAnUong.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(58, 77);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(188, 58);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += button1_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(265, 83);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(878, 47);
            txtTimKiem.TabIndex = 2;
            // 
            // Frm5
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 822);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvAnUong);
            Name = "Frm5";
            Text = "Ăn uống";
            Load += Frm5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnUong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAnUong;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
    }
}