namespace BookStoreManagement
{
    partial class FormQLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.cboNXB = new System.Windows.Forms.ComboBox();
            this.btnTacGiaTimKiem = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtSlton = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTacGiaTimKiem = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiemSach = new System.Windows.Forms.Button();
            this.dgvMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnTimKiemSach);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1563, 708);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(163, 342);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(908, 27);
            this.txtTimKiem.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tìm kiếm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSSP);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 374);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1517, 289);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSach,
            this.dgvTenSach,
            this.dgvMaTL,
            this.dgvMaNXB,
            this.dgvMaTG,
            this.dgvSLT,
            this.dgvGiaBan});
            this.dgvDSSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSP.Location = new System.Drawing.Point(3, 22);
            this.dgvDSSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.RowHeadersWidth = 51;
            this.dgvDSSP.RowTemplate.Height = 24;
            this.dgvDSSP.Size = new System.Drawing.Size(1511, 265);
            this.dgvDSSP.TabIndex = 0;
            this.dgvDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellClick);
            this.dgvDSSP.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDSSP_EditingControlShowing);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTheLoai);
            this.groupBox1.Controls.Add(this.cboNXB);
            this.groupBox1.Controls.Add(this.btnTacGiaTimKiem);
            this.groupBox1.Controls.Add(this.btnBoQua);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.dgvTacGia);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtSlton);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtTacGiaTimKiem);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1517, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(572, 82);
            this.cboTheLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(227, 27);
            this.cboTheLoai.TabIndex = 9;
            this.cboTheLoai.SelectedIndexChanged += new System.EventHandler(this.cboTheLoai_SelectedIndexChanged);
            // 
            // cboNXB
            // 
            this.cboNXB.FormattingEnabled = true;
            this.cboNXB.Location = new System.Drawing.Point(572, 30);
            this.cboNXB.Margin = new System.Windows.Forms.Padding(4);
            this.cboNXB.Name = "cboNXB";
            this.cboNXB.Size = new System.Drawing.Size(227, 27);
            this.cboNXB.TabIndex = 9;
            // 
            // btnTacGiaTimKiem
            // 
            this.btnTacGiaTimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGiaTimKiem.Location = new System.Drawing.Point(1324, 28);
            this.btnTacGiaTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTacGiaTimKiem.Name = "btnTacGiaTimKiem";
            this.btnTacGiaTimKiem.Size = new System.Drawing.Size(97, 34);
            this.btnTacGiaTimKiem.TabIndex = 8;
            this.btnTacGiaTimKiem.Text = "Tìm";
            this.btnTacGiaTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(901, 249);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(97, 34);
            this.btnBoQua.TabIndex = 5;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(797, 249);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(97, 34);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(572, 249);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 34);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Location = new System.Drawing.Point(895, 83);
            this.dgvTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.RowHeadersWidth = 51;
            this.dgvTacGia.RowTemplate.Height = 24;
            this.dgvTacGia.Size = new System.Drawing.Size(526, 126);
            this.dgvTacGia.TabIndex = 6;
            this.dgvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellClick);
            this.dgvTacGia.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvTacGia_EditingControlShowing);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(685, 249);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 34);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sách:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(455, 249);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 34);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(171, 178);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(225, 27);
            this.txtGiaBan.TabIndex = 3;
            // 
            // txtSlton
            // 
            this.txtSlton.Location = new System.Drawing.Point(171, 134);
            this.txtSlton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSlton.Name = "txtSlton";
            this.txtSlton.Size = new System.Drawing.Size(225, 27);
            this.txtSlton.TabIndex = 3;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(171, 82);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(225, 27);
            this.txtTenSach.TabIndex = 3;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(572, 133);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(227, 27);
            this.txtTacGia.TabIndex = 3;
            // 
            // txtTacGiaTimKiem
            // 
            this.txtTacGiaTimKiem.Location = new System.Drawing.Point(1007, 30);
            this.txtTacGiaTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTacGiaTimKiem.Name = "txtTacGiaTimKiem";
            this.txtTacGiaTimKiem.Size = new System.Drawing.Size(311, 27);
            this.txtTacGiaTimKiem.TabIndex = 3;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(171, 33);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(225, 27);
            this.txtMaSach.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nhà xuất bản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thể loại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng tồn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tác giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(891, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm tác giả:";
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Location = new System.Drawing.Point(1077, 335);
            this.btnTimKiemSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Size = new System.Drawing.Size(97, 34);
            this.btnTimKiemSach.TabIndex = 5;
            this.btnTimKiemSach.Text = "Tìm";
            this.btnTimKiemSach.UseVisualStyleBackColor = true;
            // 
            // dgvMaSach
            // 
            this.dgvMaSach.DataPropertyName = "MaSach";
            this.dgvMaSach.HeaderText = "Mã sách";
            this.dgvMaSach.MinimumWidth = 6;
            this.dgvMaSach.Name = "dgvMaSach";
            this.dgvMaSach.Width = 125;
            // 
            // dgvTenSach
            // 
            this.dgvTenSach.DataPropertyName = "TenSach";
            this.dgvTenSach.HeaderText = "Tên sách";
            this.dgvTenSach.MinimumWidth = 6;
            this.dgvTenSach.Name = "dgvTenSach";
            this.dgvTenSach.Width = 125;
            // 
            // dgvMaTL
            // 
            this.dgvMaTL.DataPropertyName = "MaTL";
            this.dgvMaTL.HeaderText = "Mã thể loại";
            this.dgvMaTL.MinimumWidth = 6;
            this.dgvMaTL.Name = "dgvMaTL";
            this.dgvMaTL.Width = 125;
            // 
            // dgvMaNXB
            // 
            this.dgvMaNXB.DataPropertyName = "MaNXB";
            this.dgvMaNXB.HeaderText = "Mã NXB";
            this.dgvMaNXB.MinimumWidth = 6;
            this.dgvMaNXB.Name = "dgvMaNXB";
            this.dgvMaNXB.Width = 125;
            // 
            // dgvMaTG
            // 
            this.dgvMaTG.DataPropertyName = "MaTG";
            this.dgvMaTG.HeaderText = "Mã tác giả";
            this.dgvMaTG.MinimumWidth = 6;
            this.dgvMaTG.Name = "dgvMaTG";
            this.dgvMaTG.Width = 125;
            // 
            // dgvSLT
            // 
            this.dgvSLT.DataPropertyName = "SLTon";
            this.dgvSLT.HeaderText = "Số lượng tồn";
            this.dgvSLT.MinimumWidth = 6;
            this.dgvSLT.Name = "dgvSLT";
            this.dgvSLT.Width = 125;
            // 
            // dgvGiaBan
            // 
            this.dgvGiaBan.DataPropertyName = "GiaBan";
            this.dgvGiaBan.HeaderText = "Giá bán";
            this.dgvGiaBan.MinimumWidth = 6;
            this.dgvGiaBan.Name = "dgvGiaBan";
            this.dgvGiaBan.Width = 125;
            // 
            // FormQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1860, 783);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQLSanPham";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.FormQLSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSlton;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Button btnTacGiaTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.DataGridView dgvTacGia;
        private System.Windows.Forms.TextBox txtTacGiaTimKiem;
        private System.Windows.Forms.Button btnTimKiemSach;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.ComboBox cboNXB;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGiaBan;
    }
}