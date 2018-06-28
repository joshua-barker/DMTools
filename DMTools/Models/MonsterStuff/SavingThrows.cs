using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMTools.Models
{
    public class SavingThrows
    {
        public int SavingThrowsId { get; set; }
        public bool HasStrengthSavingThrow { get; set; }
        public int StrengthSavingThrowModifier { get; set; }
        public bool HasDexteritySavingThrow { get; set; }
        public int DexteritySavingThrowModifier { get; set; }
        public bool HasConstitutionSavingThrow { get; set; }
        public int ConstitutionSavingThrowModifier { get; set; }
        public bool HasIntelligenceSavingThrow { get; set; }
        public int IntelligenceSavingThrowModifier { get; set; }
        public bool HasWisdomSavingThrow { get; set; }
        public int WisdomSavingThrowModifier { get; set; }
        public bool HasCharismaSavingThrow { get; set; }
        public int CharismaSavingThrowModifier { get; set; }

        public static SavingThrows CalculateSavingThrowsModifiers(Monster monster)
        {
            SavingThrows savingThrows = new SavingThrows();

            if (monster.SavingThrows != null)
            {
                savingThrows = monster.SavingThrows;
            }

            if (savingThrows.HasStrengthSavingThrow)
            {
                savingThrows.StrengthSavingThrowModifier = monster.AbilityModifiers.StrengthModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.StrengthSavingThrowModifier = monster.AbilityModifiers.StrengthModifier;
            }
            if (savingThrows.HasDexteritySavingThrow)
            {
                savingThrows.DexteritySavingThrowModifier = monster.AbilityModifiers.DexterityModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.DexteritySavingThrowModifier = monster.AbilityModifiers.DexterityModifier;
            }
            if (savingThrows.HasConstitutionSavingThrow)
            {
                savingThrows.ConstitutionSavingThrowModifier = monster.AbilityModifiers.ConstitutionModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.ConstitutionSavingThrowModifier = monster.AbilityModifiers.ConstitutionModifier;
            }
            if (savingThrows.HasIntelligenceSavingThrow)
            {
                savingThrows.IntelligenceSavingThrowModifier = monster.AbilityModifiers.IntelligenceModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.IntelligenceSavingThrowModifier = monster.AbilityModifiers.IntelligenceModifier;
            }
            if (savingThrows.HasWisdomSavingThrow)
            {
                savingThrows.WisdomSavingThrowModifier = monster.AbilityModifiers.WisdomModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.WisdomSavingThrowModifier = monster.AbilityModifiers.WisdomModifier;
            }
            if (savingThrows.HasCharismaSavingThrow)
            {
                savingThrows.CharismaSavingThrowModifier = monster.AbilityModifiers.CharismaModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.CharismaSavingThrowModifier = monster.AbilityModifiers.CharismaModifier;
            }

            return savingThrows;
        }
    }
}