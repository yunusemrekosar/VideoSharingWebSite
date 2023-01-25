using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Domain.Entities.Common;

namespace WebSite.Domain.Entities
{
    public class Video : BaseEntity
    {
        public Video()
        {
            Playlists = new List<Playlist>();
            Comments = new List<Comment>();
        }

        [MaxLength(80), MinLength(5)]
        public string VideoName { get; set; }

        [MaxLength(100), MinLength(5)]
        public string? VideoDescription { get; set; }
        public string? VideoThumbnail { get; set; }
        public int? LikeCount { get; set; }
        public int? DislikeCount { get; set; }
        public int? VideoViewCount { get; set; }
        public int UserID { get; set; }
        public int? CategoryID { get; set; }
        public int ChannelID { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
        public Channel Channel { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<UserDislikedVideo> DislikedVideos { get; set; }
        public ICollection<UserLikedVideo> LikedVideos { get; set; }
        public ICollection<UserWatchedVideo> WatchedVideos { get; set; }
    }
}
