using System.Collections.Generic;
using DMTools.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMTools.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }

        [ForeignKey("Character")]
        public int CharacterId { get; set; }
        public Monster Character { get; set; }

        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}