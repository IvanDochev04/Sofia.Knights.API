using Microsoft.EntityFrameworkCore.Migrations;

namespace SofiaKnights_API.Migrations
{
    public partial class AwardPictureAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18c7a996-e02a-4094-b0eb-320c803d8dcc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba98d165-5d2d-4565-a9e0-7a6f18833eba");

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Awards",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0eb0a08c-98b1-4a8e-a46a-2943da1629a0", "35760c71-68dd-4be1-a760-08d952306c0b", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83c31df0-feb2-49aa-baad-2dc6011ccd06", "66d2cf8c-6123-45c6-82aa-56b21611ad95", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0eb0a08c-98b1-4a8e-a46a-2943da1629a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83c31df0-feb2-49aa-baad-2dc6011ccd06");

            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Awards");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18c7a996-e02a-4094-b0eb-320c803d8dcc", "4f6108e4-54cc-4901-a9e5-10d7e1253a4b", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba98d165-5d2d-4565-a9e0-7a6f18833eba", "fb4edaf8-397d-42cf-bb45-4cc11a9d0a7d", "Administrator", "ADMINISTRATOR" });
        }
    }
}
