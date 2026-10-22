namespace QuanLySinhVien
{
    partial class FormChinh
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
            lbtieude = new Label();
            lblMaSV = new Label();
            lblGioiTinh = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            lblKhoa = new Label();
            lblDiemTB = new Label();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            cboKhoa = new ComboBox();
            dgvSinhVien = new DataGridView();
            gbThongtin = new GroupBox();
            txtDiemTB = new TextBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnThemKhoa = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTongSo = new Label();
            lblTrangThai = new Label();
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuSinhVien = new ToolStripMenuItem();
            mnuKhoa = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            gbThongtin.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbtieude
            // 
            lbtieude.AutoSize = true;
            lbtieude.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtieude.Location = new Point(370, 24);
            lbtieude.Name = "lbtieude";
            lbtieude.Size = new Size(295, 40);
            lbtieude.TabIndex = 0;
            lbtieude.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(16, 19);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(74, 15);
            lblMaSV.TabIndex = 1;
            lblMaSV.Text = "Mã sinh viên";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(361, 71);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(52, 15);
            lblGioiTinh.TabIndex = 2;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(16, 52);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(43, 15);
            lblHoTen.TabIndex = 3;
            lblHoTen.Text = "Họ tên";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(16, 90);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(60, 15);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(349, 57);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(34, 15);
            lblKhoa.TabIndex = 5;
            lblKhoa.Text = "Khoa";
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.Location = new Point(349, 90);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(94, 15);
            lblDiemTB.TabIndex = 6;
            lblDiemTB.Text = "Điểm trung bình";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(99, 49);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(183, 23);
            txtHoTen.TabIndex = 7;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(99, 16);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(100, 23);
            txtMaSV.TabIndex = 8;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(423, 67);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(51, 19);
            rdoNam.TabIndex = 9;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(495, 67);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(41, 19);
            rdoNu.TabIndex = 10;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(99, 84);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(100, 23);
            dtpNgaySinh.TabIndex = 11;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(449, 54);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(121, 23);
            cboKhoa.TabIndex = 12;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(12, 240);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.Size = new Size(764, 166);
            dgvSinhVien.TabIndex = 13;
            // 
            // gbThongtin
            // 
            gbThongtin.Controls.Add(txtDiemTB);
            gbThongtin.Controls.Add(btnLamMoi);
            gbThongtin.Controls.Add(btnXoa);
            gbThongtin.Controls.Add(btnSua);
            gbThongtin.Controls.Add(btnThem);
            gbThongtin.Controls.Add(btnThemKhoa);
            gbThongtin.Controls.Add(lblMaSV);
            gbThongtin.Controls.Add(cboKhoa);
            gbThongtin.Controls.Add(lblHoTen);
            gbThongtin.Controls.Add(dtpNgaySinh);
            gbThongtin.Controls.Add(lblDiemTB);
            gbThongtin.Controls.Add(lblKhoa);
            gbThongtin.Controls.Add(txtMaSV);
            gbThongtin.Controls.Add(txtHoTen);
            gbThongtin.Controls.Add(lblNgaySinh);
            gbThongtin.Location = new Point(12, 52);
            gbThongtin.Name = "gbThongtin";
            gbThongtin.Size = new Size(764, 182);
            gbThongtin.TabIndex = 14;
            gbThongtin.TabStop = false;
            gbThongtin.Text = "Thông tin sinh viên";
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(449, 87);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(100, 23);
            txtDiemTB.TabIndex = 19;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(349, 127);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(74, 51);
            btnLamMoi.TabIndex = 18;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(242, 125);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 54);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(139, 125);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 52);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(39, 124);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 53);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnThemKhoa
            // 
            btnThemKhoa.Location = new Point(577, 54);
            btnThemKhoa.Name = "btnThemKhoa";
            btnThemKhoa.Size = new Size(24, 23);
            btnThemKhoa.TabIndex = 13;
            btnThemKhoa.Text = "+";
            btnThemKhoa.UseVisualStyleBackColor = true;
            btnThemKhoa.Click += btnThemKhoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(722, 423);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(66, 23);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(533, 423);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(183, 23);
            txtTimKiem.TabIndex = 18;
            txtTimKiem.Text = "Nhập từ khóa";
            // 
            // lblTongSo
            // 
            lblTongSo.AutoSize = true;
            lblTongSo.Location = new Point(12, 426);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(111, 15);
            lblTongSo.TabIndex = 19;
            lblTongSo.Text = "Tổng số sinh viên: 0";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(213, 426);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(54, 15);
            lblTrangThai.TabIndex = 20;
            lblTrangThai.Text = "Sẵn sàng";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, mnuQuanLy });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(38, 20);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuSinhVien, mnuKhoa });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(60, 20);
            mnuQuanLy.Text = "Quản lý";
            mnuQuanLy.Click += dữLiệuToolStripMenuItem_Click;
            // 
            // mnuSinhVien
            // 
            mnuSinhVien.Name = "mnuSinhVien";
            mnuSinhVien.Size = new Size(180, 22);
            mnuSinhVien.Text = "Quản lý sinh viên";
            mnuSinhVien.Click += mnuSinhVien_Click;
            // 
            // mnuKhoa
            // 
            mnuKhoa.Name = "mnuKhoa";
            mnuKhoa.Size = new Size(180, 22);
            mnuKhoa.Text = "Quản lý khoa";
            mnuKhoa.Click += mnuKhoa_Click;
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTrangThai);
            Controls.Add(lblTongSo);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvSinhVien);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(lblGioiTinh);
            Controls.Add(btnTimKiem);
            Controls.Add(lbtieude);
            Controls.Add(gbThongtin);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormChinh";
            Text = "Form1";
            Load += FormChinh_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            gbThongtin.ResumeLayout(false);
            gbThongtin.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtieude;
        private Label lblMaSV;
        private Label lblGioiTinh;
        private Label lblHoTen;
        private Label lblNgaySinh;
        private Label lblKhoa;
        private Label lblDiemTB;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private ComboBox cboKhoa;
        private DataGridView dgvSinhVien;
        private GroupBox gbThongtin;
        public DateTimePicker dtpNgaySinh;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnThemKhoa;
        private TextBox txtDiemTB;
        private TextBox txtTimKiem;
        private Label lblTongSo;
        private Label lblTrangThai;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuSinhVien;
        private ToolStripMenuItem mnuKhoa;
    }
}
