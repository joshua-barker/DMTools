using System;
using System.Data.Entity;
using System.Linq;
using DMTools.Enums;

namespace DMTools.Models
{

    public class DMToolsContext : DbContext
    {
        // Your context has been configured to use a 'DMToolsContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DMTools.Models.DMToolsContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DMToolsContext' 
        // connection string in the application configuration file.
        public DMToolsContext()
            : base("name=DMToolsContext")
        {
        }

        public virtual DbSet<Monster> Monsters { get; set; }
        public DbSet<Equipment> Equipments { get; set; }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Player> Players { get; set; }

        public DbSet<Encounter> Encounters { get; set; }
    }
}