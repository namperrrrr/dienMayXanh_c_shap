using MySql.Data.MySqlClient;
using quanLyDienMayXanh.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyDienMayXanh.model.nhansu
{
    public class ChucVuDAO
    {
        // 1. Lấy danh sách chức vụ
        public List<ChucVu> GetAll()
        {
            List<ChucVu> list = new List<ChucVu>();
            string sql = "SELECT * FROM ChucVu";

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
                            ChucVu cv = new ChucVu();
                            cv.MaCV = rs["MaCV"].ToString();
                            cv.TenCV = rs["TenCV"].ToString();

                            // Chuyển đổi an toàn sang double
                            cv.LuongCoBan = Convert.ToDouble(rs["LuongCoBan"]);

                            cv.MoTa = rs["MoTa"].ToString();
                            list.Add(cv);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi GetAll ChucVu: " + e.Message);
                }
            }
            return list;
        }

        // 2. Thêm mới chức vụ
        public int Insert(ChucVu cv)
        {
            string sql = "INSERT INTO ChucVu(MaCV, TenCV, LuongCoBan, MoTa) VALUES (@MaCV, @TenCV, @Luong, @MoTa)";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@MaCV", cv.MaCV);
                    cmd.Parameters.AddWithValue("@TenCV", cv.TenCV);
                    cmd.Parameters.AddWithValue("@Luong", cv.LuongCoBan);
                    cmd.Parameters.AddWithValue("@MoTa", cv.MoTa);

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi Insert ChucVu: " + e.Message);
                    return 0;
                }
            }
        }

        // 3. Sửa chức vụ
        public int Update(ChucVu cv)
        {
            string sql = "UPDATE ChucVu SET TenCV=@TenCV, LuongCoBan=@Luong, MoTa=@MoTa WHERE MaCV=@MaCV";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@TenCV", cv.TenCV);
                    cmd.Parameters.AddWithValue("@Luong", cv.LuongCoBan);
                    cmd.Parameters.AddWithValue("@MoTa", cv.MoTa);

                    cmd.Parameters.AddWithValue("@MaCV", cv.MaCV); // Điều kiện WHERE

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi Update ChucVu: " + e.Message);
                    return 0;
                }
            }
        }

        // 4. Xóa chức vụ
        public int Delete(string maCV)
        {
            string sql = "DELETE FROM ChucVu WHERE MaCV=@MaCV";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return 0;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@MaCV", maCV);

                    return cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi Delete ChucVu: " + e.Message);
                    return 0;
                }
            }
        }

        // 5. Check trùng mã
        public bool CheckTrungMa(string maCV)
        {
            string sql = "SELECT COUNT(*) FROM ChucVu WHERE MaCV=@MaCV";

            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return false;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@MaCV", maCV);

                    // ExecuteScalar hiệu quả hơn việc lấy ResultSet về rồi next()
                    long count = Convert.ToInt64(cmd.ExecuteScalar());
                    return count > 0;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi CheckTrungMa ChucVu: " + e.Message);
                    return false;
                }
            }
        }
    }
}
