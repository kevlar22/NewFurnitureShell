namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kevin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.addresses",
                c => new
                    {
                        userID = c.String(nullable: false, maxLength: 128),
                        streetAddress = c.String(),
                        city = c.String(),
                        state = c.String(),
                        zip = c.Int(nullable: false),
                        aptNum = c.String(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.userID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.itemNeedRequests",
                c => new
                    {
                        requestId = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        category = c.String(),
                        minPrice = c.Int(nullable: false),
                        maxPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.requestId)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.itemsForSales",
                c => new
                    {
                        itemID = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        name = c.String(),
                        price = c.Int(nullable: false),
                        description = c.String(),
                        image = c.String(),
                        category = c.String(),
                    })
                .PrimaryKey(t => t.itemID)
                .ForeignKey("dbo.Users", t => t.userID, cascadeDelete: true)
                .Index(t => t.userID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        userName = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.itemsForSales", "userID", "dbo.Users");
            DropForeignKey("dbo.itemNeedRequests", "userId", "dbo.Users");
            DropForeignKey("dbo.addresses", "User_ID", "dbo.Users");
            DropIndex("dbo.itemsForSales", new[] { "userID" });
            DropIndex("dbo.itemNeedRequests", new[] { "userId" });
            DropIndex("dbo.addresses", new[] { "User_ID" });
            DropTable("dbo.Users");
            DropTable("dbo.itemsForSales");
            DropTable("dbo.itemNeedRequests");
            DropTable("dbo.addresses");
        }
    }
}
