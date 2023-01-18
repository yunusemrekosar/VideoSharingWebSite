using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using WebSite.Domain.Entities.Common;

namespace WebSite.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Videos = new HashSet<Video>();
            AdminChannels = new HashSet<Channel>();
            SubscribedChannels = new HashSet<Channel>();
            DislikedVideos = new HashSet<UserDislikedVideo>();
            LikedVideos = new HashSet<UserLikedVideo>();
            WatchedVideos = new HashSet<UserWatchedVideo>();
            Playlists = new HashSet<Playlist>();
            Comments = new HashSet<Comment>();
            SubComments = new HashSet<SubComment>();
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [MaxLength(12)]
        public string TelNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public bool? MemberIsWomen { get; set; }
        public string? ProfilePhoto { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public ICollection<Video> Videos { get; set; }
        public ICollection<Channel> SubscribedChannels { get; set; }
        public ICollection<Channel> AdminChannels { get; set; }
        public ICollection<UserDislikedVideo>  DislikedVideos { get; set; }
        public ICollection<UserLikedVideo>  LikedVideos { get; set; }
        public ICollection<UserWatchedVideo>  WatchedVideos { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
        public ICollection<Comment > Comments { get; set; }
        public ICollection<SubComment> SubComments { get; set; }

    }
}
