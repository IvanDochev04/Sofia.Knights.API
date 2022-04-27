using Microsoft.EntityFrameworkCore.Migrations;

namespace SofiaKnights_API.Migrations
{
    public partial class InitialRoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd8599a5-1085-4233-82fb-585001d808bb", "86da4565-f5dc-4685-9ae3-cdd1edfe0d3c", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45340321-2772-40e4-8eed-f29f97d10e65", "19936f84-8f05-45dc-9cf8-db4508551a8f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45340321-2772-40e4-8eed-f29f97d10e65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd8599a5-1085-4233-82fb-585001d808bb");
        }
    }
}
