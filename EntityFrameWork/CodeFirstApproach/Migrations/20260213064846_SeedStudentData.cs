using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BranchId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 1, "shubham@gmail.com", "Shubham", 91 },
                    { 2, 2, "rahul@gmail.com", "Rahul", 92 },
                    { 3, 1, "amit@gmail.com", "Amit", 93 },
                    { 4, 3, "priya@gmail.com", "Priya", 94 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
