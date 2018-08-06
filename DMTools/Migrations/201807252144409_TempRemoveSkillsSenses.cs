namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TempRemoveSkillsSenses : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Monsters", "SensesId", "dbo.Senses");
            DropForeignKey("dbo.Monsters", "SkillsId", "dbo.Skills");
            DropIndex("dbo.Monsters", new[] { "SkillsId" });
            DropIndex("dbo.Monsters", new[] { "SensesId" });
            DropColumn("dbo.Monsters", "SkillsId");
            DropColumn("dbo.Monsters", "SensesId");
            DropTable("dbo.Senses");
            DropTable("dbo.Skills");
        }
        
        public override void Down()
        {
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
            
            AddColumn("dbo.Monsters", "SensesId", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "SkillsId", c => c.Int(nullable: false));
            CreateIndex("dbo.Monsters", "SensesId");
            CreateIndex("dbo.Monsters", "SkillsId");
            AddForeignKey("dbo.Monsters", "SkillsId", "dbo.Skills", "SkillsId", cascadeDelete: true);
            AddForeignKey("dbo.Monsters", "SensesId", "dbo.Senses", "SensesId", cascadeDelete: true);
        }
    }
}
