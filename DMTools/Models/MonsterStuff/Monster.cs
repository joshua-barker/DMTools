using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMTools.Enums;

namespace DMTools.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int ArmorClass { get; set; }
        public int Speed { get; set; }
        public double ChallengeRating { get; set; }
        public bool IsLegendary { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public Sizes Size { get; set; }
        public Races Race { get; set; }
        public Types Type { get; set; }
        public Species Species { get; set; }
        public Alignments Alignment { get; set; }
        public SavingThrows SavingThrows { get; set; }
        public Skills Skills { get; set; }
        public Senses Senses { get; set; }
    }
}