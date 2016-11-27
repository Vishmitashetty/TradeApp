namespace TradeCSTDataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datatypechange : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Trades", "TransactionType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trades", "TransactionType", c => c.String(nullable: false, maxLength: 1));
        }
    }
}
