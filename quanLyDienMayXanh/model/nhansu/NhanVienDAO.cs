using MySql.Data.MySqlClient;
using quanLyDienMayXanh.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyDienMayXanh.model.nhansu
{
    public class NhanVienDAO
    {
        public List<NhanVien> GetAll()
        {
            List<NhanVien> list = new List<NhanVien>();
            string sql = "SELECT * FROM NhanVien";
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
                            NhanVien nv = new NhanVien();
                            nv.MaNV = rs["MaNV"].ToString();
                            nv.HoTen = rs["HoTen"].ToString();
                            nv.GioiTinh = rs["GioiTinh"].ToString();
                            nv.Sdt = rs["SDT"].ToString();
                            nv.Email = rs["Email"].ToString();
                            nv.MaCV = rs["MaCV"].ToString();

                            list.Add(nv);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi GetAll: " + e.Message);
                }
            }
            return list;
        }
        public int Insert(NhanVien nv)
        {
            string sql = "INSERT INTO NhanVien (MaNV, HoTen, GioiTinh, SDT, Email, MaCV) VALUES (@MaNV, @HoTen, @GioiTinh, @SDT, @Email, @MaCV)";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                    cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                    cmd.Parameters.AddWithValue("@SDT", nv.Sdt);
                    cmd.Parameters.AddWithValue("@Email", nv.Email);
                    cmd.Parameters.AddWithValue("@MaCV", nv.MaCV);

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi Insert: " + e.Message);
                    return 0;
                }
            }
        }
        public int Update(NhanVien nv)
        {
            string sql = "UPDATE NhanVien SET HoTen=@HoTen, GioiTinh=@GioiTinh, SDT=@SDT, Email=@Email, MaCV=@MaCV WHERE MaNV=@MaNV";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);

                    cmd.Parameters.AddWithValue("@HoTen", nv.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                    cmd.Parameters.AddWithValue("@SDT", nv.Sdt);
                    cmd.Parameters.AddWithValue("@Email", nv.Email);
                    cmd.Parameters.AddWithValue("@MaCV", nv.MaCV);
                    cmd.Parameters.AddWithValue("@MaNV", nv.MaNV); // Điều kiện WHERE

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi Update: " + e.Message);
                    return 0;
                }
            }
        }
        public int Delete(string maNV)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNV=@MaNV";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi Delete: " + e.Message);
                    return 0;
                }
            }
        }
        public bool CheckTrungMa(string maNV)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV=@MaNV";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return false;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi CheckTrungMa: " + e.Message);
                    return false;
                }
            }
        }
    }
}
