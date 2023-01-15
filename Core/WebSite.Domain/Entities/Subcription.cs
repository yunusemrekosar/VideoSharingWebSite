using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Domain.Entities.Common;

namespace WebSite.Domain.Entities
{
    public class Subcription 
    {
        public Subcription()
        {
            Users = new HashSet<User>();
            Channels = new HashSet<Channel>();
        }
        public int UserID { get; set; }
        public int ChannelID { get; set; }
        public ICollection<Channel> Channels { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
