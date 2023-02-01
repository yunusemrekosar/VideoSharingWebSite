using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Application.ViewModels
{
    public class VMChannel
    {
        public int Id { get; set; }

        [MaxLength(30), MinLength(2)]
        public string ChannelName { get; set; }

        [MaxLength(70)]
        public string? ChannelDescription { get; set; }
        public string? ProfilePhoto { get; set; }
        public int UserID { get; set; }
        public int? CategoryID { get; set; }
        public int? VideoCount { get; set; }
        public int? SubscriberCount { get; set; }
    }
}
