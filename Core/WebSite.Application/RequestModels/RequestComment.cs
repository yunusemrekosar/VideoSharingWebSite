using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Application.ViewModels
{
    public class RequestComment
    {
        public int Id { get; set; }
        public string TheComment { get; set; }
        public int UserID { get; set; }
        public int VideoID { get; set; }
        public bool? IsApropriate { get; set; }
    }
}
