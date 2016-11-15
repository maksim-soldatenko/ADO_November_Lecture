namespace Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConcurrency : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "RowVersion");
        }
    }
}
