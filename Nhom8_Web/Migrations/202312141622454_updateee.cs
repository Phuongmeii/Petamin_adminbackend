namespace Nhom8_Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DichVus", "GiaTien", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DichVus", "GiaTien", c => c.String());
        }
    }
}
