namespace ManCave.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarMake = c.String(),
                        CarPic = c.String(),
                        CarInfo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodCuisine = c.String(),
                        FoodPic = c.String(),
                        FoodInfo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        TeamPic = c.String(),
                        TeamInfo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInterests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserInterestUserName = c.String(),
                        UserInterestSportId = c.Int(nullable: false),
                        UserInterestCarId = c.Int(nullable: false),
                        UserInterestFoodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserInterests");
            DropTable("dbo.Teams");
            DropTable("dbo.Foods");
            DropTable("dbo.Cars");
        }
    }
}
