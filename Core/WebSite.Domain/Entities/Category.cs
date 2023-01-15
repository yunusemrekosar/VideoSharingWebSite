using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using WebSite.Domain.Entities.Common;

namespace WebSite.Domain.Entities
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Videos = new HashSet<Video>();
            Channels = new HashSet<Channel>();
        } 
        public string CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public ICollection<Channel> Channels { get; set; }
        public ICollection<Video> Videos { get; set; }

    }
}
