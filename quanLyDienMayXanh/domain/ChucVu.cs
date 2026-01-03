using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyDienMayXanh.domain
{
    public class ChucVu
    {
        // Sử dụng Auto-implemented Properties của C# (Gọn hơn Java Getter/Setter)
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public double LuongCoBan { get; set; } // C# dùng double giống Java
        public string MoTa { get; set; }

        // 1. Constructor rỗng
        public ChucVu()
        {
        }

        // 2. Constructor đầy đủ tham số
        public ChucVu(string maCV, string tenCV, double luongCoBan, string moTa)
        {
            this.MaCV = maCV;
            this.TenCV = tenCV;
            this.LuongCoBan = luongCoBan;
            this.MoTa = moTa;
        }

        // Override ToString để hiển thị tên đẹp trong ComboBox
        public override string ToString()
        {
            return this.TenCV;
        }

        // Override Equals để so sánh 2 đối tượng ChucVu (dùng khi set SelectedItem cho ComboBox)
        public override bool Equals(object obj)
        {
            if (obj is ChucVu other)
            {
                // So sánh chuỗi trong C# có thể dùng dấu == 
                return this.MaCV == other.MaCV;
            }
            return false;
        }

        // Khi override Equals nên override cả GetHashCode để tránh cảnh báo
        public override int GetHashCode()
        {
            return MaCV != null ? MaCV.GetHashCode() : 0;
        }
    }
}
