using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMTools.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsMagical { get; set; }
        //Enum doesn't exist yet
        public EquipmentType EquipmentType { get; set; }
    }
}