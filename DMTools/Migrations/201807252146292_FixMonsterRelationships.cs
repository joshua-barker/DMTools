namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMonsterRelationships : DbMigration
    {
        public override void Up()
        {
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
                .PrimaryKey(t => t.SensesId)
                .ForeignKey("dbo.Monsters", t => t.SensesId)
                .Index(t => t.SensesId);
            
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
                .PrimaryKey(t => t.SkillsId)
                .ForeignKey("dbo.Monsters", t => t.SkillsId)
                .Index(t => t.SkillsId);
            
            AddColumn("dbo.Monsters", "SkillsId", c => c.Int(nullable: false));
            AddColumn("dbo.Monsters", "SensesId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "SkillsId", "dbo.Monsters");
            DropForeignKey("dbo.Senses", "SensesId", "dbo.Monsters");
            DropIndex("dbo.Skills", new[] { "SkillsId" });
            DropIndex("dbo.Senses", new[] { "SensesId" });
            DropColumn("dbo.Monsters", "SensesId");
            DropColumn("dbo.Monsters", "SkillsId");
            DropTable("dbo.Skills");
            DropTable("dbo.Senses");
        }
    }
}
