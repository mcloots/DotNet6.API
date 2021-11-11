using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet.API.Migrations
{
    public partial class initialDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "List",
                columns: new[] { "ListId", "Name" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "List",
                columns: new[] { "ListId", "Name" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "Description", "ListId" },
                values: new object[] { 1, "Cooking", 1 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "Description", "ListId" },
                values: new object[] { 2, "Cleaning", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "List",
                keyColumn: "ListId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "List",
                keyColumn: "ListId",
                keyValue: 1);
        }
    }
}
