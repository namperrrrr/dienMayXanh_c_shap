using System;

namespace quanLyDienMayXanh.domain
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaDanhMuc { get; set; }
        public string ThuongHieu { get; set; }
        public string DonViTinh { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int TonKho { get; set; }
        public int ThoiGianBaoHanh { get; set; }
        public string TrangThaiHang { get; set; }      // MOI, CU, TRUNG_BAY
        public string TrangThaiKinhDoanh { get; set; } // DANG_BAN, NGUNG_KINH_DOANH
        public string MoTa { get; set; }
        public string HinhAnh { get; set; } // Link ảnh

        public SanPham() { }
    }
}