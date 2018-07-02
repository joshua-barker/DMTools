using System.Collections.Generic;
using System.ComponentModel;

namespace DMTools.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        [DisplayName("Group Name")]
        public string GroupName { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}