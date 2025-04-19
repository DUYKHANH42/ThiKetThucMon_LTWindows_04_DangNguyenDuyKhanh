namespace ThiKetThucMon_LTWindows_2421160014_DangNguyenDuyKhanh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLuu = new Button();
            btnXoa = new Button();
            btnTiep = new Button();
            lstSP = new ListBox();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtDonGia = new TextBox();
            txtSoluong = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 46);
            label1.Name = "label1";
            label1.Size = new Size(156, 64);
            label1.TabIndex = 0;
            label1.Text = "Mã SP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 137);
            label2.Name = "label2";
            label2.Size = new Size(156, 64);
            label2.TabIndex = 0;
            label2.Text = "Tên SP";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 219);
            label3.Name = "label3";
            label3.Size = new Size(156, 64);
            label3.TabIndex = 0;
            label3.Text = "Đơn giá";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 310);
            label4.Name = "label4";
            label4.Size = new Size(156, 64);
            label4.TabIndex = 0;
            label4.Text = "Số lượng";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.Red;
            btnLuu.Location = new Point(45, 428);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(156, 64);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(335, 428);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(156, 64);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTiep
            // 
            btnTiep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTiep.ForeColor = Color.Red;
            btnTiep.Location = new Point(625, 428);
            btnTiep.Name = "btnTiep";
            btnTiep.Size = new Size(156, 64);
            btnTiep.TabIndex = 7;
            btnTiep.Text = "Tiếp";
            btnTiep.UseVisualStyleBackColor = true;
            btnTiep.Click += btnTiep_Click;
            // 
            // lstSP
            // 
            lstSP.FormattingEnabled = true;
            lstSP.Location = new Point(45, 510);
            lstSP.Name = "lstSP";
            lstSP.Size = new Size(736, 260);
            lstSP.TabIndex = 8;
            lstSP.SelectedIndexChanged += lstSP_SelectedIndexChanged;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(237, 59);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.ReadOnly = true;
            txtMaSP.Size = new Size(544, 39);
            txtMaSP.TabIndex = 1;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(237, 150);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(544, 39);
            txtTenSP.TabIndex = 2;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(237, 232);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(544, 39);
            txtDonGia.TabIndex = 3;
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(237, 323);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(544, 39);
            txtSoluong.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 794);
            Controls.Add(txtSoluong);
            Controls.Add(txtDonGia);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(lstSP);
            Controls.Add(btnTiep);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Blue;
            Name = "Form1";
            Text = "Quản lý cửa hàng";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnTiep;
        private ListBox lstSP;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtDonGia;
        private TextBox txtSoluong;
    }
}
