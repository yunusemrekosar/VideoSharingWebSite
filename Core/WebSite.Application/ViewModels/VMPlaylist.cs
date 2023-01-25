using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Application.ViewModels
{
    public class VMPlaylist
    {
        public int Id { get; set; }
        public string PlaylistName { get; set; }
        public int VideoID { get; set; }
        public int UserID { get; set; }

        public string? PlaylistDescription { get; set; }
        public string? PlaylistThumbnail { get; set; }
    }
}
