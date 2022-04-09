namespace FlyCart.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialized : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        CatagoryID = c.Int(nullable: false),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Images = c.String(),
                        Stock = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Catagories", t => t.CatagoryID, cascadeDelete: true)
                .Index(t => t.CatagoryID);
            
            CreateTable(
                "dbo.ProductOptions",
                c => new
                    {
                        ProductOptionID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        MyProperty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductOptionID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Billing_Address = c.String(),
                        Shippig_Address = c.String(),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.OptionGroups",
                c => new
                    {
                        OptionGroupID = c.Int(nullable: false, identity: true),
                        OptionGroupName = c.String(),
                        ProductOptionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OptionGroupID)
                .ForeignKey("dbo.ProductOptions", t => t.ProductOptionID, cascadeDelete: true)
                .Index(t => t.ProductOptionID);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        OptionID = c.Int(nullable: false, identity: true),
                        GroupID = c.Int(nullable: false),
                        OptionName = c.String(),
                    })
                .PrimaryKey(t => t.OptionID)
                .ForeignKey("dbo.OptionGroups", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false),
                        OrderStatus = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OptionGroups", "ProductOptionID", "dbo.ProductOptions");
            DropForeignKey("dbo.Options", "GroupID", "dbo.OptionGroups");
            DropForeignKey("dbo.ProductOptions", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CatagoryID", "dbo.Catagories");
            DropIndex("dbo.Options", new[] { "GroupID" });
            DropIndex("dbo.OptionGroups", new[] { "ProductOptionID" });
            DropIndex("dbo.ProductOptions", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "CatagoryID" });
            DropTable("dbo.Orders");
            DropTable("dbo.Options");
            DropTable("dbo.OptionGroups");
            DropTable("dbo.Customers");
            DropTable("dbo.ProductOptions");
            DropTable("dbo.Products");
            DropTable("dbo.Catagories");
        }
    }
}
