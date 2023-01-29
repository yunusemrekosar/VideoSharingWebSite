using Microsoft.Extensions.DependencyInjection;
using WebSite.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using WebSite.Persistence.Concretes.UserRepository;
using WebSite.Application.ITablesRepositories.IUserRepository;
using WebSite.Application.ITablesRepositories.ICommentRepository;
using WebSite.Persistence.Concretes.CommentRepository;
using WebSite.Application.ITablesRepositories.IPlaylistRepository;
using WebSite.Persistence.Concretes.PlaylistRepository;
using WebSite.Application.ITablesRepositories.ISubcommentRepository;
using WebSite.Persistence.Concretes.SubcommentRepository;
using WebSite.Application.ITablesRepositories.ISubscriptionRepository;
using WebSite.Persistence.Concretes.SubscriptionRepository;
using WebSite.Application.ITablesRepositories.IUserDislikeRepository;
using WebSite.Persistence.Concretes.UserDislikedRepository;
using WebSite.Application.ITablesRepositories.IUserLikedVideoRepository;
using WebSite.Persistence.Concretes.UserLikedRepository;
using WebSite.Application.ITablesRepositories.IUserWatchedRepository;
using WebSite.Persistence.Concretes.UserWatchedRepository;
using WebSite.Application.ITablesRepositories.IVideoRepository;
using WebSite.Persistence.Concretes.VideoRepository;

namespace WebSite.Persistence
{
    public static class ServicesRegistrations
    {
        public static void AddPersistenceRegistrations(this IServiceCollection services)
        {
            services.AddScoped<IUserRead, UserRead>();
            services.AddScoped<IUserWrite, UserWrite>();

            services.AddScoped<IVideoRead, VideoRead>();
            services.AddScoped<IVideoWrite, VideoWrite>();

            services.AddScoped<ICommentRead, CommentRead>();
            services.AddScoped<ICommentWrite, CommentWrite>();

            services.AddScoped<IPlaylistRead, PlaylistRead>();
            services.AddScoped<IPlaylistWrite, PlaylistWrite>();

            services.AddScoped<ISubcommentRead, SubcommentRead>();
            services.AddScoped<ISubcommentWrite, SubcommentWrite>();

            services.AddScoped<IUserWatchedRead, UserWatchedRead>();
            services.AddScoped<IUserWatchedWrite, UserWatchedWrite>();

            services.AddScoped<IUserLikedVideoRead, UserLikedRead>();
            services.AddScoped<IUserLikedVideoWrite, UserLikedWrite>();

            services.AddScoped< ISubscriptionRead, SubscriptionRead>();
            services.AddScoped< ISubscriptionWrite, SubscriptionWrite>();            

            services.AddScoped<IUserDislikedVideoRead, UserDislikedRead>();
            services.AddScoped<IUserDislikedVideoWrite, UserDislikedWrite>();

            services.AddDbContext<WebSiteDbContext>(options => options.UseSqlServer(ConfigurationsMine.GetConnectionString));
        }
    }
}
