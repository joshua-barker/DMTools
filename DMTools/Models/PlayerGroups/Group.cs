using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DMTools.Models.PlayerGroups
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}