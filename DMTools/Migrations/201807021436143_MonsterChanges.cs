namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MonsterChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "Group_GroupId", "dbo.Groups");
            DropIndex("dbo.Players", new[] { "Group_GroupId" });
            RenameColumn(table: "dbo.Players", name: "Group_GroupId", newName: "GroupId");
            AlterColumn("dbo.Players", "GroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.Players", "GroupId");
            AddForeignKey("dbo.Players", "GroupId", "dbo.Groups", "GroupId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "GroupId", "dbo.Groups");
            DropIndex("dbo.Players", new[] { "GroupId" });
            AlterColumn("dbo.Players", "GroupId", c => c.Int());
            RenameColumn(table: "dbo.Players", name: "GroupId", newName: "Group_GroupId");
            CreateIndex("dbo.Players", "Group_GroupId");
            AddForeignKey("dbo.Players", "Group_GroupId", "dbo.Groups", "GroupId");
        }
    }
}
