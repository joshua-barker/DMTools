using DMTools.Enums;

namespace DMTools.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsMagical { get; set; }
        public EquipmentType EquipmentType { get; set; }
    }
}