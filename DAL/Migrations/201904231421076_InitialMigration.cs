namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_cart_product",
                c => new
                    {
                        cln_card_id = c.Int(nullable: false),
                        cln_product_id = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.cln_card_id, t.cln_product_id })
                .ForeignKey("dbo.tbl_cart", t => t.cln_card_id, cascadeDelete: true)
                .ForeignKey("dbo.tbl_product", t => t.cln_product_id, cascadeDelete: true)
                .Index(t => t.cln_card_id)
                .Index(t => t.cln_product_id);
            
            CreateTable(
                "dbo.tbl_cart",
                c => new
                    {
                        cln_id = c.Int(nullable: false),
                        cln_quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cln_id)
                .ForeignKey("dbo.tbl_user", t => t.cln_id)
                .Index(t => t.cln_id);
            
            CreateTable(
                "dbo.tbl_user",
                c => new
                    {
                        cln_id = c.Int(nullable: false, identity: true),
                        cln_name = c.String(),
                        cln_password = c.String(),
                    })
                .PrimaryKey(t => t.cln_id);
            
            CreateTable(
                "dbo.tbl_product",
                c => new
                    {
                        cln_id = c.Int(nullable: false, identity: true),
                        cln_name = c.String(),
                        cln_description = c.String(),
                        cln_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.cln_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_cart_product", "cln_product_id", "dbo.tbl_product");
            DropForeignKey("dbo.tbl_cart_product", "cln_card_id", "dbo.tbl_cart");
            DropForeignKey("dbo.tbl_cart", "cln_id", "dbo.tbl_user");
            DropIndex("dbo.tbl_cart", new[] { "cln_id" });
            DropIndex("dbo.tbl_cart_product", new[] { "cln_product_id" });
            DropIndex("dbo.tbl_cart_product", new[] { "cln_card_id" });
            DropTable("dbo.tbl_product");
            DropTable("dbo.tbl_user");
            DropTable("dbo.tbl_cart");
            DropTable("dbo.tbl_cart_product");
        }
    }
}
