using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiMigrations
{
    /// <inheritdoc />
    public partial class updateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("0ad1ed9f-c599-4728-99aa-6e976d43ea45"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("c846343c-1dcb-4d5f-868f-fca120fe4255"));

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Users",
                type: "numeric",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6d83af1c-9cd1-44a1-9bc4-f932e8676872"), "Услуга" },
                    { new Guid("f19b0976-7c53-4b26-a582-46aab6d60b79"), "Товар" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("6d83af1c-9cd1-44a1-9bc4-f932e8676872"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("f19b0976-7c53-4b26-a582-46aab6d60b79"));

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Users");

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0ad1ed9f-c599-4728-99aa-6e976d43ea45"), "Товар" },
                    { new Guid("c846343c-1dcb-4d5f-868f-fca120fe4255"), "Услуга" }
                });
        }
    }
}
