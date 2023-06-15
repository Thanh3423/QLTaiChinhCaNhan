namespace QLTCCaNhan
{
    partial class frmBaoCaoChi
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
            grbBaoCaoChi = new GroupBox();
            txtNamChi = new TextBox();
            cboThangChi = new ComboBox();
            btnThoatChi = new Button();
            btnXuatChi = new Button();
            btnTaoChi = new Button();
            lblNamChi = new Label();
            lblThangChi = new Label();
            lblBaoCaoChi = new Label();
            grbChi = new GroupBox();
            txtTongChi = new TextBox();
            lblTongChi = new Label();
            dgvChi = new DataGridView();
            saveFileDialog1 = new SaveFileDialog();
            grbBaoCaoChi.SuspendLayout();
            grbChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChi).BeginInit();
            SuspendLayout();
            // 
            // grbBaoCaoChi
            // 
            grbBaoCaoChi.Controls.Add(txtNamChi);
            grbBaoCaoChi.Controls.Add(cboThangChi);
            grbBaoCaoChi.Controls.Add(btnThoatChi);
            grbBaoCaoChi.Controls.Add(btnXuatChi);
            grbBaoCaoChi.Controls.Add(btnTaoChi);
            grbBaoCaoChi.Controls.Add(lblNamChi);
            grbBaoCaoChi.Controls.Add(lblThangChi);
            grbBaoCaoChi.Controls.Add(lblBaoCaoChi);
            grbBaoCaoChi.Dock = DockStyle.Top;
            grbBaoCaoChi.Location = new Point(0, 0);
            grbBaoCaoChi.Name = "grbBaoCaoChi";
            grbBaoCaoChi.Size = new Size(1053, 114);
            grbBaoCaoChi.TabIndex = 0;
            grbBaoCaoChi.TabStop = false;
            // 
            // txtNamChi
            // 
            txtNamChi.Location = new Point(334, 60);
            txtNamChi.Name = "txtNamChi";
            txtNamChi.Size = new Size(86, 31);
            txtNamChi.TabIndex = 2;
            txtNamChi.TextChanged += txtNamChi_TextChanged;
            // 
            // cboThangChi
            // 
            cboThangChi.FormattingEnabled = true;
            cboThangChi.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cboThangChi.Location = new Point(121, 58);
            cboThangChi.Name = "cboThangChi";
            cboThangChi.Size = new Size(94, 33);
            cboThangChi.TabIndex = 3;
            // 
            // btnThoatChi
            // 
            btnThoatChi.Location = new Point(875, 57);
            btnThoatChi.Name = "btnThoatChi";
            btnThoatChi.Size = new Size(146, 34);
            btnThoatChi.TabIndex = 1;
            btnThoatChi.Text = "Thoát";
            btnThoatChi.UseVisualStyleBackColor = true;
            btnThoatChi.Click += btnThoatChi_Click;
            // 
            // btnXuatChi
            // 
            btnXuatChi.Location = new Point(685, 58);
            btnXuatChi.Name = "btnXuatChi";
            btnXuatChi.Size = new Size(141, 34);
            btnXuatChi.TabIndex = 1;
            btnXuatChi.Text = "Xuất Báo Cáo";
            btnXuatChi.UseVisualStyleBackColor = true;
            btnXuatChi.Click += btnXuatChi_Click;
            // 
            // btnTaoChi
            // 
            btnTaoChi.Location = new Point(494, 58);
            btnTaoChi.Name = "btnTaoChi";
            btnTaoChi.Size = new Size(141, 34);
            btnTaoChi.TabIndex = 1;
            btnTaoChi.Text = "Tạo Báo cáo";
            btnTaoChi.UseVisualStyleBackColor = true;
            btnTaoChi.Click += btnTaoChi_Click;
            // 
            // lblNamChi
            // 
            lblNamChi.AutoSize = true;
            lblNamChi.Location = new Point(278, 63);
            lblNamChi.Name = "lblNamChi";
            lblNamChi.Size = new Size(50, 25);
            lblNamChi.TabIndex = 0;
            lblNamChi.Text = "Năm";
            // 
            // lblThangChi
            // 
            lblThangChi.AutoSize = true;
            lblThangChi.Location = new Point(54, 63);
            lblThangChi.Name = "lblThangChi";
            lblThangChi.Size = new Size(61, 25);
            lblThangChi.TabIndex = 0;
            lblThangChi.Text = "Tháng";
            // 
            // lblBaoCaoChi
            // 
            lblBaoCaoChi.AutoSize = true;
            lblBaoCaoChi.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaoCaoChi.Location = new Point(399, 0);
            lblBaoCaoChi.Name = "lblBaoCaoChi";
            lblBaoCaoChi.Size = new Size(192, 45);
            lblBaoCaoChi.TabIndex = 0;
            lblBaoCaoChi.Text = "Báo Cáo Chi";
            // 
            // grbChi
            // 
            grbChi.Controls.Add(txtTongChi);
            grbChi.Controls.Add(lblTongChi);
            grbChi.Controls.Add(dgvChi);
            grbChi.Dock = DockStyle.Fill;
            grbChi.Location = new Point(0, 114);
            grbChi.Name = "grbChi";
            grbChi.Size = new Size(1053, 336);
            grbChi.TabIndex = 1;
            grbChi.TabStop = false;
            // 
            // txtTongChi
            // 
            txtTongChi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTongChi.Location = new Point(897, 293);
            txtTongChi.Name = "txtTongChi";
            txtTongChi.Size = new Size(150, 31);
            txtTongChi.TabIndex = 2;
            // 
            // lblTongChi
            // 
            lblTongChi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTongChi.AutoSize = true;
            lblTongChi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongChi.Location = new Point(792, 293);
            lblTongChi.Name = "lblTongChi";
            lblTongChi.Size = new Size(90, 28);
            lblTongChi.TabIndex = 1;
            lblTongChi.Text = "Tổng Chi";
            // 
            // dgvChi
            // 
            dgvChi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChi.Location = new Point(0, 6);
            dgvChi.Name = "dgvChi";
            dgvChi.RowHeadersWidth = 62;
            dgvChi.RowTemplate.Height = 33;
            dgvChi.Size = new Size(1053, 330);
            dgvChi.TabIndex = 0;
            // 
            // frmBaoCaoChi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 450);
            Controls.Add(grbChi);
            Controls.Add(grbBaoCaoChi);
            Name = "frmBaoCaoChi";
            Text = "Báo Cáo Chi";
            grbBaoCaoChi.ResumeLayout(false);
            grbBaoCaoChi.PerformLayout();
            grbChi.ResumeLayout(false);
            grbChi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbBaoCaoChi;
        private TextBox txtNamChi;
        private ComboBox cboThangChi;
        private Button btnThoatChi;
        private Button btnXuatChi;
        private Button btnTaoChi;
        private Label lblNamChi;
        private Label lblThangChi;
        private Label lblBaoCaoChi;
        private GroupBox grbChi;
        private DataGridView dgvChi;
        private TextBox txtTongChi;
        private Label lblTongChi;
        private SaveFileDialog saveFileDialog1;
    }
}