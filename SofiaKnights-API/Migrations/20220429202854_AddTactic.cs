using Microsoft.EntityFrameworkCore.Migrations;

namespace SofiaKnights_API.Migrations
{
    public partial class AddTactic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0eb0a08c-98b1-4a8e-a46a-2943da1629a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83c31df0-feb2-49aa-baad-2dc6011ccd06");

            migrationBuilder.CreateTable(
                name: "Tactics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Formation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Concept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tactics", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tactics");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0eb0a08c-98b1-4a8e-a46a-2943da1629a0", "35760c71-68dd-4be1-a760-08d952306c0b", "Viewer", "VIEWER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83c31df0-feb2-49aa-baad-2dc6011ccd06", "66d2cf8c-6123-45c6-82aa-56b21611ad95", "Administrator", "ADMINISTRATOR" });
        }
    }
}
