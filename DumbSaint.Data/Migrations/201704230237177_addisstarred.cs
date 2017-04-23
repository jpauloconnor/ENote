namespace DumbSaint.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addisstarred : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "IsStarred", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "IsStarred");
        }
    }
}
