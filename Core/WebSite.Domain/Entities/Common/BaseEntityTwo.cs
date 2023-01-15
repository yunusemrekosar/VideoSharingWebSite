using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Domain.Entities.Common
{
    public class BaseEntityTwo
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int VideoID { get; set; }
        public Video Video { get; set; }
        public User User { get; set; }
    }
}
