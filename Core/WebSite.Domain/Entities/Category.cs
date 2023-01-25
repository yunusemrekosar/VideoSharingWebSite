using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [MaxLength(50), MinLength(5)]
        public string CategoryName { get; set; }

        [MaxLength(70), MinLength(5)]
        public string? CategoryDescription { get; set; }
        public ICollection<Channel> Channels { get; set; }
        public ICollection<Video> Videos { get; set; }

    }
}
