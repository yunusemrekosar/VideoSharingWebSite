using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Application.ViewModels
{
    public class VMVideo
    {
        public int Id { get; set; }
        public string VideoName { get; set; }

        public string? VideoDescription { get; set; }
        public string? VideoThumbnail { get; set; }
        public int? LikeCount { get; set; }
        public int? DislikeCount { get; set; }
        public int? VideoViewCount { get; set; }
        public int UserID { get; set; }
        public int? CategoryID { get; set; }
        public int ChannelID { get; set; }
    }
}
