namespace QLTCCaNhan
{
    partial class frmBaoCaoVay
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
            grbBaoCaoVay = new GroupBox();
            btnThoatVay = new Button();
            btnXuatVay = new Button();
            dataGridView1 = new DataGridView();
            btnTaoVay = new Button();
            cboThangVay = new ComboBox();
            txtNam = new TextBox();
            lblNam = new Label();
            lblBaoCaoVay = new Label();
            lblThangVay = new Label();
            grbVay = new GroupBox();
            txtTongVay = new TextBox();
            lblTongTien = new Label();
            dgvVay = new DataGridView();
            grbBaoCaoVay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grbVay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVay).BeginInit();
            SuspendLayout();
            // 
            // grbBaoCaoVay
            // 
            grbBaoCaoVay.Controls.Add(btnThoatVay);
            grbBaoCaoVay.Controls.Add(btnXuatVay);
            grbBaoCaoVay.Controls.Add(dataGridView1);
            grbBaoCaoVay.Controls.Add(btnTaoVay);
            grbBaoCaoVay.Controls.Add(cboThangVay);
            grbBaoCaoVay.Controls.Add(txtNam);
            grbBaoCaoVay.Controls.Add(lblNam);
            grbBaoCaoVay.Controls.Add(lblBaoCaoVay);
            grbBaoCaoVay.Controls.Add(lblThangVay);
            grbBaoCaoVay.Dock = DockStyle.Top;
            grbBaoCaoVay.Location = new Point(0, 0);
            grbBaoCaoVay.Name = "grbBaoCaoVay";
            grbBaoCaoVay.Size = new Size(1054, 116);
            grbBaoCaoVay.TabIndex = 0;
            grbBaoCaoVay.TabStop = false;
            // 
            // btnThoatVay
            // 
            btnThoatVay.Location = new Point(873, 63);
            btnThoatVay.Name = "btnThoatVay";
            btnThoatVay.Size = new Size(112, 34);
            btnThoatVay.TabIndex = 5;
            btnThoatVay.Text = "Thoát";
            btnThoatVay.UseVisualStyleBackColor = true;
            btnThoatVay.Click += btnThoatVay_Click;
            // 
            // btnXuatVay
            // 
            btnXuatVay.Location = new Point(668, 63);
            btnXuatVay.Name = "btnXuatVay";
            btnXuatVay.Size = new Size(145, 34);
            btnXuatVay.TabIndex = 4;
            btnXuatVay.Text = "Xuất Báo Cáo";
            btnXuatVay.UseVisualStyleBackColor = true;
            btnXuatVay.Click += btnXuatVay_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1054, 262);
            dataGridView1.TabIndex = 0;
            // 
            // btnTaoVay
            // 
            btnTaoVay.Location = new Point(469, 63);
            btnTaoVay.Name = "btnTaoVay";
            btnTaoVay.Size = new Size(145, 34);
            btnTaoVay.TabIndex = 3;
            btnTaoVay.Text = "Tạo báo Cáo";
            btnTaoVay.UseVisualStyleBackColor = true;
            btnTaoVay.Click += btnTaovay_Click;
            // 
            // cboThangVay
            // 
            cboThangVay.FormattingEnabled = true;
            cboThangVay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cboThangVay.Location = new Point(95, 69);
            cboThangVay.Name = "cboThangVay";
            cboThangVay.Size = new Size(106, 33);
            cboThangVay.TabIndex = 1;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(274, 68);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(106, 31);
            txtNam.TabIndex = 2;
            // 
            // lblNam
            // 
            lblNam.AutoSize = true;
            lblNam.Location = new Point(228, 72);
            lblNam.Name = "lblNam";
            lblNam.Size = new Size(50, 25);
            lblNam.TabIndex = 2;
            lblNam.Text = "Năm";
            // 
            // lblBaoCaoVay
            // 
            lblBaoCaoVay.AutoSize = true;
            lblBaoCaoVay.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaoCaoVay.Location = new Point(373, 0);
            lblBaoCaoVay.Name = "lblBaoCaoVay";
            lblBaoCaoVay.Size = new Size(195, 45);
            lblBaoCaoVay.TabIndex = 0;
            lblBaoCaoVay.Text = "Báo Cáo Vay";
            // 
            // lblThangVay
            // 
            lblThangVay.AutoSize = true;
            lblThangVay.Location = new Point(30, 72);
            lblThangVay.Name = "lblThangVay";
            lblThangVay.Size = new Size(61, 25);
            lblThangVay.TabIndex = 1;
            lblThangVay.Text = "Tháng";
            // 
            // grbVay
            // 
            grbVay.Controls.Add(txtTongVay);
            grbVay.Controls.Add(lblTongTien);
            grbVay.Controls.Add(dgvVay);
            grbVay.Dock = DockStyle.Fill;
            grbVay.Location = new Point(0, 116);
            grbVay.Name = "grbVay";
            grbVay.Size = new Size(1054, 334);
            grbVay.TabIndex = 1;
            grbVay.TabStop = false;
            // 
            // txtTongVay
            // 
            txtTongVay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTongVay.Location = new Point(892, 291);
            txtTongVay.Name = "txtTongVay";
            txtTongVay.Size = new Size(150, 31);
            txtTongVay.TabIndex = 2;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(796, 294);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(90, 25);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng Tiền";
            // 
            // dgvVay
            // 
            dgvVay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVay.Location = new Point(0, 0);
            dgvVay.Name = "dgvVay";
            dgvVay.RowHeadersWidth = 62;
            dgvVay.RowTemplate.Height = 33;
            dgvVay.Size = new Size(1054, 334);
            dgvVay.TabIndex = 0;
            // 
            // frmBaoCaoVay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 450);
            Controls.Add(grbVay);
            Controls.Add(grbBaoCaoVay);
            Name = "frmBaoCaoVay";
            Text = "Báo Cáo Vay";
            grbBaoCaoVay.ResumeLayout(false);
            grbBaoCaoVay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grbVay.ResumeLayout(false);
            grbVay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbBaoCaoVay;
        private Button btnThoatVay;
        private Button btnXuatVay;
        private Button btnTaoVay;
        private ComboBox cboThangVay;
        private TextBox txtNam;
        private Label lblNam;
        private Label lblBaoCaoVay;
        private Label lblThangVay;
        private GroupBox grbVay;
        private TextBox txtTongVay;
        private Label lblTongTien;
        private DataGridView dgvVay;
        private DataGridView dataGridView1;
    }
}