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
    public partial class FormQLKhachHang : Form
    {
        KhachHangBLL khbll = new KhachHangBLL();
        public FormQLKhachHang()
        {
            InitializeComponent();
        }
        public void LoadData(DataGridView dgv)
        {

            dgv.DataSource = khbll.LayKhachHangBLL();
            txtMaKH.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }
        void XoaTextBox()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";

        }
      

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            LoadData(dgvDSKH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            txtMaKH.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                string makh = txtMaKH.Text;
                khbll.XoaKhachHangBLL(makh);
                MessageBox.Show("Xóa thành công");
                XoaTextBox();
                LoadData(dgvDSKH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = txtMaKH.Text;
                string tenkh = txtTenKH.Text;
                string sdt = txtSDT.Text;
                if (makh == "" || tenkh == "" || sdt =="")
                {
                    MessageBox.Show("Không được bỏ trống thông tin");
                    txtMaKH.Focus();

                }
                if (makh == "")
                {
                    MessageBox.Show("Không được bỏ trống mã khách hàng!");
                    txtMaKH.Focus();
                }
                else if (tenkh == "")
                {
                    MessageBox.Show("Không được bỏ trống tên khách hàng!");
                    txtTenKH.Focus();
                }
                else if (sdt == "")
                {
                    MessageBox.Show("Không được bỏ trống số điện thoại!");
                    txtTenKH.Focus();
                }
                else
                {
                    if (khbll.ThemKhachHangBLL(makh, tenkh,sdt))
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadData(dgvDSKH);
                        XoaTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Mã đã tồn tại!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = txtMaKH.Text;
                string tenkh = txtTenKH.Text;
                string sdt = txtSDT.Text;
                KhachHangDTO kh = new KhachHangDTO(makh, tenkh,sdt);
                khbll.SuaKhachHangBLL(kh);
                MessageBox.Show("Sửa thành công");
                XoaTextBox();
                dgvDSKH.DataSource = khbll.LayKhachHangBLL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormQLKhachHang_Load(object sender, EventArgs e)
        {
            LoadData(dgvDSKH);
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = true;
            txtMaKH.Enabled = false;
            
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSKH.Rows.Count)
            {
                DataGridViewRow row = dgvDSKH.Rows[e.RowIndex];
                // Thêm dòng
                if (row != null)
                {
                    // Gán giá trị từ các ô vào các TextBox tương ứng
                    txtMaKH.Text = row.Cells[0].Value.ToString();
                    txtTenKH.Text = row.Cells[1].Value.ToString();
                    txtSDT.Text = row.Cells[2].Value.ToString();
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnBoQua.Enabled = true;
                }

            }
        }
    }
}
