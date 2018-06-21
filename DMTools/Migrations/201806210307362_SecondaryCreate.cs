namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondaryCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        EquipmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Monster_Id = c.Int(),
                    })
                .PrimaryKey(t => t.EquipmentId)
                .ForeignKey("dbo.Monsters", t => t.Monster_Id)
                .Index(t => t.Monster_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipments", "Monster_Id", "dbo.Monsters");
            DropIndex("dbo.Equipments", new[] { "Monster_Id" });
            DropTable("dbo.Equipments");
        }
    }
}
