namespace TelegramBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfilesandWorkExperiense : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Profiles", "City", c => c.Int(nullable: false));
            DropColumn("dbo.Profiles", "Work_experience");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profiles", "Work_experience", c => c.Int(nullable: false));
            DropColumn("dbo.Profiles", "City");
            DropColumn("dbo.Profiles", "Age");
        }
    }
}
