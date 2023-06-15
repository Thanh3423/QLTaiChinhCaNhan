namespace QLVay
{
    partial class Form4
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
            btnAnUong = new Button();
            btnDiLai = new Button();
            btnDienNuoc = new Button();
            btnQuanAo = new Button();
            btnKhac = new Button();
            SuspendLayout();
            // 
            // btnAnUong
            // 
            btnAnUong.Location = new Point(63, 116);
            btnAnUong.Name = "btnAnUong";
            btnAnUong.Size = new Size(188, 144);
            btnAnUong.TabIndex = 0;
            btnAnUong.Text = "Ăn uống";
            btnAnUong.UseVisualStyleBackColor = true;
            btnAnUong.Click += btnAnUong_Click;
            // 
            // btnDiLai
            // 
            btnDiLai.Location = new Point(422, 116);
            btnDiLai.Name = "btnDiLai";
            btnDiLai.Size = new Size(188, 144);
            btnDiLai.TabIndex = 1;
            btnDiLai.Text = "Đi lại";
            btnDiLai.UseVisualStyleBackColor = true;
            btnDiLai.Click += btnDiLai_Click;
            // 
            // btnDienNuoc
            // 
            btnDienNuoc.Location = new Point(843, 116);
            btnDienNuoc.Name = "btnDienNuoc";
            btnDienNuoc.Size = new Size(188, 144);
            btnDienNuoc.TabIndex = 2;
            btnDienNuoc.Text = "Điện nước";
            btnDienNuoc.UseVisualStyleBackColor = true;
            btnDienNuoc.Click += btnDienNuoc_Click;
            // 
            // btnQuanAo
            // 
            btnQuanAo.Location = new Point(245, 394);
            btnQuanAo.Name = "btnQuanAo";
            btnQuanAo.Size = new Size(188, 144);
            btnQuanAo.TabIndex = 3;
            btnQuanAo.Text = "Mua sắm";
            btnQuanAo.UseVisualStyleBackColor = true;
            btnQuanAo.Click += btnQuanAo_Click;
            // 
            // btnKhac
            // 
            btnKhac.Location = new Point(661, 394);
            btnKhac.Name = "btnKhac";
            btnKhac.Size = new Size(188, 144);
            btnKhac.TabIndex = 4;
            btnKhac.Text = "Khác";
            btnKhac.UseVisualStyleBackColor = true;
            btnKhac.Click += btnKhac_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 874);
            Controls.Add(btnKhac);
            Controls.Add(btnQuanAo);
            Controls.Add(btnDienNuoc);
            Controls.Add(btnDiLai);
            Controls.Add(btnAnUong);
            Name = "Form4";
            Text = "Danh mục chi:";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAnUong;
        private Button btnDiLai;
        private Button btnDienNuoc;
        private Button btnQuanAo;
        private Button btnKhac;
    }
}