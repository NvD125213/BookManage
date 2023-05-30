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
    public partial class FormTacGia : Form
    {
        public TacGiaBLL tgbll = new TacGiaBLL();
        public FormTacGia()
        {
            InitializeComponent();
        }
        public void LoadData(DataGridView dgv)
        {
           
            dgv.DataSource = tgbll.LayDanhSachTacGiaBLL();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaTG.Enabled = false;

        }
        void XoaTextBox()
        {
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtSDT.Text = "";
        }

        private void FormTacGia_Load(object sender, EventArgs e)
        {
            LoadData(dgvDSTG);
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = true;
            txtMaTG.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                string matg = txtMaTG.Text;
                if (tgbll.XoaTacGiaBLL(matg))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData(dgvDSTG);
                    XoaTextBox();
                }
                else
                {
                    MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            txtMaTG.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string matg = txtMaTG.Text;
                string tentg = txtTenTG.Text;
                string sdt = txtSDT.Text;
                if (matg == "" || tentg == "" || sdt == "")
                {
                    MessageBox.Show("Không được bỏ trống thông tin!");
                    txtMaTG.Focus();
                    return;

                }
                else
                {
                    if (tgbll.ThemTacGiaBLL(matg,tentg, sdt))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadData(dgvDSTG);
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

        private void btnSua_Click(object sender, EventArgs e)
        {

           try
            {
                string matg = txtMaTG.Text;
                string tentg = txtTenTG.Text;
                string sdt = txtSDT.Text;
                if (tgbll.SuaTacGiaBLL(matg, tentg, sdt))
                {
                    MessageBox.Show("Sửa thành công!");
                    XoaTextBox();
                    LoadData(dgvDSTG);

                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            LoadData(dgvDSTG);

        }

        private void dgvDSTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSTG.Rows.Count)
            {
                DataGridViewRow row = dgvDSTG.Rows[e.RowIndex];
                // Thêm dòng
                if (row != null)
                {
                    // Gán giá trị từ các ô vào các TextBox tương ứng
                    txtMaTG.Text = row.Cells["dgvMaTG"].Value.ToString();
                    txtTenTG.Text = row.Cells["dgvTenTG"].Value.ToString();
                    txtSDT.Text = row.Cells["dgvSDT"].Value.ToString();
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnBoQua.Enabled = true;
                    txtMaTG.Enabled = false;
                }

            }
        }
    }
}
