
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLySinhVien.Models;

namespace QuanLySinhVien
{
    public partial class FormChinh : Form
    {
        private int? idDangSua = null;

        public FormChinh()
        {
            InitializeComponent();

            // Thiết lập giao diện bảng
            TaoCotDataGridView();

            // Gắn sự kiện
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnThemKhoa.Click += btnThemKhoa_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
        }

        private void TaoCotDataGridView()
        {
            dgvSinhVien.AutoGenerateColumns = false;
            dgvSinhVien.Columns.Clear();
            dgvSinhVien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.AllowUserToAddRows = false;

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "Id",
                Visible = false
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMaSV",
                HeaderText = "Mã SV",
                Width = 100
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colHoTen",
                HeaderText = "Họ tên",
                Width = 180
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNgaySinh",
                HeaderText = "Ngày sinh",
                Width = 110
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGioiTinh",
                HeaderText = "Giới tính",
                Width = 90
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colKhoa",
                HeaderText = "Khoa",
                Width = 150
            });

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDiemTB",
                HeaderText = "Điểm TB",
                Width = 90
            });
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            rdoNam.Checked = true;
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);

            LayDanhSachKhoa();
            LayDanhSachSinhVien();
        }

        private void LayDanhSachKhoa()
        {
            try
            {
                using var db = new QuanLySinhVienDbContext();

                var danhSach = db.Khoas
                    .OrderBy(k => k.TenKhoa)
                    .ToList();

                cboKhoa.DataSource = null;
                cboKhoa.DisplayMember = "TenKhoa";
                cboKhoa.ValueMember = "Id";
                cboKhoa.DataSource = danhSach;

                if (danhSach.Count > 0)
                    cboKhoa.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Không tải được danh sách khoa:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LayDanhSachSinhVien(string tuKhoa = "")
        {
            try
            {
                using var db = new QuanLySinhVienDbContext();

                // Include lấy thêm thông tin Khoa.
                // ToList thực thi truy vấn và lấy dữ liệu về bộ nhớ.
                var truyVan = db.SinhViens
                    .Include(sv => sv.Khoa)
                    .AsQueryable();

                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    tuKhoa = tuKhoa.Trim();

                    truyVan = truyVan.Where(sv =>
                        sv.MaSV.Contains(tuKhoa) ||
                        sv.HoTen.Contains(tuKhoa));
                }

                var danhSach = truyVan
                    .OrderBy(sv => sv.MaSV)
                    .ToList();

                dgvSinhVien.Rows.Clear();

                foreach (var sv in danhSach)
                {
                    dgvSinhVien.Rows.Add(
                        sv.Id,
                        sv.MaSV,
                        sv.HoTen,
                        sv.NgaySinh.ToString("dd/MM/yyyy"),
                        sv.GioiTinh,
                        sv.Khoa?.TenKhoa ?? "",
                        sv.DiemTB.HasValue
                            ? sv.DiemTB.Value.ToString("0.##")
                            : ""
                    );
                }

                lblTongSo.Text =
                    $"Tổng số sinh viên: {danhSach.Count}";

                lblTrangThai.Text = "Sẵn sàng";
            }
            catch (Exception ex)
            {
                lblTrangThai.Text = "Lỗi kết nối CSDL";

                MessageBox.Show(
                    "Không thể đọc dữ liệu sinh viên.\n" +
                    "Kiểm tra SQL Server và đã chạy Update-Database chưa.\n\n" +
                    ex.Message,
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool KiemTraDuLieu(out double? diemTB)
        {
            diemTB = null;

            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!");
                txtMaSV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return false;
            }

            if (cboKhoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng tạo và chọn khoa!");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                if (!double.TryParse(txtDiemTB.Text.Trim(), out double diem))
                {
                    MessageBox.Show("Điểm trung bình phải là số hợp lệ!");
                    txtDiemTB.Focus();
                    return false;
                }

                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm trung bình phải từ 0 đến 10!");
                    txtDiemTB.Focus();
                    return false;
                }

                diemTB = diem;
            }

            if (dtpNgaySinh.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không được ở tương lai!");
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu(out double? diemTB))
                return;

            try
            {
                using var db = new QuanLySinhVienDbContext();

                string maSV = txtMaSV.Text.Trim();

                bool biTrung = db.SinhViens
                    .Any(sv => sv.MaSV == maSV);

                if (biTrung)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return;
                }

                var sv = new SinhVien
                {
                    MaSV = maSV,
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value.Date,
                    GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
                    KhoaId = Convert.ToInt32(cboKhoa.SelectedValue),
                    DiemTB = diemTB
                };

                db.SinhViens.Add(sv);
                db.SaveChanges();

                MessageBox.Show("Thêm sinh viên thành công!");

                LamMoiForm();
                LayDanhSachSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thêm sinh viên thất bại:\n" + ex.Message);
            }
        }

        private void dgvSinhVien_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

            idDangSua = Convert.ToInt32(row.Cells["colId"].Value);

            txtMaSV.Text = row.Cells["colMaSV"].Value?.ToString() ?? "";
            txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString() ?? "";

            DateTime.TryParseExact(
                row.Cells["colNgaySinh"].Value?.ToString(),
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime ngaySinh);

            dtpNgaySinh.Value = ngaySinh == DateTime.MinValue
                ? DateTime.Today
                : ngaySinh;

            string gioiTinh =
                row.Cells["colGioiTinh"].Value?.ToString() ?? "Nam";

            rdoNam.Checked = gioiTinh == "Nam";
            rdoNu.Checked = gioiTinh == "Nữ";

            txtDiemTB.Text =
                row.Cells["colDiemTB"].Value?.ToString() ?? "";

            using var db = new QuanLySinhVienDbContext();

            var sv = db.SinhViens
                .FirstOrDefault(x => x.Id == idDangSua.Value);

            if (sv != null)
                cboKhoa.SelectedValue = sv.KhoaId;

            // Không cho đổi mã trong chế độ sửa
            txtMaSV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idDangSua == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            if (!KiemTraDuLieu(out double? diemTB))
                return;

            try
            {
                using var db = new QuanLySinhVienDbContext();

                var sv = db.SinhViens
                    .FirstOrDefault(x => x.Id == idDangSua.Value);

                if (sv == null)
                {
                    MessageBox.Show("Sinh viên không còn tồn tại!");
                    LayDanhSachSinhVien();
                    return;
                }

                sv.HoTen = txtHoTen.Text.Trim();
                sv.NgaySinh = dtpNgaySinh.Value.Date;
                sv.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                sv.KhoaId = Convert.ToInt32(cboKhoa.SelectedValue);
                sv.DiemTB = diemTB;

                db.SaveChanges();

                MessageBox.Show("Cập nhật sinh viên thành công!");

                LamMoiForm();
                LayDanhSachSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại:\n" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idDangSua == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            var xacNhan = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (xacNhan != DialogResult.Yes)
                return;

            try
            {
                using var db = new QuanLySinhVienDbContext();

                var sv = db.SinhViens
                    .FirstOrDefault(x => x.Id == idDangSua.Value);

                if (sv != null)
                {
                    db.SinhViens.Remove(sv);
                    db.SaveChanges();
                }

                MessageBox.Show("Xóa sinh viên thành công!");

                LamMoiForm();
                LayDanhSachSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại:\n" + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            LayDanhSachSinhVien();
        }

        private void LamMoiForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();

            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            rdoNam.Checked = true;

            if (cboKhoa.Items.Count > 0)
                cboKhoa.SelectedIndex = 0;

            txtMaSV.Enabled = true;
            idDangSua = null;

            dgvSinhVien.ClearSelection();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LayDanhSachSinhVien(txtTimKiem.Text);
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            using var form = new FormThemKhoa();

            if (form.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using var db = new QuanLySinhVienDbContext();

                string tenKhoa = form.TenKhoaMoi.Trim();

                bool biTrung = db.Khoas.Any(
                    k => k.TenKhoa == tenKhoa);

                if (biTrung)
                {
                    MessageBox.Show("Tên khoa đã tồn tại!");
                    return;
                }

                db.Khoas.Add(new Khoa
                {
                    TenKhoa = tenKhoa
                });

                db.SaveChanges();

                LayDanhSachKhoa();

                MessageBox.Show("Thêm khoa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu khoa thất bại:\n" + ex.Message);
            }
        }

        private void dữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
private void mnuKhoa_Click(object sender, EventArgs e)
        {
            using (FormQuanLyKhoa f = new FormQuanLyKhoa())
            {
                f.ShowDialog();
            }
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            using (FormChinh f = new FormChinh())
            {
                f.ShowDialog();
            }
        }
    }
}
