
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLySinhVien.Models;

namespace QuanLySinhVien
{
    public partial class FormQuanLyKhoa : Form
    {
        private int? idDangChon = null;

        public FormQuanLyKhoa()
        {
            InitializeComponent();

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            dgvKhoa.CellClick += dgvKhoa_CellClick;
            Load += FormQuanLyKhoa_Load;
        }

        private void FormQuanLyKhoa_Load(object? sender, EventArgs e)
        {
            dgvKhoa.AutoGenerateColumns = true;
            dgvKhoa.ReadOnly = true;
            dgvKhoa.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvKhoa.MultiSelect = false;
            dgvKhoa.AllowUserToAddRows = false;

            TaiDanhSach();
        }

        private void TaiDanhSach()
        {
            using var db = new QuanLySinhVienDbContext();

            dgvKhoa.DataSource = db.Khoas
                .AsNoTracking()
                .OrderBy(k => k.Id)
                .ToList();

            if (dgvKhoa.Columns["SinhViens"] != null)
                dgvKhoa.Columns["SinhViens"].Visible = false;
        }

        private bool LayDuLieu(
            out string ten,
            out int? nam,
            out int? giangVien)
        {
            ten = txtTenKhoa.Text.Trim();
            nam = null;
            giangVien = null;

            if (ten == "")
            {
                MessageBox.Show("Vui lòng nhập tên khoa.");
                txtTenKhoa.Focus();
                return false;
            }

            if (txtNamThanhLap.Text.Trim() != "")
            {
                if (!int.TryParse(txtNamThanhLap.Text, out int n)
                    || n < 1900 || n > DateTime.Now.Year)
                {
                    MessageBox.Show("Năm thành lập không hợp lệ.");
                    return false;
                }

                nam = n;
            }

            if (txtTongSoGiangVien.Text.Trim() != "")
            {
                if (!int.TryParse(
                    txtTongSoGiangVien.Text, out int gv) || gv < 0)
                {
                    MessageBox.Show("Số giảng viên phải là số nguyên không âm.");
                    return false;
                }

                giangVien = gv;
            }

            return true;
        }

        private void btnThem_Click(object? sender, EventArgs e)
        {
            if (!LayDuLieu(out string ten, out int? nam,
                out int? gv)) return;

            try
            {
                using var db = new QuanLySinhVienDbContext();

                if (db.Khoas.Any(k => k.TenKhoa.ToLower() == ten.ToLower()))
                {
                    MessageBox.Show("Tên khoa đã tồn tại.");
                    return;
                }

                db.Khoas.Add(new Khoa
                {
                    TenKhoa = ten,
                    NamThanhLap = nam,
                    TongSoGiangVien = gv
                });

                db.SaveChanges();
                TaiDanhSach();
                LamMoi();
                MessageBox.Show("Thêm khoa thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dgvKhoa_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvKhoa.Rows[e.RowIndex];

            idDangChon = Convert.ToInt32(row.Cells["Id"].Value);
            txtTenKhoa.Text = row.Cells["TenKhoa"].Value?.ToString() ?? "";
            txtNamThanhLap.Text =
                row.Cells["NamThanhLap"].Value?.ToString() ?? "";
            txtTongSoGiangVien.Text =
                row.Cells["TongSoGiangVien"].Value?.ToString() ?? "";
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (!idDangChon.HasValue)
            {
                MessageBox.Show("Hãy chọn khoa cần sửa.");
                return;
            }

            if (!LayDuLieu(out string ten, out int? nam,
                out int? gv)) return;

            try
            {
                using var db = new QuanLySinhVienDbContext();
                int id = idDangChon.Value;

                if (db.Khoas.Any(k =>
                    k.TenKhoa.ToLower() == ten.ToLower() && k.Id != id))
                {
                    MessageBox.Show("Tên khoa đã tồn tại.");
                    return;
                }

                var khoa = db.Khoas.Find(id);

                if (khoa == null)
                {
                    MessageBox.Show("Không tìm thấy khoa.");
                    TaiDanhSach();
                    LamMoi();
                    return;
                }

                khoa.TenKhoa = ten;
                khoa.NamThanhLap = nam;
                khoa.TongSoGiangVien = gv;

                db.SaveChanges();
                TaiDanhSach();
                LamMoi();
                MessageBox.Show("Sửa khoa thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (!idDangChon.HasValue)
            {
                MessageBox.Show("Hãy chọn khoa cần xóa.");
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa khoa?",
                "Xác nhận", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using var db = new QuanLySinhVienDbContext();
                int id = idDangChon.Value;

                if (db.SinhViens.Any(sv => sv.KhoaId == id))
                {
                    MessageBox.Show(
                        "Không thể xóa vì khoa vẫn còn sinh viên.");
                    return;
                }

                var khoa = db.Khoas.Find(id);

                if (khoa == null)
                {
                    MessageBox.Show("Không tìm thấy khoa.");
                    TaiDanhSach();
                    LamMoi();
                    return;
                }

                db.Khoas.Remove(khoa);
                db.SaveChanges();

                TaiDanhSach();
                LamMoi();
                MessageBox.Show("Xóa khoa thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            idDangChon = null;
            txtTenKhoa.Clear();
            txtNamThanhLap.Clear();
            txtTongSoGiangVien.Clear();
            dgvKhoa.ClearSelection();
            txtTenKhoa.Focus();
        }
    }
}
