namespace TelegramBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profiles", "Phone_number", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profiles", "Phone_number", c => c.String());
        }
    }
}
