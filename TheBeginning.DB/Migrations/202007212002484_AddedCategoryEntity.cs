namespace TheBeginning.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCategoryEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ProductEntities", "CategoryEntityID", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductEntities", "CategoryEntityID");
            AddForeignKey("dbo.ProductEntities", "CategoryEntityID", "dbo.CategoryEntities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductEntities", "CategoryEntityID", "dbo.CategoryEntities");
            DropIndex("dbo.ProductEntities", new[] { "CategoryEntityID" });
            DropColumn("dbo.ProductEntities", "CategoryEntityID");
            DropTable("dbo.CategoryEntities");
        }
    }
}
