namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConsolidateMonsterStats : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SavingThrows", "SavingThrowsId", "dbo.Monsters");
            DropForeignKey("dbo.Senses", "SensesId", "dbo.Monsters");
            DropForeignKey("dbo.Skills", "SkillsId", "dbo.Monsters");
            DropIndex("dbo.SavingThrows", new[] { "SavingThrowsId" });
            DropIndex("dbo.Senses", new[] { "SensesId" });
            DropIndex("dbo.Skills", new[] { "SkillsId" });
            AddColumn("dbo.Monsters", "HasStrengthSavingThrow", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "StrengthSavingThrowModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasDexteritySavingThrow", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "DexteritySavingThrowModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasConstitutionSavingThrow", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "ConstitutionSavingThrowModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasIntelligenceSavingThrow", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "IntelligenceSavingThrowModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasWisdomSavingThrow", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "WisdomSavingThrowModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasCharismaSavingThrow", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "CharismaSavingThrowModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasAthleticsProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "AthleticsModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasAcrobaticsProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "AcrobaticsModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasSleightOfHandProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "SleightOfHandModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasStealthProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "StealthModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasArcanaProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "ArcanaModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasHistoryProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "HistoryModifer", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasInvestigationProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "InvestigationModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasNatureProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "NatureModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasReligionProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "ReligionModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasAnimalHandlingProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "AnimalHandlingModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasInsightProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "InsightModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasMedicineProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "MedicineModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasPerceptionProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "PerceptionModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasSurvialProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "SurvivalModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasDeceptionProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "DeceptionModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasIntimidationProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "IntimidationModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasPerformanceProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "PerformanceModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasPersuasionProficiency", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "PersuasionModifier", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "HasBlindSight", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "HasDarkVision", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "HasTremorSense", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "HasTrueSight", c => c.Boolean(nullable: false));
            AddColumn("dbo.Monsters", "HasMagicSense", c => c.Boolean(nullable: false));
            DropColumn("dbo.Monsters", "SavingThrowsId");
            DropColumn("dbo.Monsters", "SkillsId");
            DropColumn("dbo.Monsters", "SensesId");
            DropTable("dbo.SavingThrows");
            DropTable("dbo.Senses");
            DropTable("dbo.Skills");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillsId = c.Int(nullable: false),
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
            
            CreateTable(
                "dbo.Senses",
                c => new
                    {
                        SensesId = c.Int(nullable: false),
                        HasBlindSight = c.Boolean(nullable: false),
                        HasDarkVision = c.Boolean(nullable: false),
                        HasTremorSense = c.Boolean(nullable: false),
                        HasTrueSight = c.Boolean(nullable: false),
                        HasMagicSense = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SensesId);
            
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
                .PrimaryKey(t => t.SavingThrowsId);
            
            AddColumn("dbo.Monsters", "SensesId", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "SkillsId", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "SavingThrowsId", c => c.Int(nullable: false));
            DropColumn("dbo.Monsters", "HasMagicSense");
            DropColumn("dbo.Monsters", "HasTrueSight");
            DropColumn("dbo.Monsters", "HasTremorSense");
            DropColumn("dbo.Monsters", "HasDarkVision");
            DropColumn("dbo.Monsters", "HasBlindSight");
            DropColumn("dbo.Monsters", "PersuasionModifier");
            DropColumn("dbo.Monsters", "HasPersuasionProficiency");
            DropColumn("dbo.Monsters", "PerformanceModifier");
            DropColumn("dbo.Monsters", "HasPerformanceProficiency");
            DropColumn("dbo.Monsters", "IntimidationModifier");
            DropColumn("dbo.Monsters", "HasIntimidationProficiency");
            DropColumn("dbo.Monsters", "DeceptionModifier");
            DropColumn("dbo.Monsters", "HasDeceptionProficiency");
            DropColumn("dbo.Monsters", "SurvivalModifier");
            DropColumn("dbo.Monsters", "HasSurvialProficiency");
            DropColumn("dbo.Monsters", "PerceptionModifier");
            DropColumn("dbo.Monsters", "HasPerceptionProficiency");
            DropColumn("dbo.Monsters", "MedicineModifier");
            DropColumn("dbo.Monsters", "HasMedicineProficiency");
            DropColumn("dbo.Monsters", "InsightModifier");
            DropColumn("dbo.Monsters", "HasInsightProficiency");
            DropColumn("dbo.Monsters", "AnimalHandlingModifier");
            DropColumn("dbo.Monsters", "HasAnimalHandlingProficiency");
            DropColumn("dbo.Monsters", "ReligionModifier");
            DropColumn("dbo.Monsters", "HasReligionProficiency");
            DropColumn("dbo.Monsters", "NatureModifier");
            DropColumn("dbo.Monsters", "HasNatureProficiency");
            DropColumn("dbo.Monsters", "InvestigationModifier");
            DropColumn("dbo.Monsters", "HasInvestigationProficiency");
            DropColumn("dbo.Monsters", "HistoryModifer");
            DropColumn("dbo.Monsters", "HasHistoryProficiency");
            DropColumn("dbo.Monsters", "ArcanaModifier");
            DropColumn("dbo.Monsters", "HasArcanaProficiency");
            DropColumn("dbo.Monsters", "StealthModifier");
            DropColumn("dbo.Monsters", "HasStealthProficiency");
            DropColumn("dbo.Monsters", "SleightOfHandModifier");
            DropColumn("dbo.Monsters", "HasSleightOfHandProficiency");
            DropColumn("dbo.Monsters", "AcrobaticsModifier");
            DropColumn("dbo.Monsters", "HasAcrobaticsProficiency");
            DropColumn("dbo.Monsters", "AthleticsModifier");
            DropColumn("dbo.Monsters", "HasAthleticsProficiency");
            DropColumn("dbo.Monsters", "CharismaSavingThrowModifier");
            DropColumn("dbo.Monsters", "HasCharismaSavingThrow");
            DropColumn("dbo.Monsters", "WisdomSavingThrowModifier");
            DropColumn("dbo.Monsters", "HasWisdomSavingThrow");
            DropColumn("dbo.Monsters", "IntelligenceSavingThrowModifier");
            DropColumn("dbo.Monsters", "HasIntelligenceSavingThrow");
            DropColumn("dbo.Monsters", "ConstitutionSavingThrowModifier");
            DropColumn("dbo.Monsters", "HasConstitutionSavingThrow");
            DropColumn("dbo.Monsters", "DexteritySavingThrowModifier");
            DropColumn("dbo.Monsters", "HasDexteritySavingThrow");
            DropColumn("dbo.Monsters", "StrengthSavingThrowModifier");
            DropColumn("dbo.Monsters", "HasStrengthSavingThrow");
            CreateIndex("dbo.Skills", "SkillsId");
            CreateIndex("dbo.Senses", "SensesId");
            CreateIndex("dbo.SavingThrows", "SavingThrowsId");
            AddForeignKey("dbo.Skills", "SkillsId", "dbo.Monsters", "Id");
            AddForeignKey("dbo.Senses", "SensesId", "dbo.Monsters", "Id");
            AddForeignKey("dbo.SavingThrows", "SavingThrowsId", "dbo.Monsters", "Id");
        }
    }
}
