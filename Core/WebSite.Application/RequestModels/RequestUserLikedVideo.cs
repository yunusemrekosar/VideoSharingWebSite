using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Application.ViewModels
{
    public class RequestUserLikedVideo
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int VideoID { get; set; }
    }
}
