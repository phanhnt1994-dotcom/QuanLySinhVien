namespace QuanLySinhVien
{
    partial class FormQuanLyKhoa
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
            txtTenKhoa = new TextBox();
            txtNamThanhLap = new TextBox();
            txtTongSoGiangVien = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvKhoa = new DataGridView();
            lblTenKhoa = new Label();
            lblNamThanhLap = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(41, 42);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(100, 23);
            txtTenKhoa.TabIndex = 0;
            // 
            // txtNamThanhLap
            // 
            txtNamThanhLap.Location = new Point(198, 42);
            txtNamThanhLap.Name = "txtNamThanhLap";
            txtNamThanhLap.Size = new Size(100, 23);
            txtNamThanhLap.TabIndex = 1;
            // 
            // txtTongSoGiangVien
            // 
            txtTongSoGiangVien.Location = new Point(371, 42);
            txtTongSoGiangVien.Name = "txtTongSoGiangVien";
            txtTongSoGiangVien.Size = new Size(100, 23);
            txtTongSoGiangVien.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(41, 101);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 48);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm khoa ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(147, 101);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 48);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa khoa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(257, 101);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 48);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa khoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(371, 101);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 48);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvKhoa
            // 
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(12, 155);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.Size = new Size(488, 246);
            dgvKhoa.TabIndex = 7;
            // 
            // lblTenKhoa
            // 
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Location = new Point(41, 9);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Size = new Size(85, 15);
            lblTenKhoa.TabIndex = 8;
            lblTenKhoa.Text = "Nhập tên khoa";
            // 
            // lblNamThanhLap
            // 
            lblNamThanhLap.AutoSize = true;
            lblNamThanhLap.Location = new Point(198, 9);
            lblNamThanhLap.Name = "lblNamThanhLap";
            lblNamThanhLap.Size = new Size(116, 15);
            lblNamThanhLap.TabIndex = 9;
            lblNamThanhLap.Text = "Nhập năm thành lập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 9);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 10;
            label3.Text = "Nhập số giảng viên";
            // 
            // FormQuanLyKhoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 413);
            Controls.Add(label3);
            Controls.Add(lblNamThanhLap);
            Controls.Add(lblTenKhoa);
            Controls.Add(dgvKhoa);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTongSoGiangVien);
            Controls.Add(txtNamThanhLap);
            Controls.Add(txtTenKhoa);
            Name = "FormQuanLyKhoa";
            Text = "FormQuanLyKhoa";
            Load += FormQuanLyKhoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenKhoa;
        private TextBox txtNamThanhLap;
        private TextBox txtTongSoGiangVien;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvKhoa;
        private Label lblTenKhoa;
        private Label lblNamThanhLap;
        private Label label3;
    }
}