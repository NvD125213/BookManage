using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class DangNhapDAL : DatabaseDAL
    {

        public string LayQuyenDAL(string madn)
        {

            OpenConnection();
            string query = "SELECT Quyen FROM DangNhap WHERE MaDN = @madn";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@madn", madn);

            string quyen = (string)command.ExecuteScalar();
            return quyen;

        }
        public bool CheckLoginDAL(string madn, string matkhau)
        {

            OpenConnection();
            string query = "SELECT COUNT(*) FROM DangNhap WHERE MaDN = @madn AND MatKhau = @matkhau ";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@madn", madn);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);

            //cmd.Parameters.AddWithValue("@quyen", quyen);
            cmd.Connection = conn;
            int count = (int)cmd.ExecuteScalar();
            return count > 0;


        }
        public bool CheckLDangNhapDAL(string madn)
        {

            OpenConnection();
            string query = "SELECT COUNT(*) FROM DangNhap WHERE MaDN = @madn";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@madn", madn);
            cmd.Connection = conn;
            int count = (int)cmd.ExecuteScalar();
            return count <= 0;


        }
        public DataTable GetDangNhap(DangNhapDTO dn)
        {
            OpenConnection();
            string sql = "Select * from DangNhap";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;

        }
        public bool ThemDangNhapDAL(string madn, string tendn, string mk,string quyen)
        {
            OpenConnection();
            bool isSuccess = false;
            SqlCommand cmd = new SqlCommand("Insert into DangNhap(MaDN,TenDN,MatKhau,Quyen) values (@madn,@tendn,@matkhau,@quyen)", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@madn", madn);
            cmd.Parameters.AddWithValue("@tendn", tendn);
            cmd.Parameters.AddWithValue("@matkhau", quyen);
            cmd.Parameters.AddWithValue("@quyen", quyen);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isSuccess = true;
                }
            }
            catch
            {
                return false;
            }

            return isSuccess;

        }
        public bool SuaDangNhapDAL(string madn, string tendn, string matkhau, string quyen)
        {
            OpenConnection();
            bool isSuccess = false;
            SqlCommand cmd = new SqlCommand("Update DangNhap set TenDN=@tendn,MatKhau=@mk,Quyen=@quyen where MaDN = @madn", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@madn", madn);
            cmd.Parameters.AddWithValue("@tendn", tendn);
            cmd.Parameters.AddWithValue("@mk", matkhau);
            cmd.Parameters.AddWithValue("@quyen", quyen);


            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                isSuccess = true;
            }


            return isSuccess;

        }
        public void XoaDangNhapDAL(string madn)
        {
            OpenConnection();
            string sql = "Delete DangNhap where MaDN=@madn";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@madn", madn);
            cmd.ExecuteNonQuery();
        }

    }

}

