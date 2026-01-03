using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyDienMayXanh.domain
{
    public class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string MaNV { get; set; }    // Khóa ngoại trỏ sang NhanVien
        public int CapDoQuyen { get; set; } // 1: NV, 2: QL, 3: Admin
        public string TrangThai { get; set; } // "Hoạt động" hoặc "Đã khóa"
        public TaiKhoan()
        {
        }
        public TaiKhoan(string tenDangNhap, string matKhau, string maNV, int capDoQuyen, string trangThai)
        {
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.MaNV = maNV;
            this.CapDoQuyen = capDoQuyen;
            this.TrangThai = trangThai;
        }
    }
}
