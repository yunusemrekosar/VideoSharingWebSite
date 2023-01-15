using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Domain.Entities.Common;

namespace WebSite.Domain.Entities
{
    public class Channel : BaseEntity
    {
        public Channel()
        {
            Videos = new HashSet<Video>();
            SubscribedUsers= new HashSet<User>();
        }
        public string ChannelName { get; set; }
        public string? ChannelDescription { get; set; }
        public string? ProfilePhoto { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public int VideoCount { get; set; }
        public int SubscriberCount { get; set; }
        public Category Category { get; set; }
        public User AdminUser { get; set; }
        public ICollection<User> SubscribedUsers { get; set; }
        public ICollection<Video> Videos { get; set; }
        

    }
}
