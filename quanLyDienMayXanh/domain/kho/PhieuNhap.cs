using System;

namespace quanLyDienMayXanh.domain.kho
{
    public class PhieuNhap
    {
        public int ID { get; set; }
        public string MaPhieu { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; } // Dùng để hiển thị lên bảng
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public DateTime NgayNhap { get; set; }
        public string GhiChu { get; set; }

        public PhieuNhap() { }
    }
}