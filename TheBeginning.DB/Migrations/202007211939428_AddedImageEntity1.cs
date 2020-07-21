namespace TheBeginning.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImageEntity1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductEntities", "ImageEntity_Id", "dbo.ImageEntities");
            DropIndex("dbo.ProductEntities", new[] { "ImageEntity_Id" });
            RenameColumn(table: "dbo.ProductEntities", name: "ImageEntity_Id", newName: "ImageEntityID");
            AlterColumn("dbo.ProductEntities", "ImageEntityID", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductEntities", "ImageEntityID");
            AddForeignKey("dbo.ProductEntities", "ImageEntityID", "dbo.ImageEntities", "Id", cascadeDelete: true);
            DropColumn("dbo.ProductEntities", "ProductID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductEntities", "ProductID", c => c.Int(nullable: false));
            DropForeignKey("dbo.ProductEntities", "ImageEntityID", "dbo.ImageEntities");
            DropIndex("dbo.ProductEntities", new[] { "ImageEntityID" });
            AlterColumn("dbo.ProductEntities", "ImageEntityID", c => c.Int());
            RenameColumn(table: "dbo.ProductEntities", name: "ImageEntityID", newName: "ImageEntity_Id");
            CreateIndex("dbo.ProductEntities", "ImageEntity_Id");
            AddForeignKey("dbo.ProductEntities", "ImageEntity_Id", "dbo.ImageEntities", "Id");
        }
    }
}
