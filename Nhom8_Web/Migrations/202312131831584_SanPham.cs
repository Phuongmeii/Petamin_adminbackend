namespace Nhom8_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SanPham : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenBlog = c.String(maxLength: 200),
                        NoiDung = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DichVus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenDichVu = c.String(maxLength: 200),
                        SoLuong = c.Int(nullable: false),
                        MoTa = c.String(),
                        GiaTien = c.String(),
                        HinhAnh = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ChiTietDonHangs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaHoaDon = c.Int(nullable: false),
                        MaSanPham = c.Int(nullable: false),
                        MaDichVu = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DichVus", t => t.MaDichVu, cascadeDelete: true)
                .ForeignKey("dbo.DonHangs", t => t.MaHoaDon, cascadeDelete: true)
                .ForeignKey("dbo.SanPhams", t => t.MaSanPham, cascadeDelete: true)
                .Index(t => t.MaHoaDon)
                .Index(t => t.MaSanPham)
                .Index(t => t.MaDichVu);
            
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TrangThai = c.Int(nullable: false),
                        TrangThaiThanhToan = c.Int(nullable: false),
                        TongTien = c.Double(nullable: false),
                        NgayLap = c.DateTime(nullable: false),
                        MaKhachHang = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.KhachHangs", t => t.MaKhachHang)
                .Index(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HoVaTen = c.String(maxLength: 200),
                        Email = c.String(maxLength: 200),
                        DiaChi = c.String(maxLength: 200),
                        SDT = c.String(maxLength: 12),
                        HinhAnh = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(maxLength: 200),
                        LoaiSanPham = c.String(),
                        SoLuong = c.Int(nullable: false),
                        GiaTien = c.Int(nullable: false),
                        GiamGia = c.Int(nullable: false),
                        GiaBan = c.Int(nullable: false),
                        TrangThai = c.Int(nullable: false),
                        HinhAnh = c.Binary(),
                        LoaiSanPhamID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LoaiSanPhams", t => t.LoaiSanPhamID)
                .Index(t => t.LoaiSanPhamID);
            
            CreateTable(
                "dbo.LoaiSanPhams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietDonHangs", "MaSanPham", "dbo.SanPhams");
            DropForeignKey("dbo.SanPhams", "LoaiSanPhamID", "dbo.LoaiSanPhams");
            DropForeignKey("dbo.ChiTietDonHangs", "MaHoaDon", "dbo.DonHangs");
            DropForeignKey("dbo.DonHangs", "MaKhachHang", "dbo.KhachHangs");
            DropForeignKey("dbo.ChiTietDonHangs", "MaDichVu", "dbo.DichVus");
            DropIndex("dbo.SanPhams", new[] { "LoaiSanPhamID" });
            DropIndex("dbo.DonHangs", new[] { "MaKhachHang" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "MaDichVu" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "MaSanPham" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "MaHoaDon" });
            DropTable("dbo.LoaiSanPhams");
            DropTable("dbo.SanPhams");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DonHangs");
            DropTable("dbo.ChiTietDonHangs");
            DropTable("dbo.DichVus");
            DropTable("dbo.Blogs");
        }
    }
}
