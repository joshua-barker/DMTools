using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMTools.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMTools.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int ArmorClass { get; set; }
        public int Speed { get; set; }
        public int ProficiencyBonus { get; set; }
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

        [ForeignKey("AbilityModifiers")]
        public int AbilityModifiersId { get; set; }
        public AbilityModifiers AbilityModifiers { get; set; }

        [ForeignKey("SavingThrows")]
        public int SavingThrowsId { get; set; }
        public SavingThrows SavingThrows { get; set; }

        [ForeignKey("Skills")]
        public int SkillsId { get; set; }
        public Skills Skills { get; set; }

        [ForeignKey("Senses")]
        public int SensesId { get; set; }
        public Senses Senses { get; set; }

        public ICollection<Equipment> Equipment { get; set; }
    }
}