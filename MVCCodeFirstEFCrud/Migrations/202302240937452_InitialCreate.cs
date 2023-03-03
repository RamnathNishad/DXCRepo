namespace MVCCodeFirstEFCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_customer",
                c => new
                    {
                        CustId = c.Int(nullable: false, identity: true),
                        CustName = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.CustId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_customer");
        }
    }
}
