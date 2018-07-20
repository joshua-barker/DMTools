namespace DMTools.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMonsterToAbilityModifiers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbilityModifiers", "MonsterId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AbilityModifiers", "MonsterId");
        }
    }
}
