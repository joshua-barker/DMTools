namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MinorGroupChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Encounters",
                c => new
                    {
                        EncounterId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Group_GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.EncounterId)
                .ForeignKey("dbo.Groups", t => t.Group_GroupId)
                .Index(t => t.Group_GroupId);
            
            AddColumn("dbo.Players", "Encounter_EncounterId", c => c.Int());
            AddColumn("dbo.Monsters", "Encounter_EncounterId", c => c.Int());
            CreateIndex("dbo.Monsters", "Encounter_EncounterId");
            CreateIndex("dbo.Players", "Encounter_EncounterId");
            AddForeignKey("dbo.Monsters", "Encounter_EncounterId", "dbo.Encounters", "EncounterId");
            AddForeignKey("dbo.Players", "Encounter_EncounterId", "dbo.Encounters", "EncounterId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Encounters", "Group_GroupId", "dbo.Groups");
            DropForeignKey("dbo.Players", "Encounter_EncounterId", "dbo.Encounters");
            DropForeignKey("dbo.Monsters", "Encounter_EncounterId", "dbo.Encounters");
            DropIndex("dbo.Players", new[] { "Encounter_EncounterId" });
            DropIndex("dbo.Monsters", new[] { "Encounter_EncounterId" });
            DropIndex("dbo.Encounters", new[] { "Group_GroupId" });
            DropColumn("dbo.Monsters", "Encounter_EncounterId");
            DropColumn("dbo.Players", "Encounter_EncounterId");
            DropTable("dbo.Encounters");
        }
    }
}
