namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupsPlayersAndModifyAbilityModifiers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                    })
                .PrimaryKey(t => t.GroupId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CharacterId = c.Int(nullable: false),
                        Group_GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.Monsters", t => t.CharacterId, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.Group_GroupId)
                .Index(t => t.CharacterId)
                .Index(t => t.Group_GroupId);
            
            AddColumn("dbo.Equipments", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Group_GroupId", "dbo.Groups");
            DropForeignKey("dbo.Players", "CharacterId", "dbo.Monsters");
            DropIndex("dbo.Players", new[] { "Group_GroupId" });
            DropIndex("dbo.Players", new[] { "CharacterId" });
            DropColumn("dbo.Equipments", "Discriminator");
            DropTable("dbo.Players");
            DropTable("dbo.Groups");
        }
    }
}
