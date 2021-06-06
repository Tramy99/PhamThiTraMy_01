namespace PhamThiTraMy_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LopHocs",
                c => new
                    {
                        MaLop = c.Int(nullable: false, identity: true),
                        TenLop = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaLop);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 20, unicode:false),
                        HoTen = c.String(maxLength: 50),
                        MaLop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSinhVien)
                .ForeignKey("dbo.LopHocs", t => t.MaLop, cascadeDelete: true)
                .Index(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "MaLop", "dbo.LopHocs");
            DropIndex("dbo.SinhViens", new[] { "MaLop" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.LopHocs");
        }
    }
}
