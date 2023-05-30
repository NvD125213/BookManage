namespace BookStoreManagement
{
    partial class FormHoaDon
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gp = new System.Windows.Forms.GroupBox();
            this.dgvDSCT = new System.Windows.Forms.DataGridView();
            this.dgvMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpNgayLapTK = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnLuuCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.dgvMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToanBo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCT)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtToanBo);
            this.panel1.Controls.Add(this.gp);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.dtpNgayLapTK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1777, 623);
            this.panel1.TabIndex = 0;
            // 
            // gp
            // 
            this.gp.Controls.Add(this.dgvDSCT);
            this.gp.Location = new System.Drawing.Point(1042, 335);
            this.gp.Name = "gp";
            this.gp.Size = new System.Drawing.Size(651, 282);
            this.gp.TabIndex = 8;
            this.gp.TabStop = false;
            this.gp.Text = "Danh sách chi tiết hóa đơn";
            // 
            // dgvDSCT
            // 
            this.dgvDSCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSach,
            this.dgvSoLuong,
            this.dgvThanhTien});
            this.dgvDSCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSCT.Location = new System.Drawing.Point(3, 23);
            this.dgvDSCT.Name = "dgvDSCT";
            this.dgvDSCT.RowHeadersWidth = 51;
            this.dgvDSCT.RowTemplate.Height = 24;
            this.dgvDSCT.Size = new System.Drawing.Size(645, 256);
            this.dgvDSCT.TabIndex = 0;
            // 
            // dgvMaSach
            // 
            this.dgvMaSach.DataPropertyName = "MaSach";
            this.dgvMaSach.HeaderText = "Mã sách";
            this.dgvMaSach.MinimumWidth = 6;
            this.dgvMaSach.Name = "dgvMaSach";
            this.dgvMaSach.Width = 125;
            // 
            // dgvSoLuong
            // 
            this.dgvSoLuong.DataPropertyName = "SoLuong";
            this.dgvSoLuong.HeaderText = "Số lượng";
            this.dgvSoLuong.MinimumWidth = 6;
            this.dgvSoLuong.Name = "dgvSoLuong";
            this.dgvSoLuong.Width = 125;
            // 
            // dgvThanhTien
            // 
            this.dgvThanhTien.DataPropertyName = "ThanhTien";
            this.dgvThanhTien.HeaderText = "Thành tiền";
            this.dgvThanhTien.MinimumWidth = 6;
            this.dgvThanhTien.Name = "dgvThanhTien";
            this.dgvThanhTien.Width = 125;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1457, 293);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 31);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpNgayLapTK
            // 
            this.dtpNgayLapTK.CustomFormat = "dd/MM//yyyy";
            this.dtpNgayLapTK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapTK.Location = new System.Drawing.Point(1150, 297);
            this.dtpNgayLapTK.Name = "dtpNgayLapTK";
            this.dtpNgayLapTK.Size = new System.Drawing.Size(290, 27);
            this.dtpNgayLapTK.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1056, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngày lập:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtGiaBan);
            this.groupBox4.Controls.Add(this.btnInHD);
            this.groupBox4.Controls.Add(this.btnLuuCT);
            this.groupBox4.Controls.Add(this.btnXoaCT);
            this.groupBox4.Controls.Add(this.btnThemCT);
            this.groupBox4.Controls.Add(this.nudSoLuong);
            this.groupBox4.Controls.Add(this.cboMaSach);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(1042, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(651, 268);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(303, 96);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(186, 27);
            this.txtGiaBan.TabIndex = 4;
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(415, 161);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(107, 45);
            this.btnInHD.TabIndex = 3;
            this.btnInHD.Text = "In ";
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnLuuCT
            // 
            this.btnLuuCT.Location = new System.Drawing.Point(291, 161);
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.Size = new System.Drawing.Size(107, 45);
            this.btnLuuCT.TabIndex = 3;
            this.btnLuuCT.Text = "Lưu";
            this.btnLuuCT.UseVisualStyleBackColor = true;
            this.btnLuuCT.Click += new System.EventHandler(this.btnLuuCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(161, 161);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(107, 45);
            this.btnXoaCT.TabIndex = 3;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Location = new System.Drawing.Point(29, 161);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(107, 45);
            this.btnThemCT.TabIndex = 3;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(134, 92);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(62, 34);
            this.nudSoLuong.TabIndex = 2;
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cboMaSach
            // 
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(134, 40);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(355, 27);
            this.cboMaSach.TabIndex = 1;
            this.cboMaSach.SelectedIndexChanged += new System.EventHandler(this.cboMaSach_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá bán:";
            this.label9.Click += new System.EventHandler(this.label8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số  lượng:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên sách:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSHD);
            this.groupBox3.Location = new System.Drawing.Point(520, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 609);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách hóa đơn";
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaHD,
            this.dgvMaNV,
            this.dgvMaKH,
            this.dgvNgayLap,
            this.dgvTongTien});
            this.dgvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHD.Location = new System.Drawing.Point(3, 23);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.RowHeadersWidth = 51;
            this.dgvDSHD.RowTemplate.Height = 24;
            this.dgvDSHD.Size = new System.Drawing.Size(510, 583);
            this.dgvDSHD.TabIndex = 0;
            this.dgvDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellClick);
            this.dgvDSHD.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSHD_CellFormatting);
            // 
            // dgvMaHD
            // 
            this.dgvMaHD.DataPropertyName = "MaHD";
            this.dgvMaHD.HeaderText = "Mã hóa đơn";
            this.dgvMaHD.MinimumWidth = 6;
            this.dgvMaHD.Name = "dgvMaHD";
            this.dgvMaHD.Width = 125;
            // 
            // dgvMaNV
            // 
            this.dgvMaNV.DataPropertyName = "MaNV";
            this.dgvMaNV.HeaderText = "Mã nhân viên";
            this.dgvMaNV.MinimumWidth = 6;
            this.dgvMaNV.Name = "dgvMaNV";
            this.dgvMaNV.Width = 125;
            // 
            // dgvMaKH
            // 
            this.dgvMaKH.DataPropertyName = "MaKH";
            this.dgvMaKH.HeaderText = "Mã khách hàng";
            this.dgvMaKH.MinimumWidth = 6;
            this.dgvMaKH.Name = "dgvMaKH";
            this.dgvMaKH.Width = 125;
            // 
            // dgvNgayLap
            // 
            this.dgvNgayLap.DataPropertyName = "NgayLap";
            this.dgvNgayLap.HeaderText = "Ngày lập";
            this.dgvNgayLap.MinimumWidth = 6;
            this.dgvNgayLap.Name = "dgvNgayLap";
            this.dgvNgayLap.Width = 125;
            // 
            // dgvTongTien
            // 
            this.dgvTongTien.DataPropertyName = "TongTien";
            this.dgvTongTien.HeaderText = "Tổng tiền";
            this.dgvTongTien.MinimumWidth = 6;
            this.dgvTongTien.Name = "dgvTongTien";
            this.dgvTongTien.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnBoQua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(11, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(24, 130);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(176, 82);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(264, 130);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(176, 82);
            this.btnBoQua.TabIndex = 0;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(264, 26);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(176, 82);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(24, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(176, 82);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Controls.Add(this.cboKhachHang);
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(159, 187);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(281, 27);
            this.dtpNgayLap.TabIndex = 3;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(159, 130);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(281, 27);
            this.cboKhachHang.TabIndex = 2;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(159, 81);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(281, 27);
            this.cboNhanVien.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(159, 236);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(281, 27);
            this.txtTongTien.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(159, 35);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(281, 27);
            this.txtMaHD.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhân viên lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // txtToanBo
            // 
            this.txtToanBo.Location = new System.Drawing.Point(1570, 293);
            this.txtToanBo.Name = "txtToanBo";
            this.txtToanBo.Size = new System.Drawing.Size(120, 31);
            this.txtToanBo.TabIndex = 9;
            this.txtToanBo.Text = "Toàn bộ";
            this.txtToanBo.UseVisualStyleBackColor = true;
            this.txtToanBo.Click += new System.EventHandler(this.txtToanBo_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1828, 760);
            this.Controls.Add(this.panel1);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCT)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gp;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtpNgayLapTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnLuuCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.DataGridView dgvDSCT;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvThanhTien;
        private System.Windows.Forms.Button txtToanBo;
    }
}