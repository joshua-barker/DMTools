using System;
using System.ComponentModel;

namespace DMTools.Models
{
    public class AbilityModifiers
    {
        public int AbilityModifiersId { get; set; }
        [DisplayName("Strength Modifier")]
        public int StrengthModifier { get; set; }
        [DisplayName("Dexterity Modifier")]
        public int DexterityModifier { get; set; }
        [DisplayName("Constitution Modifier")]
        public int ConstitutionModifier { get; set; }
        [DisplayName("Intelligence Modifier")]
        public int IntelligenceModifier { get; set; }
        [DisplayName("Wisdom Modifier")]
        public int WisdomModifier { get; set; }
        [DisplayName("Charisma Modifier")]
        public int CharismaModifier { get; set; }

        public static AbilityModifiers CalculateAbilityModifiers(Monster monster)
        {
            AbilityModifiers modifiers = new AbilityModifiers();

            if (monster.AbilityModifiers != null)
            {
                modifiers = monster.AbilityModifiers;
            }

            modifiers.StrengthModifier = DoTheAbilityMaths(monster.Strength);
            modifiers.DexterityModifier = DoTheAbilityMaths(monster.Dexterity);
            modifiers.ConstitutionModifier = DoTheAbilityMaths(monster.Constitution);
            modifiers.IntelligenceModifier = DoTheAbilityMaths(monster.Intelligence);
            modifiers.WisdomModifier = DoTheAbilityMaths(monster.Wisdom);
            modifiers.CharismaModifier = DoTheAbilityMaths(monster.Charisma);

            return modifiers;
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