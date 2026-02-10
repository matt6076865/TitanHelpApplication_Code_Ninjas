using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TitanHelpApplication.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProblemDescription = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Priority = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Date", "Name", "Priority", "ProblemDescription", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 2, 6, 1, 19, 21, 496, DateTimeKind.Local).AddTicks(9652), "Alice Smith", "Medium", "Printer jammed", "Open" },
                    { 2, new DateTime(2026, 2, 6, 1, 19, 21, 497, DateTimeKind.Local).AddTicks(42), "Bob Jones", "High", "Email login failed", "Open" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
