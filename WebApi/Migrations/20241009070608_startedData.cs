using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiMigrations
{
    /// <inheritdoc />
    public partial class startedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("6d83af1c-9cd1-44a1-9bc4-f932e8676872"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("f19b0976-7c53-4b26-a582-46aab6d60b79"));

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Created", "Description", "Title" },
                values: new object[] { new Guid("ae577988-728e-4bce-9844-4a6c9b94715d"), new DateTime(2024, 11, 3, 7, 6, 7, 864, DateTimeKind.Utc).AddTicks(1340), "Desc1", "Title1" });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b78315ac-5974-4486-8304-9d05f178ee2c"), "Услуга" },
                    { new Guid("f1809ced-84a3-41ba-b90a-4b8000df13a3"), "Товар" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discount", "FIO", "IsClient", "IsProvider" },
                values: new object[,]
                {
                    { new Guid("23c79b89-d2ad-4b8e-ba33-11ca50388be4"), 0m, "Максимов Максим Максимович", false, true },
                    { new Guid("7df6c1ac-a827-4b46-adc4-2dcc4e4e4131"), 10m, "Иванов Иван Иванович", true, true },
                    { new Guid("9c6c2d50-79c8-43fa-bf4b-121ee2394df4"), 0m, "Петров Петр Петрович", true, false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { new Guid("056b702f-d98a-443c-9587-ca64617e23fd"), 1, "Песня, сгенерированная нейросетью", 100m, new Guid("f1809ced-84a3-41ba-b90a-4b8000df13a3") },
                    { new Guid("0dc9404f-f079-4e89-a331-b58db8089d88"), 1, "Видеоурок \"Как сделать первый 3D дизайн\"", 2000m, new Guid("f1809ced-84a3-41ba-b90a-4b8000df13a3") },
                    { new Guid("1124ef01-12cf-46e3-aaac-e8c20b0ba855"), 1, "Цифровой арт \"Красивый город\"", 5000m, new Guid("f1809ced-84a3-41ba-b90a-4b8000df13a3") },
                    { new Guid("4362281a-6132-45f3-bad4-edc424c1c034"), 1, "Видеоурок \"Песня \"Ромашки\" на гитаре\"", 2000m, new Guid("f1809ced-84a3-41ba-b90a-4b8000df13a3") },
                    { new Guid("65e10283-95aa-4711-9052-745de9005f1b"), 1, "Онлайн урок по рисованию", 1900m, new Guid("b78315ac-5974-4486-8304-9d05f178ee2c") },
                    { new Guid("81fc0df0-5b56-441c-885e-99fc1dbe2736"), 1, "Цифровой арт \"Цифровое искусство\"", 5000m, new Guid("f1809ced-84a3-41ba-b90a-4b8000df13a3") },
                    { new Guid("938674e5-14d6-4734-bc80-4344b071aab2"), 1, "Помощь с идеей для вашего проекта", 500m, new Guid("b78315ac-5974-4486-8304-9d05f178ee2c") },
                    { new Guid("af8c9018-a90c-45d9-adff-3cfd1a915b67"), 1, "Курс \"Художник за месяц\"", 6000m, new Guid("f1809ced-84a3-41ba-b90a-4b8000df13a3") },
                    { new Guid("d22977f1-0369-4b4d-9646-6731f70b6f69"), 1, "Реклама", 10000m, new Guid("b78315ac-5974-4486-8304-9d05f178ee2c") },
                    { new Guid("d893676f-1bf7-4a46-a17e-a859d7721a14"), 1, "Цифровой арт \"Далекое будущее\"", 5000m, new Guid("f1809ced-84a3-41ba-b90a-4b8000df13a3") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Count", "ProductId", "Sum", "UserId" },
                values: new object[] { new Guid("e7e98153-2027-417a-8249-b900f49a1522"), 1, new Guid("d893676f-1bf7-4a46-a17e-a859d7721a14"), 1m, new Guid("7df6c1ac-a827-4b46-adc4-2dcc4e4e4131") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("ae577988-728e-4bce-9844-4a6c9b94715d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e7e98153-2027-417a-8249-b900f49a1522"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("056b702f-d98a-443c-9587-ca64617e23fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0dc9404f-f079-4e89-a331-b58db8089d88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1124ef01-12cf-46e3-aaac-e8c20b0ba855"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4362281a-6132-45f3-bad4-edc424c1c034"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65e10283-95aa-4711-9052-745de9005f1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81fc0df0-5b56-441c-885e-99fc1dbe2736"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("938674e5-14d6-4734-bc80-4344b071aab2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af8c9018-a90c-45d9-adff-3cfd1a915b67"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d22977f1-0369-4b4d-9646-6731f70b6f69"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23c79b89-d2ad-4b8e-ba33-11ca50388be4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c6c2d50-79c8-43fa-bf4b-121ee2394df4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d893676f-1bf7-4a46-a17e-a859d7721a14"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("b78315ac-5974-4486-8304-9d05f178ee2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7df6c1ac-a827-4b46-adc4-2dcc4e4e4131"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("f1809ced-84a3-41ba-b90a-4b8000df13a3"));

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6d83af1c-9cd1-44a1-9bc4-f932e8676872"), "Услуга" },
                    { new Guid("f19b0976-7c53-4b26-a582-46aab6d60b79"), "Товар" }
                });
        }
    }
}
