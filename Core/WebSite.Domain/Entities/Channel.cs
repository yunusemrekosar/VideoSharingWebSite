using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.PortableExecutable;
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
            SubscribedUsers= new HashSet<Subscription>();
        }
        [MaxLength(30), MinLength(2)]
        public string ChannelName { get; set; }

        [MaxLength(70)]
        public string? ChannelDescription { get; set; }
        public string? ProfilePhoto { get; set; }
        public int UserID { get; set; }
        public int? CategoryID { get; set; }
        public int? VideoCount { get; set; }
        public int? SubscriberCount { get; set; }
        public Category Category { get; set; }
        public User AdminUser { get; set; }
        public ICollection<Subscription> SubscribedUsers { get; set; }
        public ICollection<Video> Videos { get; set; }
        

    }
}
