using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Domain.Entities;

namespace WebSite.Persistence.Context
{
    public class WebSiteDbContext : DbContext
    {
        public WebSiteDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Channel> Channels  { get; set; }
        public DbSet<Playlist> Playlists  { get; set; }
        public DbSet<SubComment> SubComments  { get; set; }
        public DbSet<Subcription >  Subcriptions  { get; set; }
        public DbSet<UserDislikedVideo> UserDislikedVideos { get; set; }
        public DbSet<UserLikedVideo> UserLikedVideos  { get; set; }
        public DbSet<UserWatchedVideo> UserWatchedVideos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<Channel>()
                .HasMany(u => u.SubscribedUsers)
                .WithMany(c => c.SubscribedChannels)
                .UsingEntity<Subcription>();

            modelBuilder.Entity<Video>()
                .HasOne(v => v.User)
                .WithMany(u => u.Videos)
                .HasForeignKey(v => v.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<UserDislikedVideo>()
                .HasOne(udv => udv.User)
                .WithMany(u => u.DislikedVideos)
                .HasForeignKey(udv => udv.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<UserLikedVideo>()
                .HasOne(udv => udv.User)
                .WithMany(u => u.LikedVideos)
                .HasForeignKey(udv => udv.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<UserWatchedVideo>()
                .HasOne(udv => udv.User)
                .WithMany(u => u.WatchedVideos)
                .HasForeignKey(udv => udv.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull);

                modelBuilder.Entity<UserDislikedVideo>()
                .HasOne(udv => udv.Video)
                .WithMany(u => u.DislikedVideos)
                .HasForeignKey(udv => udv.VideoID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<UserLikedVideo>()
                .HasOne(udv => udv.Video)
                .WithMany(u => u.LikedVideos)
                .HasForeignKey(udv => udv.VideoID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<UserWatchedVideo>()
                .HasOne(udv => udv.Video)
                .WithMany(u => u.WatchedVideos)
                .HasForeignKey(udv => udv.VideoID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<SubComment>()
                .HasOne(s => s.User)
                .WithMany(u => u.SubComments)
                .HasForeignKey(s => s.UserID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }

     
    
}
