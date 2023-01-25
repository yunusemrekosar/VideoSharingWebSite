using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Domain.Entities.Common;

namespace WebSite.Domain.Entities
{
    public class Subscription : BaseEntity
    {
        public int UserID { get; set; }
        public int ChannelID { get; set; }
        public Channel Channel { get; set; }
        public User User { get; set; }

    }
}
