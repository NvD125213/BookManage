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
    public partial class FormThemNXB : Form
    {
        NXBBLL nxbbll = new NXBBLL();

        public FormThemNXB()
        {
            InitializeComponent();
        }
        public void LoadData(DataGridView dgv)
        {
            nxbbll = new NXBBLL();
            dgv.DataSource = nxbbll.LayDanhSachNXBBLL();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }
        void XoaTextBox()
        {
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        private void dgvDSNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormThemNXB_Load(object sender, EventArgs e)
        {
            LoadData(dgvDSNXB);
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = true;
            txtMaNXB.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            txtMaNXB.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manxb = txtMaNXB.Text;
            string tennxb = txtTenNXB.Text;
            string dc = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            if (nxbbll.SuaNXBBLL(manxb, tennxb, dc, sdt))
            {
                MessageBox.Show("Sửa thành công!");
                XoaTextBox();
                LoadData(dgvDSNXB);

            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string manxb = txtMaNXB.Text;
            string tennxb = txtTenNXB.Text;
            string dc = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            try
            {

                if (manxb == "" || tennxb == "" || dc == "" || sdt == "")
                {
                    MessageBox.Show("Không được bỏ trống thông tin!");
                    txtMaNXB.Focus();
                    return;

                }
                else
                {
                    if (nxbbll.ThemNXBBLL(manxb, tennxb, dc, sdt))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadData(dgvDSNXB);
                        XoaTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Trùng mã NXB!");
                    }
                }

            }

            catch
            {
                MessageBox.Show("Lỗi thông tin!");
            }
        }

        private void dgvDSNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSNXB.Rows.Count)
            {
                DataGridViewRow row = dgvDSNXB.Rows[e.RowIndex];
                // Thêm dòng
                if (row != null)
                {
                    // Gán giá trị từ các ô vào các TextBox tương ứng
                    txtMaNXB.Text = row.Cells["dgvMaNXB"].Value.ToString();
                    txtTenNXB.Text = row.Cells["dgvTenNXB"].Value.ToString();
                    txtDiaChi.Text = row.Cells["dgvDiaChi"].Value.ToString();
                    txtSDT.Text = row.Cells["dgvSDT"].Value.ToString();
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnBoQua.Enabled = true;
                    txtMaNXB.Enabled = false;
                }          

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manxb = txtMaNXB.Text;
            if (nxbbll.XoaNXBBLL(manxb))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData(dgvDSNXB);
                XoaTextBox();
            }
            else
            {
                MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            LoadData(dgvDSNXB);
        }
    }
}
