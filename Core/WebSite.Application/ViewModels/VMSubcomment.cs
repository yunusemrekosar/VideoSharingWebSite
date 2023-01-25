using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Application.ViewModels
{
    public class VMSubcomment
    {
        public int Id { get; set; }
        public string TheComment { get; set; }
        public bool? IsApropriate { get; set; }
        public int UserID { get; set; }
        public int CommentID { get; set; }
    }
}
