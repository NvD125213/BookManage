using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DTO;
using BLL;
namespace BookStoreManagement
{
    public partial class FormHoaDon : Form
    {

       
        private HoaDonBLL hdbll = new HoaDonBLL();
        private CTHoaDonBLL ctbll = new CTHoaDonBLL();
        public FormHoaDon()
        {
            InitializeComponent();
        }
        void XoaTextBox()
        {
            txtMaHD.Text = "";
            cboKhachHang.Text = "";
            cboNhanVien.Text = "";
            txtTongTien.Text = "0";

        }
        private void LoadDSHoaDon()
        {
            dgvDSHD.DataSource = hdbll.GetHoaDonBLL();
            txtGiaBan.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtMaHD.Enabled = false;
            txtTongTien.Enabled = false;

        }
        void LoadDSChiTiet()
        {
            CTHoaDonDTO ct = new CTHoaDonDTO();
            ct.Mahd = txtMaHD.Text;
            dgvDSCT.DataSource = ctbll.GetDSChiTietHDBLL(ct.Mahd);
            btnThemCT.Enabled = true;
            btnXoaCT.Enabled = true;
            btnLuuCT.Enabled = false;
            cboMaSach.Enabled = true;
            txtTongTien.Enabled = false;
        }
      
        private void XoaThongTinCT()
        {
            cboMaSach.Text = "";
            nudSoLuong.Value = 0;
          
        }
        private void LoadSach()
        {
            SachBLL s = new SachBLL();
            cboMaSach.DataSource = s.GetSachBLL();
            cboMaSach.DisplayMember = "TenSach";
            cboMaSach.ValueMember = "MaSach";
            cboMaSach.ValueMember = "GiaBan";

        }
        private void LoadNV()
        {
            NhanVienBLL s = new NhanVienBLL();
            cboNhanVien.DataSource = s.GetNVBLL();
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";
        }
       private void LoadKH()
        {
            KhachHangBLL s = new KhachHangBLL();
            cboKhachHang.DataSource = s.GetKHBLL();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = "0";
            txtTongTien.Enabled = false;
            LoadDSHoaDon();
            LoadKH();
            LoadNV();
            LoadSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            txtMaHD.Enabled = true;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.Mahd = txtMaHD.Text;
            hd.Ngaylap = dtpNgayLap.Value;
            hd.Tongtien = Convert.ToSingle(txtTongTien.Text);
            hd.Makh = cboKhachHang.SelectedValue.ToString();
            hd.Manv=cboNhanVien.SelectedValue.ToString();
            if (hdbll.CheckMaHDBLL(hd.Mahd))
            {
                hdbll.AddHoaDonBLL(hd);
                MessageBox.Show("Thêm thành công!");
                LoadDSHoaDon();
                XoaTextBox();
            }
            else
            {
                MessageBox.Show("Trùng mã hóa đơn! Nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSach.SelectedItem != null)
            {
                // Lấy giá trị thực tế (Giaban) của mục đã chọn
                SachDTO sach = (SachDTO)cboMaSach.SelectedItem;
                float giaBan = sach.Giaban;

                // Đổ giá trị vào text box
                txtGiaBan.Text = giaBan.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.Mahd = txtMaHD.Text;
            hdbll.XoaHoaDonBLL(hd.Mahd);
            MessageBox.Show("Xóa thành công!");
            XoaTextBox();
            LoadDSHoaDon();
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHD.Focus();
                return;
            }
            if (dgvDSHD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (e.RowIndex >= 0) // kiểm tra hàng được click là hàng thực sự, không phải hàng tiêu đề
            {
                DataGridViewRow row = dgvDSHD.Rows[e.RowIndex];
                txtMaHD.Text = row.Cells[0].Value.ToString();
                string birthDateString = row.Cells["dgvNgayLap"].Value.ToString();

                DateTime ngaysinh;
                if (DateTime.TryParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh))
                {
                    // Gán giá trị vào DateTimePicker
                    dtpNgayLap.Value = ngaysinh;
                }

                txtTongTien.Text = row.Cells["dgvTongTien"].Value.ToString();
                string nv = row.Cells["dgvMaNV"].Value.ToString();
                cboNhanVien.SelectedValue = nv;
                string kh = row.Cells["dgvMaKH"].Value.ToString();
                cboKhachHang.SelectedValue = kh;
                LoadDSChiTiet();
            }
            txtMaHD.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void dgvDSHD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSHD.Columns[e.ColumnIndex].Name == "dgvNgayLap" && e.Value != null)
            {
                // Định dạng lại giá trị ngày
                if (e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            XoaThongTinCT();
            cboMaSach.Enabled = true;
            btnXoaCT.Enabled = false;
            btnThemCT.Enabled = false;
            btnLuuCT.Enabled = true;
            btnInHD.Enabled = false;
        }

        private void btnLuuCT_Click(object sender, EventArgs e)
        {
            CTHoaDonDTO s = new CTHoaDonDTO
            {
                Mahd = txtMaHD.Text,
                Masach = ((SachDTO)cboMaSach.SelectedItem).Masach,
                Soluong = (int)nudSoLuong.Value,

            };
            ctbll.AddChiTietHDBLL(s);
            XoaThongTinCT();
            LoadDSChiTiet();
            LoadDSHoaDon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime ngaylap = dtpNgayLapTK.Value;
            DataTable result = hdbll.SearchNgayLapBLL(ngaylap);
            dgvDSHD.DataSource = result;
        }

        private void txtToanBo_Click(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = hdbll.GetHoaDonBLL();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            DataTable dt = ctbll.InHoaDonBLL(mahd);
            rptHoaDon r = new rptHoaDon();
            r.SetDataSource(dt);
            FormInBC frm = new FormInBC();
            frm.crystalReportViewer1.ReportSource = r;
            frm.ShowDialog();
        }
    }

}
