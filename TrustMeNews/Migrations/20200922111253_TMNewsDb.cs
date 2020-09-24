using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrustMeNews.Migrations
{
    public partial class TMNewsDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    headline = table.Column<string>(nullable: false),
                    standfirst = table.Column<string>(nullable: true),
                    byline = table.Column<string>(nullable: true),
                    main = table.Column<string>(nullable: true),
                    bodyText = table.Column<string>(nullable: true),
                    thumbnail = table.Column<string>(nullable: true),
                    trailText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.headline);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    sectionId = table.Column<string>(nullable: true),
                    sectionName = table.Column<string>(nullable: true),
                    webPublicationDate = table.Column<DateTime>(nullable: false),
                    webTitle = table.Column<string>(nullable: true),
                    fieldsheadline = table.Column<string>(nullable: true),
                    Result = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.id);
                    table.ForeignKey(
                        name: "FK_Articles_Users_Result",
                        column: x => x.Result,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articles_Field_fieldsheadline",
                        column: x => x.fieldsheadline,
                        principalTable: "Field",
                        principalColumn: "headline",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    Comment = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Users_Comment",
                        column: x => x.Comment,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_Result",
                table: "Articles",
                column: "Result");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_fieldsheadline",
                table: "Articles",
                column: "fieldsheadline");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Comment",
                table: "Comments",
                column: "Comment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
