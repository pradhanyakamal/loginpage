using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace loginrazor.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45ad14e1-96d9-4bd9-8997-832c8781727d", null, "teamleader", "teamleader" },
                    { "c61b9116-0afd-43c3-8bbc-04436a50bb56", null, "developer", "developer" },
                    { "e444b6d4-5d2f-4d66-a78c-7893607ba6d4", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45ad14e1-96d9-4bd9-8997-832c8781727d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c61b9116-0afd-43c3-8bbc-04436a50bb56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e444b6d4-5d2f-4d66-a78c-7893607ba6d4");
        }
    }
}
