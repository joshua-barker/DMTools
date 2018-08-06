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
            Equipment = new HashSet<Equipment>();
        }

        public int Id { get; set; }      

        #region Base Monster Information

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

        public Sizes Size { get; set; }
        public Races Race { get; set; }
        public Types Type { get; set; }
        public Species Species { get; set; }
        public Alignments Alignment { get; set; }

        public ICollection<Equipment> Equipment { get; set; }

        #endregion

        #region Abilities and Ability Modifiers

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

        #endregion

        #region Saving Throws

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

        public static Monster CalculateSavingThrowsModifiers(Monster monster)
        {

            if (monster.HasStrengthSavingThrow)
            {
                monster.StrengthSavingThrowModifier = monster.StrengthModifier + monster.ProficiencyBonus;
            }
            else
            {
                monster.StrengthSavingThrowModifier = monster.StrengthModifier;
            }

            if (monster.HasDexteritySavingThrow)
            {
                monster.DexteritySavingThrowModifier = monster.DexterityModifier + monster.ProficiencyBonus;
            }
            else
            {
                monster.DexteritySavingThrowModifier = monster.DexterityModifier;
            }

            if (monster.HasConstitutionSavingThrow)
            {
                monster.ConstitutionSavingThrowModifier = monster.ConstitutionModifier + monster.ProficiencyBonus;
            }
            else
            {
                monster.ConstitutionSavingThrowModifier = monster.ConstitutionModifier;
            }

            if (monster.HasIntelligenceSavingThrow)
            {
                monster.IntelligenceSavingThrowModifier = monster.IntelligenceModifier + monster.ProficiencyBonus;
            }
            else
            {
                monster.IntelligenceSavingThrowModifier = monster.IntelligenceModifier;
            }

            if (monster.HasWisdomSavingThrow)
            {
                monster.WisdomSavingThrowModifier = monster.WisdomModifier + monster.ProficiencyBonus;
            }
            else
            {
                monster.WisdomSavingThrowModifier = monster.WisdomModifier;
            }

            if (monster.HasCharismaSavingThrow)
            {
                monster.CharismaSavingThrowModifier = monster.CharismaModifier + monster.ProficiencyBonus;
            }
            else
            {
                monster.CharismaSavingThrowModifier = monster.CharismaModifier;
            }

            return monster;
        }

        #endregion

        #region Skills

        // Strength Skills
        public bool HasAthleticsProficiency { get; set; }
        [DisplayName("Athletics Modifier")]
        public int AthleticsModifier { get; set; }

        // Dexterity Skills
        public bool HasAcrobaticsProficiency { get; set; }
        [DisplayName("Acrobatics Modifier")]
        public int AcrobaticsModifier { get; set; }
        public bool HasSleightOfHandProficiency { get; set; }
        [DisplayName("Sleight of Hand Modifier")]
        public int SleightOfHandModifier { get; set; }
        public bool HasStealthProficiency { get; set; }
        [DisplayName("Stealth Modifier")]
        public int StealthModifier { get; set; }

        // Intelligence Skills
        public bool HasArcanaProficiency { get; set; }
        [DisplayName("Arcana Modifier")]
        public int ArcanaModifier { get; set; }
        public bool HasHistoryProficiency { get; set; }
        [DisplayName("History Modifier")]
        public int HistoryModifer { get; set; }
        public bool HasInvestigationProficiency { get; set; }
        [DisplayName("Investigation Modifier")]
        public int InvestigationModifier { get; set; }
        public bool HasNatureProficiency { get; set; }
        [DisplayName("Nature Modifier")]
        public int NatureModifier { get; set; }
        public bool HasReligionProficiency { get; set; }
        [DisplayName("Religion Modifier")]
        public int ReligionModifier { get; set; }

        // Wisdom Skills
        public bool HasAnimalHandlingProficiency { get; set; }
        [DisplayName("Animal Handling Modifier")]
        public int AnimalHandlingModifier { get; set; }
        public bool HasInsightProficiency { get; set; }
        [DisplayName("Insight Modifier")]
        public int InsightModifier { get; set; }
        public bool HasMedicineProficiency { get; set; }
        [DisplayName("Medicine Modifier")]
        public int MedicineModifier { get; set; }
        public bool HasPerceptionProficiency { get; set; }
        [DisplayName("Perception Modifier")]
        public int PerceptionModifier { get; set; }
        public bool HasSurvialProficiency { get; set; }
        [DisplayName("Survival Modifier")]
        public int SurvivalModifier { get; set; }

        // Charisma
        public bool HasDeceptionProficiency { get; set; }
        [DisplayName("Deception Modifier")]
        public int DeceptionModifier { get; set; }
        public bool HasIntimidationProficiency { get; set; }
        [DisplayName("Intimidation Modifier")]
        public int IntimidationModifier { get; set; }
        public bool HasPerformanceProficiency { get; set; }
        [DisplayName("Performance Modifier")]
        public int PerformanceModifier { get; set; }
        public bool HasPersuasionProficiency { get; set; }
        [DisplayName("Persuasion Modifier")]
        public int PersuasionModifier { get; set; }

        public static Monster CalculateSkillsModifiers(Monster monster)
        {
            int strength = monster.StrengthModifier;
            int dexterity = monster.DexterityModifier;
            int intelligence = monster.IntelligenceModifier;
            int wisdom = monster.WisdomModifier;
            int charisma = monster.CharismaModifier;
            int proficiency = monster.ProficiencyBonus;

            // Strength Skill
            if (monster.HasAthleticsProficiency)
            {
                monster.AthleticsModifier = strength + proficiency;
            }
            else
            {
                monster.AthleticsModifier = strength;
            }

            // Dexterity Skills
            if (monster.HasAthleticsProficiency)
            {
                monster.AthleticsModifier = dexterity + proficiency;
            }
            else
            {
                monster.AthleticsModifier = dexterity;
            }
            if (monster.HasSleightOfHandProficiency)
            {
                monster.SleightOfHandModifier = dexterity + proficiency;
            }
            else
            {
                monster.SleightOfHandModifier = dexterity;
            }
            if (monster.HasStealthProficiency)
            {
                monster.StealthModifier = dexterity + proficiency;
            }
            else
            {
                monster.StealthModifier = dexterity;
            }

            // Intelligence Skills
            if (monster.HasArcanaProficiency)
            {
                monster.ArcanaModifier = intelligence + proficiency;
            }
            else
            {
                monster.ArcanaModifier = intelligence;
            }
            if (monster.HasHistoryProficiency)
            {
                monster.HistoryModifer = intelligence + proficiency;
            }
            else
            {
                monster.HistoryModifer = intelligence;
            }
            if (monster.HasInvestigationProficiency)
            {
                monster.InvestigationModifier = intelligence + proficiency;
            }
            else
            {
                monster.InvestigationModifier = intelligence;
            }
            if (monster.HasNatureProficiency)
            {
                monster.NatureModifier = intelligence + proficiency;
            }
            else
            {
                monster.NatureModifier = intelligence;
            }
            if (monster.HasReligionProficiency)
            {
                monster.ReligionModifier = intelligence + proficiency;
            }
            else
            {
                monster.ReligionModifier = intelligence;
            }

            // Wisdom Skills
            if (monster.HasAnimalHandlingProficiency)
            {
                monster.AnimalHandlingModifier = wisdom + proficiency;
            }
            else
            {
                monster.AnimalHandlingModifier = wisdom;
            }
            if (monster.HasInsightProficiency)
            {
                monster.InsightModifier = wisdom + proficiency;
            }
            else
            {
                monster.InsightModifier = wisdom;
            }
            if (monster.HasMedicineProficiency)
            {
                monster.MedicineModifier = wisdom + proficiency;
            }
            else
            {
                monster.MedicineModifier = wisdom;
            }
            if (monster.HasPerceptionProficiency)
            {
                monster.PerceptionModifier = wisdom + proficiency;
            }
            else
            {
                monster.PerceptionModifier = wisdom;
            }
            if (monster.HasSurvialProficiency)
            {
                monster.SurvivalModifier = wisdom + proficiency;
            }
            else
            {
                monster.SurvivalModifier = wisdom;
            }

            // Charisma Skills
            if (monster.HasDeceptionProficiency)
            {
                monster.DeceptionModifier = charisma + proficiency;
            }
            else
            {
                monster.DeceptionModifier = charisma;
            }
            if (monster.HasIntimidationProficiency)
            {
                monster.IntimidationModifier = charisma + proficiency;
            }
            else
            {
                monster.IntimidationModifier = charisma;
            }
            if (monster.HasPerformanceProficiency)
            {
                monster.PerformanceModifier = charisma + proficiency;
            }
            else
            {
                monster.PerformanceModifier = charisma;
            }
            if (monster.HasPersuasionProficiency)
            {
                monster.PersuasionModifier = charisma + proficiency;
            }
            else
            {
                monster.PersuasionModifier = charisma;
            }

            return monster;
        }

        #endregion

        #region Senses

        [DisplayName("Has Blind Sight")]
        public bool HasBlindSight { get; set; }
        [DisplayName("Has Dark Vision")]
        public bool HasDarkVision { get; set; }
        [DisplayName("Has Tremor Sense")]
        public bool HasTremorSense { get; set; }
        [DisplayName("Has True Sight")]
        public bool HasTrueSight { get; set; }
        [DisplayName("Has Magic Sense")]
        public bool HasMagicSense { get; set; }

        #endregion


    }
}