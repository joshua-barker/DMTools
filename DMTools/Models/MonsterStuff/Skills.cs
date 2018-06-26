using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMTools.Models
{
    public class Skills
    {
        public int SkillsId { get; set; }

        // Strength Skills
        public bool HasAthleticsProficiency { get; set; }
        public int AthleticsModifier { get; set; }

        // Dexterity Skills
        public bool HasAcrobaticsProficiency { get; set; }
        public int AcrobaticsModifier { get; set; }
        public bool HasSleightOfHandProficiency { get; set; }
        public int SleightOfHandModifier { get; set; }
        public bool HasStealthProficiency { get; set; }
        public int StealthModifier { get; set; }

        // Intelligence Skills
        public bool HasArcanaProficiency { get; set; }
        public int ArcanaModifier { get; set; }
        public bool HasHistoryProficiency { get; set; }
        public int HistoryModifer { get; set; }
        public bool HasInvestigationProficiency { get; set; }
        public int InvestigationModifier { get; set; }
        public bool HasNatureProficiency { get; set; }
        public int NatureModifier { get; set; }
        public bool HasReligionProficiency { get; set; }
        public int ReligionModifier { get; set; }

        // Wisdom Skills
        public bool HasAnimalHandlingProficiency { get; set; }
        public int AnimalHandlingModifier { get; set; }
        public bool HasInsightProficiency { get; set; }
        public int InsightModifier { get; set; }
        public bool HasMedicineProficiency { get; set; }
        public int MedicineModifier { get; set; }
        public bool HasPerceptionProficiency { get; set; }
        public int PerceptionModifier { get; set; }
        public bool HasSurvialProficiency { get; set; }
        public int SurvivalModifier { get; set; }

        // Charisma
        public bool HasDeceptionProficiency { get; set; }
        public int DeceptionModifier { get; set; }
        public bool HasIntimidationProficiency { get; set; }
        public int IntimidationModifier { get; set; }
        public bool HasPerformanceProficiency { get; set; }
        public int PerformanceModifier { get; set; }
        public bool HasPersuasionProficiency { get; set; }
        public int PersuasionModifier { get; set; }

        public static Skills CalculateSkillsModifiers(Monster monster)
        {
            Skills skills = new Skills();
            int strength = monster.AbilityModifiers.StrengthModifier;
            int dexterity = monster.AbilityModifiers.DexterityModifier;
            int intelligence = monster.AbilityModifiers.IntelligenceModifier;
            int wisdom = monster.AbilityModifiers.WisdomModifier;
            int charisma = monster.AbilityModifiers.CharismaModifier;
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