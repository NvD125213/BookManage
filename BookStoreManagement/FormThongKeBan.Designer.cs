namespace BookStoreManagement
{
    partial class formTK
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThangEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpThangStart = new System.Windows.Forms.DateTimePicker();
            this.rdbThang = new System.Windows.Forms.RadioButton();
            this.rdbTL = new System.Windows.Forms.RadioButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 720);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.crystalReportViewer1);
            this.groupBox3.Location = new System.Drawing.Point(525, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1027, 679);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thống kê";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.btnThongKe);
            this.groupBox2.Location = new System.Drawing.Point(17, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 332);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa chọn chức năng";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(277, 88);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(123, 162);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Xuất excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnInTK_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(58, 88);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(123, 162);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "In thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTL);
            this.groupBox1.Controls.Add(this.rdbThang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpThangEnd);
            this.groupBox1.Controls.Add(this.dtpThangStart);
            this.groupBox1.Location = new System.Drawing.Point(17, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 327);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thống kê nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tháng kết thúc:";
            // 
            // dtpThangEnd
            // 
            this.dtpThangEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpThangEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangEnd.Location = new System.Drawing.Point(142, 86);
            this.dtpThangEnd.Name = "dtpThangEnd";
            this.dtpThangEnd.Size = new System.Drawing.Size(286, 27);
            this.dtpThangEnd.TabIndex = 1;
            // 
            // dtpThangStart
            // 
            this.dtpThangStart.CustomFormat = "dd/MM/yyyy";
            this.dtpThangStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangStart.Location = new System.Drawing.Point(142, 36);
            this.dtpThangStart.Name = "dtpThangStart";
            this.dtpThangStart.Size = new System.Drawing.Size(286, 27);
            this.dtpThangStart.TabIndex = 2;
            // 
            // rdbThang
            // 
            this.rdbThang.AutoSize = true;
            this.rdbThang.Location = new System.Drawing.Point(142, 156);
            this.rdbThang.Name = "rdbThang";
            this.rdbThang.Size = new System.Drawing.Size(99, 23);
            this.rdbThang.TabIndex = 4;
            this.rdbThang.TabStop = true;
            this.rdbThang.Text = "Doanh thu";
            this.rdbThang.UseVisualStyleBackColor = true;
            // 
            // rdbTL
            // 
            this.rdbTL.AutoSize = true;
            this.rdbTL.Location = new System.Drawing.Point(308, 156);
            this.rdbTL.Name = "rdbTL";
            this.rdbTL.Size = new System.Drawing.Size(119, 23);
            this.rdbTL.TabIndex = 4;
            this.rdbTL.TabStop = true;
            this.rdbTL.Text = "Từng thể loại";
            this.rdbTL.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 23);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1021, 653);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // formTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1627, 747);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formTK";
            this.Text = "FormThongKeBan";
            this.Load += new System.EventHandler(this.lvBangTK_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThangEnd;
        private System.Windows.Forms.DateTimePicker dtpThangStart;
        private System.Windows.Forms.RadioButton rdbTL;
        private System.Windows.Forms.RadioButton rdbThang;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}