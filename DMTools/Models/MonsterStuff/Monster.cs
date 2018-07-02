﻿using System.Collections.Generic;
using DMTools.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace DMTools.Models
{
    public class Monster
    {
        public Monster()
        {
            AbilityModifiers = new AbilityModifiers();
            SavingThrows = new SavingThrows();
            Skills = new Skills();
            Senses = new Senses();
            Equipment = new HashSet<Equipment>();

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Backstory { get; set; }
        [DisplayName("Experience for Killing")]
        public int ExperienceForKilling { get; set; }
        [DisplayName("Max Health")]
        public int MaxHealth { get; set; }
        [DisplayName("Current Health")]
        public int CurrentHealth { get; set; }
        public int Level { get; set; }
        [DisplayName("Armor Class")]
        public int ArmorClass { get; set; }
        public int Speed { get; set; }
        [DisplayName("Proficiency Bonus")]
        public int ProficiencyBonus { get; set; }
        [DisplayName("Challenge Rating")]
        public double ChallengeRating { get; set; }
        [DisplayName("Is Legendary")]
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