using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberIsWomen = table.Column<bool>(type: "bit", nullable: true),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Channels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChannelName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ChannelDescription = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    VideoCount = table.Column<int>(type: "int", nullable: true),
                    SubscriberCount = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Channels_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Channels_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaylistName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VideoID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    PlaylistDescription = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PlaylistThumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlists_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ChannelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => new { x.UserID, x.ChannelID });
                    table.ForeignKey(
                        name: "FK_Subscriptions_Channels_ChannelID",
                        column: x => x.ChannelID,
                        principalTable: "Channels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    VideoDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VideoThumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LikeCount = table.Column<int>(type: "int", nullable: true),
                    DislikeCount = table.Column<int>(type: "int", nullable: true),
                    VideoViewCount = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    ChannelID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Video_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Video_Channels_ChannelID",
                        column: x => x.ChannelID,
                        principalTable: "Channels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Video_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheComment = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    VideoID = table.Column<int>(type: "int", nullable: false),
                    IsApropriate = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comment_Video_VideoID",
                        column: x => x.VideoID,
                        principalTable: "Video",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlaylistVideo",
                columns: table => new
                {
                    PlaylistsId = table.Column<int>(type: "int", nullable: false),
                    VideosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistVideo", x => new { x.PlaylistsId, x.VideosId });
                    table.ForeignKey(
                        name: "FK_PlaylistVideo_Playlists_PlaylistsId",
                        column: x => x.PlaylistsId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistVideo_Video_VideosId",
                        column: x => x.VideosId,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDislikedVideos",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    VideoID = table.Column<int>(type: "int", nullable: false),
                    DislikedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDislikedVideos", x => new { x.UserID, x.VideoID });
                    table.ForeignKey(
                        name: "FK_UserDislikedVideos_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDislikedVideos_Video_VideoID",
                        column: x => x.VideoID,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLikedVideos",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    VideoID = table.Column<int>(type: "int", nullable: false),
                    LikedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLikedVideos", x => new { x.UserID, x.VideoID });
                    table.ForeignKey(
                        name: "FK_UserLikedVideos_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLikedVideos_Video_VideoID",
                        column: x => x.VideoID,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWatchedVideos",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    VideoID = table.Column<int>(type: "int", nullable: false),
                    WatchedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWatchedVideos", x => new { x.UserID, x.VideoID });
                    table.ForeignKey(
                        name: "FK_UserWatchedVideos_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWatchedVideos_Video_VideoID",
                        column: x => x.VideoID,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheComment = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsApropriate = table.Column<bool>(type: "bit", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CommentID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubComments_Comment_CommentID",
                        column: x => x.CommentID,
                        principalTable: "Comment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubComments_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Channels_CategoryID",
                table: "Channels",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Channels_UserID",
                table: "Channels",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserID",
                table: "Comment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_VideoID",
                table: "Comment",
                column: "VideoID");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_UserID",
                table: "Playlists",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistVideo_VideosId",
                table: "PlaylistVideo",
                column: "VideosId");

            migrationBuilder.CreateIndex(
                name: "IX_SubComments_CommentID",
                table: "SubComments",
                column: "CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_SubComments_UserID",
                table: "SubComments",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_ChannelID",
                table: "Subscriptions",
                column: "ChannelID");

            migrationBuilder.CreateIndex(
                name: "IX_UserDislikedVideos_VideoID",
                table: "UserDislikedVideos",
                column: "VideoID");

            migrationBuilder.CreateIndex(
                name: "IX_UserLikedVideos_VideoID",
                table: "UserLikedVideos",
                column: "VideoID");

            migrationBuilder.CreateIndex(
                name: "IX_UserWatchedVideos_VideoID",
                table: "UserWatchedVideos",
                column: "VideoID");

            migrationBuilder.CreateIndex(
                name: "IX_Video_CategoryID",
                table: "Video",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Video_ChannelID",
                table: "Video",
                column: "ChannelID");

            migrationBuilder.CreateIndex(
                name: "IX_Video_UserID",
                table: "Video",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaylistVideo");

            migrationBuilder.DropTable(
                name: "SubComments");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "UserDislikedVideos");

            migrationBuilder.DropTable(
                name: "UserLikedVideos");

            migrationBuilder.DropTable(
                name: "UserWatchedVideos");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Channels");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
