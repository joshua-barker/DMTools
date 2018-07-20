namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoveAbilityModifiersToMonster : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Monsters", "AbilityModifiersId", "dbo.AbilityModifiers");
            DropIndex("dbo.Monsters", new[] { "AbilityModifiersId" });
            AddColumn("dbo.Monsters", "StrengthModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "DexterityModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "ConstitutionModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "IntelligenceModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "WisdomModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "CharismaModifier", c => c.Int(nullable: false));
            DropColumn("dbo.Monsters", "AbilityModifiersId");
            DropTable("dbo.AbilityModifiers");
        }
        
        public override void Down()
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
                        MonsterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AbilityModifiersId);
            
            AddColumn("dbo.Monsters", "AbilityModifiersId", c => c.Int(nullable: false));
            DropColumn("dbo.Monsters", "CharismaModifier");
            DropColumn("dbo.Monsters", "WisdomModifier");
            DropColumn("dbo.Monsters", "IntelligenceModifier");
            DropColumn("dbo.Monsters", "ConstitutionModifier");
            DropColumn("dbo.Monsters", "DexterityModifier");
            DropColumn("dbo.Monsters", "StrengthModifier");
            CreateIndex("dbo.Monsters", "AbilityModifiersId");
            AddForeignKey("dbo.Monsters", "AbilityModifiersId", "dbo.AbilityModifiers", "AbilityModifiersId", cascadeDelete: true);
        }
    }
}
