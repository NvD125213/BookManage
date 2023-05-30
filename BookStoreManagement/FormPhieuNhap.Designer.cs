namespace BookStoreManagement
{
    partial class FormPhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.dgvMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvPN = new System.Windows.Forms.DataGridView();
            this.dgvMaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpNgayNhapTK = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.btnBoQuaCT = new System.Windows.Forms.Button();
            this.btnLuuCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.txtLoi = new System.Windows.Forms.Label();
            this.txtLoi2 = new System.Windows.Forms.Label();
            this.txtLoi3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 885);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvCTPN);
            this.groupBox5.Location = new System.Drawing.Point(434, 465);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1045, 302);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin chi tiết";
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSach,
            this.dgvGiaNhap,
            this.dgvGiaBan,
            this.dgvSoLuong});
            this.dgvCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPN.Location = new System.Drawing.Point(3, 23);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.RowHeadersWidth = 51;
            this.dgvCTPN.RowTemplate.Height = 24;
            this.dgvCTPN.Size = new System.Drawing.Size(1039, 276);
            this.dgvCTPN.TabIndex = 0;
            this.dgvCTPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPN_CellClick);
            // 
            // dgvMaSach
            // 
            this.dgvMaSach.DataPropertyName = "MaSach";
            this.dgvMaSach.HeaderText = "Mã sách";
            this.dgvMaSach.MinimumWidth = 6;
            this.dgvMaSach.Name = "dgvMaSach";
            this.dgvMaSach.Width = 125;
            // 
            // dgvGiaNhap
            // 
            this.dgvGiaNhap.DataPropertyName = "GiaNhap";
            this.dgvGiaNhap.HeaderText = "Giá nhập";
            this.dgvGiaNhap.MinimumWidth = 6;
            this.dgvGiaNhap.Name = "dgvGiaNhap";
            this.dgvGiaNhap.Width = 125;
            // 
            // dgvGiaBan
            // 
            this.dgvGiaBan.DataPropertyName = "GiaBan";
            this.dgvGiaBan.HeaderText = "Giá bán";
            this.dgvGiaBan.MinimumWidth = 6;
            this.dgvGiaBan.Name = "dgvGiaBan";
            this.dgvGiaBan.Width = 125;
            // 
            // dgvSoLuong
            // 
            this.dgvSoLuong.DataPropertyName = "SoLuong";
            this.dgvSoLuong.HeaderText = "Số lượng";
            this.dgvSoLuong.MinimumWidth = 6;
            this.dgvSoLuong.Name = "dgvSoLuong";
            this.dgvSoLuong.Width = 125;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPN);
            this.groupBox4.Location = new System.Drawing.Point(3, 465);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 302);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phiếu nhập";
            // 
            // dgvPN
            // 
            this.dgvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaPN,
            this.dgvNgayLap,
            this.dgvTongTien});
            this.dgvPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPN.Location = new System.Drawing.Point(3, 23);
            this.dgvPN.Name = "dgvPN";
            this.dgvPN.RowHeadersWidth = 51;
            this.dgvPN.RowTemplate.Height = 24;
            this.dgvPN.Size = new System.Drawing.Size(419, 276);
            this.dgvPN.TabIndex = 0;
            this.dgvPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN_CellClick);
            this.dgvPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN_CellContentClick);
            // 
            // dgvMaPN
            // 
            this.dgvMaPN.DataPropertyName = "MaPN";
            this.dgvMaPN.HeaderText = "Mã phiếu nhập";
            this.dgvMaPN.MinimumWidth = 6;
            this.dgvMaPN.Name = "dgvMaPN";
            this.dgvMaPN.Width = 125;
            // 
            // dgvNgayLap
            // 
            this.dgvNgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.dgvNgayLap.DefaultCellStyle = dataGridViewCellStyle1;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpNgayNhapTK);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Location = new System.Drawing.Point(1093, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 429);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // dtpNgayNhapTK
            // 
            this.dtpNgayNhapTK.Location = new System.Drawing.Point(115, 44);
            this.dtpNgayNhapTK.Name = "dtpNgayNhapTK";
            this.dtpNgayNhapTK.Size = new System.Drawing.Size(252, 27);
            this.dtpNgayNhapTK.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngày lập:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(115, 106);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(132, 49);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLoi3);
            this.groupBox2.Controls.Add(this.txtLoi2);
            this.groupBox2.Controls.Add(this.txtLoi);
            this.groupBox2.Controls.Add(this.nudSoLuong);
            this.groupBox2.Controls.Add(this.cboMaSach);
            this.groupBox2.Controls.Add(this.txtGiaBan);
            this.groupBox2.Controls.Add(this.btnBoQuaCT);
            this.groupBox2.Controls.Add(this.btnLuuCT);
            this.groupBox2.Controls.Add(this.btnXoaCT);
            this.groupBox2.Controls.Add(this.btnThemCT);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(434, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 429);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(163, 221);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(272, 27);
            this.nudSoLuong.TabIndex = 3;
            this.nudSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudSoLuong_KeyPress);
            // 
            // cboMaSach
            // 
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(163, 47);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(272, 27);
            this.cboMaSach.TabIndex = 2;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(163, 162);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(272, 27);
            this.txtGiaBan.TabIndex = 1;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // btnBoQuaCT
            // 
            this.btnBoQuaCT.Location = new System.Drawing.Point(486, 281);
            this.btnBoQuaCT.Name = "btnBoQuaCT";
            this.btnBoQuaCT.Size = new System.Drawing.Size(132, 49);
            this.btnBoQuaCT.TabIndex = 1;
            this.btnBoQuaCT.Text = "Bỏ qua";
            this.btnBoQuaCT.UseVisualStyleBackColor = true;
            // 
            // btnLuuCT
            // 
            this.btnLuuCT.Location = new System.Drawing.Point(486, 199);
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.Size = new System.Drawing.Size(132, 49);
            this.btnLuuCT.TabIndex = 1;
            this.btnLuuCT.Text = "Lưu";
            this.btnLuuCT.UseVisualStyleBackColor = true;
            this.btnLuuCT.Click += new System.EventHandler(this.btnLuuCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Location = new System.Drawing.Point(486, 117);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(132, 49);
            this.btnXoaCT.TabIndex = 1;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Location = new System.Drawing.Point(486, 35);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(132, 49);
            this.btnThemCT.TabIndex = 1;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(163, 100);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(272, 27);
            this.txtGiaNhap.TabIndex = 1;
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng:";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá bán:";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá nhập:";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã sách:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBoQua);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox1.Location = new System.Drawing.Point(3, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(425, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(241, 325);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(132, 49);
            this.btnBoQua.TabIndex = 1;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(241, 251);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(132, 49);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(49, 325);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 49);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(49, 251);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 49);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(140, 100);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(253, 27);
            this.dtpNgayLap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày lập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(140, 162);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(253, 27);
            this.txtTongTien.TabIndex = 2;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(140, 47);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(253, 27);
            this.txtMaPhieuNhap.TabIndex = 2;
            // 
            // txtLoi
            // 
            this.txtLoi.AutoSize = true;
            this.txtLoi.ForeColor = System.Drawing.Color.Red;
            this.txtLoi.Location = new System.Drawing.Point(161, 133);
            this.txtLoi.Name = "txtLoi";
            this.txtLoi.Size = new System.Drawing.Size(155, 19);
            this.txtLoi.TabIndex = 4;
            this.txtLoi.Text = "*Vui lòng chỉ nhập số";
            // 
            // txtLoi2
            // 
            this.txtLoi2.AutoSize = true;
            this.txtLoi2.ForeColor = System.Drawing.Color.Red;
            this.txtLoi2.Location = new System.Drawing.Point(161, 192);
            this.txtLoi2.Name = "txtLoi2";
            this.txtLoi2.Size = new System.Drawing.Size(155, 19);
            this.txtLoi2.TabIndex = 4;
            this.txtLoi2.Text = "*Vui lòng chỉ nhập số";
            this.txtLoi2.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // txtLoi3
            // 
            this.txtLoi3.AutoSize = true;
            this.txtLoi3.ForeColor = System.Drawing.Color.Red;
            this.txtLoi3.Location = new System.Drawing.Point(161, 251);
            this.txtLoi3.Name = "txtLoi3";
            this.txtLoi3.Size = new System.Drawing.Size(155, 19);
            this.txtLoi3.TabIndex = 4;
            this.txtLoi3.Text = "*Vui lòng chỉ nhập số";
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 913);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPhieuNhap";
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Button btnBoQuaCT;
        private System.Windows.Forms.Button btnLuuCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvPN;
        private System.Windows.Forms.DateTimePicker dtpNgayNhapTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTongTien;
        private System.Windows.Forms.Label txtLoi3;
        private System.Windows.Forms.Label txtLoi2;
        private System.Windows.Forms.Label txtLoi;
    }
}