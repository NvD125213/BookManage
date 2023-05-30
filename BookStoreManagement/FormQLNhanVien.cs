using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Imaging;
using DTO;

namespace BookStoreManagement
{
    public partial class FormQLNhanVien : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        DangNhapBLL dangNhapBLL = new DangNhapBLL();
        private bool hasSelectedImage = false;
        public FormQLNhanVien()
        {
            InitializeComponent();
        }
        public void LoadData(DataGridView dgv)
        {

            dgvDSNV.DataSource = nvbll.LayDanhSachNVBLL();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }
        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            DangNhapDTO dn =new DangNhapDTO();
            dgvDSNV.DataSource = nvbll.LayDanhSachNVBLL();
            dgvDN.DataSource = dangNhapBLL.GetDangNhapBLL(dn);
            txtMaNV.Enabled = false;
            rdbNam.Checked = true;
            rdbNu.Checked = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaDN.Enabled = false;
            btnXoaTK.Enabled = false;
            btnLuuTK.Enabled = false;
            btnSuaTK.Enabled = false;
        }
        void XoaTextBox()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            rdbNam.Checked = true;
            rdbNu.Checked = false;
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            picAnhNV.Image = null;


        }
        void XoaTextBox2()
        {
            txtMaDN.Text = "";
            txtTenDN.Text = "";
            rdbNhanVien.Checked = true;
            rdbQuanLy.Checked = false;
            txtMatKhau.Text = "";
          


        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pnThongTinNV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnAnhNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Picture file (.png, .jpg)|*.png; *.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picAnhNV.Image = Image.FromFile(dlg.FileName);
                picAnhNV.SizeMode = PictureBoxSizeMode.StretchImage;
                hasSelectedImage = true;
            }

        }
        // Chuyển đổi hình ảnh lưu vào database
        private byte[] ImageToBase64(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            txtMaNV.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.Manv = txtMaNV.Text;
            nv.Tennv = txtTenNV.Text;
            nv.Gt = rdbNam.Checked ? "Nam" : "Nữ";
            nv.Ngaysinh = dtpNgaySinh.Value;
            nv.Diachi = txtDiaChi.Text;
            nv.Email = txtEmail.Text;
            nv.Sdt = txtSDT.Text;         
          



            // Khởi tạo đối tượng NhanVienDTO từ các tham số đã lấy được
            //NhanVienDTO nv = new NhanVienDTO(manv, tennv, gt, ngaysinh, diachi, email, sdt, imageBytes);
           
            if(nvbll.CheckMaNVBLL(nv.Manv))
            {

                if (hasSelectedImage)
                {
                    nv.Anh = ImageToBase64(picAnhNV.Image, picAnhNV.Image.RawFormat);



                    if (nvbll.IsValidEmail(nv.Email))
                    {
                        if (nvbll.IsValidPhoneNumber(nv.Sdt))
                        {
                            if (nvbll.ThemNVBLL(nv))
                            {

                                MessageBox.Show("Thêm thành công!");
                                nvbll.ThemNVBLL(nv);
                                LoadData(dgvDSNV);
                                XoaTextBox();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSDT.Text = string.Empty;
                            txtSDT.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập địa chỉ email hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = string.Empty;
                        txtEmail.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ảnh trước khi thực hiện lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Trùng mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }    




        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSNV.Rows.Count)
            {
                DataGridViewRow row = dgvDSNV.Rows[e.RowIndex];
                // Thêm dòng
                if (row != null)
                {
                    // Gán giá trị từ các ô vào các TextBox tương ứng
                    txtMaNV.Text = row.Cells["dgvMaNV"].Value.ToString();
                    txtTenNV.Text = row.Cells["dgvTenNV"].Value.ToString();
                    string gender = row.Cells["dgvGT"].Value.ToString();

                    // Tự động chọn RadioButton tương ứng với giới tính
                    if (gender == "Nam")
                    {
                        rdbNam.Checked = true;
                    }
                    else if (gender == "Nữ")
                    {
                        rdbNu.Checked = true;
                    }

                    string birthDateString = row.Cells["dgvNgaySinh"].Value.ToString();

                    DateTime ngaysinh;
                    if (DateTime.TryParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh))
                    {
                        // Gán giá trị vào DateTimePicker
                        dtpNgaySinh.Value = ngaysinh;
                    }
                    txtDiaChi.Text = row.Cells["dgvDiaChi"].Value.ToString();
                    txtSDT.Text = row.Cells["dgvSDT"].Value.ToString();
                    txtEmail.Text = row.Cells["dgvEmail"].Value.ToString();
                    // Lấy giá trị của thuộc tính picAnhNV của hàng được nhấn

                    object cellValue = dgvDSNV.Rows[e.RowIndex].Cells["dgvAnh"].Value;

                    if (cellValue != DBNull.Value)
                    {
                        byte[] imageData = (byte[])cellValue;
                        Image image = Base64ToImage(imageData);
                        picAnhNV.Image = image;
                        picAnhNV.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                    else
                    {
                        picAnhNV.Image = null;
                    }
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    btnBoQua.Enabled = true;
                }

            }
        }

        private void dgvDSNV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.Manv = txtMaNV.Text;
            nv.Tennv = txtTenNV.Text;
            nv.Gt = rdbNam.Checked ? "Nam" : "Nữ";
            nv.Ngaysinh = dtpNgaySinh.Value;
            nv.Diachi = txtDiaChi.Text;
            nv.Email = txtEmail.Text;
            nv.Sdt = txtSDT.Text;
            nv.Anh = ImageToBase64(picAnhNV.Image, picAnhNV.Image.RawFormat);
            try
            {
                nvbll.SuaNVBLL(nv);
                LoadData(dgvDSNV);
                XoaTextBox();
            }
            catch
            {
                MessageBox.Show("Lỗi thông tin sửa! Kiểm tra lại!");
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            if (nvbll.XoaNVBLL(manv))
            {
                MessageBox.Show("Xóa thành công!");
                LoadData(dgvDSNV);
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
            LoadData(dgvDSNV);
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            txtMaDN.Enabled = true;
            btnThemTK.Enabled = false;
            btnSuaTK.Enabled = false;
            btnXoaTK.Enabled = false;
            btnLuuTK.Enabled = true;

        }
        public void LoadDataTK(DataGridView dgv)
        {
            DangNhapDTO dn  = new DangNhapDTO();
            dgvDN.DataSource = dangNhapBLL.GetDangNhapBLL(dn);
            btnThemTK.Enabled = true;
            btnLuuTK.Enabled = false;
            btnSuaTK.Enabled = false;
            btnXoaTK.Enabled = false;

        }

        private void btnLuuTK_Click(object sender, EventArgs e)
        {
            string matk = txtMaDN.Text;
            string tendn = txtTenDN.Text;
            string mk = txtMatKhau.Text;
            string quyen = rdbNhanVien.Checked ? "Nhân viên" : "Quản lý";
            if (matk == "" || tendn == "" || mk == "")
            {
                MessageBox.Show("Không được bỏ trống thông tin!");
                txtMaDN.Focus();
                return;

            }
            else
            {
                if (dangNhapBLL.ThemDN(matk, tendn, mk,quyen))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadDataTK(dgvDN);
                    XoaTextBox2();
                }
                else
                {
                    MessageBox.Show("Trùng mã đăng nhập!");
                }
            }

        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            string matk = txtMaDN.Text;
            string tendn = txtTenDN.Text;
            string mk = txtMatKhau.Text;
            string quyen = rdbNhanVien.Checked ? "Nhân viên" : "Quản lý";
            if (dangNhapBLL.SuaDN(matk, tendn, mk, quyen))
            {
                MessageBox.Show("Sửa thành công!");
                XoaTextBox();
                LoadDataTK(dgvDN);

            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            string madn = txtMaDN.Text;
            dangNhapBLL.XoaDN(madn);
            MessageBox.Show("Xóa thành công!");
            XoaTextBox2();
            LoadDataTK(dgvDN);
        }

        private void btnBoQuaTK_Click(object sender, EventArgs e)
        {
            XoaTextBox2();
            LoadDataTK(dgvDN);
        }

        private void dgvDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDN.Rows.Count)
            {
                DataGridViewRow row = dgvDN.Rows[e.RowIndex];
                // Thêm dòng
                if (row != null)
                {
                    // Gán giá trị từ các ô vào các TextBox tương ứng
                    txtMaDN.Text = row.Cells[0].Value.ToString();
                    txtTenDN.Text = row.Cells[1].Value.ToString();
                    txtMatKhau.Text = row.Cells[2].Value.ToString();
                    string quyen = row.Cells[3].Value.ToString();

                    if (quyen == "Nhân viên")
                    {
                        rdbNhanVien.Checked = true;
                    }
                    else if (quyen == "Quản lý")
                    {
                        rdbQuanLy.Checked = true;
                    }

                    btnThemTK.Enabled = false;
                    btnSuaTK.Enabled = true;
                    btnXoaTK.Enabled = true;
                    btnLuuTK.Enabled = false;
                    btnBoQuaTK.Enabled = true;
                    txtMaDN.Enabled = false;
                }

            }
        }
    }
}
