namespace TradeCSTDataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedvalueofabc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trades", "Maturity", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trades", "Maturity", c => c.DateTime(nullable: false));
        }
    }
}
