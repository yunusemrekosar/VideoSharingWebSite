using System.ComponentModel.DataAnnotations;
using WebSite.Domain.Entities.Common;

namespace WebSite.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Videos = new HashSet<Video>();
            AdminChannels = new HashSet<Channel>();
            SubscribedChannels = new HashSet<Subscription>();
            DislikedVideos = new HashSet<UserDislikedVideo>();
            LikedVideos = new HashSet<UserLikedVideo>();
            WatchedVideos = new HashSet<UserWatchedVideo>();
            Playlists = new HashSet<Playlist>();
            Comments = new HashSet<Comment>();
            SubComments = new HashSet<SubComment>();
        }

        [MaxLength(50), MinLength(4)]
        public string UserName { get; set; }

        [MaxLength(30), MinLength(6)]
        public string Password { get; set; }

        [MaxLength(50), MinLength(2)]
        public string FirstName { get; set; }

        [MaxLength(50), MinLength(2)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public bool? MemberIsWomen { get; set; }
        public string? ProfilePhoto { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public ICollection<Video> Videos { get; set; }
        public ICollection<Subscription> SubscribedChannels { get; set; }
        public ICollection<Channel> AdminChannels { get; set; }
        public ICollection<UserDislikedVideo>  DislikedVideos { get; set; }
        public ICollection<UserLikedVideo>  LikedVideos { get; set; }
        public ICollection<UserWatchedVideo>  WatchedVideos { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
        public ICollection<Comment > Comments { get; set; }
        public ICollection<SubComment> SubComments { get; set; }

    }
}
