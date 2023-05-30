namespace BookStoreManagement
{
    partial class FormQLNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNhanVien));
            this.pnThongTinNV = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDN = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbNhanVien = new System.Windows.Forms.RadioButton();
            this.btnBoQuaTK = new System.Windows.Forms.Button();
            this.rdbQuanLy = new System.Windows.Forms.RadioButton();
            this.btnLuuTK = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnSuaTK = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMaDN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.dgvMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.picAnhNV = new System.Windows.Forms.PictureBox();
            this.btnAnhNV = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnThongTinNV.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDN)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnThongTinNV
            // 
            this.pnThongTinNV.AutoScroll = true;
            this.pnThongTinNV.Controls.Add(this.groupBox4);
            this.pnThongTinNV.Controls.Add(this.panel1);
            this.pnThongTinNV.Controls.Add(this.groupBox3);
            this.pnThongTinNV.Controls.Add(this.groupBox2);
            this.pnThongTinNV.Controls.Add(this.groupBox1);
            this.pnThongTinNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongTinNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnThongTinNV.Location = new System.Drawing.Point(0, 0);
            this.pnThongTinNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnThongTinNV.Name = "pnThongTinNV";
            this.pnThongTinNV.Size = new System.Drawing.Size(1840, 766);
            this.pnThongTinNV.TabIndex = 0;
            this.pnThongTinNV.Paint += new System.Windows.Forms.PaintEventHandler(this.pnThongTinNV_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDN);
            this.groupBox4.Location = new System.Drawing.Point(1152, 363);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(547, 358);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách tài khoản";
            // 
            // dgvDN
            // 
            this.dgvDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDN.Location = new System.Drawing.Point(3, 22);
            this.dgvDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDN.Name = "dgvDN";
            this.dgvDN.RowHeadersWidth = 51;
            this.dgvDN.Size = new System.Drawing.Size(541, 334);
            this.dgvDN.TabIndex = 0;
            this.dgvDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDN_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnBoQua);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(963, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 340);
            this.panel1.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 20);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 37);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(35, 71);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 37);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(35, 230);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(113, 37);
            this.btnBoQua.TabIndex = 5;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(35, 124);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 37);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(35, 177);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 37);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbNhanVien);
            this.groupBox3.Controls.Add(this.btnBoQuaTK);
            this.groupBox3.Controls.Add(this.rdbQuanLy);
            this.groupBox3.Controls.Add(this.btnLuuTK);
            this.groupBox3.Controls.Add(this.btnXoaTK);
            this.groupBox3.Controls.Add(this.btnSuaTK);
            this.groupBox3.Controls.Add(this.btnThemTK);
            this.groupBox3.Controls.Add(this.txtMatKhau);
            this.groupBox3.Controls.Add(this.txtTenDN);
            this.groupBox3.Controls.Add(this.txtMaDN);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1152, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(547, 319);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cấp tài khoản";
            // 
            // rdbNhanVien
            // 
            this.rdbNhanVien.AutoSize = true;
            this.rdbNhanVien.Location = new System.Drawing.Point(277, 164);
            this.rdbNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbNhanVien.Name = "rdbNhanVien";
            this.rdbNhanVien.Size = new System.Drawing.Size(97, 23);
            this.rdbNhanVien.TabIndex = 7;
            this.rdbNhanVien.TabStop = true;
            this.rdbNhanVien.Text = "Nhân viên";
            this.rdbNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnBoQuaTK
            // 
            this.btnBoQuaTK.Location = new System.Drawing.Point(381, 222);
            this.btnBoQuaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoQuaTK.Name = "btnBoQuaTK";
            this.btnBoQuaTK.Size = new System.Drawing.Size(73, 37);
            this.btnBoQuaTK.TabIndex = 5;
            this.btnBoQuaTK.Text = "Bỏ qua";
            this.btnBoQuaTK.UseVisualStyleBackColor = true;
            this.btnBoQuaTK.Click += new System.EventHandler(this.btnBoQuaTK_Click);
            // 
            // rdbQuanLy
            // 
            this.rdbQuanLy.AutoSize = true;
            this.rdbQuanLy.Location = new System.Drawing.Point(187, 164);
            this.rdbQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbQuanLy.Name = "rdbQuanLy";
            this.rdbQuanLy.Size = new System.Drawing.Size(82, 23);
            this.rdbQuanLy.TabIndex = 7;
            this.rdbQuanLy.TabStop = true;
            this.rdbQuanLy.Text = "Quản lý";
            this.rdbQuanLy.UseVisualStyleBackColor = true;
            // 
            // btnLuuTK
            // 
            this.btnLuuTK.Location = new System.Drawing.Point(303, 222);
            this.btnLuuTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuTK.Name = "btnLuuTK";
            this.btnLuuTK.Size = new System.Drawing.Size(72, 37);
            this.btnLuuTK.TabIndex = 5;
            this.btnLuuTK.Text = "Lưu";
            this.btnLuuTK.UseVisualStyleBackColor = true;
            this.btnLuuTK.Click += new System.EventHandler(this.btnLuuTK_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Location = new System.Drawing.Point(225, 222);
            this.btnXoaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(72, 37);
            this.btnXoaTK.TabIndex = 5;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.Location = new System.Drawing.Point(147, 222);
            this.btnSuaTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(72, 37);
            this.btnSuaTK.TabIndex = 5;
            this.btnSuaTK.Text = "Sửa";
            this.btnSuaTK.UseVisualStyleBackColor = true;
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(65, 222);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(76, 37);
            this.btnThemTK.TabIndex = 5;
            this.btnThemTK.Text = "Thêm";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(187, 124);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(267, 27);
            this.txtMatKhau.TabIndex = 1;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(187, 85);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(267, 27);
            this.txtTenDN.TabIndex = 1;
            // 
            // txtMaDN
            // 
            this.txtMaDN.Location = new System.Drawing.Point(187, 34);
            this.txtMaDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDN.Name = "txtMaDN";
            this.txtMaDN.Size = new System.Drawing.Size(267, 27);
            this.txtMaDN.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Chức vụ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mật khẩu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên người dùng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên tài khoản:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSNV);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(59, 363);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1087, 358);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaNV,
            this.dgvTenNV,
            this.dgvGT,
            this.dgvNgaySinh,
            this.dgvDiaChi,
            this.dgvSDT,
            this.dgvEmail,
            this.dgvAnh});
            this.dgvDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNV.Location = new System.Drawing.Point(3, 22);
            this.dgvDSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.RowHeadersWidth = 51;
            this.dgvDSNV.Size = new System.Drawing.Size(1081, 334);
            this.dgvDSNV.TabIndex = 0;
            this.dgvDSNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNV_CellClick);
            this.dgvDSNV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSNV_DataBindingComplete);
            // 
            // dgvMaNV
            // 
            this.dgvMaNV.DataPropertyName = "MaNV";
            this.dgvMaNV.HeaderText = "Mã nhân viên";
            this.dgvMaNV.MinimumWidth = 6;
            this.dgvMaNV.Name = "dgvMaNV";
            this.dgvMaNV.Width = 125;
            // 
            // dgvTenNV
            // 
            this.dgvTenNV.DataPropertyName = "TenNV";
            this.dgvTenNV.HeaderText = "Tên nhân viên";
            this.dgvTenNV.MinimumWidth = 6;
            this.dgvTenNV.Name = "dgvTenNV";
            this.dgvTenNV.Width = 125;
            // 
            // dgvGT
            // 
            this.dgvGT.DataPropertyName = "GT";
            this.dgvGT.HeaderText = "Giới tính";
            this.dgvGT.MinimumWidth = 6;
            this.dgvGT.Name = "dgvGT";
            this.dgvGT.Width = 125;
            // 
            // dgvNgaySinh
            // 
            this.dgvNgaySinh.DataPropertyName = "FormattedBirthDate";
            this.dgvNgaySinh.HeaderText = "Ngày sinh";
            this.dgvNgaySinh.MinimumWidth = 6;
            this.dgvNgaySinh.Name = "dgvNgaySinh";
            this.dgvNgaySinh.Width = 125;
            // 
            // dgvDiaChi
            // 
            this.dgvDiaChi.DataPropertyName = "DiaChi";
            this.dgvDiaChi.HeaderText = "Địa chỉ";
            this.dgvDiaChi.MinimumWidth = 6;
            this.dgvDiaChi.Name = "dgvDiaChi";
            this.dgvDiaChi.Width = 125;
            // 
            // dgvSDT
            // 
            this.dgvSDT.DataPropertyName = "SDT";
            this.dgvSDT.HeaderText = "Số điện thoại";
            this.dgvSDT.MinimumWidth = 6;
            this.dgvSDT.Name = "dgvSDT";
            this.dgvSDT.Width = 125;
            // 
            // dgvEmail
            // 
            this.dgvEmail.DataPropertyName = "Email";
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 6;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.Width = 125;
            // 
            // dgvAnh
            // 
            this.dgvAnh.DataPropertyName = "Anh";
            this.dgvAnh.HeaderText = "Ảnh";
            this.dgvAnh.MinimumWidth = 6;
            this.dgvAnh.Name = "dgvAnh";
            this.dgvAnh.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.picAnhNV);
            this.groupBox1.Controls.Add(this.btnAnhNV);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(899, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(312, 134);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(51, 23);
            this.rdbNu.TabIndex = 7;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(231, 134);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(62, 23);
            this.rdbNam.TabIndex = 7;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // picAnhNV
            // 
            this.picAnhNV.BackColor = System.Drawing.Color.Transparent;
            this.picAnhNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAnhNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhNV.Location = new System.Drawing.Point(627, 44);
            this.picAnhNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAnhNV.Name = "picAnhNV";
            this.picAnhNV.Size = new System.Drawing.Size(245, 190);
            this.picAnhNV.TabIndex = 6;
            this.picAnhNV.TabStop = false;
            // 
            // btnAnhNV
            // 
            this.btnAnhNV.Location = new System.Drawing.Point(700, 255);
            this.btnAnhNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnhNV.Name = "btnAnhNV";
            this.btnAnhNV.Size = new System.Drawing.Size(92, 37);
            this.btnAnhNV.TabIndex = 5;
            this.btnAnhNV.Text = "Chọn ảnh";
            this.btnAnhNV.UseVisualStyleBackColor = true;
            this.btnAnhNV.Click += new System.EventHandler(this.btnAnhNV_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(231, 293);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(353, 27);
            this.txtEmail.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(231, 250);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(353, 27);
            this.txtSDT.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(231, 207);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(353, 27);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(231, 164);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(353, 27);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(231, 94);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(353, 27);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(231, 44);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(353, 27);
            this.txtMaNV.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // FormQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 766);
            this.Controls.Add(this.pnThongTinNV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FormQLNhanVien_Load);
            this.pnThongTinNV.ResumeLayout(false);
            this.pnThongTinNV.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnThongTinNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAnhNV;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnAnhNV;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaDN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDN;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rdbNhanVien;
        private System.Windows.Forms.Button btnBoQuaTK;
        private System.Windows.Forms.RadioButton rdbQuanLy;
        private System.Windows.Forms.Button btnLuuTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnSuaTK;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAnh;
    }
}