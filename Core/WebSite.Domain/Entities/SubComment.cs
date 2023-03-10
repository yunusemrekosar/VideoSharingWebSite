using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Domain.Entities.Common;

namespace WebSite.Domain.Entities
{
    public class SubComment : BaseEntity
    {
        [MaxLength(250)]
        public string TheComment{ get; set; }
        public bool? IsApropriate { get; set; }
        public int UserID { get; set; }
        public int CommentID { get; set; }
        public Comment Comment { get; set; }
        public User User { get; set; }
    }
}
