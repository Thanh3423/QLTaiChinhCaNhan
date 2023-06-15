namespace QLVay
{
    partial class Form6
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
            dgvDiLai = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDiLai).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(354, 90);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(878, 47);
            txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(89, 84);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(188, 58);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvDiLai
            // 
            dgvDiLai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiLai.Location = new Point(46, 183);
            dgvDiLai.Name = "dgvDiLai";
            dgvDiLai.RowHeadersWidth = 102;
            dgvDiLai.RowTemplate.Height = 49;
            dgvDiLai.Size = new Size(1215, 635);
            dgvDiLai.TabIndex = 3;
            dgvDiLai.CellClick += dgvDiLai_CellClick;
            dgvDiLai.CellContentClick += dgvDiLai_CellContentClick;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 873);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvDiLai);
            Name = "Form6";
            Text = "Đi lại";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiLai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvDiLai;
    }
}