using System.ComponentModel;
using DMTools.Enums;

namespace DMTools.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Magical")]
        public bool IsMagical { get; set; }
        [DisplayName("Equipment Type")]
        public EquipmentType EquipmentType { get; set; }
    }
}