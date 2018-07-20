using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DMTools.Enums
{
    public enum Alignments
    {
        [Display(Name = "Lawful Good")]
        LawfulGood = 1,
        [Display(Name = "Lawful Neutral")]
        LawfulNeutral = 2,
        [Display(Name = "Lawful Evil")]
        LawfulEvil = 3,
        [Display(Name = "Neutral Good")]
        NeutralGood = 4,
        [Display(Name = "True Neutral")]
        TrueNeutral = 5,
        [Display(Name = "Neutral Evil")]
        NeutralEvil = 6,
        [Display(Name = "Chaotic Good")]
        ChaoticGood = 7,
        [Display(Name = "Chaotic Neutral")]
        ChaoticNeutral = 8,
        [Display(Name = "Chaotic Evil")]
        ChaoticEvil = 9
    }
}