namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TempRemoveSavingThrows : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Monsters", "SavingThrowsId", "dbo.SavingThrows");
            DropIndex("dbo.Monsters", new[] { "SavingThrowsId" });
            DropColumn("dbo.Monsters", "SavingThrowsId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Monsters", "SavingThrowsId", c => c.Int(nullable: false));
            CreateIndex("dbo.Monsters", "SavingThrowsId");
            AddForeignKey("dbo.Monsters", "SavingThrowsId", "dbo.SavingThrows", "SavingThrowsId", cascadeDelete: true);
        }
    }
}
