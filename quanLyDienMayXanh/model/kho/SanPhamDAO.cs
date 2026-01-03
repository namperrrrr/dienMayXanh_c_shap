using MySql.Data.MySqlClient;
using quanLyDienMayXanh.domain;
using System;
using System.Collections.Generic;

namespace quanLyDienMayXanh.model.kho
{
    public class SanPhamDAO
    {
        public List<SanPham> GetAll()
        {
            List<SanPham> list = new List<SanPham>();
            string sql = "SELECT * FROM SanPham";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return list;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    using (MySqlDataReader rs = cmd.ExecuteReader())
                    {
                        while (rs.Read())
                        {
                            SanPham sp = new SanPham();
                            sp.MaSP = rs["MaSP"].ToString();
                            sp.TenSP = rs["TenSP"].ToString();
                            sp.MaDanhMuc = rs["MaDanhMuc"].ToString();
                            sp.ThuongHieu = rs["ThuongHieu"].ToString();
                            sp.DonViTinh = rs["DonViTinh"].ToString();
                            sp.GiaNhap = Convert.ToDecimal(rs["GiaNhap"]);
                            sp.GiaBan = Convert.ToDecimal(rs["GiaBan"]);
                            sp.TonKho = Convert.ToInt32(rs["TonKho"]);
                            sp.ThoiGianBaoHanh = Convert.ToInt32(rs["ThoiGianBaoHanh"]);
                            sp.TrangThaiHang = rs["TrangThaiHang"].ToString();
                            sp.TrangThaiKinhDoanh = rs["TrangThaiKinhDoanh"].ToString();
                            sp.MoTa = rs["MoTa"].ToString();
                            sp.HinhAnh = rs["HinhAnh"].ToString();
                            list.Add(sp);
                        }
                    }
                }
                catch (Exception e) { Console.WriteLine("Lỗi GetAll SP: " + e.Message); }
            }
            return list;
        }

        public int Insert(SanPham sp)
        {
            string sql = "INSERT INTO SanPham (MaSP, TenSP, MaDanhMuc, ThuongHieu, DonViTinh, GiaNhap, GiaBan, TonKho, ThoiGianBaoHanh, TrangThaiHang, TrangThaiKinhDoanh, MoTa, HinhAnh) " +
                         "VALUES (@MaSP, @TenSP, @MaDanhMuc, @ThuongHieu, @DonViTinh, @GiaNhap, @GiaBan, 0, @ThoiGianBaoHanh, @TrangThaiHang, 'DANG_BAN', @MoTa, @HinhAnh)";
            // Lưu ý: TonKho mặc định là 0 khi tạo mới, nhập hàng mới tăng tồn kho (theo logic nghiệp vụ thông thường)

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                    cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                    cmd.Parameters.AddWithValue("@MaDanhMuc", sp.MaDanhMuc);
                    cmd.Parameters.AddWithValue("@ThuongHieu", sp.ThuongHieu);
                    cmd.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh);
                    cmd.Parameters.AddWithValue("@GiaNhap", sp.GiaNhap);
                    cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                    cmd.Parameters.AddWithValue("@ThoiGianBaoHanh", sp.ThoiGianBaoHanh);
                    cmd.Parameters.AddWithValue("@TrangThaiHang", sp.TrangThaiHang);
                    cmd.Parameters.AddWithValue("@MoTa", sp.MoTa);
                    cmd.Parameters.AddWithValue("@HinhAnh", sp.HinhAnh);
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e) { Console.WriteLine("Lỗi Insert SP: " + e.Message); return 0; }
            }
        }

        public int Update(SanPham sp)
        {
            string sql = "UPDATE SanPham SET TenSP=@TenSP, MaDanhMuc=@MaDanhMuc, ThuongHieu=@ThuongHieu, DonViTinh=@DonViTinh, " +
                         "GiaNhap=@GiaNhap, GiaBan=@GiaBan, ThoiGianBaoHanh=@ThoiGianBaoHanh, TrangThaiHang=@TrangThaiHang, " +
                         "MoTa=@MoTa, HinhAnh=@HinhAnh WHERE MaSP=@MaSP";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                    cmd.Parameters.AddWithValue("@MaDanhMuc", sp.MaDanhMuc);
                    cmd.Parameters.AddWithValue("@ThuongHieu", sp.ThuongHieu);
                    cmd.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh);
                    cmd.Parameters.AddWithValue("@GiaNhap", sp.GiaNhap);
                    cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                    cmd.Parameters.AddWithValue("@ThoiGianBaoHanh", sp.ThoiGianBaoHanh);
                    cmd.Parameters.AddWithValue("@TrangThaiHang", sp.TrangThaiHang);
                    cmd.Parameters.AddWithValue("@MoTa", sp.MoTa);
                    cmd.Parameters.AddWithValue("@HinhAnh", sp.HinhAnh);
                    cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e) { Console.WriteLine("Lỗi Update SP: " + e.Message); return 0; }
            }
        }

        public int Delete(string maSP)
        {
            // Thay vì xóa vĩnh viễn, ta chuyển trạng thái sang NGUNG_KINH_DOANH để giữ lịch sử đơn hàng
            string sql = "UPDATE SanPham SET TrangThaiKinhDoanh='NGUNG_KINH_DOANH' WHERE MaSP=@MaSP";
            // Nếu muốn xóa hẳn: string sql = "DELETE FROM SanPham WHERE MaSP=@MaSP";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e) { Console.WriteLine("Lỗi Delete SP: " + e.Message); return 0; }
            }
        }

        public List<SanPham> Search(string keyword, string maDanhMuc)
        {
            List<SanPham> list = new List<SanPham>();
            string sql = "SELECT * FROM SanPham WHERE (TenSP LIKE @Keyword OR MaSP LIKE @Keyword)";
            if (!string.IsNullOrEmpty(maDanhMuc))
            {
                sql += " AND MaDanhMuc = @MaDanhMuc";
            }

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return list;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    if (!string.IsNullOrEmpty(maDanhMuc))
                    {
                        cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                    }

                    using (MySqlDataReader rs = cmd.ExecuteReader())
                    {
                        while (rs.Read())
                        {
                            // Copy logic map dữ liệu từ GetAll xuống đây hoặc tách hàm riêng
                            SanPham sp = new SanPham();
                            sp.MaSP = rs["MaSP"].ToString();
                            sp.TenSP = rs["TenSP"].ToString();
                            sp.MaDanhMuc = rs["MaDanhMuc"].ToString();
                            sp.ThuongHieu = rs["ThuongHieu"].ToString();
                            sp.DonViTinh = rs["DonViTinh"].ToString();
                            sp.GiaNhap = Convert.ToDecimal(rs["GiaNhap"]);
                            sp.GiaBan = Convert.ToDecimal(rs["GiaBan"]);
                            sp.TonKho = Convert.ToInt32(rs["TonKho"]);
                            sp.ThoiGianBaoHanh = Convert.ToInt32(rs["ThoiGianBaoHanh"]);
                            sp.TrangThaiHang = rs["TrangThaiHang"].ToString();
                            sp.TrangThaiKinhDoanh = rs["TrangThaiKinhDoanh"].ToString();
                            sp.MoTa = rs["MoTa"].ToString();
                            sp.HinhAnh = rs["HinhAnh"].ToString();
                            list.Add(sp);
                        }
                    }
                }
                catch (Exception e) { Console.WriteLine("Lỗi Search SP: " + e.Message); }
            }
            return list;
        }

        public bool CheckTrungMa(string maSP)
        {
            string sql = "SELECT COUNT(*) FROM SanPham WHERE MaSP=@MaSP";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return false;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception) { return false; }
            }
        }
    }
}