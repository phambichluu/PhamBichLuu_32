namespace PhamBichLuu_32.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TinhThanhs",
                c => new
                    {
                        MaTinhThanh = c.Int(nullable: false, identity: true),
                        TenTinhThanh = c.String(),
                    })
                .PrimaryKey(t => t.MaTinhThanh);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaTinhThanh = c.Int(nullable: false),
                        MaNhanVien = c.String(),
                        TenNhanVien = c.String(),
                    })
                .PrimaryKey(t => t.MaTinhThanh)
                .ForeignKey("dbo.TinhThanhs", t => t.MaTinhThanh)
                .Index(t => t.MaTinhThanh);
            
            DropTable("dbo.TinhThanhs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TinhThanhs",
                c => new
                    {
                        MaTinhThanh = c.Int(nullable: false, identity: true),
                        TenTinhThanh = c.String(),
                    })
                .PrimaryKey(t => t.MaTinhThanh);
            
            DropForeignKey("dbo.NhanViens", "MaTinhThanh", "dbo.TinhThanhs");
            DropIndex("dbo.NhanViens", new[] { "MaTinhThanh" });
            DropTable("dbo.NhanViens");
            DropTable("dbo.TinhThanhs");
        }
    }
}
