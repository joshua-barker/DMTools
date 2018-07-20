using System;
using System.Collections.Generic;

namespace DMTools.Models
{
    public class Encounter
    {
        public int EncounterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<Monster> Monsters { get; set; }
    }
}