namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Monsters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Health = c.Int(nullable: false),
                        ArmorClass = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        ChallengeRating = c.Double(nullable: false),
                        IsLegendary = c.Boolean(nullable: false),
                        Strength = c.Int(nullable: false),
                        Dexterity = c.Int(nullable: false),
                        Constitution = c.Int(nullable: false),
                        Intelligence = c.Int(nullable: false),
                        Wisdom = c.Int(nullable: false),
                        Charisma = c.Int(nullable: false),
                        Size = c.Int(nullable: false),
                        Race = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Species = c.Int(nullable: false),
                        Alignment = c.Int(nullable: false),
                        SavingThrowsId = c.Int(nullable: false),
                        SkillsId = c.Int(nullable: false),
                        SensesId = c.Int(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SavingThrows", t => t.SavingThrowsId, cascadeDelete: true)
                .ForeignKey("dbo.Senses", t => t.SensesId, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.SkillsId, cascadeDelete: true)
                .Index(t => t.SavingThrowsId)
                .Index(t => t.SkillsId)
                .Index(t => t.SensesId);
            
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
            
            CreateTable(
                "dbo.Senses",
                c => new
                    {
                        SensesId = c.Int(nullable: false, identity: true),
                        HasBlindSight = c.Boolean(nullable: false),
                        HasDarkVision = c.Boolean(nullable: false),
                        HasTremorSense = c.Boolean(nullable: false),
                        HasTrueSight = c.Boolean(nullable: false),
                        HasMagicSense = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SensesId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillsId = c.Int(nullable: false, identity: true),
                        HasAthleticsProficiency = c.Boolean(nullable: false),
                        AthleticsModifier = c.Int(nullable: false),
                        HasAcrobaticsProficiency = c.Boolean(nullable: false),
                        AcrobaticsModifier = c.Int(nullable: false),
                        HasSleightOfHandProficiency = c.Boolean(nullable: false),
                        SleightOfHandModifier = c.Int(nullable: false),
                        HasStealthProficiency = c.Boolean(nullable: false),
                        StealthModifier = c.Int(nullable: false),
                        HasArcanaProficiency = c.Boolean(nullable: false),
                        ArcanaModifier = c.Int(nullable: false),
                        HasHistoryProficiency = c.Boolean(nullable: false),
                        HistoryModifer = c.Int(nullable: false),
                        HasInvestigationProficiency = c.Boolean(nullable: false),
                        InvestigationModifier = c.Int(nullable: false),
                        HasNatureProficiency = c.Boolean(nullable: false),
                        NatureModifier = c.Int(nullable: false),
                        HasReligionProficiency = c.Boolean(nullable: false),
                        ReligionModifier = c.Int(nullable: false),
                        HasAnimalHandlingProficiency = c.Boolean(nullable: false),
                        AnimalHandlingModifier = c.Int(nullable: false),
                        HasInsightProficiency = c.Boolean(nullable: false),
                        InsightModifier = c.Int(nullable: false),
                        HasMedicineProficiency = c.Boolean(nullable: false),
                        MedicineModifier = c.Int(nullable: false),
                        HasPerceptionProficiency = c.Boolean(nullable: false),
                        PerceptionModifier = c.Int(nullable: false),
                        HasSurvialProficiency = c.Boolean(nullable: false),
                        SurvivalModifier = c.Int(nullable: false),
                        HasDeceptionProficiency = c.Boolean(nullable: false),
                        DeceptionModifier = c.Int(nullable: false),
                        HasIntimidationProficiency = c.Boolean(nullable: false),
                        IntimidationModifier = c.Int(nullable: false),
                        HasPerformanceProficiency = c.Boolean(nullable: false),
                        PerformanceModifier = c.Int(nullable: false),
                        HasPersuasionProficiency = c.Boolean(nullable: false),
                        PersuasionModifier = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Monsters", "SkillsId", "dbo.Skills");
            DropForeignKey("dbo.Monsters", "SensesId", "dbo.Senses");
            DropForeignKey("dbo.Monsters", "SavingThrowsId", "dbo.SavingThrows");
            DropIndex("dbo.Monsters", new[] { "SensesId" });
            DropIndex("dbo.Monsters", new[] { "SkillsId" });
            DropIndex("dbo.Monsters", new[] { "SavingThrowsId" });
            DropTable("dbo.Skills");
            DropTable("dbo.Senses");
            DropTable("dbo.SavingThrows");
            DropTable("dbo.Monsters");
        }
    }
}
