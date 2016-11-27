namespace TradeCSTDataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CounterParties",
                c => new
                    {
                        CounterPartyId = c.Int(nullable: false, identity: true),
                        CounterPartyName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.CounterPartyId);
            
            CreateTable(
                "dbo.Trades",
                c => new
                    {
                        TradeId = c.Int(nullable: false, identity: true),
                        CounterPartyId = c.Int(nullable: false),
                        SecurityId = c.Int(nullable: false),
                        TransactionType = c.String(nullable: false, maxLength: 1),
                        Qty = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 15, scale: 6),
                        NetAmount = c.Decimal(nullable: false, precision: 15, scale: 6),
                        TradeDate = c.DateTime(nullable: false),
                        Maturity = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TradeId)
                .ForeignKey("dbo.CounterParties", t => t.CounterPartyId, cascadeDelete: true)
                .ForeignKey("dbo.Securities", t => t.SecurityId, cascadeDelete: true)
                .Index(t => t.CounterPartyId)
                .Index(t => t.SecurityId);
            
            CreateTable(
                "dbo.Securities",
                c => new
                    {
                        SecurityId = c.Int(nullable: false, identity: true),
                        CUSIP = c.String(maxLength: 9),
                        SEDOL = c.String(maxLength: 7),
                        ISIN = c.String(maxLength: 12),
                        SecName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.SecurityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trades", "SecurityId", "dbo.Securities");
            DropForeignKey("dbo.Trades", "CounterPartyId", "dbo.CounterParties");
            DropIndex("dbo.Trades", new[] { "SecurityId" });
            DropIndex("dbo.Trades", new[] { "CounterPartyId" });
            DropTable("dbo.Securities");
            DropTable("dbo.Trades");
            DropTable("dbo.CounterParties");
        }
    }
}
