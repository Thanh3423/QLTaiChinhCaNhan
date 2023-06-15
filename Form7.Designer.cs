namespace QLVay
{
    partial class Form7
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
            dgvDienNuoc = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDienNuoc).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(431, 129);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(878, 47);
            txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(224, 123);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(188, 58);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvDienNuoc
            // 
            dgvDienNuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDienNuoc.Location = new Point(178, 221);
            dgvDienNuoc.Name = "dgvDienNuoc";
            dgvDienNuoc.RowHeadersWidth = 102;
            dgvDienNuoc.RowTemplate.Height = 49;
            dgvDienNuoc.Size = new Size(1215, 635);
            dgvDienNuoc.TabIndex = 3;
            dgvDienNuoc.CellContentClick += dgvDienNuoc_CellContentClick;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 950);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvDienNuoc);
            Name = "Form7";
            Text = "Điện nước";
            ((System.ComponentModel.ISupportInitialize)dgvDienNuoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvDienNuoc;
    }
}