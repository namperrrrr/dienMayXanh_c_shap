using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyDienMayXanh.domain
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string MaCV { get; set; } // Khóa ngoại trỏ sang ChucVu

        // 1. Constructor rỗng
        public NhanVien()
        {
        }

        // 2. Constructor đầy đủ tham số
        public NhanVien(string maNV, string hoTen, string gioiTinh, string sdt, string email, string maCV)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.Sdt = sdt;
            this.Email = email;
            this.MaCV = maCV;
        }

        // 3. Override ToString (Giống @Override trong Java)
        public override string ToString()
        {
            return this.HoTen; // Hiển thị tên khi cần
        }
    }
}
