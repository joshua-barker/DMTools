using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMTools.Models
{
    public class Senses
    {
        public int SensesId { get; set; }
        public bool HasBlindSight { get; set; }
        public bool HasDarkVision { get; set; }
        public bool HasTremorSense { get; set; }
        public bool HasTrueSight { get; set; }
        public bool HasMagicSense { get; set; }
    }
}