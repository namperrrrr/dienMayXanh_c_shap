using MySql.Data.MySqlClient;
using quanLyDienMayXanh.domain.kho;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace quanLyDienMayXanh.model.kho
{
    class PhieuNhapDAO
    {
        // 1. Lấy danh sách phiếu nhập
        public List<PhieuNhap> GetAll()
        {
            List<PhieuNhap> list = new List<PhieuNhap>();
            MySqlConnection conn = ConnectDB.GetConnection();
            if (conn == null) return list;

            try
            {
                // Sửa SQL: Lấy TenNCC thay vì MaNCC
                string sql = @"SELECT pn.*, sp.TenSP 
                               FROM phieu_nhap pn 
                               LEFT JOIN sanpham sp ON pn.MaSP = sp.MaSP 
                               ORDER BY pn.NgayNhap DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PhieuNhap pn = new PhieuNhap();
                    pn.ID = reader.GetInt32("ID");
                    pn.MaPhieu = reader.GetString("MaPhieu");
                    pn.MaNV = reader.GetString("MaNV");

                    // Đọc TenNCC
                    pn.TenNCC = reader.IsDBNull(reader.GetOrdinal("TenNCC")) ? "" : reader.GetString("TenNCC");

                    pn.MaSP = reader.GetString("MaSP");
                    pn.TenSP = reader.IsDBNull(reader.GetOrdinal("TenSP")) ? "" : reader.GetString("TenSP");
                    pn.SoLuong = reader.GetInt32("SoLuong");
                    pn.DonGia = reader.GetDecimal("DonGia");
                    pn.ThanhTien = reader.GetDecimal("ThanhTien");
                    pn.NgayNhap = reader.GetDateTime("NgayNhap");
                    pn.GhiChu = reader.IsDBNull(reader.GetOrdinal("GhiChu")) ? "" : reader.GetString("GhiChu");

                    list.Add(pn);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load phiếu nhập: " + ex.Message); }
            finally { ConnectDB.CloseConnection(conn); }
            return list;
        }

        // 2. Thêm phiếu nhập
        public bool Add(PhieuNhap pn)
        {
            MySqlConnection conn = ConnectDB.GetConnection();
            if (conn == null) return false;
            MySqlTransaction trans = null;

            try
            {
                trans = conn.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = trans;

                // Sửa câu lệnh INSERT: Thay MaNCC bằng TenNCC
                cmd.CommandText = @"INSERT INTO phieu_nhap (MaPhieu, MaNV, TenNCC, MaSP, SoLuong, DonGia, ThanhTien, GhiChu, NgayNhap) 
                                    VALUES (@maPhieu, @maNV, @tenNCC, @maSP, @soLuong, @donGia, @thanhTien, @ghiChu, NOW())";

                cmd.Parameters.AddWithValue("@maPhieu", pn.MaPhieu);
                cmd.Parameters.AddWithValue("@maNV", pn.MaNV);

                // Truyền tham số TenNCC
                cmd.Parameters.AddWithValue("@tenNCC", pn.TenNCC);

                cmd.Parameters.AddWithValue("@maSP", pn.MaSP);
                cmd.Parameters.AddWithValue("@soLuong", pn.SoLuong);
                cmd.Parameters.AddWithValue("@donGia", pn.DonGia);
                cmd.Parameters.AddWithValue("@thanhTien", pn.ThanhTien);
                cmd.Parameters.AddWithValue("@ghiChu", pn.GhiChu);
                cmd.ExecuteNonQuery();

                // Update cộng tồn kho (Giữ nguyên)
                cmd.CommandText = "UPDATE sanpham SET TonKho = TonKho + @slNhap WHERE MaSP = @maSPKho";
                cmd.Parameters.AddWithValue("@slNhap", pn.SoLuong);
                cmd.Parameters.AddWithValue("@maSPKho", pn.MaSP);
                cmd.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans?.Rollback();
                MessageBox.Show("Lỗi thêm phiếu: " + ex.Message);
                return false;
            }
            finally { ConnectDB.CloseConnection(conn); }
        }

        public bool Update(PhieuNhap pn)
        {
            MySqlConnection conn = ConnectDB.GetConnection();
            if (conn == null) return false;
            MySqlTransaction trans = null;

            try
            {
                trans = conn.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = trans;

                // 1. Lấy số lượng cũ
                cmd.CommandText = "SELECT SoLuong FROM phieu_nhap WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", pn.ID);
                object result = cmd.ExecuteScalar();
                if (result == null) throw new Exception("Không tìm thấy phiếu!");
                int slCu = Convert.ToInt32(result);

                // 2. Update phiếu nhập (Thêm update TenNCC)
                cmd.CommandText = @"UPDATE phieu_nhap 
                            SET SoLuong = @sl, DonGia = @dg, ThanhTien = @tt, GhiChu = @gc, TenNCC = @tenNCC 
                            WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", pn.ID);
                cmd.Parameters.AddWithValue("@sl", pn.SoLuong);
                cmd.Parameters.AddWithValue("@dg", pn.DonGia);
                cmd.Parameters.AddWithValue("@tt", pn.ThanhTien);
                cmd.Parameters.AddWithValue("@gc", pn.GhiChu);
                cmd.Parameters.AddWithValue("@tenNCC", pn.TenNCC); // Cập nhật tên NCC mới
                cmd.ExecuteNonQuery();

                // 3. Cập nhật kho (Giữ nguyên logic)
                int chenhLech = pn.SoLuong - slCu;
                if (chenhLech != 0)
                {
                    cmd.CommandText = "UPDATE sanpham SET TonKho = TonKho + @chenhLech WHERE MaSP = @maSP";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@chenhLech", chenhLech);
                    cmd.Parameters.AddWithValue("@maSP", pn.MaSP);
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans?.Rollback();
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
                return false;
            }
            finally { ConnectDB.CloseConnection(conn); }
        }

        public bool Delete(int id, string maSP, int soLuongDaNhap)
        {
            // Logic xóa giữ nguyên
            MySqlConnection conn = ConnectDB.GetConnection();
            MySqlTransaction trans = null;
            try
            {
                trans = conn.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = trans;

                cmd.CommandText = "DELETE FROM phieu_nhap WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE sanpham SET TonKho = TonKho - @slCu WHERE MaSP = @maSP";
                cmd.Parameters.AddWithValue("@slCu", soLuongDaNhap);
                cmd.Parameters.AddWithValue("@maSP", maSP);
                cmd.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans?.Rollback();
                MessageBox.Show("Lỗi xóa: " + ex.Message);
                return false;
            }
            finally { ConnectDB.CloseConnection(conn); }
        }

        public bool CheckMaPhieu(string maPhieu)
        {
            MySqlConnection conn = ConnectDB.GetConnection();
            if (conn == null) return false;
            try
            {
                string sql = "SELECT COUNT(*) FROM phieu_nhap WHERE MaPhieu = @maPhieu";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maPhieu", maPhieu);

                // ExecuteScalar trả về object, cần ép kiểu về long hoặc int
                long count = Convert.ToInt64(cmd.ExecuteScalar());
                return count > 0; // Trả về true nếu đã tồn tại
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra trùng mã: " + ex.Message);
                return false;
            }
            finally { ConnectDB.CloseConnection(conn); }
        }
    }
}