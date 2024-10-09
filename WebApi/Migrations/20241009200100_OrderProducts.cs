using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiMigrations
{
    /// <inheritdoc />
    public partial class OrderProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProductId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e27b1bb1-555e-4dde-bb6d-fd6e65bbacf8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("458c8a33-8b85-48e3-8a45-35255ba26b00"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("239dc1f9-f6fa-4a25-a7c6-c2da45e34191"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b21bf5f-9e8e-4d44-9694-9e6bdf552154"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fd2001c-1772-461e-bfa5-a85c259448c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96e495df-484f-419d-a3f0-f01171b0bf43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bc91a43-4f0e-4db6-a7b2-dc75409d7644"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e33e7c8-e0e3-44de-acda-dee3973232b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b25d5a5a-2155-4944-9455-b620d68c713b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7cc61d0-3bd5-4d41-8efd-1f8e63352b1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dada8280-b999-4fa7-bf76-88326b1bb056"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90f537d4-c46b-4f4e-9978-9c1156fb2d30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d01fe64d-c823-4b7a-948a-b30dd58a9043"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a4d9b48-ed19-4578-bcb5-92418e08403a"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("01b7d1d6-fa88-4fa5-85ae-3c54a6602fe2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fbf9d1e1-5773-4507-81ba-35ad787ed33d"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f"));

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Orders");

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Users",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Created", "Description", "Title" },
                values: new object[] { new Guid("ea1c4ded-edf8-48c3-a9e5-e6b813673e33"), new DateTime(2024, 10, 29, 20, 0, 59, 975, DateTimeKind.Utc).AddTicks(4985), "Desc1", "Title1" });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02b1143a-7a7c-43a0-b701-cf0bdf18b59b"), "Услуга" },
                    { new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10"), "Товар" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discount", "FIO", "IsClient", "IsProvider" },
                values: new object[,]
                {
                    { new Guid("0dd1c72a-e674-4373-9423-df5de9d1a506"), 0m, "Петров Петр Петрович", true, false },
                    { new Guid("3d0c1708-d345-4a94-9033-cd608dbcf986"), 10m, "Иванов Иван Иванович", true, true },
                    { new Guid("feb0569b-57ab-4b68-bb99-672522b32ade"), 0m, "Максимов Максим Максимович", false, true }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Sum", "UserId" },
                values: new object[] { new Guid("329d94cc-9384-4b7d-82f3-e7b9849198a2"), 1m, new Guid("3d0c1708-d345-4a94-9033-cd608dbcf986") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { new Guid("0ab5e34f-b0ce-48e7-add4-6b90e541188b"), 1, "Цифровой арт \"Красивый город\"", 5000m, new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10") },
                    { new Guid("244722fb-5822-488e-957d-63fbf2d124cb"), 1, "Видеоурок \"Песня \"Ромашки\" на гитаре\"", 2000m, new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10") },
                    { new Guid("32d2d2aa-afed-4b7e-9ab6-6a1069da67e8"), 1, "Цифровой арт \"Цифровое искусство\"", 5000m, new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10") },
                    { new Guid("3f3f0a3d-879e-4c70-9b67-244a198503ef"), 1, "Помощь с идеей для вашего проекта", 500m, new Guid("02b1143a-7a7c-43a0-b701-cf0bdf18b59b") },
                    { new Guid("4b03d3da-16b7-40ef-be7d-b7d3c9ec57e1"), 1, "Песня, сгенерированная нейросетью", 100m, new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10") },
                    { new Guid("5922576e-1645-44bd-b46f-73dbc2767715"), 1, "Цифровой арт \"Далекое будущее\"", 5000m, new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10") },
                    { new Guid("ca801d47-180c-4fc3-8fb0-b822e28047ab"), 1, "Реклама", 10000m, new Guid("02b1143a-7a7c-43a0-b701-cf0bdf18b59b") },
                    { new Guid("f7ab464f-bd8a-4007-95dd-a525041e98a3"), 1, "Курс \"Художник за месяц\"", 6000m, new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10") },
                    { new Guid("f8306c6c-b934-451d-9156-3da0c2f7fb5c"), 1, "Онлайн урок по рисованию", 1900m, new Guid("02b1143a-7a7c-43a0-b701-cf0bdf18b59b") },
                    { new Guid("fc4cd567-52da-4590-ac58-04cc5a162a79"), 1, "Видеоурок \"Как сделать первый 3D дизайн\"", 2000m, new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("ea1c4ded-edf8-48c3-a9e5-e6b813673e33"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("329d94cc-9384-4b7d-82f3-e7b9849198a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ab5e34f-b0ce-48e7-add4-6b90e541188b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("244722fb-5822-488e-957d-63fbf2d124cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32d2d2aa-afed-4b7e-9ab6-6a1069da67e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f3f0a3d-879e-4c70-9b67-244a198503ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b03d3da-16b7-40ef-be7d-b7d3c9ec57e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5922576e-1645-44bd-b46f-73dbc2767715"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca801d47-180c-4fc3-8fb0-b822e28047ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7ab464f-bd8a-4007-95dd-a525041e98a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8306c6c-b934-451d-9156-3da0c2f7fb5c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc4cd567-52da-4590-ac58-04cc5a162a79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0dd1c72a-e674-4373-9423-df5de9d1a506"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("feb0569b-57ab-4b68-bb99-672522b32ade"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("02b1143a-7a7c-43a0-b701-cf0bdf18b59b"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d0c1708-d345-4a94-9033-cd608dbcf986"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Users",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Created", "Description", "Title" },
                values: new object[] { new Guid("e27b1bb1-555e-4dde-bb6d-fd6e65bbacf8"), new DateTime(2024, 10, 16, 8, 50, 6, 208, DateTimeKind.Utc).AddTicks(4359), "Desc1", "Title1" });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01b7d1d6-fa88-4fa5-85ae-3c54a6602fe2"), "Услуга" },
                    { new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f"), "Товар" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discount", "FIO", "IsClient", "IsProvider" },
                values: new object[,]
                {
                    { new Guid("90f537d4-c46b-4f4e-9978-9c1156fb2d30"), 0m, "Максимов Максим Максимович", false, true },
                    { new Guid("d01fe64d-c823-4b7a-948a-b30dd58a9043"), 0m, "Петров Петр Петрович", true, false },
                    { new Guid("fbf9d1e1-5773-4507-81ba-35ad787ed33d"), 10m, "Иванов Иван Иванович", true, true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { new Guid("239dc1f9-f6fa-4a25-a7c6-c2da45e34191"), 1, "Реклама", 10000m, new Guid("01b7d1d6-fa88-4fa5-85ae-3c54a6602fe2") },
                    { new Guid("3a4d9b48-ed19-4578-bcb5-92418e08403a"), 1, "Цифровой арт \"Далекое будущее\"", 5000m, new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f") },
                    { new Guid("3b21bf5f-9e8e-4d44-9694-9e6bdf552154"), 1, "Видеоурок \"Как сделать первый 3D дизайн\"", 2000m, new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f") },
                    { new Guid("6fd2001c-1772-461e-bfa5-a85c259448c6"), 1, "Онлайн урок по рисованию", 1900m, new Guid("01b7d1d6-fa88-4fa5-85ae-3c54a6602fe2") },
                    { new Guid("96e495df-484f-419d-a3f0-f01171b0bf43"), 1, "Песня, сгенерированная нейросетью", 100m, new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f") },
                    { new Guid("9bc91a43-4f0e-4db6-a7b2-dc75409d7644"), 1, "Цифровой арт \"Красивый город\"", 5000m, new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f") },
                    { new Guid("9e33e7c8-e0e3-44de-acda-dee3973232b7"), 1, "Помощь с идеей для вашего проекта", 500m, new Guid("01b7d1d6-fa88-4fa5-85ae-3c54a6602fe2") },
                    { new Guid("b25d5a5a-2155-4944-9455-b620d68c713b"), 1, "Курс \"Художник за месяц\"", 6000m, new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f") },
                    { new Guid("b7cc61d0-3bd5-4d41-8efd-1f8e63352b1c"), 1, "Цифровой арт \"Цифровое искусство\"", 5000m, new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f") },
                    { new Guid("dada8280-b999-4fa7-bf76-88326b1bb056"), 1, "Видеоурок \"Песня \"Ромашки\" на гитаре\"", 2000m, new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Count", "ProductId", "Sum", "UserId" },
                values: new object[] { new Guid("458c8a33-8b85-48e3-8a45-35255ba26b00"), 1, new Guid("3a4d9b48-ed19-4578-bcb5-92418e08403a"), 1m, new Guid("fbf9d1e1-5773-4507-81ba-35ad787ed33d") });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
