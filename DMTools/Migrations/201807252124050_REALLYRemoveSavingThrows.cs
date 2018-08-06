namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class REALLYRemoveSavingThrows : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.SavingThrows");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SavingThrows",
                c => new
                    {
                        SavingThrowsId = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.SavingThrowsId);
            
        }
    }
}
