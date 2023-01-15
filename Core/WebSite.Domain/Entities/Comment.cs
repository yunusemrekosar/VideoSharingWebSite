using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Domain.Entities.Common;

namespace WebSite.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public Comment()
        {
            SubComments = new HashSet<SubComment>();
        }
        public string TheComment { get; set; }
        public int  UserID{ get; set; }
        public int VideoID { get; set; }
        public bool IsApropriate { get; set; }
        public User User { get; set; }
        public Video Video { get; set; }
        public ICollection<SubComment> SubComments { get; set; }
    }
}
