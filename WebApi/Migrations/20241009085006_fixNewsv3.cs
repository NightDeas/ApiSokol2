using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiMigrations
{
    /// <inheritdoc />
    public partial class fixNewsv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
