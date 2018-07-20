using System;
using System.ComponentModel;

namespace DMTools.Models
{
    public class Skills
    {
        public int SkillsId { get; set; }

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

        public static Skills CalculateSkillsModifiers(Monster monster)
        {
            Skills skills = new Skills();
            int strength = monster.StrengthModifier;
            int dexterity = monster.DexterityModifier;
            int intelligence = monster.IntelligenceModifier;
            int wisdom = monster.WisdomModifier;
            int charisma = monster.CharismaModifier;
            int proficiency = monster.ProficiencyBonus;

            if (monster.Skills != null)
            {
                skills = monster.Skills;
            }

            // Strength Skill
            if (skills.HasAthleticsProficiency)
            {
                skills.AthleticsModifier = strength + proficiency;
            }
            else
            {
                skills.AthleticsModifier = strength;
            }

            // Dexterity Skills
            if (skills.HasAthleticsProficiency)
            {
                skills.AthleticsModifier = dexterity + proficiency;
            }
            else
            {
                skills.AthleticsModifier = dexterity;
            }
            if (skills.HasSleightOfHandProficiency)
            {
                skills.SleightOfHandModifier = dexterity + proficiency;
            }
            else
            {
                skills.SleightOfHandModifier = dexterity;
            }
            if (skills.HasStealthProficiency)
            {
                skills.StealthModifier = dexterity + proficiency;
            }
            else
            {
                skills.StealthModifier = dexterity;
            }

            // Intelligence Skills
            if (skills.HasArcanaProficiency)
            {
                skills.ArcanaModifier = intelligence + proficiency;
            }
            else
            {
                skills.ArcanaModifier = intelligence;
            }
            if (skills.HasHistoryProficiency)
            {
                skills.HistoryModifer = intelligence + proficiency;
            }
            else
            {
                skills.HistoryModifer = intelligence;
            }
            if (skills.HasInvestigationProficiency)
            {
                skills.InvestigationModifier = intelligence + proficiency;
            }
            else
            {
                skills.InvestigationModifier = intelligence;
            }
            if (skills.HasNatureProficiency)
            {
                skills.NatureModifier = intelligence + proficiency;
            }
            else
            {
                skills.NatureModifier = intelligence;
            }
            if (skills.HasReligionProficiency)
            {
                skills.ReligionModifier = intelligence + proficiency;
            }
            else
            {
                skills.ReligionModifier = intelligence;
            }

            // Wisdom Skills
            if (skills.HasAnimalHandlingProficiency)
            {
                skills.AnimalHandlingModifier = wisdom + proficiency;
            }
            else
            {
                skills.AnimalHandlingModifier = wisdom;
            }
            if (skills.HasInsightProficiency)
            {
                skills.InsightModifier = wisdom + proficiency;
            }
            else
            {
                skills.InsightModifier = wisdom;
            }
            if (skills.HasMedicineProficiency)
            {
                skills.MedicineModifier = wisdom + proficiency;
            }
            else
            {
                skills.MedicineModifier = wisdom;
            }
            if (skills.HasPerceptionProficiency)
            {
                skills.PerceptionModifier = wisdom + proficiency;
            }
            else
            {
                skills.PerceptionModifier = wisdom;
            }
            if (skills.HasSurvialProficiency)
            {
                skills.SurvivalModifier = wisdom + proficiency;
            }
            else
            {
                skills.SurvivalModifier = wisdom;
            }

            // Charisma Skills
            if (skills.HasDeceptionProficiency)
            {
                skills.DeceptionModifier = charisma + proficiency;
            }
            else
            {
                skills.DeceptionModifier = charisma;
            }
            if (skills.HasIntimidationProficiency)
            {
                skills.IntimidationModifier = charisma + proficiency;
            }
            else
            {
                skills.IntimidationModifier = charisma;
            }
            if (skills.HasPerformanceProficiency)
            {
                skills.PerformanceModifier = charisma + proficiency;
            }
            else
            {
                skills.PerformanceModifier = charisma;
            }
            if (skills.HasPersuasionProficiency)
            {
                skills.PersuasionModifier = charisma + proficiency;
            }
            else
            {
                skills.PersuasionModifier = charisma;
            }

            return skills;
        }
    }
}