namespace TheBeginning.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImageEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageUrls = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ProductEntities", "ProductID", c => c.Int(nullable: false));
            AddColumn("dbo.ProductEntities", "ImageEntity_Id", c => c.Int());
            CreateIndex("dbo.ProductEntities", "ImageEntity_Id");
            AddForeignKey("dbo.ProductEntities", "ImageEntity_Id", "dbo.ImageEntities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductEntities", "ImageEntity_Id", "dbo.ImageEntities");
            DropIndex("dbo.ProductEntities", new[] { "ImageEntity_Id" });
            DropColumn("dbo.ProductEntities", "ImageEntity_Id");
            DropColumn("dbo.ProductEntities", "ProductID");
            DropTable("dbo.ImageEntities");
        }
    }
}
