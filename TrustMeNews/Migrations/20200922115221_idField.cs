using Microsoft.EntityFrameworkCore.Migrations;

namespace TrustMeNews.Migrations
{
    public partial class idField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_Result",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_Comment",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_Comment",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Articles_Result",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Articles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserID",
                table: "Comments",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_UserId",
                table: "Articles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserID",
                table: "Comments",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_UserId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Articles_UserId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "Comment",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Result",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Comment",
                table: "Comments",
                column: "Comment");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_Result",
                table: "Articles",
                column: "Result");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_Result",
                table: "Articles",
                column: "Result",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_Comment",
                table: "Comments",
                column: "Comment",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
