namespace Nhom8_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChiTietDonHang : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ChiTietDonHangs", "MaDichVu", "dbo.DichVus");
            DropForeignKey("dbo.ChiTietDonHangs", "MaHoaDon", "dbo.DonHangs");
            DropForeignKey("dbo.ChiTietDonHangs", "MaSanPham", "dbo.SanPhams");
            DropIndex("dbo.ChiTietDonHangs", new[] { "MaHoaDon" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "MaSanPham" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "MaDichVu" });
            RenameColumn(table: "dbo.ChiTietDonHangs", name: "MaDichVu", newName: "DichVuID");
            RenameColumn(table: "dbo.ChiTietDonHangs", name: "MaHoaDon", newName: "DonHangID");
            RenameColumn(table: "dbo.ChiTietDonHangs", name: "MaSanPham", newName: "SanPhamID");
            RenameColumn(table: "dbo.DonHangs", name: "MaKhachHang", newName: "KhachHangID");
            RenameIndex(table: "dbo.DonHangs", name: "IX_MaKhachHang", newName: "IX_KhachHangID");
            AlterColumn("dbo.ChiTietDonHangs", "DonHangID", c => c.Int());
            AlterColumn("dbo.ChiTietDonHangs", "SanPhamID", c => c.Int());
            AlterColumn("dbo.ChiTietDonHangs", "DichVuID", c => c.Int());
            CreateIndex("dbo.ChiTietDonHangs", "DonHangID");
            CreateIndex("dbo.ChiTietDonHangs", "SanPhamID");
            CreateIndex("dbo.ChiTietDonHangs", "DichVuID");
            AddForeignKey("dbo.ChiTietDonHangs", "DichVuID", "dbo.DichVus", "ID");
            AddForeignKey("dbo.ChiTietDonHangs", "DonHangID", "dbo.DonHangs", "ID");
            AddForeignKey("dbo.ChiTietDonHangs", "SanPhamID", "dbo.SanPhams", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietDonHangs", "SanPhamID", "dbo.SanPhams");
            DropForeignKey("dbo.ChiTietDonHangs", "DonHangID", "dbo.DonHangs");
            DropForeignKey("dbo.ChiTietDonHangs", "DichVuID", "dbo.DichVus");
            DropIndex("dbo.ChiTietDonHangs", new[] { "DichVuID" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "SanPhamID" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "DonHangID" });
            AlterColumn("dbo.ChiTietDonHangs", "DichVuID", c => c.Int(nullable: false));
            AlterColumn("dbo.ChiTietDonHangs", "SanPhamID", c => c.Int(nullable: false));
            AlterColumn("dbo.ChiTietDonHangs", "DonHangID", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.DonHangs", name: "IX_KhachHangID", newName: "IX_MaKhachHang");
            RenameColumn(table: "dbo.DonHangs", name: "KhachHangID", newName: "MaKhachHang");
            RenameColumn(table: "dbo.ChiTietDonHangs", name: "SanPhamID", newName: "MaSanPham");
            RenameColumn(table: "dbo.ChiTietDonHangs", name: "DonHangID", newName: "MaHoaDon");
            RenameColumn(table: "dbo.ChiTietDonHangs", name: "DichVuID", newName: "MaDichVu");
            CreateIndex("dbo.ChiTietDonHangs", "MaDichVu");
            CreateIndex("dbo.ChiTietDonHangs", "MaSanPham");
            CreateIndex("dbo.ChiTietDonHangs", "MaHoaDon");
            AddForeignKey("dbo.ChiTietDonHangs", "MaSanPham", "dbo.SanPhams", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ChiTietDonHangs", "MaHoaDon", "dbo.DonHangs", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ChiTietDonHangs", "MaDichVu", "dbo.DichVus", "ID", cascadeDelete: true);
        }
    }
}
