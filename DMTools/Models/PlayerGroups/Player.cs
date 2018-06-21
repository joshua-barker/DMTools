using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DMTools.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMTools.Models.PlayerGroups
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }

        [ForeignKey("Character")]
        public int CharacterId { get; set; }
        public Monster Character { get; set; }
    }
}