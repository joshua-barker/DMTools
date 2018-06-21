namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProficiencyBonus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Monsters", "ProficiencyBonus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Monsters", "ProficiencyBonus");
        }
    }
}
