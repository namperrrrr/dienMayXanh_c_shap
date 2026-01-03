namespace quanLyDienMayXanh.domain
{
    public class DanhMuc
    {
        public string MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }

        public override string ToString()
        {
            return TenDanhMuc; // Hiển thị tên trong ComboBox
        }
    }
}