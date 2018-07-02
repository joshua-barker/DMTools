using System;
using System.ComponentModel;

namespace DMTools.Models
{
    public class Senses
    {
        public int SensesId { get; set; }
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
    }
}