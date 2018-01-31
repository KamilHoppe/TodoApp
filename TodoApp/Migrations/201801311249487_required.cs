namespace TodoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Todoes", "Message", c => c.String(nullable: false));
            AlterColumn("dbo.Todoes", "Tittle", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Todoes", "Tittle", c => c.String(maxLength: 200));
            AlterColumn("dbo.Todoes", "Message", c => c.String());
        }
    }
}
