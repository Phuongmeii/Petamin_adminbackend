namespace Nhom8_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateSanPham : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SanPhams", "LoaiSanPham");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SanPhams", "LoaiSanPham", c => c.String());
        }
    }
}
