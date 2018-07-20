using System.Collections.Generic;
using DMTools.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System;

namespace DMTools.Models
{
    public class Monster
    {
        public Monster()
        {
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
        [DisplayName("Strength Modifier")]
        public int StrengthModifier { get; set; }
        public int Dexterity { get; set; }
        [DisplayName("Dexterity Modifier")]
        public int DexterityModifier { get; set; }
        public int Constitution { get; set; }
        [DisplayName("Constitution Modifier")]
        public int ConstitutionModifier { get; set; }
        public int Intelligence { get; set; }
        [DisplayName("Intelligence Modifier")]
        public int IntelligenceModifier { get; set; }
        public int Wisdom { get; set; }
        [DisplayName("Wisdom Modifier")]
        public int WisdomModifier { get; set; }
        public int Charisma { get; set; }
        [DisplayName("Charisma Modifier")]
        public int CharismaModifier { get; set; }
        public Sizes Size { get; set; }
        public Races Race { get; set; }
        public Types Type { get; set; }
        public Species Species { get; set; }
        public Alignments Alignment { get; set; }

        [ForeignKey("SavingThrows")]
        public int SavingThrowsId { get; set; }
        public virtual SavingThrows SavingThrows { get; set; }

        [ForeignKey("Skills")]
        public int SkillsId { get; set; }
        public virtual Skills Skills { get; set; }

        [ForeignKey("Senses")]
        public int SensesId { get; set; }
        public virtual Senses Senses { get; set; }

        public ICollection<Equipment> Equipment { get; set; }

        public static Monster CalculateAbilityModifiers(Monster monster)
        {
            monster.StrengthModifier = DoTheAbilityMaths(monster.Strength);
            monster.DexterityModifier = DoTheAbilityMaths(monster.Dexterity);
            monster.ConstitutionModifier = DoTheAbilityMaths(monster.Constitution);
            monster.IntelligenceModifier = DoTheAbilityMaths(monster.Intelligence);
            monster.WisdomModifier = DoTheAbilityMaths(monster.Wisdom);
            monster.CharismaModifier = DoTheAbilityMaths(monster.Charisma);

            return monster;
        }

        private static int DoTheAbilityMaths(int ability)
        {
            int newValue;
            decimal temp = (ability - 10) / 2;

            // If modifier is negative, round up, otherwise round down.
            if (temp < 0)
            {
                newValue = (int)Math.Ceiling(temp);
            }
            else
            {
                newValue = (int)temp;
            }

            return newValue;
        }
    }
}