using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using OfficeOpenXml;
using System.IO;

namespace BookStoreManagement
{
    public partial class formTK : Form
    {
        private TKHoaDonBLL tkbll = new TKHoaDonBLL();
        public formTK()
        {
            InitializeComponent();
        }

        private void lvBangTK_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ngays = dtpThangStart.Value;
            DateTime ngaye = dtpThangEnd.Value;
          
                if(rdbThang.Checked)
                {
                    
                    DataTable ds = tkbll.BaoCaoTKBLL(ngays, ngaye);
                    rptBaoCaoTK r = new rptBaoCaoTK();
                    r.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = r;
                }    
                else if (rdbTL.Checked)
                {
                    DataTable ds = tkbll.BaoCaoTLBLL(ngays, ngaye);
                    rptTheoTL r = new rptTheoTL();
                    r.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = r;
                }    
            
           

        }

     
        private void btnInTK_Click(object sender, EventArgs e)
        {
            DateTime ngaystart = dtpThangStart.Value; // Lấy giá trị từ DateTimePicker ngày bắt đầu
            DateTime ngayend = dtpThangEnd.Value; // Lấy giá trị từ DateTimePicker ngày kết thúc
          
            try
            {
                if (rdbThang.Checked)
                {

                    string filePath = @"D:\BookStoreManagement\BookStoreManagement\Excel\Thống kê.xlsx";
                    tkbll.ExportDataToExcel(ngaystart, ngayend, filePath);
                    DateTime ngays = dtpThangStart.Value;
                    DateTime ngaye = dtpThangEnd.Value;
                }
                else if (rdbTL.Checked)
                {
                    string filePath = @"D:\BookStoreManagement\BookStoreManagement\Excel\Thống kê.xlsx";
                    tkbll.ExportDataToExcelTheLoai(ngaystart, ngayend, filePath);
                    DateTime ngays = dtpThangStart.Value;
                    DateTime ngaye = dtpThangEnd.Value;
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn mục xem!");
            }
        }
    }
}
