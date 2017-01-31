namespace TradeData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class position1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        Ticker = c.String(nullable: false),
                        CUSIP = c.String(maxLength: 9),
                        ISIN = c.String(maxLength: 12),
                        SEDOL = c.String(maxLength: 7),
                        position = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PositionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Positions");
        }
    }
}
