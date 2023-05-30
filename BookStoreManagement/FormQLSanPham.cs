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

    public partial class FormQLSanPham : Form
    {
        private SachBLL sbll = new SachBLL();
        private TheLoaiDTO theLoai = new TheLoaiDTO();
        private NXBDTO nxb = new NXBDTO();
        public FormQLSanPham()
        {
            InitializeComponent();
        }
        public void LoadData(DataGridView dgv)
        {

            dgvDSSP.DataSource = sbll.LayDSSachBLL();
            txtMaSach.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }
        void XoaTextBox()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtSlton.Enabled = false;
            txtSlton.Text = "0";
            txtGiaBan.Enabled = false;
            txtGiaBan.Text = "0";
            cboNXB.SelectedItem = "";
            cboTheLoai.SelectedItem = "";
        }


        private void LoadTheLoai()
        {
            TheLoaiBLL tl = new TheLoaiBLL();
            cboTheLoai.DataSource = tl.LayTlTrongSach();
            cboTheLoai.DisplayMember = "TenTL";
            cboTheLoai.ValueMember = "MaTL";

        }
        private void LoadNXB()
        {
            NXBBLL nxb = new NXBBLL();
            cboNXB.DataSource = nxb.LayNXBTrongSachBLL();
            cboNXB.DisplayMember = "TenNXB";
            cboNXB.ValueMember = "MaNXB";
        }

        private void FormQLSanPham_Load(object sender, EventArgs e)
        {
            txtSlton.Enabled=false;
            txtTacGia.Enabled=false;
            LoadData(dgvDSSP);
            LoadTheLoai();
            LoadNXB();
            List<TacGiaDTO> tg = sbll.LayDanhSachTacGiaBLL();
            dgvTacGia.CellClick += dgvTacGia_CellClick;
            dgvTacGia.DataSource = tg;

            XoaTextBox();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            txtMaSach.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTacGia.Rows.Count)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvTacGia.Rows[e.RowIndex];

                // Lấy giá trị cột Mã tác giả từ dòng được chọn
                string maTacGia = row.Cells["MaTG"].Value.ToString();

                // Đổ giá trị Mã tác giả vào TextBox
                txtTacGia.Text = maTacGia;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SachDTO s = new SachDTO
            {
                Masach = txtMaSach.Text,
                Tensach = txtTenSach.Text,
                Matl = ((TheLoaiDTO)cboTheLoai.SelectedItem).Matl,
                Manxb = ((NXBDTO)cboNXB.SelectedItem).MaNXB,
                Matg = txtTacGia.Text,
                Slt = Convert.ToInt32(txtSlton.Text),

            };

            if(sbll.CheckMaSachBLL(s.Masach))
            {
                sbll.ThemSachBLL(s);
                MessageBox.Show("Thêm thành công!");
                LoadData(dgvDSSP);
                XoaTextBox();
            } 
            else
            {
                MessageBox.Show("Trùng mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SachDTO s = new SachDTO
            {
                Masach = txtMaSach.Text,
                Tensach = txtTenSach.Text,
                Matl = ((TheLoaiDTO)cboTheLoai.SelectedItem).Matl,
                Manxb = ((NXBDTO)cboNXB.SelectedItem).MaNXB,
                Matg = txtTacGia.Text,
                Slt = Convert.ToInt32(txtSlton.Text),
                Giaban = Convert.ToSingle(txtGiaBan.Text),

            };
            sbll.SuaSachBLL(s);
            MessageBox.Show("Sửa thành công!");
            LoadData(dgvDSSP);
            XoaTextBox();
        }

        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSSP.Rows.Count)
            {
                DataGridViewRow row = dgvDSSP.Rows[e.RowIndex];
                // Thêm dòng
                if (row != null)
                {
                    // Gán giá trị từ các ô vào các TextBox tương ứng
                    txtMaSach.Text = row.Cells["dgvMaSach"].Value.ToString();
                    txtTenSach.Text = row.Cells["dgvTenSach"].Value.ToString();
                    string tl = row.Cells["dgvMaTL"].Value.ToString();
                    cboTheLoai.SelectedValue = tl;
                    string nxb = row.Cells["dgvMaNXB"].Value.ToString();
                    cboNXB.SelectedValue = nxb;
                    txtTacGia.Enabled = false;
                    txtTacGia.Text = row.Cells["dgvMaTG"].Value.ToString();
                    txtSlton.Text = row.Cells["dgvSLT"].Value.ToString();
                    txtGiaBan.Text = row.Cells["dgvGiaBan"].Value.ToString();
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnBoQua.Enabled = true;
                }

            }
        }

        private void dgvDSSP_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            dgvTacGia.EditingControlShowing += dgvTacGia_EditingControlShowing ;
        }

        private void dgvTacGia_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
          
        }

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masach = txtMaSach.Text;
            if (sbll.XoaSachBLL(masach))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData(dgvDSSP);
                XoaTextBox();
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            LoadData(dgvDSSP);
        }
    }
}
