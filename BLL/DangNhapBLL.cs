using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;


namespace BLL
{
 
    public class DangNhapBLL
    {
        //Gọi các phương thức của lớp DataAccessLayer để kiểm tra thông tin đăng nhập và lấy quyền của người dùng.

        public DangNhapDAL dangnhap = new DangNhapDAL();
       
        public bool CheckLoginBLL(string madn, string matkhau)
        {
            return dangnhap.CheckLoginDAL(madn, matkhau);
        }
        public string LayQuyenBLL(string madn)
        {
            return dangnhap.LayQuyenDAL(madn);
        }
        public bool ThemDN(string madn, string tendn, string mk, string quyen)
        {
            if(dangnhap.CheckLDangNhapDAL(madn))
            {
                if(dangnhap.ThemDangNhapDAL(madn,tendn,mk,quyen))
                {
                    return true;


                }   
                else
                {
                    return false;
                }    
            }
            else
            {
                return false;

            }

        }
        public bool SuaDN(string madn, string tendn, string mk, string quyen)
        {
            return dangnhap.SuaDangNhapDAL(madn,tendn,mk,quyen);
        }
        public void XoaDN(string madn)
        {
            dangnhap.XoaDangNhapDAL(madn);
        }
        public DataTable GetDangNhapBLL(DangNhapDTO dn)
        {
            return dangnhap.GetDangNhap(dn);
        }
    }
}
