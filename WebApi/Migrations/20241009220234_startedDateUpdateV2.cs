using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiMigrations
{
    /// <inheritdoc />
    public partial class startedDateUpdateV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("95d3041f-f142-4409-b592-e19e4e7028f9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("05d4b664-b567-412d-a21b-7824c0976206"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1365566a-563a-4834-b7f6-950297794793"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4150c4a8-9a7b-4c87-97e3-fad1cfed1c39"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("79b58660-1d78-4976-a98c-b29b4a57cac4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8a48c13f-c50e-42fa-8e2b-2357548d09f5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("90fb9e61-6850-4ff7-8c18-9d5fd70b0c77"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9e7ab212-a9d6-4616-86e1-fb842485f598"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a812867f-b8e9-4835-896e-8fb6099b4621"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a9f5f4c3-415d-464c-a532-03302b378b0c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d12edc6f-8952-44b7-acaa-7f050c50bc04"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fa78ddf5-b4a5-4d31-94a9-58a25dc6fc3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01d885f7-7881-471e-a3e2-d4fcfcfe0210"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06f79e87-ddf3-4c49-92b2-cc356f85b646"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0d478767-6694-445e-8bf2-f6712147e534"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ff9f2f2-cb34-4c57-8a96-32655cd1da37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1342ffba-e85b-45a1-a1b5-404dc1986e25"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1405b1eb-51d3-4750-85f6-6f4636967f23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37265ae9-33b2-44ad-99b1-c549fcc5bc9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3825d84a-447f-4217-91ee-9f9a60e6f63d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("408d5260-a49c-46d2-8114-eb24d0bfb424"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43231c9a-3418-4726-84a9-fd2c6f84c9de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("564663ac-3011-4cf9-90fe-9300020b476e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65adcb24-538b-4e8c-a860-70442495dda8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("692ccf87-b5a2-4dc1-ab46-b104dd46ae1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75aa912e-4315-482a-9c5a-184bf9a1e2bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("827e8080-b986-4825-a326-a5aed79d134f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8281f531-9ec9-44cc-98e4-fc7af383488c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e4f259c-007c-4aac-b771-cb57e608d731"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9287dc76-18bc-4002-b5e6-19deb1d77a6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a28f1b4b-2b83-4e30-af18-38af58d89dbc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a381fc31-eaee-481c-868f-a88f9fef1749"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3c6de5f-7f87-4101-90b4-501fecb36f9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a50bbd30-e7c4-4a32-80f2-4edee9b2adb3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7eb1467-1682-4bea-80f4-6dba64d3ad30"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2bd8a05-d8aa-4a1c-bbf8-202fa0f8acc8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b428d92f-06f7-49d4-b984-b396d9533982"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b70c166f-9069-4230-8d97-2fb2e667ae32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bab26e79-6c90-449c-9038-dbe258b975de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce616c21-51ac-4660-9aef-cfd65e3014e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d08768f0-1654-449d-bcfd-97a8f6e6794c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5641a58-80fe-4bc0-b7d1-58ecfb85475d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d5745193-0e24-445e-9e95-60220b194d42"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0af06de-6202-4ed9-866a-79475ca9efa8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e21788ac-9fa4-4474-9a9b-845229805542"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e43f7445-fad5-4534-b01d-50d8096f82d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7cfd964-05de-432b-8068-7de98e434d4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee1a693f-99d8-4afd-a4c8-4d60db28bf10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4993ba6-8ac3-46c3-af81-d4bb1d8fb2b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f638aca2-7890-4e7f-b1dd-f88145354069"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1dcc42a9-0724-4b3d-b8f9-c2699d06cb4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ebf0e54-9a35-4a10-9054-b81d1d75922f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("245836ac-2412-4fe1-9548-304daaa1cf9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c8def36-64e6-477d-8f35-76fc892423a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("364463f4-baab-40a8-8f2c-9cf77982ce6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36dabd14-217f-4917-a281-8ac4dbdb842f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39cc6d32-cf9f-40df-a65f-87bce06befa5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c7a9896-e818-4a6a-8a95-1b516a82629c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43da0b64-8ff9-40f2-8d97-1d539b9383af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4575172b-166e-43e3-af4a-7da6467ce14f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f9caa01-4356-4969-92f8-b6d622f048e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61b98779-5bfe-45eb-995b-1688e2aadd6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67daab92-b483-47b4-b8c5-6ed905828fbf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("691cdc0c-8c16-4868-b587-cb9b6fd16127"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("738e28cf-42ce-406c-b67e-9cab59d29df3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80c4bf1d-a15d-40ac-8293-007a04c79b31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cf4937e-fb42-4e21-a26f-2b05876f2cea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94f57503-66c8-4a10-ae03-da99f5aff486"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b4c39c74-cb8b-46b7-a53d-103e2275de53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be99cca3-1228-461f-af6e-69dbc6d590d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d503a950-406f-459d-a690-3bbce73c08f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e533be64-c1ac-41fa-80a6-529a36163087"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("b15898a5-fd66-4ec8-b65a-bc196889db52"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("06f842a9-751d-4010-b535-85737f345ccf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19f0034c-fac8-494d-a640-be26fd8f4916"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60b358fc-e826-4563-a432-3646a984bc55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6135f7e8-761b-461d-b975-d099c4fb455a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6865fe79-462a-453f-ace5-7b56308827cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76302cb6-2487-4fbc-8de1-934a51d06783"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c07d30eb-94ad-4ae9-abf5-d43991aca43c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c468a92f-3bdc-4035-82e8-87bfe26ae2e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d191ab87-3e56-4c2c-a195-bffe56542d84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9d0189b-c971-4811-94d7-eb1349015c7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f38cda8e-d1ca-4e60-be2d-fbca58f4edbe"));

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Created", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("21a1ff8a-58d0-41e5-be60-9d9070d2e10b"), new DateTime(2024, 11, 4, 22, 2, 34, 277, DateTimeKind.Utc).AddTicks(4251), "Конкурс для скульпторов и художников, работающих в области пластики. Прием работ до 10 января.", "Конкурс 'Скульптура и пластика'" },
                    { new Guid("36eb092e-05fd-41d6-bc62-51940137893a"), new DateTime(2024, 11, 7, 22, 2, 34, 277, DateTimeKind.Utc).AddTicks(4230), "Конкурс открыт для художников со всего мира. Прием работ до 15 октября.", "Международный конкурс 'Живопись 2023'" },
                    { new Guid("4c2180a0-afed-4e62-8544-2a8626c88af2"), new DateTime(2024, 11, 2, 22, 2, 34, 277, DateTimeKind.Utc).AddTicks(4242), "Выставка фотографий, демонстрирующих фотографию как самостоятельное искусство.", "Выставка 'Фотография как искусство'" },
                    { new Guid("58339ca1-5e56-4851-b422-234649f6472f"), new DateTime(2024, 10, 30, 22, 2, 34, 277, DateTimeKind.Utc).AddTicks(4212), "Выставка представляет работы современных художников, посвященные теме абстракции.", "Выставка современного искусства 'Абстракция'" },
                    { new Guid("ac89a8a0-83a5-46f3-8cb7-35e6baa2f2f5"), new DateTime(2024, 10, 25, 22, 2, 34, 277, DateTimeKind.Utc).AddTicks(4245), "Конкурс посвящен графике и рисункам. Прием работ до 20 декабря.", "Конкурс 'Графика и рисунки'" },
                    { new Guid("d254605c-74c6-438c-92f3-d7294a5c158a"), new DateTime(2024, 10, 13, 22, 2, 34, 277, DateTimeKind.Utc).AddTicks(4254), "Выставка, демонстрирующая взаимодействие искусства и современных технологий.", "Выставка 'Искусство и технологии'" },
                    { new Guid("d7da9d3b-ea39-483f-92c7-8ab2e57c4304"), new DateTime(2024, 10, 16, 22, 2, 34, 277, DateTimeKind.Utc).AddTicks(4239), "Конкурс для молодых художников до 30 лет. Прием работ до 30 ноября.", "Конкурс 'Молодое искусство'" },
                    { new Guid("d7e6e1bc-f58e-4069-ab22-d8223c323e31"), new DateTime(2024, 10, 12, 22, 2, 34, 277, DateTimeKind.Utc).AddTicks(4233), "Выставка посвящена искусству XX века, включая работы известных мастеров.", "Выставка 'Искусство XX века'" },
                    { new Guid("de8a49bc-897b-4fa9-aa42-bf26b1667138"), new DateTime(2024, 11, 1, 22, 2, 34, 277, DateTimeKind.Utc).AddTicks(4258), "Конкурс для детских художников до 12 лет. Прием работ до 1 февраля.", "Конкурс 'Искусство для детей'" },
                    { new Guid("e64c3e83-009e-4134-b302-2f313d78ab01"), new DateTime(2024, 10, 18, 22, 2, 34, 277, DateTimeKind.Utc).AddTicks(4248), "Выставка работ художников из стран Востока, представляющих традиционное и современное искусство.", "Выставка 'Искусство Востока'" }
                });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f56906c9-6721-4c98-9560-bd9113e43584"), "Товар" },
                    { new Guid("fa0914dc-0673-46e9-a306-1fc33e316228"), "Услуга" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discount", "FIO", "IsClient", "IsProvider" },
                values: new object[,]
                {
                    { new Guid("082221a6-6b47-4493-8412-2f328a21977e"), 0m, "Федоров Андрей Николаевич", true, false },
                    { new Guid("092ae16c-9cf9-4e90-b177-50ecb2e3910d"), 0m, "Козлов Максим Иванович", true, false },
                    { new Guid("2d3694cb-398a-4165-a12b-55b725582c21"), 0m, "Ильин Сергей Дмитриевич", true, false },
                    { new Guid("2f8bdb62-2c31-4baa-86b2-2eeed74abc78"), 0m, "Дмитриев Максим Иванович", true, false },
                    { new Guid("38f3e1f4-15b0-458b-9025-bc211d9cc09d"), 0m, "Григорьев Иван Сергеевич", false, true },
                    { new Guid("3a9cda25-aa61-4af5-92a6-efcc92c0cd37"), 0m, "Сидоров Иван Сергеевич", false, true },
                    { new Guid("3c953c26-f702-4c92-bab2-01b0198b2bee"), 0m, "Попов Константин Петрович", false, true },
                    { new Guid("40f089ab-0289-4ec8-94b6-d25e932332b3"), 0m, "Михайлов Иван Сергеевич", false, true },
                    { new Guid("4686a4b7-4854-4a7a-9353-189c5f7e4389"), 0m, "Васильев Константин Петрович", false, true },
                    { new Guid("585ac79f-b7a0-4628-9b04-ca206f7789c8"), 0m, "Петров Алексей Дмитриевич", true, false },
                    { new Guid("5ba1051a-f926-4232-b868-c419393fc3db"), 0m, "Юриков Дмитрий Александрович", true, false },
                    { new Guid("6af2acff-68e0-4913-846e-f9b904e6bf02"), 0m, "Павлов Константин Петрович", false, true },
                    { new Guid("6cfe1b90-e5bd-4c55-9623-72f12a9f8d43"), 0m, "Соколов Сергей Дмитриевич", true, false },
                    { new Guid("7546af60-7c85-452d-95d1-d393ed4adf05"), 0m, "Макаров Дмитрий Александрович", false, true },
                    { new Guid("79c4e5c0-b126-4e97-bb58-98b9a90a1c94"), 0m, "Николаев Сергей Дмитриевич", true, false },
                    { new Guid("811c4aae-3e74-43c9-8838-f84214d0e96f"), 0m, "Комаров Константин Петрович", false, true },
                    { new Guid("8f6c17af-edc7-4501-a8c0-23bdb6afa0d9"), 0m, "Ковалев Дмитрий Александрович", false, true },
                    { new Guid("93c44847-317e-45fa-9467-78567e2eea59"), 0m, "Алексеев Андрей Николаевич", true, false },
                    { new Guid("98a64158-9f68-452a-9d1b-642886680e8f"), 0m, "Кузнецов Сергей Дмитриевич", true, false },
                    { new Guid("9d48fe50-2a4d-4f45-a3cc-ab52bb89f2b1"), 0m, "Морозов Андрей Николаевич", true, false },
                    { new Guid("9f9f9231-7905-4ce4-bf8a-c74b97d95f94"), 0m, "Егоров Дмитрий Александрович", false, true },
                    { new Guid("b64ecc03-31c9-42f7-8b03-c962f2b71626"), 0m, "Иванов Сергей Максимович", false, true },
                    { new Guid("bd519fc7-7510-4cf6-9387-0c93f271a55e"), 0m, "Сергеев Константин Петрович", false, true },
                    { new Guid("bda25231-388f-4f7a-93ae-2d41347ed241"), 0m, "Матвеев Сергей Дмитриевич", true, false },
                    { new Guid("cf729368-9b75-43f2-814c-2ebef2c46351"), 0m, "Белов Максим Иванович", true, false },
                    { new Guid("d0e7795e-6770-4f34-9a57-5fbeecd5d475"), 0m, "Лебедев Максим Иванович", true, false },
                    { new Guid("d4799574-0cf1-452d-ad7d-7ab94e199ab9"), 0m, "Новиков Дмитрий Александрович", false, true },
                    { new Guid("db3959eb-6d96-4dd3-b4c1-3358796c7465"), 0m, "Филиппов Дмитрий Александрович", false, true },
                    { new Guid("e0bd28b1-e495-41e1-8888-098eba8d927d"), 0m, "Андреев Максим Иванович", true, false },
                    { new Guid("e782e27f-1cef-4e37-9327-65ff262a1dea"), 0m, "Семенов Андрей Николаевич", true, false },
                    { new Guid("ea3a8711-adec-4718-ab5f-953271361ad0"), 0m, "Соловьев Андрей Николаевич", true, false },
                    { new Guid("fa60f85f-e7c1-433e-b19c-3e7f033afda3"), 0m, "Борисов Иван Сергеевич", false, true },
                    { new Guid("ffac6a60-49be-45fe-aedc-b91939658058"), 0m, "Орлов Иван Сергеевич", false, true }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Sum", "UserId" },
                values: new object[,]
                {
                    { new Guid("3d8e73c5-d853-4f1e-92ab-d5cc5f84c5a9"), 0m, new Guid("5ba1051a-f926-4232-b868-c419393fc3db") },
                    { new Guid("49f9f13f-980b-4657-9318-a210551e4648"), 0m, new Guid("082221a6-6b47-4493-8412-2f328a21977e") },
                    { new Guid("56be3227-f305-49d5-b333-079b24494165"), 0m, new Guid("4686a4b7-4854-4a7a-9353-189c5f7e4389") },
                    { new Guid("6b8168f8-4cac-4643-9ccf-1e708c935a49"), 0m, new Guid("9d48fe50-2a4d-4f45-a3cc-ab52bb89f2b1") },
                    { new Guid("779f3978-6ddc-4a7a-86c6-06e1339bea1e"), 0m, new Guid("6cfe1b90-e5bd-4c55-9623-72f12a9f8d43") },
                    { new Guid("82a58195-2111-47a5-a66f-e3c8fc11cba6"), 0m, new Guid("b64ecc03-31c9-42f7-8b03-c962f2b71626") },
                    { new Guid("927c67df-1f62-4162-919f-f8405a43b7d6"), 0m, new Guid("d4799574-0cf1-452d-ad7d-7ab94e199ab9") },
                    { new Guid("ab2239d0-e8b2-4011-bbd3-da430e8a6852"), 0m, new Guid("585ac79f-b7a0-4628-9b04-ca206f7789c8") },
                    { new Guid("d55e04e8-b332-4909-8a60-b1bb0ca3693c"), 0m, new Guid("3a9cda25-aa61-4af5-92a6-efcc92c0cd37") },
                    { new Guid("da3667ba-fab2-4026-bac0-7f2c94523b6d"), 0m, new Guid("092ae16c-9cf9-4e90-b177-50ecb2e3910d") },
                    { new Guid("e36468b9-8f81-4bdd-bf25-598eaf02e48c"), 0m, new Guid("40f089ab-0289-4ec8-94b6-d25e932332b3") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { new Guid("00372f81-ebef-43ef-ac2d-5619969822c0"), 1, "Курс \"3D игровая графика\"", 4500m, new Guid("fa0914dc-0673-46e9-a306-1fc33e316228") },
                    { new Guid("18bb9847-1633-46c4-b8cf-4a60c57ab10f"), 1, "Видеоурок \"Основы 3D моделирования\"", 2500m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("1cf02577-ca5f-4411-9907-d13c4c970356"), 1, "Цифровой арт \"Цифровое искусство\"", 5000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("22998821-fb2e-4141-ac72-3385af29f60a"), 1, "Цифровой арт \"Пейзаж с вулканом\"", 5000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("244fff05-1912-49a6-be38-d94e3611a743"), 1, "Цифровой арт \"Пейзаж с пустыней\"", 3000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("2db81b6d-e3fc-462b-bdbb-2aa4763fe5b1"), 1, "Цифровой арт \"Ночной город\"", 3500m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("38b7cf5f-0f52-4a05-85be-f6ce02821e2f"), 1, "Видеоурок \"Рисование в Krita\"", 2000m, new Guid("fa0914dc-0673-46e9-a306-1fc33e316228") },
                    { new Guid("4630792d-fd9e-4ac8-94a9-f2f8dac0ea59"), 1, "Цифровой арт \"Пейзаж с лесом\"", 2500m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("5596e107-0997-4f22-9db0-98b311a24dfc"), 1, "Цифровой арт \"Летний день\"", 2000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("6abd137c-f131-431a-accc-a9e362be39e2"), 1, "Видеоурок \"Рисование в Sketchbook\"", 3000m, new Guid("fa0914dc-0673-46e9-a306-1fc33e316228") },
                    { new Guid("6cc9107c-1d36-46b7-accd-9251a797a4a0"), 1, "Курс \"3D моделирование\"", 4500m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("765f4300-ad81-4d02-b297-99c38f08bc87"), 1, "Курс \"Художник за месяц\"", 6000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("7fd7bc37-1937-4867-bfb5-c7043e50c257"), 1, "Помощь с идеей для вашего проекта", 500m, new Guid("fa0914dc-0673-46e9-a306-1fc33e316228") },
                    { new Guid("823f309b-992e-4f9f-9a4c-eff8b0e54f49"), 1, "Цифровой арт \"Пейзаж с горами\"", 3000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("83fcb507-6b78-4096-9006-db626f1a21df"), 1, "Видеоурок \"Как сделать первый 3D дизайн\"", 2000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("8524858d-1d5a-42d5-acc6-c7260277ea8b"), 1, "Цифровой арт \"Пейзаж с морем\"", 5000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("87f97c00-9396-490c-8556-4b97fb379998"), 1, "Цифровой арт \"Зимний лес\"", 5000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("8c438b4b-8157-412c-b9c4-f89e0a11a277"), 1, "Курс \"2D анимация\"", 4000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("92e95b48-9d7a-40fa-8c59-7cfacd720780"), 1, "Цифровой арт \"Далекое будущее\"", 5000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("99b49d0f-1855-4f91-81da-92c13cae73af"), 1, "Курс \"3D анимация\"", 6000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("a32633fe-9f8f-4559-aff4-924ae6a3ad4e"), 1, "Курс \"2D игровая графика\"", 4000m, new Guid("fa0914dc-0673-46e9-a306-1fc33e316228") },
                    { new Guid("a46317b3-3ef1-4e42-97d9-0dbb0a58d5e0"), 1, "Видеоурок \"Рисование в Photoshop\"", 1500m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("a50a9ef6-14f3-4b01-8df6-d83adfa38442"), 1, "Видеоурок \"Песня \"Ромашки\" на гитаре\"", 2000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("ab5f37f9-54c0-4a77-8f70-2f7db77a0b7b"), 1, "Реклама", 10000m, new Guid("fa0914dc-0673-46e9-a306-1fc33e316228") },
                    { new Guid("b9736cff-3b96-4680-bddb-7c822cec5358"), 1, "Курс \"Графика в игре\"", 4500m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("bd7e0876-29b7-44dc-b2b1-690f1abfe78d"), 1, "Цифровой арт \"Закат на пляже\"", 4000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("bf3b962d-e34d-4462-a1a4-9274507ae5e1"), 1, "Видеоурок \"Рисование в Affinity Designer\"", 3500m, new Guid("fa0914dc-0673-46e9-a306-1fc33e316228") },
                    { new Guid("cf43902d-2ab4-43ce-9611-8713c815db53"), 1, "Цифровой арт \"Пейзаж с водопадом\"", 5000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("dd38a027-0bf4-48d2-8cbb-6ff8e5ba463e"), 1, "Цифровой арт \"Пейзаж с озером\"", 5000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("e7009ac0-865c-4b51-b5dc-37dbae7b615b"), 1, "Видеоурок \"Рисование в PaintTool SAI\"", 2500m, new Guid("fa0914dc-0673-46e9-a306-1fc33e316228") },
                    { new Guid("e8d2ba41-7cd0-46bd-8e29-f2e127a9114f"), 1, "Видеоурок \"Рисование портретов\"", 3000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("f07eb676-2fa4-4cec-959a-08fa2b670b73"), 1, "Онлайн урок по рисованию", 1900m, new Guid("fa0914dc-0673-46e9-a306-1fc33e316228") },
                    { new Guid("f2ac61ab-95b8-44c2-aaa3-a9984671bfcc"), 1, "Цифровой арт \"Красивый город\"", 5000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("f2df1f9f-b66c-4b33-81ad-3b80f9a54abd"), 1, "Песня, сгенерированная нейросетью", 100m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("f75d397b-36ae-4c3e-a5a1-042f5fdc57a2"), 1, "Цифровой арт \"Городской пейзаж\"", 2500m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("fe5a98cc-5bc7-40d9-a30d-e124e7d4dc9c"), 1, "Песня, сгенерированная нейросетью \"Весна\"", 150m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("feab2179-c234-4960-86bf-17f7e4089aac"), 1, "Видеоурок \"Рисование в Procreate\"", 3500m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") },
                    { new Guid("ff652fb8-a33c-4fce-ace3-6926817f17bc"), 1, "Видеоурок \"Рисование в Illustrator\"", 2000m, new Guid("f56906c9-6721-4c98-9560-bd9113e43584") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("21a1ff8a-58d0-41e5-be60-9d9070d2e10b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("36eb092e-05fd-41d6-bc62-51940137893a"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4c2180a0-afed-4e62-8544-2a8626c88af2"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("58339ca1-5e56-4851-b422-234649f6472f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("ac89a8a0-83a5-46f3-8cb7-35e6baa2f2f5"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("d254605c-74c6-438c-92f3-d7294a5c158a"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("d7da9d3b-ea39-483f-92c7-8ab2e57c4304"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("d7e6e1bc-f58e-4069-ab22-d8223c323e31"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("de8a49bc-897b-4fa9-aa42-bf26b1667138"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e64c3e83-009e-4134-b302-2f313d78ab01"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3d8e73c5-d853-4f1e-92ab-d5cc5f84c5a9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("49f9f13f-980b-4657-9318-a210551e4648"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("56be3227-f305-49d5-b333-079b24494165"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6b8168f8-4cac-4643-9ccf-1e708c935a49"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("779f3978-6ddc-4a7a-86c6-06e1339bea1e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("82a58195-2111-47a5-a66f-e3c8fc11cba6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("927c67df-1f62-4162-919f-f8405a43b7d6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ab2239d0-e8b2-4011-bbd3-da430e8a6852"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("d55e04e8-b332-4909-8a60-b1bb0ca3693c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("da3667ba-fab2-4026-bac0-7f2c94523b6d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e36468b9-8f81-4bdd-bf25-598eaf02e48c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00372f81-ebef-43ef-ac2d-5619969822c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18bb9847-1633-46c4-b8cf-4a60c57ab10f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cf02577-ca5f-4411-9907-d13c4c970356"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22998821-fb2e-4141-ac72-3385af29f60a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("244fff05-1912-49a6-be38-d94e3611a743"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2db81b6d-e3fc-462b-bdbb-2aa4763fe5b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38b7cf5f-0f52-4a05-85be-f6ce02821e2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4630792d-fd9e-4ac8-94a9-f2f8dac0ea59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5596e107-0997-4f22-9db0-98b311a24dfc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6abd137c-f131-431a-accc-a9e362be39e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cc9107c-1d36-46b7-accd-9251a797a4a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("765f4300-ad81-4d02-b297-99c38f08bc87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7fd7bc37-1937-4867-bfb5-c7043e50c257"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("823f309b-992e-4f9f-9a4c-eff8b0e54f49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83fcb507-6b78-4096-9006-db626f1a21df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8524858d-1d5a-42d5-acc6-c7260277ea8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87f97c00-9396-490c-8556-4b97fb379998"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c438b4b-8157-412c-b9c4-f89e0a11a277"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92e95b48-9d7a-40fa-8c59-7cfacd720780"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99b49d0f-1855-4f91-81da-92c13cae73af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a32633fe-9f8f-4559-aff4-924ae6a3ad4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a46317b3-3ef1-4e42-97d9-0dbb0a58d5e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a50a9ef6-14f3-4b01-8df6-d83adfa38442"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab5f37f9-54c0-4a77-8f70-2f7db77a0b7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9736cff-3b96-4680-bddb-7c822cec5358"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd7e0876-29b7-44dc-b2b1-690f1abfe78d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf3b962d-e34d-4462-a1a4-9274507ae5e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf43902d-2ab4-43ce-9611-8713c815db53"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dd38a027-0bf4-48d2-8cbb-6ff8e5ba463e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e7009ac0-865c-4b51-b5dc-37dbae7b615b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8d2ba41-7cd0-46bd-8e29-f2e127a9114f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f07eb676-2fa4-4cec-959a-08fa2b670b73"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2ac61ab-95b8-44c2-aaa3-a9984671bfcc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2df1f9f-b66c-4b33-81ad-3b80f9a54abd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f75d397b-36ae-4c3e-a5a1-042f5fdc57a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe5a98cc-5bc7-40d9-a30d-e124e7d4dc9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("feab2179-c234-4960-86bf-17f7e4089aac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff652fb8-a33c-4fce-ace3-6926817f17bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d3694cb-398a-4165-a12b-55b725582c21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f8bdb62-2c31-4baa-86b2-2eeed74abc78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38f3e1f4-15b0-458b-9025-bc211d9cc09d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c953c26-f702-4c92-bab2-01b0198b2bee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6af2acff-68e0-4913-846e-f9b904e6bf02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7546af60-7c85-452d-95d1-d393ed4adf05"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79c4e5c0-b126-4e97-bb58-98b9a90a1c94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("811c4aae-3e74-43c9-8838-f84214d0e96f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f6c17af-edc7-4501-a8c0-23bdb6afa0d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93c44847-317e-45fa-9467-78567e2eea59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98a64158-9f68-452a-9d1b-642886680e8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f9f9231-7905-4ce4-bf8a-c74b97d95f94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd519fc7-7510-4cf6-9387-0c93f271a55e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bda25231-388f-4f7a-93ae-2d41347ed241"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf729368-9b75-43f2-814c-2ebef2c46351"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0e7795e-6770-4f34-9a57-5fbeecd5d475"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db3959eb-6d96-4dd3-b4c1-3358796c7465"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e0bd28b1-e495-41e1-8888-098eba8d927d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e782e27f-1cef-4e37-9327-65ff262a1dea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ea3a8711-adec-4718-ab5f-953271361ad0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa60f85f-e7c1-433e-b19c-3e7f033afda3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffac6a60-49be-45fe-aedc-b91939658058"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("f56906c9-6721-4c98-9560-bd9113e43584"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("fa0914dc-0673-46e9-a306-1fc33e316228"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("082221a6-6b47-4493-8412-2f328a21977e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("092ae16c-9cf9-4e90-b177-50ecb2e3910d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a9cda25-aa61-4af5-92a6-efcc92c0cd37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40f089ab-0289-4ec8-94b6-d25e932332b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4686a4b7-4854-4a7a-9353-189c5f7e4389"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("585ac79f-b7a0-4628-9b04-ca206f7789c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5ba1051a-f926-4232-b868-c419393fc3db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cfe1b90-e5bd-4c55-9623-72f12a9f8d43"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d48fe50-2a4d-4f45-a3cc-ab52bb89f2b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b64ecc03-31c9-42f7-8b03-c962f2b71626"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4799574-0cf1-452d-ad7d-7ab94e199ab9"));

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Created", "Description", "Title" },
                values: new object[] { new Guid("95d3041f-f142-4409-b592-e19e4e7028f9"), new DateTime(2024, 10, 17, 21, 50, 20, 778, DateTimeKind.Utc).AddTicks(9743), "Desc1", "Title1" });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b15898a5-fd66-4ec8-b65a-bc196889db52"), "Услуга" },
                    { new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4"), "Товар" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discount", "FIO", "IsClient", "IsProvider" },
                values: new object[,]
                {
                    { new Guid("06f842a9-751d-4010-b535-85737f345ccf"), 0m, "Соколов Сергей Дмитриевич", true, false },
                    { new Guid("19f0034c-fac8-494d-a640-be26fd8f4916"), 0m, "Михайлов Иван Сергеевич", false, true },
                    { new Guid("1dcc42a9-0724-4b3d-b8f9-c2699d06cb4d"), 0m, "Григорьев Иван Сергеевич", false, true },
                    { new Guid("1ebf0e54-9a35-4a10-9054-b81d1d75922f"), 0m, "Алексеев Андрей Николаевич", true, false },
                    { new Guid("245836ac-2412-4fe1-9548-304daaa1cf9e"), 0m, "Николаев Сергей Дмитриевич", true, false },
                    { new Guid("2c8def36-64e6-477d-8f35-76fc892423a4"), 0m, "Белов Максим Иванович", true, false },
                    { new Guid("364463f4-baab-40a8-8f2c-9cf77982ce6c"), 0m, "Семенов Андрей Николаевич", true, false },
                    { new Guid("36dabd14-217f-4917-a281-8ac4dbdb842f"), 0m, "Комаров Константин Петрович", false, true },
                    { new Guid("39cc6d32-cf9f-40df-a65f-87bce06befa5"), 0m, "Соловьев Андрей Николаевич", true, false },
                    { new Guid("3c7a9896-e818-4a6a-8a95-1b516a82629c"), 0m, "Лебедев Максим Иванович", true, false },
                    { new Guid("43da0b64-8ff9-40f2-8d97-1d539b9383af"), 0m, "Андреев Максим Иванович", true, false },
                    { new Guid("4575172b-166e-43e3-af4a-7da6467ce14f"), 0m, "Попов Константин Петрович", false, true },
                    { new Guid("5f9caa01-4356-4969-92f8-b6d622f048e5"), 0m, "Павлов Константин Петрович", false, true },
                    { new Guid("60b358fc-e826-4563-a432-3646a984bc55"), 0m, "Козлов Максим Иванович", true, false },
                    { new Guid("6135f7e8-761b-461d-b975-d099c4fb455a"), 0m, "Юриков Дмитрий Александрович", true, false },
                    { new Guid("61b98779-5bfe-45eb-995b-1688e2aadd6a"), 0m, "Матвеев Сергей Дмитриевич", true, false },
                    { new Guid("67daab92-b483-47b4-b8c5-6ed905828fbf"), 0m, "Кузнецов Сергей Дмитриевич", true, false },
                    { new Guid("6865fe79-462a-453f-ace5-7b56308827cc"), 0m, "Васильев Константин Петрович", false, true },
                    { new Guid("691cdc0c-8c16-4868-b587-cb9b6fd16127"), 0m, "Ильин Сергей Дмитриевич", true, false },
                    { new Guid("738e28cf-42ce-406c-b67e-9cab59d29df3"), 0m, "Орлов Иван Сергеевич", false, true },
                    { new Guid("76302cb6-2487-4fbc-8de1-934a51d06783"), 0m, "Иванов Сергей Максимович", false, true },
                    { new Guid("80c4bf1d-a15d-40ac-8293-007a04c79b31"), 0m, "Филиппов Дмитрий Александрович", false, true },
                    { new Guid("8cf4937e-fb42-4e21-a26f-2b05876f2cea"), 0m, "Дмитриев Максим Иванович", true, false },
                    { new Guid("94f57503-66c8-4a10-ae03-da99f5aff486"), 0m, "Ковалев Дмитрий Александрович", false, true },
                    { new Guid("b4c39c74-cb8b-46b7-a53d-103e2275de53"), 0m, "Егоров Дмитрий Александрович", false, true },
                    { new Guid("be99cca3-1228-461f-af6e-69dbc6d590d9"), 0m, "Борисов Иван Сергеевич", false, true },
                    { new Guid("c07d30eb-94ad-4ae9-abf5-d43991aca43c"), 0m, "Федоров Андрей Николаевич", true, false },
                    { new Guid("c468a92f-3bdc-4035-82e8-87bfe26ae2e2"), 0m, "Петров Алексей Дмитриевич", true, false },
                    { new Guid("d191ab87-3e56-4c2c-a195-bffe56542d84"), 0m, "Сидоров Иван Сергеевич", false, true },
                    { new Guid("d503a950-406f-459d-a690-3bbce73c08f7"), 0m, "Сергеев Константин Петрович", false, true },
                    { new Guid("d9d0189b-c971-4811-94d7-eb1349015c7c"), 0m, "Новиков Дмитрий Александрович", false, true },
                    { new Guid("e533be64-c1ac-41fa-80a6-529a36163087"), 0m, "Макаров Дмитрий Александрович", false, true },
                    { new Guid("f38cda8e-d1ca-4e60-be2d-fbca58f4edbe"), 0m, "Морозов Андрей Николаевич", true, false }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Sum", "UserId" },
                values: new object[,]
                {
                    { new Guid("05d4b664-b567-412d-a21b-7824c0976206"), 0m, new Guid("d191ab87-3e56-4c2c-a195-bffe56542d84") },
                    { new Guid("1365566a-563a-4834-b7f6-950297794793"), 0m, new Guid("d9d0189b-c971-4811-94d7-eb1349015c7c") },
                    { new Guid("4150c4a8-9a7b-4c87-97e3-fad1cfed1c39"), 0m, new Guid("60b358fc-e826-4563-a432-3646a984bc55") },
                    { new Guid("79b58660-1d78-4976-a98c-b29b4a57cac4"), 0m, new Guid("76302cb6-2487-4fbc-8de1-934a51d06783") },
                    { new Guid("8a48c13f-c50e-42fa-8e2b-2357548d09f5"), 0m, new Guid("c468a92f-3bdc-4035-82e8-87bfe26ae2e2") },
                    { new Guid("90fb9e61-6850-4ff7-8c18-9d5fd70b0c77"), 0m, new Guid("19f0034c-fac8-494d-a640-be26fd8f4916") },
                    { new Guid("9e7ab212-a9d6-4616-86e1-fb842485f598"), 0m, new Guid("06f842a9-751d-4010-b535-85737f345ccf") },
                    { new Guid("a812867f-b8e9-4835-896e-8fb6099b4621"), 0m, new Guid("6135f7e8-761b-461d-b975-d099c4fb455a") },
                    { new Guid("a9f5f4c3-415d-464c-a532-03302b378b0c"), 0m, new Guid("6865fe79-462a-453f-ace5-7b56308827cc") },
                    { new Guid("d12edc6f-8952-44b7-acaa-7f050c50bc04"), 0m, new Guid("c07d30eb-94ad-4ae9-abf5-d43991aca43c") },
                    { new Guid("fa78ddf5-b4a5-4d31-94a9-58a25dc6fc3b"), 0m, new Guid("f38cda8e-d1ca-4e60-be2d-fbca58f4edbe") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { new Guid("01d885f7-7881-471e-a3e2-d4fcfcfe0210"), 1, "Цифровой арт \"Пейзаж с лесом\"", 2500m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("06f79e87-ddf3-4c49-92b2-cc356f85b646"), 1, "Видеоурок \"Рисование портретов\"", 3000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("0d478767-6694-445e-8bf2-f6712147e534"), 1, "Цифровой арт \"Пейзаж с вулканом\"", 5000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("0ff9f2f2-cb34-4c57-8a96-32655cd1da37"), 1, "Курс \"3D моделирование\"", 4500m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("1342ffba-e85b-45a1-a1b5-404dc1986e25"), 1, "Видеоурок \"Рисование в Illustrator\"", 2000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("1405b1eb-51d3-4750-85f6-6f4636967f23"), 1, "Цифровой арт \"Цифровое искусство\"", 5000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("37265ae9-33b2-44ad-99b1-c549fcc5bc9b"), 1, "Цифровой арт \"Пейзаж с озером\"", 5000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("3825d84a-447f-4217-91ee-9f9a60e6f63d"), 1, "Видеоурок \"Как сделать первый 3D дизайн\"", 2000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("408d5260-a49c-46d2-8114-eb24d0bfb424"), 1, "Цифровой арт \"Летний день\"", 2000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("43231c9a-3418-4726-84a9-fd2c6f84c9de"), 1, "Курс \"3D анимация\"", 6000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("564663ac-3011-4cf9-90fe-9300020b476e"), 1, "Курс \"2D анимация\"", 4000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("65adcb24-538b-4e8c-a860-70442495dda8"), 1, "Песня, сгенерированная нейросетью \"Весна\"", 150m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("692ccf87-b5a2-4dc1-ab46-b104dd46ae1c"), 1, "Онлайн урок по рисованию", 1900m, new Guid("b15898a5-fd66-4ec8-b65a-bc196889db52") },
                    { new Guid("75aa912e-4315-482a-9c5a-184bf9a1e2bc"), 1, "Видеоурок \"Рисование в Sketchbook\"", 3000m, new Guid("b15898a5-fd66-4ec8-b65a-bc196889db52") },
                    { new Guid("827e8080-b986-4825-a326-a5aed79d134f"), 1, "Цифровой арт \"Зимний лес\"", 5000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("8281f531-9ec9-44cc-98e4-fc7af383488c"), 1, "Видеоурок \"Основы 3D моделирования\"", 2500m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("8e4f259c-007c-4aac-b771-cb57e608d731"), 1, "Цифровой арт \"Городской пейзаж\"", 2500m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("9287dc76-18bc-4002-b5e6-19deb1d77a6c"), 1, "Цифровой арт \"Пейзаж с водопадом\"", 5000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("a28f1b4b-2b83-4e30-af18-38af58d89dbc"), 1, "Видеоурок \"Рисование в PaintTool SAI\"", 2500m, new Guid("b15898a5-fd66-4ec8-b65a-bc196889db52") },
                    { new Guid("a381fc31-eaee-481c-868f-a88f9fef1749"), 1, "Цифровой арт \"Закат на пляже\"", 4000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("a3c6de5f-7f87-4101-90b4-501fecb36f9b"), 1, "Цифровой арт \"Пейзаж с пустыней\"", 3000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("a50bbd30-e7c4-4a32-80f2-4edee9b2adb3"), 1, "Цифровой арт \"Пейзаж с морем\"", 5000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("a7eb1467-1682-4bea-80f4-6dba64d3ad30"), 1, "Видеоурок \"Рисование в Photoshop\"", 1500m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("b2bd8a05-d8aa-4a1c-bbf8-202fa0f8acc8"), 1, "Песня, сгенерированная нейросетью", 100m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("b428d92f-06f7-49d4-b984-b396d9533982"), 1, "Видеоурок \"Песня \"Ромашки\" на гитаре\"", 2000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("b70c166f-9069-4230-8d97-2fb2e667ae32"), 1, "Цифровой арт \"Пейзаж с горами\"", 3000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("bab26e79-6c90-449c-9038-dbe258b975de"), 1, "Видеоурок \"Рисование в Procreate\"", 3500m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("ce616c21-51ac-4660-9aef-cfd65e3014e3"), 1, "Курс \"Художник за месяц\"", 6000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("d08768f0-1654-449d-bcfd-97a8f6e6794c"), 1, "Видеоурок \"Рисование в Krita\"", 2000m, new Guid("b15898a5-fd66-4ec8-b65a-bc196889db52") },
                    { new Guid("d5641a58-80fe-4bc0-b7d1-58ecfb85475d"), 1, "Курс \"Графика в игре\"", 4500m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("d5745193-0e24-445e-9e95-60220b194d42"), 1, "Помощь с идеей для вашего проекта", 500m, new Guid("b15898a5-fd66-4ec8-b65a-bc196889db52") },
                    { new Guid("e0af06de-6202-4ed9-866a-79475ca9efa8"), 1, "Цифровой арт \"Далекое будущее\"", 5000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("e21788ac-9fa4-4474-9a9b-845229805542"), 1, "Видеоурок \"Рисование в Affinity Designer\"", 3500m, new Guid("b15898a5-fd66-4ec8-b65a-bc196889db52") },
                    { new Guid("e43f7445-fad5-4534-b01d-50d8096f82d2"), 1, "Цифровой арт \"Ночной город\"", 3500m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("e7cfd964-05de-432b-8068-7de98e434d4a"), 1, "Цифровой арт \"Красивый город\"", 5000m, new Guid("ffba678c-7f98-47db-b8fd-aa371c5efaf4") },
                    { new Guid("ee1a693f-99d8-4afd-a4c8-4d60db28bf10"), 1, "Реклама", 10000m, new Guid("b15898a5-fd66-4ec8-b65a-bc196889db52") },
                    { new Guid("f4993ba6-8ac3-46c3-af81-d4bb1d8fb2b9"), 1, "Курс \"3D игровая графика\"", 4500m, new Guid("b15898a5-fd66-4ec8-b65a-bc196889db52") },
                    { new Guid("f638aca2-7890-4e7f-b1dd-f88145354069"), 1, "Курс \"2D игровая графика\"", 4000m, new Guid("b15898a5-fd66-4ec8-b65a-bc196889db52") }
                });
        }
    }
}
