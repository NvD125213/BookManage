using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace BookStoreManagement
{
    public partial class bsmLogin : Form
    {

        public DangNhapBLL dangnhapbll;

        public bsmLogin()
        {
            InitializeComponent();
            dangnhapbll = new DangNhapBLL();
        }

        private void bsmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string madn = txtTenDangNhap.Text;
            string matkhau = txtMatKhau.Text;
            //string quyen = cboQuyen.SelectedText.ToString();
            dangnhapbll = new DangNhapBLL();
            //  string kiemtra = dangnhapbll.CheckLogin(tendn, matkhau, quyen);
            if(madn == "")
            {
                MessageBox.Show("Không được để trống tên đăng nhập","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            else if (matkhau == "")
            {
                MessageBox.Show("Không được để trống mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
            }

            else if (dangnhapbll.CheckLoginBLL(madn, matkhau))
            {
                string quyen = dangnhapbll.LayQuyenBLL(madn);

                FormMain mainForm = new FormMain(quyen);
                mainForm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng");
            }    


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
