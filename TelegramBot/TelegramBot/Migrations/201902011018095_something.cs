namespace TelegramBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class something : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkExperienses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Level = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkExperienses");
        }
    }
}
