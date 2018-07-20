using System.ComponentModel;


namespace DMTools.Models
{
    public class SavingThrows
    {
        public int SavingThrowsId { get; set; }
        public bool HasStrengthSavingThrow { get; set; }
        [DisplayName("Strength Saving Throw Modifier")]
        public int StrengthSavingThrowModifier { get; set; }
        public bool HasDexteritySavingThrow { get; set; }
        [DisplayName("Dexterity Saving Throw Modifier")]
        public int DexteritySavingThrowModifier { get; set; }
        public bool HasConstitutionSavingThrow { get; set; }
        [DisplayName("Constitution Saving Throw Modifier")]
        public int ConstitutionSavingThrowModifier { get; set; }
        public bool HasIntelligenceSavingThrow { get; set; }
        [DisplayName("Intelligence Saving Throw Modifier")]
        public int IntelligenceSavingThrowModifier { get; set; }
        public bool HasWisdomSavingThrow { get; set; }
        [DisplayName("Wisdom Saving Throw Modifier")]
        public int WisdomSavingThrowModifier { get; set; }
        public bool HasCharismaSavingThrow { get; set; }
        [DisplayName("Charisma Saving Throw Modifier")]
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
                savingThrows.StrengthSavingThrowModifier = monster.StrengthModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.StrengthSavingThrowModifier = monster.StrengthModifier;
            }
            if (savingThrows.HasDexteritySavingThrow)
            {
                savingThrows.DexteritySavingThrowModifier = monster.DexterityModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.DexteritySavingThrowModifier = monster.DexterityModifier;
            }
            if (savingThrows.HasConstitutionSavingThrow)
            {
                savingThrows.ConstitutionSavingThrowModifier = monster.ConstitutionModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.ConstitutionSavingThrowModifier = monster.ConstitutionModifier;
            }
            if (savingThrows.HasIntelligenceSavingThrow)
            {
                savingThrows.IntelligenceSavingThrowModifier = monster.IntelligenceModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.IntelligenceSavingThrowModifier = monster.IntelligenceModifier;
            }
            if (savingThrows.HasWisdomSavingThrow)
            {
                savingThrows.WisdomSavingThrowModifier = monster.WisdomModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.WisdomSavingThrowModifier = monster.WisdomModifier;
            }
            if (savingThrows.HasCharismaSavingThrow)
            {
                savingThrows.CharismaSavingThrowModifier = monster.CharismaModifier + monster.ProficiencyBonus;
            }
            else
            {
                savingThrows.CharismaSavingThrowModifier = monster.CharismaModifier;
            }

            return savingThrows;
        }
    }
}