using System.Collections.Generic;

namespace QuanLySinhVien.Models
{
    public class Khoa
    {
        public int Id { get; set; }
        public string TenKhoa { get; set; } = "";
        public int? NamThanhLap { get; set; }
        public int? TongSoGiangVien { get; set; }

        public List<SinhVien> SinhViens { get; set; }
            = new List<SinhVien>();
    }
}