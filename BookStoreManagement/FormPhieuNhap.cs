using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using DTO;
using BLL;

namespace BookStoreManagement
{
    public partial class FormPhieuNhap : Form
    {
        private string maPn;
        private DateTime ngayLap;
        private string tongTien;

        private PhieuNhapBLL pnbll = new PhieuNhapBLL();
        private ChiTietPhieuNhapBLL ctbll = new ChiTietPhieuNhapBLL();
        public FormPhieuNhap()
        {
            InitializeComponent();
            txtGiaNhap.KeyPress += txtGiaNhap_KeyPress;
            txtGiaBan.KeyPress += txtGiaBan_KeyPress;
            nudSoLuong.KeyPress += nudSoLuong_KeyPress;
        }
        void XoaTextBox()
        {
            txtMaPhieuNhap.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtTongTien.Text = "0";

        }
        private void LoadDSPhieuNhap()
        {
            dgvPN.DataSource = pnbll.GetPhieuNhapBLL();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtMaPhieuNhap.Enabled = false;
            txtTongTien.Enabled = false;


        }
        private void LoadDSChiTiet()
        {
            ChiTietPhieuNhapDTO ct = new ChiTietPhieuNhapDTO();
            ct.Mapn = txtMaPhieuNhap.Text;
            dgvCTPN.DataSource = ctbll.GetDSChiTietPN(ct.Mapn);
            btnThemCT.Enabled = true;
            btnXoaCT.Enabled = true;
            btnLuuCT.Enabled = false;
            cboMaSach.Enabled = true;
            txtTongTien.Enabled = false;
        }
        void layDuLieu()
        {

            maPn = txtMaPhieuNhap.Text;
            ngayLap = dtpNgayLap.Value;
            tongTien = txtTongTien.Text;

        }
        void XoaThongTinCT()
        {
            cboMaSach.Text = "";
            nudSoLuong.Value = 0;
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
        }
        private void LoadSach()
        {
            SachBLL s = new SachBLL();
            cboMaSach.DataSource = s.GetSachBLL();
            cboMaSach.DisplayMember = "TenSach";
            cboMaSach.ValueMember = "MaSach";
        }


        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = "0";
            txtLoi.Visible = false;
            txtLoi2.Visible = false;
            txtLoi3.Visible = false;
            LoadDSPhieuNhap();
            LoadSach();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            txtMaPhieuNhap.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            XoaThongTinCT();
            LoadDSChiTiet();
            txtMaPhieuNhap.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled=false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuNhapDTO pn = new PhieuNhapDTO();
            pn.Mapn = txtMaPhieuNhap.Text;
            pn.Ngaylap = dtpNgayLap.Value;
            pn.Tongtien = Convert.ToSingle(txtTongTien.Text);
            if (pnbll.CheckMaPNhBLL(pn.Mapn))
            {
                pnbll.AddPhieuNhapBLL(pn);
                MessageBox.Show("Thêm thành công!");
                LoadDSPhieuNhap();
                XoaTextBox();
            }
            else
            {
                MessageBox.Show("Trùng mã phiếu nhập! Nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuNhapDTO pn = new PhieuNhapDTO();
            pn.Mapn = txtMaPhieuNhap.Text;
            pnbll.XoaPNBLL(pn.Mapn);
            MessageBox.Show("Xóa thành công!");
            XoaTextBox();
            LoadDSPhieuNhap();
        }

        private void dgvPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPhieuNhap.Focus();
                return;
            }
            if (dgvPN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (e.RowIndex >= 0) // kiểm tra hàng được click là hàng thực sự, không phải hàng tiêu đề
            {
                DataGridViewRow row = dgvPN.Rows[e.RowIndex];
                txtMaPhieuNhap.Text = row.Cells[0].Value.ToString();
                string birthDateString = row.Cells["dgvNgayLap"].Value.ToString();

                DateTime ngaysinh;
                if (DateTime.TryParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh))
                {
                    // Gán giá trị vào DateTimePicker
                    dtpNgayLap.Value = ngaysinh;
                }

                txtTongTien.Text = row.Cells[2].Value.ToString();
                LoadDSChiTiet();
            }
            layDuLieu();
            txtMaPhieuNhap.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            XoaThongTinCT();
            cboMaSach.Enabled = true;
            btnXoaCT.Enabled = false;
            btnThemCT.Enabled = false;
            btnLuuCT.Enabled = true;
            btnBoQuaCT.Enabled = true;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhapDTO s = new ChiTietPhieuNhapDTO
            {
                Mapn = txtMaPhieuNhap.Text,
                Masach = ((SachDTO)cboMaSach.SelectedItem).Masach,
                Gianhap = Convert.ToSingle(txtGiaNhap.Text),
                Giaban = Convert.ToSingle(txtGiaBan.Text),
                Soluong = (int)nudSoLuong.Value,

            };
            ctbll.XoaCTPhieuNhap(s.Mapn,s.Masach);
            XoaThongTinCT();
            LoadDSChiTiet();
            LoadDSPhieuNhap();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhapDTO s = new ChiTietPhieuNhapDTO
            {
                Mapn = txtMaPhieuNhap.Text,
                Masach = ((SachDTO)cboMaSach.SelectedItem).Masach,
                Gianhap = Convert.ToSingle(txtGiaNhap.Text),
                Giaban = Convert.ToSingle(txtGiaBan.Text),
                Soluong = (int)nudSoLuong.Value,

            };
            ctbll.AddChiTietPhieuNhapBLL(s);
            XoaThongTinCT();
            LoadDSChiTiet();
            LoadDSPhieuNhap();
        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThemCT.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaPhieuNhap.Focus();
                return;
            }
            if (dgvCTPN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (e.RowIndex >= 0) // kiểm tra hàng được click là hàng thực sự, không phải hàng tiêu đề
            {
                DataGridViewRow row = dgvCTPN.Rows[e.RowIndex];
                string s = row.Cells["dgvMaSach"].Value.ToString();
                cboMaSach.SelectedValue = s;
                txtGiaNhap.Text = row.Cells["dgvGiaNhap"].Value.ToString();
                txtGiaBan.Text = row.Cells["dgvGiaBan"].Value.ToString();
                nudSoLuong.Value = Convert.ToInt32(row.Cells["dgvSoLuong"].Value.ToString());
                LoadDSChiTiet();
            }


            cboMaSach.Enabled = false;
            btnXoaCT.Enabled = true;
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
                txtLoi.Visible = true;
            }
            else
            {
                txtLoi.Visible = false; // Xóa thông báo lỗi nếu người dùng nhập đúng
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
                txtLoi2.Visible = true;
            }
            else
            {
                txtLoi.Visible = false; // Xóa thông báo lỗi nếu người dùng nhập đúng
            }
        }

        private void nudSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
                txtLoi3.Visible = true;
            }
            else
            {
                txtLoi.Visible = false; // Xóa thông báo lỗi nếu người dùng nhập đúng
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }

}
