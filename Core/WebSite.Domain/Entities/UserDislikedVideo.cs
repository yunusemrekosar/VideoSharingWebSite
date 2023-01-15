using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Domain.Entities.Common;

namespace WebSite.Domain.Entities
{
    public class UserDislikedVideo: BaseEntityTwo
    {
        public DateTime DislikedDate { get; set; }
    }
}
