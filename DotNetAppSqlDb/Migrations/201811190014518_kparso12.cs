namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kparso12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatchBuyertoSellers_Result",
                c => new
                    {
                        itemID = c.Int(nullable: false, identity: true),
                        sellerID = c.Int(nullable: false),
                        userID = c.Int(nullable: false),
                        name = c.String(),
                        price = c.Int(nullable: false),
                        description = c.String(),
                        image = c.String(),
                        category = c.String(),
                        buyerID = c.Int(),
                        buyerFirst = c.String(),
                    })
                .PrimaryKey(t => t.itemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MatchBuyertoSellers_Result");
        }
    }
}
