namespace ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unknown : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoItems",
                c => new
                    {
                        ToDoItemID = c.Int(nullable: false, identity: true),
                        ToDoText = c.String(),
                        IsDone = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ToDoItemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToDoItems");
        }
    }
}
