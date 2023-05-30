namespace BookStoreManagement
{
    partial class FormThemTheLoai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSTL = new System.Windows.Forms.DataGridView();
            this.dgvMaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBoQuaTL = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 596);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBoQuaTL);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTenTheLoai);
            this.groupBox2.Controls.Add(this.txtMaTheLoai);
            this.groupBox2.Location = new System.Drawing.Point(28, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 249);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thể loại";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(448, 143);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 34);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(312, 143);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(174, 143);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(36, 143);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thể loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thể loại:";
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.Location = new System.Drawing.Point(157, 84);
            this.txtTenTheLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(494, 27);
            this.txtTenTheLoai.TabIndex = 0;
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.Location = new System.Drawing.Point(157, 42);
            this.txtMaTheLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(494, 27);
            this.txtMaTheLoai.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSTL);
            this.groupBox1.Location = new System.Drawing.Point(28, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 294);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thể loại";
            // 
            // dgvDSTL
            // 
            this.dgvDSTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaTheLoai,
            this.dgvTenTheLoai});
            this.dgvDSTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTL.Location = new System.Drawing.Point(3, 23);
            this.dgvDSTL.Name = "dgvDSTL";
            this.dgvDSTL.RowHeadersWidth = 51;
            this.dgvDSTL.RowTemplate.Height = 24;
            this.dgvDSTL.Size = new System.Drawing.Size(986, 268);
            this.dgvDSTL.TabIndex = 0;
            this.dgvDSTL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTL_CellClick);
            this.dgvDSTL.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTL_RowEnter);
            this.dgvDSTL.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDSTL_RowPrePaint);
            this.dgvDSTL.Click += new System.EventHandler(this.dgvDSTL_Click);
            // 
            // dgvMaTheLoai
            // 
            this.dgvMaTheLoai.DataPropertyName = "MaTL";
            this.dgvMaTheLoai.HeaderText = "Mã thể loại";
            this.dgvMaTheLoai.MinimumWidth = 6;
            this.dgvMaTheLoai.Name = "dgvMaTheLoai";
            this.dgvMaTheLoai.Width = 250;
            // 
            // dgvTenTheLoai
            // 
            this.dgvTenTheLoai.DataPropertyName = "TenTL";
            this.dgvTenTheLoai.HeaderText = "Tên thể loại";
            this.dgvTenTheLoai.MinimumWidth = 6;
            this.dgvTenTheLoai.Name = "dgvTenTheLoai";
            this.dgvTenTheLoai.Width = 250;
            // 
            // btnBoQuaTL
            // 
            this.btnBoQuaTL.Location = new System.Drawing.Point(576, 140);
            this.btnBoQuaTL.Name = "btnBoQuaTL";
            this.btnBoQuaTL.Size = new System.Drawing.Size(93, 37);
            this.btnBoQuaTL.TabIndex = 3;
            this.btnBoQuaTL.Text = "Bỏ qua";
            this.btnBoQuaTL.UseVisualStyleBackColor = true;
            this.btnBoQuaTL.Click += new System.EventHandler(this.btnBoQuaTL_Click);
            // 
            // FormThemTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1529, 862);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThemTheLoai";
            this.Text = "FormThemTheLoai";
            this.Load += new System.EventHandler(this.FormThemTheLoai_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTheLoai;
        private System.Windows.Forms.TextBox txtMaTheLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenTheLoai;
        private System.Windows.Forms.Button btnBoQuaTL;
    }
}