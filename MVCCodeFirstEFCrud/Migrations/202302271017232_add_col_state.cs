namespace MVCCodeFirstEFCrud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_col_state : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_customer", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_customer", "State");
        }
    }
}
