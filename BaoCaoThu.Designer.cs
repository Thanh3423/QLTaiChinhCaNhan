namespace QLTCCaNhan
{
    partial class frmBaoCaoThu
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
            grbBaoCaoThu = new GroupBox();
            txtNamThu = new TextBox();
            btnTaoThu = new Button();
            cboThangThu = new ComboBox();
            btnThoat = new Button();
            btnXuatThu = new Button();
            lblNamThu = new Label();
            lblThangThu = new Label();
            label1 = new Label();
            grbThu = new GroupBox();
            txtTongThu = new TextBox();
            lblTongThu = new Label();
            dgvThu = new DataGridView();
            grbBaoCaoThu.SuspendLayout();
            grbThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThu).BeginInit();
            SuspendLayout();
            // 
            // grbBaoCaoThu
            // 
            grbBaoCaoThu.Controls.Add(txtNamThu);
            grbBaoCaoThu.Controls.Add(btnTaoThu);
            grbBaoCaoThu.Controls.Add(cboThangThu);
            grbBaoCaoThu.Controls.Add(btnThoat);
            grbBaoCaoThu.Controls.Add(btnXuatThu);
            grbBaoCaoThu.Controls.Add(lblNamThu);
            grbBaoCaoThu.Controls.Add(lblThangThu);
            grbBaoCaoThu.Controls.Add(label1);
            grbBaoCaoThu.Dock = DockStyle.Top;
            grbBaoCaoThu.Location = new Point(0, 0);
            grbBaoCaoThu.Name = "grbBaoCaoThu";
            grbBaoCaoThu.Size = new Size(1055, 117);
            grbBaoCaoThu.TabIndex = 0;
            grbBaoCaoThu.TabStop = false;
            // 
            // txtNamThu
            // 
            txtNamThu.Location = new Point(291, 61);
            txtNamThu.Name = "txtNamThu";
            txtNamThu.Size = new Size(114, 31);
            txtNamThu.TabIndex = 2;
            // 
            // btnTaoThu
            // 
            btnTaoThu.Location = new Point(497, 54);
            btnTaoThu.Name = "btnTaoThu";
            btnTaoThu.Size = new Size(142, 44);
            btnTaoThu.TabIndex = 2;
            btnTaoThu.Text = "Tạo Báo cáo";
            btnTaoThu.UseVisualStyleBackColor = true;
            btnTaoThu.Click += btnTaoThu_Click;
            // 
            // cboThangThu
            // 
            cboThangThu.FormattingEnabled = true;
            cboThangThu.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cboThangThu.Location = new Point(95, 61);
            cboThangThu.Name = "cboThangThu";
            cboThangThu.Size = new Size(120, 33);
            cboThangThu.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(880, 54);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(142, 44);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuatThu
            // 
            btnXuatThu.Location = new Point(696, 54);
            btnXuatThu.Name = "btnXuatThu";
            btnXuatThu.Size = new Size(142, 44);
            btnXuatThu.TabIndex = 2;
            btnXuatThu.Text = "Xuất Báo Cáo";
            btnXuatThu.UseVisualStyleBackColor = true;
            btnXuatThu.Click += btnXuatThu_Click;
            // 
            // lblNamThu
            // 
            lblNamThu.AutoSize = true;
            lblNamThu.Location = new Point(244, 64);
            lblNamThu.Name = "lblNamThu";
            lblNamThu.Size = new Size(50, 25);
            lblNamThu.TabIndex = 1;
            lblNamThu.Text = "Năm";
            // 
            // lblThangThu
            // 
            lblThangThu.AutoSize = true;
            lblThangThu.Location = new Point(30, 64);
            lblThangThu.Name = "lblThangThu";
            lblThangThu.Size = new Size(61, 25);
            lblThangThu.TabIndex = 1;
            lblThangThu.Text = "Tháng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(403, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 45);
            label1.TabIndex = 0;
            label1.Text = "Báo Cáo Thu";
            // 
            // grbThu
            // 
            grbThu.Controls.Add(txtTongThu);
            grbThu.Controls.Add(lblTongThu);
            grbThu.Controls.Add(dgvThu);
            grbThu.Dock = DockStyle.Fill;
            grbThu.Location = new Point(0, 117);
            grbThu.Name = "grbThu";
            grbThu.Size = new Size(1055, 314);
            grbThu.TabIndex = 1;
            grbThu.TabStop = false;
            // 
            // txtTongThu
            // 
            txtTongThu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTongThu.Location = new Point(899, 271);
            txtTongThu.Name = "txtTongThu";
            txtTongThu.Size = new Size(150, 31);
            txtTongThu.TabIndex = 2;
            // 
            // lblTongThu
            // 
            lblTongThu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTongThu.AutoSize = true;
            lblTongThu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongThu.Location = new Point(799, 274);
            lblTongThu.Name = "lblTongThu";
            lblTongThu.Size = new Size(94, 28);
            lblTongThu.TabIndex = 1;
            lblTongThu.Text = "Tổng Thu";
            // 
            // dgvThu
            // 
            dgvThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThu.Location = new Point(0, 0);
            dgvThu.Name = "dgvThu";
            dgvThu.RowHeadersWidth = 62;
            dgvThu.RowTemplate.Height = 33;
            dgvThu.Size = new Size(1055, 314);
            dgvThu.TabIndex = 0;
            // 
            // frmBaoCaoThu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 431);
            Controls.Add(grbThu);
            Controls.Add(grbBaoCaoThu);
            Name = "frmBaoCaoThu";
            Text = "Báo Cáo Thu";
            grbBaoCaoThu.ResumeLayout(false);
            grbBaoCaoThu.PerformLayout();
            grbThu.ResumeLayout(false);
            grbThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbBaoCaoThu;
        private Button btnTaoThu;
        private Button btnThoat;
        private Button btnXuatThu;
        private Label lblNamThu;
        private Label lblThangThu;
        private Label label1;
        private ComboBox cboThangThu;
        private TextBox txtNamThu;
        private GroupBox grbThu;
        private TextBox txtTongThu;
        private Label lblTongThu;
        private DataGridView dgvThu;
    }
}