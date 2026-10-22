
using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormThemKhoa : Form
    {
        public string TenKhoaMoi { get; private set; } = "";

        public FormThemKhoa()
        {
            InitializeComponent();

            btnLuu.Click += btnLuu_Click;
            btnHuy.Click += btnHuy_Click;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenKhoa = txtTenKhoa.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenKhoa))
            {
                MessageBox.Show("Vui lòng nhập tên khoa!");
                txtTenKhoa.Focus();
                return;
            }

            TenKhoaMoi = tenKhoa;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

