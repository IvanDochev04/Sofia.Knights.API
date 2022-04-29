using Microsoft.EntityFrameworkCore.Migrations;

namespace SofiaKnights_API.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00214c5d-c9ca-43af-9beb-7d1761ddf7e6", "89d02588-bacc-43a7-adf9-a150298cc3ea", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e6d58bd-34a6-4590-aa18-7ca3f1f03cee", "2f48b924-ce3c-4526-849f-e91e9a24be1d", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00214c5d-c9ca-43af-9beb-7d1761ddf7e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e6d58bd-34a6-4590-aa18-7ca3f1f03cee");
        }
    }
}
