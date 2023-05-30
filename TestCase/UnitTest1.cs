using NUnit.Framework;
using DAL;
using DTO;
using System;
using System.Data;
using System.Collections.Generic;
using Moq;
using BookStoreManagement;
using BLL;


namespace TestCase
{
    public class Tests
    {
        private TacGiaDAL tacGiaDAL;

        [SetUp]
        public void Setup()
        {
            tacGiaDAL = new TacGiaDAL();
        }

        [Test]
        public void LayTacGiaDAL_ReturnsDataTable()
        {
            // Arrange

            // Act
            DataTable result = tacGiaDAL.LayTacGiaDAL();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<DataTable>(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }

        [Test]
        public void CheckTacGia_ExistingMatg()
        {
            // Arrange
            string existingMatg = "TG01";

            // Act
            bool result = tacGiaDAL.CheckTacGia(existingMatg);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckTacGia_NonExistingMatg()
        {
            // Arrange
            string nonExistingMatg = "TG08";

            // Act
            bool result = tacGiaDAL.CheckTacGia(nonExistingMatg);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ThemTacGiaDAL_ValidData_ReturnsTrue()
        {
            // Arrange
            string matg = "TG999";
            string tentg = "Nguyen Van Test";
            string sdt = "123456789";

            // Act
            bool result = tacGiaDAL.ThemTacGiaDAL(matg, tentg, sdt);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void XoaTacGiaDAL_ExistingMatg_ReturnsTrue()
        {
            // Arrange
            string existingMatg = "TG999";

            // Act
            bool result = tacGiaDAL.XoaTacGiaDAL(existingMatg);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void SuaTacGiaDAL_ValidData_ReturnsTrue()
        {
            // Arrange
            string matg = "TG01";
            string newTentg = "Updated Tac Gia";
            string newSdt = "987654321";

            // Act
            bool result = tacGiaDAL.SuaTacGiaDAL(matg, newTentg, newSdt);

            // Assert
            Assert.IsTrue(result);
        }
    }
    public class Test2
    {
        private PhieuNhapDAL phieuNhapDAL;

        [SetUp]
        public void Setup()
        {
            phieuNhapDAL = new PhieuNhapDAL();
        }

        [Test]
        public void GetPhieuNhapList_ReturnsList()
        {
            // Arrange

            // Act
            var result = phieuNhapDAL.GetPhieuNhapList();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf(typeof(List<PhieuNhapDTO>), result);
            Assert.IsTrue(result.Count > 0);
        }

        [Test]
        public void AddPhieuNhap_ValidPhieuNhap_AddsToDatabase()
        {
            // Arrange
            PhieuNhapDTO phieuNhap = new PhieuNhapDTO
            {
                Mapn = "PN01",
                Ngaylap = DateTime.Now,
                Tongtien = 1000.0f
            };


            phieuNhapDAL.AddPhieuNhap(phieuNhap);


        }

        [Test]
        public void XoaPhieuNhap_ExistingMapn_ReturnsTrue()
        {
            // Arrange
            string existingMapn = "PN01";

            // Act
            bool result = phieuNhapDAL.XoaPhieuNhap(existingMapn);

            // Assert
            Assert.IsTrue(result);
            // You can further assert that the data with the specified 'mapn' is no longer present in the database
        }

        [Test]
        public void CheckMaPN_ExistingMapn_ReturnsFalse()
        {
            // Arrange
            string existingMapn = "PN001";

            // Act
            bool result = phieuNhapDAL.CheckMaPN(existingMapn);

            // Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckMaPN_ExistingMapn2_ReturnsFalse()
        {
            // Arrange
            string existingMapn = "PN01";

            // Act
            bool result = phieuNhapDAL.CheckMaPN(existingMapn);

            // Assert
            Assert.IsFalse(result);
        }
    }
    public class Test3
    {


        private ChiTietPhieuNhapDAL chiTietPhieuNhapDAL;

        [SetUp]
        public void SetUp()
        {

            chiTietPhieuNhapDAL = new ChiTietPhieuNhapDAL();
        }

        [Test]
        public void LayDSPhieuNhap_ReturnsDataTable()
        {
            // Arrange
            string mapn = "PN02";

            // Act
            DataTable dt = chiTietPhieuNhapDAL.LayDSPhieuNhap(mapn);

            // Assert
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [Test]
        public void AddChiTietPhieuNhap_ValidCTPN()
        {
            // Arrange
            ChiTietPhieuNhapDTO chiTietPhieuNhap = new ChiTietPhieuNhapDTO
            {
                Mapn = "PN02",
                Masach = "S04",
                Gianhap = 50000,
                Giaban = 80000,
                Soluong = 50
            };

            // Act
            chiTietPhieuNhapDAL.AddChiTietPhieuNhap(chiTietPhieuNhap);


        }

        [Test]
        public void XoaChiTietPhieuNhap_ReturnsTrue()
        {
            // Arrange
            string mapn = "PN01";
            string masach = "S01";

            // Act
            bool result = chiTietPhieuNhapDAL.XoaChiTietPhieuNhap(mapn, masach);

            // Assert
            Assert.IsTrue(result);

        }
    }
    public class Test5
    {
        private NXBDAL nxb;

        [SetUp]
        public void Setup()
        {
            nxb = new NXBDAL();
        }

        [Test]
        public void LayNXB()
        {
            // Arrange

            // Act
            DataTable result = nxb.LayDanhSachNXBDAL();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<DataTable>(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }

        [Test]
        public void CheckTacGia_RT()
        {
            // Arrange
            string existingMatg = "NXB01";

            // Act
            bool result = nxb.checkNXB(existingMatg);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckNXB_RF()
        {
            // Arrange
            string nonExistingMatg = "TG999";

            // Act
            bool result = nxb.checkNXB(nonExistingMatg);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ThemNXB_ValidData_ReturnsTrue()
        {
            // Arrange
            string matg = "NXB999";
            string tentg = "Nguyen Van Test";
            string dc = "HN";
            string sdt = "123456789";

            // Act
            bool result = nxb.ThemNXBDAL(matg, tentg, dc, sdt);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void XoaNXB_ExistingManxb_ReturnsTrue()
        {
            // Arrange
            string existingMatg = "NXB01";

            // Act
            bool result = nxb.XoaNXBDAL(existingMatg);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void SuaNXB_ValidData_ReturnsTrue()
        {
            // Arrange
            string matg = "NXB01";
            string newTentg = "Updated Tac Gia";
            string newSdt = "987654321";
            string dc = "HN";

            // Act
            bool result = nxb.SuaNXBDAL(matg, newTentg, dc, newSdt);

            // Assert
            Assert.IsTrue(result);
        }
    }
    public class Test6
    {
        private TheLoaiDAL tl;

        [SetUp]
        public void Setup()
        {
            tl = new TheLoaiDAL();
        }

        [Test]
        public void LayTL()
        {
            // Arrange

            // Act
            DataTable result = tl.LayTheLoaiDAL();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<DataTable>(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }

        [Test]
        public void CheckTL_RF()
        {
            // Arrange
            string existingMatg = "TL99";

            // Act
            bool result = tl.check(existingMatg);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void CheckTL_RT()
        {
            // Arrange
            string nonExistingMatg = "TL999";

            // Act
            bool result = tl.check(nonExistingMatg);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ThemTL_ValidData_ReturnsTrue()
        {
            // Arrange
            string matg = "TL999";
            string tentg = "Nguyen Van Test";

            // Act

            tl.ThemTheLoaiDAL(matg, tentg);
            // Assert

        }

        [Test]
        public void XoaTL_ExistingMatl_ReturnsTrue()
        {
            // Arrange
            string existingMatg = "TL999";

            // Act
            tl.XoaTheLoaiDAL(existingMatg);

            // Assert
        }

        [Test]
        public void SuaTL_ValidData_ReturnsTrue()
        {
            TheLoaiDTO dto = new TheLoaiDTO
            {
                Matl = "TL999",
                Tentl = "Nguyen Van Test",

            };
            // Arrange



            // Act
            tl.SuaTheLoaiDAL(dto);

            // Assert

        }
    }
    public class Test7
    {
        private NhanVienDAL nv;

        [SetUp]
        public void SetUp()
        {
            
            nv = new NhanVienDAL();
        }

        [Test]
        public void LayDanhSachNVDAL_ReturnsDataTable()
        {
            // Arrange

            // Act
            DataTable dt = nv.LayDanhSachNVDAL();

            // Assert
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count > 0);
        }

        [Test]
        public void CheckNV_ExistingManv_ReturnsFalse()
        {
            // Arrange
            string manv = "NV01"; 

            // Act
            bool result = nv.CheckNV(manv);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ThemNhanVienDAL_ValidNhanVien()
        {
            string anh = @"C:\Users\Admin\OneDrive\Pictures\Anh1.jpg";
            byte[] imageData = System.IO.File.ReadAllBytes(anh);
            // Arrange
            NhanVienDTO nvl = new NhanVienDTO
            {
                Manv = "NV001",
                Tennv = "Nguyen Van A",
                Gt = "Nam",
                Ngaysinh = new DateTime(1990, 1, 1),
                Diachi = "123 ABC",
                Sdt = "0123456789",
                Email = "abc@gmail.com",
                Anh = imageData,
            };

            // Act
            bool result = nv.ThemNhanVienDAL(nvl);

            // Assert
            Assert.IsTrue(result);
         
        }

        [Test]
        public void SuaNhanVienDAL_ValidNhanVien()
        {
            string anh = @"C:\Users\Admin\OneDrive\Pictures\Anh1.jpg"; 
            byte[] imageData = System.IO.File.ReadAllBytes(anh);
            // Arrange
            NhanVienDTO nvl = new NhanVienDTO
            {
                Manv = "NV001",
                Tennv = "Nguyen Van A - Updated",
                Gt = "Nam",
                Ngaysinh = new DateTime(1990, 1, 1),
                Diachi = "123 ABC",
                Sdt = "0123456789",
                Email = "abc@gmail.com",
                Anh = imageData
            };

            // Act
            nv.SuaNhanVienDAL(nvl);

        }

        [Test]
        public void XoaNhanVienDAL_ExistingManv()
        {
            // Arrange
            string manv = "NV001"; 

            // Act
            bool result = nv.XoaNhanVienDAL(manv);

          
            Assert.IsTrue(result);
         
        }

    }
}