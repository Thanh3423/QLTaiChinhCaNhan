namespace QLTCCaNhan
{
    partial class frmBaoCaoChoVay
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
            components = new System.ComponentModel.Container();
            grbChoVay = new GroupBox();
            btnThoatChoVay = new Button();
            txtNamChoVay = new TextBox();
            btnXuatChoVay = new Button();
            lblNamChoVay = new Label();
            btnTaoChoVay = new Button();
            cboThangChoVay = new ComboBox();
            lblThangChoVay = new Label();
            lblChoVay = new Label();
            txtTongChoVay = new TextBox();
            grbBCChoVay = new GroupBox();
            lblTongTien = new Label();
            dgvChoVay = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            grbChoVay.SuspendLayout();
            grbBCChoVay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChoVay).BeginInit();
            SuspendLayout();
            // 
            // grbChoVay
            // 
            grbChoVay.Controls.Add(btnThoatChoVay);
            grbChoVay.Controls.Add(txtNamChoVay);
            grbChoVay.Controls.Add(btnXuatChoVay);
            grbChoVay.Controls.Add(lblNamChoVay);
            grbChoVay.Controls.Add(btnTaoChoVay);
            grbChoVay.Controls.Add(cboThangChoVay);
            grbChoVay.Controls.Add(lblThangChoVay);
            grbChoVay.Controls.Add(lblChoVay);
            grbChoVay.Dock = DockStyle.Top;
            grbChoVay.Location = new Point(0, 0);
            grbChoVay.Name = "grbChoVay";
            grbChoVay.Size = new Size(1037, 106);
            grbChoVay.TabIndex = 0;
            grbChoVay.TabStop = false;
            // 
            // btnThoatChoVay
            // 
            btnThoatChoVay.Location = new Point(887, 56);
            btnThoatChoVay.Name = "btnThoatChoVay";
            btnThoatChoVay.Size = new Size(112, 34);
            btnThoatChoVay.TabIndex = 3;
            btnThoatChoVay.Text = "Thoát";
            btnThoatChoVay.UseVisualStyleBackColor = true;
            btnThoatChoVay.Click += btnThoatChoVay_Click_1;
            // 
            // txtNamChoVay
            // 
            txtNamChoVay.Location = new Point(325, 57);
            txtNamChoVay.Name = "txtNamChoVay";
            txtNamChoVay.Size = new Size(150, 31);
            txtNamChoVay.TabIndex = 5;
            // 
            // btnXuatChoVay
            // 
            btnXuatChoVay.Location = new Point(712, 53);
            btnXuatChoVay.Name = "btnXuatChoVay";
            btnXuatChoVay.Size = new Size(141, 34);
            btnXuatChoVay.TabIndex = 2;
            btnXuatChoVay.Text = "Xuất Báo Cáo";
            btnXuatChoVay.UseVisualStyleBackColor = true;
            btnXuatChoVay.Click += btnXuatChoVay_Click_1;
            // 
            // lblNamChoVay
            // 
            lblNamChoVay.AutoSize = true;
            lblNamChoVay.Location = new Point(260, 60);
            lblNamChoVay.Name = "lblNamChoVay";
            lblNamChoVay.Size = new Size(50, 25);
            lblNamChoVay.TabIndex = 2;
            lblNamChoVay.Text = "Năm";
            // 
            // btnTaoChoVay
            // 
            btnTaoChoVay.Location = new Point(536, 54);
            btnTaoChoVay.Name = "btnTaoChoVay";
            btnTaoChoVay.Size = new Size(147, 34);
            btnTaoChoVay.TabIndex = 1;
            btnTaoChoVay.Text = "Tạo Báo Cáo";
            btnTaoChoVay.UseVisualStyleBackColor = true;
            btnTaoChoVay.Click += btnTaoChoVay_Click;
            // 
            // cboThangChoVay
            // 
            cboThangChoVay.FormattingEnabled = true;
            cboThangChoVay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cboThangChoVay.Location = new Point(77, 57);
            cboThangChoVay.Name = "cboThangChoVay";
            cboThangChoVay.Size = new Size(133, 33);
            cboThangChoVay.TabIndex = 4;
            // 
            // lblThangChoVay
            // 
            lblThangChoVay.AutoSize = true;
            lblThangChoVay.Location = new Point(6, 62);
            lblThangChoVay.Name = "lblThangChoVay";
            lblThangChoVay.Size = new Size(61, 25);
            lblThangChoVay.TabIndex = 1;
            lblThangChoVay.Text = "Tháng";
            // 
            // lblChoVay
            // 
            lblChoVay.AutoSize = true;
            lblChoVay.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblChoVay.Location = new Point(347, 0);
            lblChoVay.Name = "lblChoVay";
            lblChoVay.Size = new Size(261, 45);
            lblChoVay.TabIndex = 0;
            lblChoVay.Text = "Báo Cáo Cho Vay";
            // 
            // txtTongChoVay
            // 
            txtTongChoVay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTongChoVay.Location = new Point(875, 290);
            txtTongChoVay.Name = "txtTongChoVay";
            txtTongChoVay.Size = new Size(150, 31);
            txtTongChoVay.TabIndex = 7;
            // 
            // grbBCChoVay
            // 
            grbBCChoVay.Controls.Add(lblTongTien);
            grbBCChoVay.Controls.Add(txtTongChoVay);
            grbBCChoVay.Controls.Add(dgvChoVay);
            grbBCChoVay.Dock = DockStyle.Fill;
            grbBCChoVay.Location = new Point(0, 106);
            grbBCChoVay.Name = "grbBCChoVay";
            grbBCChoVay.Size = new Size(1037, 344);
            grbBCChoVay.TabIndex = 1;
            grbBCChoVay.TabStop = false;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(779, 293);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(90, 25);
            lblTongTien.TabIndex = 6;
            lblTongTien.Text = "Tổng Tiền";
            // 
            // dgvChoVay
            // 
            dgvChoVay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChoVay.Location = new Point(3, 27);
            dgvChoVay.Name = "dgvChoVay";
            dgvChoVay.RowHeadersWidth = 62;
            dgvChoVay.RowTemplate.Height = 33;
            dgvChoVay.Size = new Size(1034, 314);
            dgvChoVay.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frmBaoCaoChoVay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 450);
            Controls.Add(grbBCChoVay);
            Controls.Add(grbChoVay);
            Name = "frmBaoCaoChoVay";
            Text = "Báo Cáo Cho Vay";
            grbChoVay.ResumeLayout(false);
            grbChoVay.PerformLayout();
            grbBCChoVay.ResumeLayout(false);
            grbBCChoVay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChoVay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbChoVay;
        private Button btnThoatChoVay;
        private TextBox txtNamChoVay;
        private Button btnXuatChoVay;
        private Label lblNamChoVay;
        private Button btnTaoChoVay;
        private ComboBox cboThangChoVay;
        private Label lblThangChoVay;
        private Label lblChoVay;
        private GroupBox grbBCChoVay;
        private DataGridView dgvChoVay;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtTongChoVay;
        private Label lblTongTien;
    }
}