﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSite.Persistence.Context;

#nullable disable

namespace WebSite.Persistence.Migrations
{
    [DbContext(typeof(WebSiteDbContext))]
    [Migration("20230120003516_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlaylistVideo", b =>
                {
                    b.Property<int>("PlaylistsId")
                        .HasColumnType("int");

                    b.Property<int>("VideosId")
                        .HasColumnType("int");

                    b.HasKey("PlaylistsId", "VideosId");

                    b.HasIndex("VideosId");

                    b.ToTable("PlaylistVideo");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Channel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ChannelDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChannelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubscriberCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int?>("VideoCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.HasIndex("UserID");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsApropriate")
                        .HasColumnType("bit");

                    b.Property<string>("TheComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("VideoID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.HasIndex("VideoID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PlaylistDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaylistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaylistThumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("VideoID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.SubComment", b =>
                {
                    b.Property<int>("SubCommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCommentID"));

                    b.Property<int>("CommentID")
                        .HasColumnType("int");

                    b.Property<bool>("IsApropriate")
                        .HasColumnType("bit");

                    b.Property<string>("TheComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("SubCommentID");

                    b.HasIndex("CommentID");

                    b.HasIndex("UserID");

                    b.ToTable("SubComments");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Subcription", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("ChannelID")
                        .HasColumnType("int");

                    b.HasKey("UserID", "ChannelID");

                    b.HasIndex("ChannelID");

                    b.ToTable("Subcriptions");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("MemberIsWomen")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("ProfilePhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.UserDislikedVideo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DislikedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("VideoID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.HasIndex("VideoID");

                    b.ToTable("UserDislikedVideos");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.UserLikedVideo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("LikedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("VideoID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.HasIndex("VideoID");

                    b.ToTable("UserLikedVideos");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.UserWatchedVideo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("VideoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("WatchedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.HasIndex("VideoID");

                    b.ToTable("UserWatchedVideos");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("ChannelID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DislikeCount")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("LikeCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("VideoDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoThumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VideoViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.HasIndex("ChannelID");

                    b.HasIndex("UserID");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("PlaylistVideo", b =>
                {
                    b.HasOne("WebSite.Domain.Entities.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebSite.Domain.Entities.Video", null)
                        .WithMany()
                        .HasForeignKey("VideosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Channel", b =>
                {
                    b.HasOne("WebSite.Domain.Entities.Category", "Category")
                        .WithMany("Channels")
                        .HasForeignKey("CategoryID")
                        .IsRequired();

                    b.HasOne("WebSite.Domain.Entities.User", "AdminUser")
                        .WithMany("AdminChannels")
                        .HasForeignKey("UserID")
                        .IsRequired();

                    b.Navigation("AdminUser");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Comment", b =>
                {
                    b.HasOne("WebSite.Domain.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserID")
                        .IsRequired();

                    b.HasOne("WebSite.Domain.Entities.Video", "Video")
                        .WithMany("Comments")
                        .HasForeignKey("VideoID")
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Playlist", b =>
                {
                    b.HasOne("WebSite.Domain.Entities.User", "User")
                        .WithMany("Playlists")
                        .HasForeignKey("UserID")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.SubComment", b =>
                {
                    b.HasOne("WebSite.Domain.Entities.Comment", "Comment")
                        .WithMany("SubComments")
                        .HasForeignKey("CommentID")
                        .IsRequired();

                    b.HasOne("WebSite.Domain.Entities.User", "User")
                        .WithMany("SubComments")
                        .HasForeignKey("UserID")
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Subcription", b =>
                {
                    b.HasOne("WebSite.Domain.Entities.Channel", "Channel")
                        .WithMany("SubscribedUsers")
                        .HasForeignKey("ChannelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebSite.Domain.Entities.User", "User")
                        .WithMany("SubscribedChannels")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.UserDislikedVideo", b =>
                {
                    b.HasOne("WebSite.Domain.Entities.User", "User")
                        .WithMany("DislikedVideos")
                        .HasForeignKey("UserID")
                        .IsRequired();

                    b.HasOne("WebSite.Domain.Entities.Video", "Video")
                        .WithMany("DislikedVideos")
                        .HasForeignKey("VideoID")
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.UserLikedVideo", b =>
                {
                    b.HasOne("WebSite.Domain.Entities.User", "User")
                        .WithMany("LikedVideos")
                        .HasForeignKey("UserID")
                        .IsRequired();

                    b.HasOne("WebSite.Domain.Entities.Video", "Video")
                        .WithMany("LikedVideos")
                        .HasForeignKey("VideoID")
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.UserWatchedVideo", b =>
                {
                    b.HasOne("WebSite.Domain.Entities.User", "User")
                        .WithMany("WatchedVideos")
                        .HasForeignKey("UserID")
                        .IsRequired();

                    b.HasOne("WebSite.Domain.Entities.Video", "Video")
                        .WithMany("WatchedVideos")
                        .HasForeignKey("VideoID")
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Video", b =>
                {
                    b.HasOne("WebSite.Domain.Entities.Category", "Category")
                        .WithMany("Videos")
                        .HasForeignKey("CategoryID")
                        .IsRequired();

                    b.HasOne("WebSite.Domain.Entities.Channel", "Channel")
                        .WithMany("Videos")
                        .HasForeignKey("ChannelID")
                        .IsRequired();

                    b.HasOne("WebSite.Domain.Entities.User", "User")
                        .WithMany("Videos")
                        .HasForeignKey("UserID")
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Channel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Category", b =>
                {
                    b.Navigation("Channels");

                    b.Navigation("Videos");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Channel", b =>
                {
                    b.Navigation("SubscribedUsers");

                    b.Navigation("Videos");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Comment", b =>
                {
                    b.Navigation("SubComments");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.User", b =>
                {
                    b.Navigation("AdminChannels");

                    b.Navigation("Comments");

                    b.Navigation("DislikedVideos");

                    b.Navigation("LikedVideos");

                    b.Navigation("Playlists");

                    b.Navigation("SubComments");

                    b.Navigation("SubscribedChannels");

                    b.Navigation("Videos");

                    b.Navigation("WatchedVideos");
                });

            modelBuilder.Entity("WebSite.Domain.Entities.Video", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("DislikedVideos");

                    b.Navigation("LikedVideos");

                    b.Navigation("WatchedVideos");
                });
#pragma warning restore 612, 618
        }
    }
}