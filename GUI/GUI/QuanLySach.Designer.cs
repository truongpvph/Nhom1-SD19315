﻿namespace GUI
{
    partial class QuanLySach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySach));
            ccbtacgia = new ComboBox();
            cbbnxb = new ComboBox();
            Image = new ImageList(components);
            pictureBox1 = new PictureBox();
            grbhinhanh = new GroupBox();
            textBox2 = new TextBox();
            ccbtheloai = new ComboBox();
            groupBox1 = new GroupBox();
            btnhienthi = new Button();
            txtTimKiem = new TextBox();
            label8 = new Label();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            txtSoDienThoai = new TextBox();
            txtMaTaiKhoan = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            laba = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvquanlynv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbhinhanh.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).BeginInit();
            SuspendLayout();
            // 
            // ccbtacgia
            // 
            ccbtacgia.FormattingEnabled = true;
            ccbtacgia.Location = new Point(130, 39);
            ccbtacgia.Name = "ccbtacgia";
            ccbtacgia.Size = new Size(296, 28);
            ccbtacgia.TabIndex = 95;
            // 
            // cbbnxb
            // 
            cbbnxb.FormattingEnabled = true;
            cbbnxb.Location = new Point(130, 106);
            cbbnxb.Name = "cbbnxb";
            cbbnxb.Size = new Size(296, 28);
            cbbnxb.TabIndex = 93;
            // 
            // Image
            // 
            Image.ColorDepth = ColorDepth.Depth32Bit;
            Image.ImageStream = (ImageListStreamer)resources.GetObject("Image.ImageStream");
            Image.TransparentColor = Color.Transparent;
            Image.Images.SetKeyName(0, "8666762_grid_shape_icon.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(7, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 196);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grbhinhanh
            // 
            grbhinhanh.BackColor = Color.FromArgb(224, 224, 224);
            grbhinhanh.Controls.Add(pictureBox1);
            grbhinhanh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbhinhanh.Location = new Point(738, 6);
            grbhinhanh.Name = "grbhinhanh";
            grbhinhanh.Size = new Size(276, 225);
            grbhinhanh.TabIndex = 92;
            grbhinhanh.TabStop = false;
            grbhinhanh.Text = "Hình Ảnh";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 197);
            textBox2.TabIndex = 0;
            // 
            // ccbtheloai
            // 
            ccbtheloai.FormattingEnabled = true;
            ccbtheloai.Location = new Point(130, 73);
            ccbtheloai.Name = "ccbtheloai";
            ccbtheloai.Size = new Size(296, 28);
            ccbtheloai.TabIndex = 94;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(460, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 229);
            groupBox1.TabIndex = 91;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mô Tả";
            // 
            // btnhienthi
            // 
            btnhienthi.BackColor = Color.FromArgb(255, 128, 128);
            btnhienthi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnhienthi.Location = new Point(460, 241);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 90;
            btnhienthi.Text = "Hiển Thị";
            btnhienthi.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(130, 243);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm Kiếm Theo Tên Sách";
            txtTimKiem.Size = new Size(296, 27);
            txtTimKiem.TabIndex = 89;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(10, 246);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 88;
            label8.Text = "Tìm Kiếm ";
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.FromArgb(255, 192, 128);
            btnxoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnxoa.Location = new Point(819, 241);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 87;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(255, 192, 128);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsua.Location = new Point(698, 241);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 86;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(255, 192, 128);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnthem.Location = new Point(577, 241);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 85;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(130, 206);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(296, 27);
            txtMatKhau.TabIndex = 84;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(130, 173);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(296, 27);
            txtTaiKhoan.TabIndex = 83;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(130, 140);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(296, 27);
            txtSoDienThoai.TabIndex = 82;
            // 
            // txtMaTaiKhoan
            // 
            txtMaTaiKhoan.Location = new Point(130, 6);
            txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            txtMaTaiKhoan.Size = new Size(296, 27);
            txtMaTaiKhoan.TabIndex = 81;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(11, 213);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 80;
            label7.Text = "Ngày Xuất Bản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(12, 114);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 79;
            label6.Text = "Mã NXB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(7, 147);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 78;
            label5.Text = "Tên Sách";
            // 
            // laba
            // 
            laba.AutoSize = true;
            laba.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            laba.Location = new Point(7, 180);
            laba.Name = "laba";
            laba.Size = new Size(68, 20);
            laba.TabIndex = 77;
            laba.Text = "Giá Sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 76;
            label3.Text = "Mã Thể Loại ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 75;
            label2.Text = "Mã Tác Giả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 74;
            label1.Text = "Mã Sách ";
            // 
            // dgvquanlynv
            // 
            dgvquanlynv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvquanlynv.BackgroundColor = Color.FromArgb(192, 255, 255);
            dgvquanlynv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvquanlynv.Location = new Point(11, 276);
            dgvquanlynv.Name = "dgvquanlynv";
            dgvquanlynv.RowHeadersWidth = 51;
            dgvquanlynv.Size = new Size(1003, 304);
            dgvquanlynv.TabIndex = 73;
            // 
            // QuanLySach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ccbtacgia);
            Controls.Add(cbbnxb);
            Controls.Add(grbhinhanh);
            Controls.Add(ccbtheloai);
            Controls.Add(groupBox1);
            Controls.Add(btnhienthi);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtMaTaiKhoan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(laba);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvquanlynv);
            Name = "QuanLySach";
            Size = new Size(1020, 583);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbhinhanh.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvquanlynv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ccbtacgia;
        private ComboBox cbbnxb;
        private ImageList Image;
        private PictureBox pictureBox1;
        private GroupBox grbhinhanh;
        private TextBox textBox2;
        private ComboBox ccbtheloai;
        private GroupBox groupBox1;
        private Button btnhienthi;
        private TextBox txtTimKiem;
        private Label label8;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private TextBox txtSoDienThoai;
        private TextBox txtMaTaiKhoan;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label laba;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvquanlynv;
    }
}
