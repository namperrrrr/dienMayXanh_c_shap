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
                // Join bảng sanpham để lấy TenSP hiển thị
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
                    pn.MaNCC = reader.GetString("MaNCC");
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

        // 2. Thêm phiếu nhập (Kèm Transaction để update Tồn kho)
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

                // A. Insert vào bảng phieu_nhap
                cmd.CommandText = @"INSERT INTO phieu_nhap (MaPhieu, MaNV, MaNCC, MaSP, SoLuong, DonGia, ThanhTien, GhiChu, NgayNhap) 
                                    VALUES (@maPhieu, @maNV, @maNCC, @maSP, @soLuong, @donGia, @thanhTien, @ghiChu, NOW())";
                cmd.Parameters.AddWithValue("@maPhieu", pn.MaPhieu);
                cmd.Parameters.AddWithValue("@maNV", pn.MaNV);
                cmd.Parameters.AddWithValue("@maNCC", pn.MaNCC);
                cmd.Parameters.AddWithValue("@maSP", pn.MaSP);
                cmd.Parameters.AddWithValue("@soLuong", pn.SoLuong);
                cmd.Parameters.AddWithValue("@donGia", pn.DonGia);
                cmd.Parameters.AddWithValue("@thanhTien", pn.ThanhTien);
                cmd.Parameters.AddWithValue("@ghiChu", pn.GhiChu);
                cmd.ExecuteNonQuery();

                // B. Update cộng tồn kho bảng sanpham
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

                // BƯỚC 1: Lấy số lượng cũ từ Database để tính lệch
                cmd.CommandText = "SELECT SoLuong FROM phieu_nhap WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", pn.ID);
                object result = cmd.ExecuteScalar();

                if (result == null) throw new Exception("Không tìm thấy phiếu nhập cần sửa!");
                int slCu = Convert.ToInt32(result);

                // BƯỚC 2: Cập nhật thông tin phiếu nhập
                cmd.CommandText = @"UPDATE phieu_nhap 
                            SET SoLuong = @sl, DonGia = @dg, ThanhTien = @tt, GhiChu = @gc 
                            WHERE ID = @id";
                // Reset parameters để add lại từ đầu cho câu lệnh Update
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", pn.ID);
                cmd.Parameters.AddWithValue("@sl", pn.SoLuong);
                cmd.Parameters.AddWithValue("@dg", pn.DonGia);
                cmd.Parameters.AddWithValue("@tt", pn.ThanhTien);
                cmd.Parameters.AddWithValue("@gc", pn.GhiChu);
                cmd.ExecuteNonQuery();

                // BƯỚC 3: Cập nhật kho (Cộng thêm phần chênh lệch)
                // Nếu nhập thêm (Mới > Cũ) -> Tồn kho tăng
                // Nếu giảm bớt (Mới < Cũ) -> Tồn kho giảm
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
        // 3. Xóa phiếu nhập (Trừ lại tồn kho)
        public bool Delete(int id, string maSP, int soLuongDaNhap)
        {
            MySqlConnection conn = ConnectDB.GetConnection();
            MySqlTransaction trans = null;
            try
            {
                trans = conn.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = trans;

                // A. Xóa phiếu
                cmd.CommandText = "DELETE FROM phieu_nhap WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                // B. Trừ tồn kho (trả lại trạng thái cũ)
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

        // 4. Helper: Lấy danh sách Nhà cung cấp
        public List<NhaCungCap> GetDSNhaCungCap()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            MySqlConnection conn = ConnectDB.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT MaNCC, TenNCC FROM nhacungcap", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new NhaCungCap
                    {
                        MaNCC = reader.GetString("MaNCC"),
                        TenNCC = reader.GetString("TenNCC")
                    });
                }
            }
            catch { }
            finally { ConnectDB.CloseConnection(conn); }
            return list;
        }
    }
}