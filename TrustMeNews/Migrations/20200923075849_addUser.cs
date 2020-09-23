using Microsoft.EntityFrameworkCore.Migrations;

namespace TrustMeNews.Migrations
{
    public partial class addUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Password", "SessionId", "UserName" },
                values: new object[] { 1, "dolla@bigmoney.cash", "money", null, "Dolla$ign" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}
