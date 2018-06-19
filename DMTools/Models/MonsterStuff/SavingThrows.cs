using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMTools.Models
{
    public class SavingThrows
    {
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



    }
}