using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiMigrations
{
    /// <inheritdoc />
    public partial class fixNewsv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e335c050-354b-42f4-8561-9118339c6cb9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d02ff807-131c-45e8-a6e5-1ed8d2890a7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0984269e-e6f6-4d76-9067-38895d1a91bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09afb0b8-76fe-40d1-917d-c0d6efcb6f81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a1a0003-bbf5-43bc-88fa-3f1f5ba687d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6775fa60-fc4e-4ca0-a1ed-9b32d7e53350"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ba56657-d1b0-4a62-a933-04381519feee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81aad1fd-3801-4a02-9458-02a7854a5512"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf29ea44-813b-47bb-b636-98959aa45234"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc988e29-6ef9-4c44-89e9-afd13d828fd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9ef5306-25e5-4d70-88d2-dbea89850c34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81789b7c-749c-43a8-a30e-4e6fe7a6a01b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d972a32d-2ec9-4b26-8970-ca36461b8e54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48317e7e-b453-4bc6-92d2-3eab900c0fa6"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("045eef69-46cf-4a29-bcb4-bd82fb18a195"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1531297b-56d7-4995-af25-e46596f6aa57"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("d05fe978-8895-462a-af5b-82c3afd94a75"));

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Created", "Description", "Title" },
                values: new object[] { new Guid("f76c24f4-073c-4ef4-8b8d-2f2ecbcc087e"), new DateTimeOffset(new DateTime(2024, 10, 13, 8, 46, 28, 697, DateTimeKind.Unspecified).AddTicks(6216), new TimeSpan(0, 0, 0, 0, 0)), "Desc1", "Title1" });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3a926894-f547-4c27-be60-73630ed2104c"), "Товар" },
                    { new Guid("81c6969d-569a-4ab5-8ef0-43430b254a9f"), "Услуга" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discount", "FIO", "IsClient", "IsProvider" },
                values: new object[,]
                {
                    { new Guid("0e0e539b-701c-4e0d-ae00-ca994e6dee1a"), 10m, "Иванов Иван Иванович", true, true },
                    { new Guid("1d4c605c-5906-400f-b17a-7022e5c3ccb4"), 0m, "Петров Петр Петрович", true, false },
                    { new Guid("b129c46e-51df-4bf4-8df7-76bff66750af"), 0m, "Максимов Максим Максимович", false, true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { new Guid("63bbc6e5-2e00-4ffe-8d1d-930b2fde0fc3"), 1, "Видеоурок \"Как сделать первый 3D дизайн\"", 2000m, new Guid("3a926894-f547-4c27-be60-73630ed2104c") },
                    { new Guid("816affd9-1bdb-4f45-9b03-570fd48ea190"), 1, "Курс \"Художник за месяц\"", 6000m, new Guid("3a926894-f547-4c27-be60-73630ed2104c") },
                    { new Guid("94a876e6-d27b-4613-b550-9ad3d81bcbf8"), 1, "Видеоурок \"Песня \"Ромашки\" на гитаре\"", 2000m, new Guid("3a926894-f547-4c27-be60-73630ed2104c") },
                    { new Guid("a0a6ea53-a7f2-46e7-ab2c-3e843e6f2310"), 1, "Помощь с идеей для вашего проекта", 500m, new Guid("81c6969d-569a-4ab5-8ef0-43430b254a9f") },
                    { new Guid("a7df5752-81a7-4bcd-b259-18ae2ae61744"), 1, "Цифровой арт \"Цифровое искусство\"", 5000m, new Guid("3a926894-f547-4c27-be60-73630ed2104c") },
                    { new Guid("a8a860ef-0dda-4bbe-ba6a-f9f9aae437ff"), 1, "Цифровой арт \"Далекое будущее\"", 5000m, new Guid("3a926894-f547-4c27-be60-73630ed2104c") },
                    { new Guid("aa6424a4-807b-4841-90fd-efb5b0a4a6c4"), 1, "Реклама", 10000m, new Guid("81c6969d-569a-4ab5-8ef0-43430b254a9f") },
                    { new Guid("b67687cf-8e4a-4f31-9b2d-03376cd4f4d4"), 1, "Онлайн урок по рисованию", 1900m, new Guid("81c6969d-569a-4ab5-8ef0-43430b254a9f") },
                    { new Guid("bc2459d8-8a61-471d-b4e1-46e63aa27658"), 1, "Цифровой арт \"Красивый город\"", 5000m, new Guid("3a926894-f547-4c27-be60-73630ed2104c") },
                    { new Guid("cc44c11f-cd20-4968-a052-8a6c3ccc74dd"), 1, "Песня, сгенерированная нейросетью", 100m, new Guid("3a926894-f547-4c27-be60-73630ed2104c") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Count", "ProductId", "Sum", "UserId" },
                values: new object[] { new Guid("46092bf3-34f7-4851-a885-a5d54fe3fb43"), 1, new Guid("a8a860ef-0dda-4bbe-ba6a-f9f9aae437ff"), 1m, new Guid("0e0e539b-701c-4e0d-ae00-ca994e6dee1a") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("f76c24f4-073c-4ef4-8b8d-2f2ecbcc087e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("46092bf3-34f7-4851-a885-a5d54fe3fb43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63bbc6e5-2e00-4ffe-8d1d-930b2fde0fc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("816affd9-1bdb-4f45-9b03-570fd48ea190"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94a876e6-d27b-4613-b550-9ad3d81bcbf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0a6ea53-a7f2-46e7-ab2c-3e843e6f2310"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7df5752-81a7-4bcd-b259-18ae2ae61744"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa6424a4-807b-4841-90fd-efb5b0a4a6c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b67687cf-8e4a-4f31-9b2d-03376cd4f4d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc2459d8-8a61-471d-b4e1-46e63aa27658"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc44c11f-cd20-4968-a052-8a6c3ccc74dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d4c605c-5906-400f-b17a-7022e5c3ccb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b129c46e-51df-4bf4-8df7-76bff66750af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8a860ef-0dda-4bbe-ba6a-f9f9aae437ff"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("81c6969d-569a-4ab5-8ef0-43430b254a9f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e0e539b-701c-4e0d-ae00-ca994e6dee1a"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("3a926894-f547-4c27-be60-73630ed2104c"));

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Created", "Description", "Title" },
                values: new object[] { new Guid("e335c050-354b-42f4-8561-9118339c6cb9"), new DateTime(2024, 10, 25, 8, 43, 24, 779, DateTimeKind.Utc).AddTicks(5681), "Desc1", "Title1" });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("045eef69-46cf-4a29-bcb4-bd82fb18a195"), "Услуга" },
                    { new Guid("d05fe978-8895-462a-af5b-82c3afd94a75"), "Товар" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discount", "FIO", "IsClient", "IsProvider" },
                values: new object[,]
                {
                    { new Guid("1531297b-56d7-4995-af25-e46596f6aa57"), 10m, "Иванов Иван Иванович", true, true },
                    { new Guid("81789b7c-749c-43a8-a30e-4e6fe7a6a01b"), 0m, "Максимов Максим Максимович", false, true },
                    { new Guid("d972a32d-2ec9-4b26-8970-ca36461b8e54"), 0m, "Петров Петр Петрович", true, false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { new Guid("0984269e-e6f6-4d76-9067-38895d1a91bd"), 1, "Онлайн урок по рисованию", 1900m, new Guid("045eef69-46cf-4a29-bcb4-bd82fb18a195") },
                    { new Guid("09afb0b8-76fe-40d1-917d-c0d6efcb6f81"), 1, "Песня, сгенерированная нейросетью", 100m, new Guid("d05fe978-8895-462a-af5b-82c3afd94a75") },
                    { new Guid("48317e7e-b453-4bc6-92d2-3eab900c0fa6"), 1, "Цифровой арт \"Далекое будущее\"", 5000m, new Guid("d05fe978-8895-462a-af5b-82c3afd94a75") },
                    { new Guid("5a1a0003-bbf5-43bc-88fa-3f1f5ba687d5"), 1, "Цифровой арт \"Красивый город\"", 5000m, new Guid("d05fe978-8895-462a-af5b-82c3afd94a75") },
                    { new Guid("6775fa60-fc4e-4ca0-a1ed-9b32d7e53350"), 1, "Видеоурок \"Как сделать первый 3D дизайн\"", 2000m, new Guid("d05fe978-8895-462a-af5b-82c3afd94a75") },
                    { new Guid("7ba56657-d1b0-4a62-a933-04381519feee"), 1, "Помощь с идеей для вашего проекта", 500m, new Guid("045eef69-46cf-4a29-bcb4-bd82fb18a195") },
                    { new Guid("81aad1fd-3801-4a02-9458-02a7854a5512"), 1, "Курс \"Художник за месяц\"", 6000m, new Guid("d05fe978-8895-462a-af5b-82c3afd94a75") },
                    { new Guid("bf29ea44-813b-47bb-b636-98959aa45234"), 1, "Реклама", 10000m, new Guid("045eef69-46cf-4a29-bcb4-bd82fb18a195") },
                    { new Guid("dc988e29-6ef9-4c44-89e9-afd13d828fd6"), 1, "Видеоурок \"Песня \"Ромашки\" на гитаре\"", 2000m, new Guid("d05fe978-8895-462a-af5b-82c3afd94a75") },
                    { new Guid("f9ef5306-25e5-4d70-88d2-dbea89850c34"), 1, "Цифровой арт \"Цифровое искусство\"", 5000m, new Guid("d05fe978-8895-462a-af5b-82c3afd94a75") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Count", "ProductId", "Sum", "UserId" },
                values: new object[] { new Guid("d02ff807-131c-45e8-a6e5-1ed8d2890a7e"), 1, new Guid("48317e7e-b453-4bc6-92d2-3eab900c0fa6"), 1m, new Guid("1531297b-56d7-4995-af25-e46596f6aa57") });
        }
    }
}
