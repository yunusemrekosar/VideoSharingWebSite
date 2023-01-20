using WebSite.Domain.Entities.Common;

namespace WebSite.Domain.Entities
{
    public class Playlist:BaseEntity
    {

        public Playlist()
        {
            Videos = new HashSet<Video>();
        }
        public string PlaylistName { get; set; }
        public int VideoID { get; set; }
        public int UserID{ get; set; }
        public string? PlaylistDescription { get; set; }
        public string? PlaylistThumbnail { get; set; }
        public User User{ get; set; }
        public ICollection<Video> Videos { get; set; }
    }
}
