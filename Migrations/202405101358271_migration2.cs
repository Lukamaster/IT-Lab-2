namespace IT_Lab_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EventModels", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.EventModels", "Location", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EventModels", "Location", c => c.String());
            AlterColumn("dbo.EventModels", "Name", c => c.String());
        }
    }
}
