using MySql.Data.MySqlClient;
using quanLyDienMayXanh.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyDienMayXanh.model.nhansu
{
    internal class TaiKhoanDAO
    {
        public List<TaiKhoan> GetAll()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            string sql = "SELECT * FROM TaiKhoan";

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
                            TaiKhoan tk = new TaiKhoan();
                            tk.TenDangNhap = rs["TenDangNhap"].ToString();
                            tk.MatKhau = rs["MatKhau"].ToString();
                            tk.MaNV = rs["MaNV"].ToString();
                            // Ép kiểu an toàn cho số nguyên
                            tk.CapDoQuyen = Convert.ToInt32(rs["CapDoQuyen"]);
                            tk.TrangThai = rs["TrangThai"].ToString();

                            list.Add(tk);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi GetAll TaiKhoan: " + e.Message);
                }
            }
            return list;
        }
        public int Insert(TaiKhoan tk)
        {
            string sql = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, MaNV, CapDoQuyen, TrangThai) VALUES (@User, @Pass, @MaNV, @Quyen, @TrangThai)";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@User", tk.TenDangNhap);
                    cmd.Parameters.AddWithValue("@Pass", tk.MatKhau);
                    cmd.Parameters.AddWithValue("@MaNV", tk.MaNV);
                    cmd.Parameters.AddWithValue("@Quyen", tk.CapDoQuyen);
                    cmd.Parameters.AddWithValue("@TrangThai", tk.TrangThai);

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi Insert TaiKhoan: " + e.Message);
                    return 0;
                }
            }
        }
        public int Update(TaiKhoan tk, string oldUsername)
        {
            string sql = "UPDATE TaiKhoan SET TenDangNhap=@NewUser, MaNV=@MaNV, CapDoQuyen=@Quyen, TrangThai=@TrangThai WHERE TenDangNhap=@OldUser";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@NewUser", tk.TenDangNhap);
                    cmd.Parameters.AddWithValue("@MaNV", tk.MaNV);
                    cmd.Parameters.AddWithValue("@Quyen", tk.CapDoQuyen);
                    cmd.Parameters.AddWithValue("@TrangThai", tk.TrangThai);

                    cmd.Parameters.AddWithValue("@OldUser", oldUsername); // Điều kiện WHERE

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi Update TaiKhoan: " + e.Message);
                    return 0;
                }
            }
        }
        public int ResetPassword(string username, string newPass)
        {
            string sql = "UPDATE TaiKhoan SET MatKhau=@Pass WHERE TenDangNhap=@User";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Pass", newPass);
                    cmd.Parameters.AddWithValue("@User", username);

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi ResetPassword: " + e.Message);
                    return 0;
                }
            }
        }
        public int Delete(string username)
        {
            string sql = "DELETE FROM TaiKhoan WHERE TenDangNhap=@User";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@User", username);

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi Delete TaiKhoan: " + e.Message);
                    return 0;
                }
            }
        }
        public TaiKhoan CheckLogin(string user, string pass)
        {
            TaiKhoan tk = null;
            string sql = "SELECT * FROM TaiKhoan WHERE TenDangNhap=@User AND MatKhau=@Pass AND TrangThai='Hoạt động'";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return null;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@User", user);
                    cmd.Parameters.AddWithValue("@Pass", pass);

                    using (MySqlDataReader rs = cmd.ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            tk = new TaiKhoan();
                            tk.TenDangNhap = rs["TenDangNhap"].ToString();
                            tk.MatKhau = rs["MatKhau"].ToString();
                            tk.MaNV = rs["MaNV"].ToString();
                            tk.CapDoQuyen = Convert.ToInt32(rs["CapDoQuyen"]);
                            tk.TrangThai = rs["TrangThai"].ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi CheckLogin: " + e.Message);
                }
            }
            return tk;
        }
        public bool CheckTrungUsername(string user)
        {
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@User";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return false;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@User", user);

                    // ExecuteScalar dùng để lấy giá trị đơn (số lượng dòng)
                    long count = Convert.ToInt64(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi CheckTrungUsername: " + e.Message);
                    return false;
                }
            }
        }
        public int GetSoLuongAdmin()
        {
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE CapDoQuyen = 3 AND TrangThai = 'Hoạt động'";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi GetSoLuongAdmin: " + e.Message);
                    return 0;
                }
            }
        }
    }
}
