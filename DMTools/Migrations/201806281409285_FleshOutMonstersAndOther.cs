namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FleshOutMonstersAndOther : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbilityModifiers",
                c => new
                    {
                        AbilityModifiersId = c.Int(nullable: false, identity: true),
                        StrengthModifier = c.Int(nullable: false),
                        DexterityModifier = c.Int(nullable: false),
                        ConstitutionModifier = c.Int(nullable: false),
                        IntelligenceModifier = c.Int(nullable: false),
                        WisdomModifier = c.Int(nullable: false),
                        CharismaModifier = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AbilityModifiersId);
            
            AddColumn("dbo.Equipments", "Description", c => c.String());
            AddColumn("dbo.Equipments", "IsMagical", c => c.Boolean(nullable: false));
            AddColumn("dbo.Equipments", "EquipmentType", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "Description", c => c.String());
            AddColumn("dbo.Monsters", "Backstory", c => c.String());
            AddColumn("dbo.Monsters", "ExperienceForKilling", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "MaxHealth", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "CurrentHealth", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "Level", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "AbilityModifiersId", c => c.Int(nullable: false));
            CreateIndex("dbo.Monsters", "AbilityModifiersId");
            AddForeignKey("dbo.Monsters", "AbilityModifiersId", "dbo.AbilityModifiers", "AbilityModifiersId", cascadeDelete: true);
            DropColumn("dbo.Monsters", "Health");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Monsters", "Health", c => c.Int(nullable: false));
            DropForeignKey("dbo.Monsters", "AbilityModifiersId", "dbo.AbilityModifiers");
            DropIndex("dbo.Monsters", new[] { "AbilityModifiersId" });
            DropColumn("dbo.Monsters", "AbilityModifiersId");
            DropColumn("dbo.Monsters", "Level");
            DropColumn("dbo.Monsters", "CurrentHealth");
            DropColumn("dbo.Monsters", "MaxHealth");
            DropColumn("dbo.Monsters", "ExperienceForKilling");
            DropColumn("dbo.Monsters", "Backstory");
            DropColumn("dbo.Monsters", "Description");
            DropColumn("dbo.Equipments", "EquipmentType");
            DropColumn("dbo.Equipments", "IsMagical");
            DropColumn("dbo.Equipments", "Description");
            DropTable("dbo.AbilityModifiers");
        }
    }
}
