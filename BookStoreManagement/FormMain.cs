using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace BookStoreManagement
{
    public partial class FormMain : Form
    {
        private string quyen;
        public FormMain(string quyen)
        {

            InitializeComponent();
            this.quyen = quyen;
            LoadFunctionality();
        }
        private void LoadFunctionality()
        {
            // Dựa vào quyền của người dùng, hiển thị các chức năng tương ứng trên form
            if (quyen == "Nhân viên")
            {
                tsmNhanVien.Enabled = false;
                tsmPhieuNhap.Enabled = false;
                tsmThongKe.Enabled = false;
                
            }
            else if (quyen == "Quản lý")
            {
                tsmNhanVien.Enabled = true;
                tsmPhieuNhap.Enabled = true;
                tsmThongKe.Enabled = true;
            }
        }
        private void thẻLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private Form currentformchild;
        private void OpenChildForm(Form childForm)
        {
            if (currentformchild != null)
            {
                currentformchild.Close();
            }    
            currentformchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }

        private void tsmNhanVien_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new FormQLNhanVien());
        }

        private void tsmKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLKhachHang());
        }

        private void tsmSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLSanPham());
        }

        private void tsmNXB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThemNXB());

        }

        private void tsmTacGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTacGia());

        }

        private void tsmTheLoai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThemTheLoai());

        }

        private void tsmHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon());
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formTK());
        }

        private void tsmThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            bsmLogin bsmLogin = new bsmLogin();
            bsmLogin.ShowDialog();
        }

        private void tsmPhieuNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhieuNhap());
        }
    }
}
