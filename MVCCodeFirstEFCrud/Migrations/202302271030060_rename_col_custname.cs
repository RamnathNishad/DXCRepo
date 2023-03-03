namespace MVCCodeFirstEFCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rename_col_custname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_customer", "Name", c => c.String());
            DropColumn("dbo.tbl_customer", "CustName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_customer", "CustName", c => c.String());
            DropColumn("dbo.tbl_customer", "Name");
        }
    }
}
