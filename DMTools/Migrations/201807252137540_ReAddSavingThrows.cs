namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReAddSavingThrows : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SavingThrows",
                c => new
                    {
                        SavingThrowsId = c.Int(nullable: false),
                        HasStrengthSavingThrow = c.Boolean(nullable: false),
                        StrengthSavingThrowModifier = c.Int(nullable: false),
                        HasDexteritySavingThrow = c.Boolean(nullable: false),
                        DexteritySavingThrowModifier = c.Int(nullable: false),
                        HasConstitutionSavingThrow = c.Boolean(nullable: false),
                        ConstitutionSavingThrowModifier = c.Int(nullable: false),
                        HasIntelligenceSavingThrow = c.Boolean(nullable: false),
                        IntelligenceSavingThrowModifier = c.Int(nullable: false),
                        HasWisdomSavingThrow = c.Boolean(nullable: false),
                        WisdomSavingThrowModifier = c.Int(nullable: false),
                        HasCharismaSavingThrow = c.Boolean(nullable: false),
                        CharismaSavingThrowModifier = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SavingThrowsId)
                .ForeignKey("dbo.Monsters", t => t.SavingThrowsId)
                .Index(t => t.SavingThrowsId);
            
            AddColumn("dbo.Monsters", "SavingThrowsId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SavingThrows", "SavingThrowsId", "dbo.Monsters");
            DropIndex("dbo.SavingThrows", new[] { "SavingThrowsId" });
            DropColumn("dbo.Monsters", "SavingThrowsId");
            DropTable("dbo.SavingThrows");
        }
    }
}
