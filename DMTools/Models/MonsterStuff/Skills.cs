using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMTools.Models
{
    public class Skills
    {
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
    }
}