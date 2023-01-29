using Microsoft.EntityFrameworkCore;
using WebSite.Domain.Entities;
using WebSite.Domain.Entities.Common;

namespace WebSite.Persistence.Context
{
    public class WebSiteDbContext : DbContext
    {
        public WebSiteDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<SubComment> SubComments { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<UserDislikedVideo> UserDislikedVideos { get; set; }
        public DbSet<UserLikedVideo> UserLikedVideos { get; set; }
        public DbSet<UserWatchedVideo> UserWatchedVideos { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case EntityState.Modified:
                        data.Entity.UpdatedDate = DateTime.Now;
                        break;
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.Now;
                        if (data.Entity is Subscription)
                        { break; }
                        data.Entity.IsActive = false;
                        break;
                    default:
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subscription>()
               .Ignore(x => x.Id)
               .Ignore(a => a.IsActive)
               .Ignore(a => a.UpdatedDate)
               .Ignore(a => a.CreatedDate); 

              modelBuilder.Entity<UserLikedVideo>()
               .Ignore(x => x.Id)
               .Ignore(a => a.IsActive)
               .Ignore(a => a.UpdatedDate)
               .Ignore(a => a.CreatedDate);

            modelBuilder.Entity<UserWatchedVideo>()
               .Ignore(x => x.Id)
               .Ignore(a => a.IsActive)
               .Ignore(a => a.UpdatedDate)
               .Ignore(a => a.CreatedDate);

            modelBuilder.Entity<UserDislikedVideo>()
                .Ignore(x => x.Id)
                .Ignore(a => a.IsActive)
                .Ignore(a => a.UpdatedDate)
                .Ignore(a => a.CreatedDate);


            modelBuilder.Entity<Video>()
                .HasOne(v => v.Category)
                .WithMany(c => c.Videos)
                .HasForeignKey(v => v.CategoryID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Channel>()
                .HasOne(c => c.Category)
                .WithMany(ca => ca.Channels)
                .HasForeignKey(c => c.CategoryID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Video>()
                .HasOne(v => v.Channel)
                .WithMany(c => c.Videos)
                .HasForeignKey(v => v.ChannelID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Channel>()
                .HasOne(c => c.AdminUser)
                .WithMany(u => u.AdminChannels)
                .HasForeignKey(c => c.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Comment>()
                .HasOne(C => C.Video)
                .WithMany(v => v.Comments)
                .HasForeignKey(c => c.VideoID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Playlist>()
                .HasOne(p => p.User)
                .WithMany(u => u.Playlists)
                .HasForeignKey(p => p.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<SubComment>()
                .HasOne(s => s.Comment)
                .WithMany(c => c.SubComments)
                .HasForeignKey(s => s.CommentID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Video>()
                .HasOne(v => v.User)
                .WithMany(u => u.Videos)
                .HasForeignKey(v => v.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<SubComment>()
                .HasOne(s => s.User)
                .WithMany(u => u.SubComments)
                .HasForeignKey(s => s.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Subscription>()
                .HasKey(k => new { k.UserID, k.ChannelID });

            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.User)
                .WithMany(u => u.SubscribedChannels)
                .HasForeignKey(a => a.UserID);

            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.Channel)
                .WithMany(u => u.SubscribedUsers)
                .HasForeignKey(a => a.ChannelID);

            modelBuilder.Entity<UserLikedVideo>()
                .HasKey(k => new { k.UserID, k.VideoID });

            modelBuilder.Entity<UserLikedVideo>()
                .HasOne(s => s.User)
                .WithMany(u => u.LikedVideos)
                .HasForeignKey(a => a.UserID);

            modelBuilder.Entity<UserLikedVideo>()
                .HasOne(s => s.Video)
                .WithMany(u => u.Liker)
                .HasForeignKey(a => a.VideoID);

            modelBuilder.Entity<UserDislikedVideo>()
                .HasKey(k => new { k.UserID, k.VideoID });

            modelBuilder.Entity<UserDislikedVideo>()
                .HasOne(s => s.User)
                .WithMany(u => u.DislikedVideos)
                .HasForeignKey(a => a.UserID);

            modelBuilder.Entity<UserDislikedVideo>()
                .HasOne(s => s.Video)
                .WithMany(u => u.Disliker)
                .HasForeignKey(a => a.VideoID);

            modelBuilder.Entity<UserWatchedVideo>()
               .HasKey(k => new { k.UserID, k.VideoID });

            modelBuilder.Entity<UserWatchedVideo>()
                .HasOne(s => s.User)
                .WithMany(u => u.WatchedVideos)
                .HasForeignKey(a => a.UserID);

            modelBuilder.Entity<UserWatchedVideo>()
                .HasOne(s => s.Video)
                .WithMany(u => u.Watcher)
                .HasForeignKey(a => a.VideoID);

        }
    }



}
