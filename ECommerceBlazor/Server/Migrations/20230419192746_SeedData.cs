using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerceBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "First product First product First product First product First product First product First product ", "https://www.notion.so/cdn-cgi/image/format=auto,width=3840,quality=100/https://images.ctfassets.net/spoqsaf9291f/4LkRwsdriDUzmpgR2QVCf7/95ebe8f6296bd68f14f0ae0291cb51c0/Productwiki.png", "First product", 99.9m },
                    { 2, "Second Product Second Product Second Product Second Product Second Product Second Product Second Product Second Product Second Product Second Product ", "https://www.notion.so/cdn-cgi/image/format=auto,width=3840,quality=100/https://images.ctfassets.net/spoqsaf9291f/4LkRwsdriDUzmpgR2QVCf7/95ebe8f6296bd68f14f0ae0291cb51c0/Productwiki.png", "Second Product", 99.9m },
                    { 3, "Third Product Third Product Third Product Third Product Third Product Third Product Third Product Third Product ", "https://www.notion.so/cdn-cgi/image/format=auto,width=3840,quality=100/https://images.ctfassets.net/spoqsaf9291f/4LkRwsdriDUzmpgR2QVCf7/95ebe8f6296bd68f14f0ae0291cb51c0/Productwiki.png", "Third Product ", 99.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
