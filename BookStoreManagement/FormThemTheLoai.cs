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
    public partial class FormThemTheLoai : Form
    {
        TheLoaiBLL tlbll = new TheLoaiBLL();
        public FormThemTheLoai()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormThemTheLoai_Load(object sender, EventArgs e)
        {
            LoadData(dgvDSTL);
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQuaTL.Enabled = true;
            txtMaTheLoai.Enabled = false;
            dgvDSTL.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvDSTL.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        public void LoadData(DataGridView dgv)
        {
          
            dgv.DataSource = tlbll.LayTheLoaiBLL();
            txtMaTheLoai.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }
        void XoaTextBox()
        {
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
           
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            txtMaTheLoai.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQuaTL.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void dgvDSTL_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }

        private void dgvDSTL_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                string matl = txtMaTheLoai.Text;
                tlbll.XoaTheLoai(matl);
                MessageBox.Show("Xóa thành công");
                XoaTextBox();
                LoadData(dgvDSTL);
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
                string matl = txtMaTheLoai.Text;
                string tentl = txtTenTheLoai.Text;
                TheLoaiDTO theloai = new TheLoaiDTO(matl,tentl);
                tlbll.SuaTheLoaiBLL(theloai);
                MessageBox.Show("Sửa thành công");
                XoaTextBox();
                LoadData(dgvDSTL);
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
                string matl = txtMaTheLoai.Text;
                string tentl = txtTenTheLoai.Text;
                if (matl == "" || tentl == "")
                {
                    MessageBox.Show("Không được bỏ trống thông tin");
                    txtMaTheLoai.Focus();

                }
                if (matl == "")
                {
                    MessageBox.Show("Không được bỏ trống mã thể loại");
                    txtMaTheLoai.Focus();
                }
                else if (tentl == "")
                {
                    MessageBox.Show("Không được bỏ trống tên thể loại");
                    txtTenTheLoai.Focus();
                }
                else
                {
                    if (tlbll.ThemTheLoaiBLL(matl, tentl))
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadData(dgvDSTL);
                        XoaTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Mã đã tồn tại");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void dgvDSTL_Click(object sender, EventArgs e)
        {
        }

        private void dgvDSTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSTL.Rows.Count)
            {
                DataGridViewRow row = dgvDSTL.Rows[e.RowIndex];
                // Thêm dòng
                if (row != null)
                {
                    // Gán giá trị từ các ô vào các TextBox tương ứng
                    txtMaTheLoai.Text = row.Cells[0].Value.ToString();
                    txtTenTheLoai.Text = row.Cells[1].Value.ToString();
                  
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnBoQuaTL.Enabled = true;
                }

            }
        }

        private void btnBoQuaTL_Click(object sender, EventArgs e)
        {

            XoaTextBox();
            LoadData(dgvDSTL);
        }
    }
}
