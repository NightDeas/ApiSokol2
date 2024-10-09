using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiMigrations
{
    /// <inheritdoc />
    public partial class startedDateUpdateV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("0585064b-1897-4279-8584-21eec028e4ee"), new DateTime(2024, 10, 12, 22, 4, 15, 489, DateTimeKind.Utc).AddTicks(1681), "Выставка фотографий, демонстрирующих фотографию как самостоятельное искусство.", "Выставка 'Фотография как искусство'" },
                    { new Guid("0bff72e1-e5e9-4f45-9384-3cb1a66549d1"), new DateTime(2024, 10, 22, 22, 4, 15, 489, DateTimeKind.Utc).AddTicks(1702), "Конкурс для детских художников до 12 лет. Прием работ до 1 февраля.", "Конкурс 'Искусство для детей'" },
                    { new Guid("0d4656a5-1bc2-449c-93f7-4bb76dfe248b"), new DateTime(2024, 11, 7, 22, 4, 15, 489, DateTimeKind.Utc).AddTicks(1692), "Конкурс для скульпторов и художников, работающих в области пластики. Прием работ до 10 января.", "Конкурс 'Скульптура и пластика'" },
                    { new Guid("3aa693a5-555c-48a5-bb3e-1654489b725b"), new DateTime(2024, 10, 11, 22, 4, 15, 489, DateTimeKind.Utc).AddTicks(1686), "Конкурс посвящен графике и рисункам. Прием работ до 20 декабря.", "Конкурс 'Графика и рисунки'" },
                    { new Guid("40648d8b-8165-421c-b5fd-1a7b7820e3cc"), new DateTime(2024, 11, 5, 22, 4, 15, 489, DateTimeKind.Utc).AddTicks(1672), "Конкурс открыт для художников со всего мира. Прием работ до 15 октября.", "Международный конкурс 'Живопись 2023'" },
                    { new Guid("6fe84a6b-6f8a-4748-9cb7-0dfa0790414e"), new DateTime(2024, 10, 28, 22, 4, 15, 489, DateTimeKind.Utc).AddTicks(1636), "Выставка представляет работы современных художников, посвященные теме абстракции.", "Выставка современного искусства 'Абстракция'" },
                    { new Guid("7cca5697-1bc9-4e3d-b197-86c1d425abcf"), new DateTime(2024, 10, 23, 22, 4, 15, 489, DateTimeKind.Utc).AddTicks(1689), "Выставка работ художников из стран Востока, представляющих традиционное и современное искусство.", "Выставка 'Искусство Востока'" },
                    { new Guid("ad469ac4-782e-443a-a345-90342d7ca37c"), new DateTime(2024, 11, 2, 22, 4, 15, 489, DateTimeKind.Utc).AddTicks(1678), "Конкурс для молодых художников до 30 лет. Прием работ до 30 ноября.", "Конкурс 'Молодое искусство'" },
                    { new Guid("bc87df8b-23d5-4ba5-800a-04c93db1afd1"), new DateTime(2024, 10, 26, 22, 4, 15, 489, DateTimeKind.Utc).AddTicks(1675), "Выставка посвящена искусству XX века, включая работы известных мастеров.", "Выставка 'Искусство XX века'" },
                    { new Guid("e540c01f-9eae-40a7-9680-4321b2157867"), new DateTime(2024, 11, 3, 22, 4, 15, 489, DateTimeKind.Utc).AddTicks(1695), "Выставка, демонстрирующая взаимодействие искусства и современных технологий.", "Выставка 'Искусство и технологии'" }
                });

            migrationBuilder.InsertData(
                table: "TypeProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a7151783-8922-42ae-a0c7-acc4125c35ab"), "Услуга" },
                    { new Guid("d8f9b99f-810b-442e-b54c-366f4e802635"), "Товар" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Discount", "FIO", "IsClient", "IsProvider" },
                values: new object[,]
                {
                    { new Guid("0624610f-5328-4031-917a-7cbab13aef2a"), 0m, "Юриков Дмитрий Александрович", true, false },
                    { new Guid("143526d3-7ab5-4336-9012-6b81111e90e2"), 0m, "Филиппов Дмитрий Александрович", false, true },
                    { new Guid("162c8f6d-8338-43a1-bc84-287bac130d12"), 0m, "Козлов Максим Иванович", true, false },
                    { new Guid("1946b329-421c-4b15-b568-9bf3119c1f1b"), 0m, "Морозов Андрей Николаевич", true, false },
                    { new Guid("1a24319d-c152-44a2-8e56-f4634dd8f806"), 0m, "Ильин Сергей Дмитриевич", true, false },
                    { new Guid("1d9a4f5d-e1d9-4ffb-9bac-9ce326b0d5af"), 0m, "Новиков Дмитрий Александрович", false, true },
                    { new Guid("1e200f3e-59bc-4df4-8530-05e4b910f909"), 0m, "Павлов Константин Петрович", false, true },
                    { new Guid("26850ef6-41c5-459a-a65c-c24fc614b34f"), 0m, "Сидоров Иван Сергеевич", false, true },
                    { new Guid("2a7652c4-9c01-436a-9d35-b49c5d5b0fc8"), 0m, "Матвеев Сергей Дмитриевич", true, false },
                    { new Guid("2f1181a8-00dd-4ab1-917c-7b91c524d5da"), 0m, "Григорьев Иван Сергеевич", false, true },
                    { new Guid("3fe7d971-d151-4473-ab37-488137be1a95"), 0m, "Дмитриев Максим Иванович", true, false },
                    { new Guid("4080739a-5f17-4923-9434-6d703fdc4283"), 0m, "Кузнецов Сергей Дмитриевич", true, false },
                    { new Guid("43dd2077-331d-40fd-94fb-ade6162034f4"), 0m, "Петров Алексей Дмитриевич", true, false },
                    { new Guid("4436a233-0afb-4f39-b429-434a41150770"), 0m, "Белов Максим Иванович", true, false },
                    { new Guid("55141aa4-3bcf-4bae-8cb5-40f9cbe4a3c0"), 0m, "Комаров Константин Петрович", false, true },
                    { new Guid("5af78c8b-2e16-4658-b00a-007be62424cc"), 0m, "Соколов Сергей Дмитриевич", true, false },
                    { new Guid("5d409dc9-763f-4ea4-8e94-3ba76dc886ae"), 0m, "Михайлов Иван Сергеевич", false, true },
                    { new Guid("6234efdd-7e0d-4960-a6f2-5790f9c3eaa2"), 0m, "Попов Константин Петрович", false, true },
                    { new Guid("695ea249-6811-46e6-a75c-9651fdda0078"), 0m, "Николаев Сергей Дмитриевич", true, false },
                    { new Guid("6f822fd4-a732-436c-a1c9-3ff027af4c1c"), 0m, "Сергеев Константин Петрович", false, true },
                    { new Guid("70d23143-4e89-4b4f-b081-aa9181fb4cc8"), 0m, "Борисов Иван Сергеевич", false, true },
                    { new Guid("76e2296f-9e00-413f-810e-5c36efa8ab81"), 0m, "Лебедев Максим Иванович", true, false },
                    { new Guid("77841083-0886-4650-a566-ff0373016690"), 0m, "Семенов Андрей Николаевич", true, false },
                    { new Guid("7fcdb4aa-41e6-4cd1-b68e-cca514a45b0e"), 0m, "Макаров Дмитрий Александрович", false, true },
                    { new Guid("81273bbb-b01c-4021-8130-3cdeda08680d"), 0m, "Алексеев Андрей Николаевич", true, false },
                    { new Guid("9b59c903-c56f-41ef-b251-1eeaff61aa95"), 0m, "Орлов Иван Сергеевич", false, true },
                    { new Guid("a71e29f2-e471-4543-a26d-d3cd12cb855a"), 0m, "Васильев Константин Петрович", false, true },
                    { new Guid("ab84e037-7581-46f3-bdf7-6d1dd7bc724f"), 0m, "Соловьев Андрей Николаевич", true, false },
                    { new Guid("bd793179-0438-4543-ad2e-dc0adefe595b"), 0m, "Андреев Максим Иванович", true, false },
                    { new Guid("ce705f63-720e-4d3f-a6d0-e42ced0a1469"), 0m, "Федоров Андрей Николаевич", true, false },
                    { new Guid("e1d9326d-443c-4fa1-a680-1fdcdb1c2ce7"), 0m, "Ковалев Дмитрий Александрович", false, true },
                    { new Guid("e220796c-1e69-45ad-b7b8-2703fb4311e7"), 0m, "Иванов Сергей Максимович", false, true },
                    { new Guid("e4a4c953-eae2-47fe-a46a-eccacab63664"), 0m, "Егоров Дмитрий Александрович", false, true }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Sum", "UserId" },
                values: new object[,]
                {
                    { new Guid("3baf39c5-f284-4ac7-8374-e5711cfb04a5"), 0m, new Guid("5d409dc9-763f-4ea4-8e94-3ba76dc886ae") },
                    { new Guid("43c08780-a723-4b0a-95cd-ac9583bd6f8f"), 0m, new Guid("5af78c8b-2e16-4658-b00a-007be62424cc") },
                    { new Guid("58fd8d05-0977-4b76-826c-3be682edf72c"), 0m, new Guid("e220796c-1e69-45ad-b7b8-2703fb4311e7") },
                    { new Guid("8062754b-ac45-4fda-bcb5-744371d6bdc3"), 0m, new Guid("1946b329-421c-4b15-b568-9bf3119c1f1b") },
                    { new Guid("a165c982-4ea8-4c8d-8fdd-76368c86dc21"), 0m, new Guid("ce705f63-720e-4d3f-a6d0-e42ced0a1469") },
                    { new Guid("b253aee2-7d4c-4ba1-9268-8fc37794b99e"), 0m, new Guid("1d9a4f5d-e1d9-4ffb-9bac-9ce326b0d5af") },
                    { new Guid("b25f053b-e25a-4336-8ac3-61c6fd3e8bb2"), 0m, new Guid("0624610f-5328-4031-917a-7cbab13aef2a") },
                    { new Guid("b623868e-855e-497a-b0e2-622acd4a9042"), 0m, new Guid("a71e29f2-e471-4543-a26d-d3cd12cb855a") },
                    { new Guid("e5db2dfd-b6d8-477f-971c-2344b3a36efd"), 0m, new Guid("43dd2077-331d-40fd-94fb-ade6162034f4") },
                    { new Guid("f58a4811-85e0-4110-9cbc-06172ab10395"), 0m, new Guid("26850ef6-41c5-459a-a65c-c24fc614b34f") },
                    { new Guid("fec4789d-1b7e-4f90-b6ac-cfd5ae9aefad"), 0m, new Guid("162c8f6d-8338-43a1-bc84-287bac130d12") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Count", "Name", "Price", "TypeId" },
                values: new object[,]
                {
                    { new Guid("0231531e-cbda-416c-b842-b8bde9acce79"), 1, "Курс \"3D игровая графика\"", 4500m, new Guid("a7151783-8922-42ae-a0c7-acc4125c35ab") },
                    { new Guid("204c9e90-cd1b-4437-a3ae-0633d1904191"), 1, "Видеоурок \"Рисование в Krita\"", 2000m, new Guid("a7151783-8922-42ae-a0c7-acc4125c35ab") },
                    { new Guid("240af5a4-6101-45eb-809f-5491b75ef970"), 0, "Помощь с идеей для вашего проекта", 500m, new Guid("a7151783-8922-42ae-a0c7-acc4125c35ab") },
                    { new Guid("24b3225b-62ac-40fe-bd0b-1ab10b760803"), 0, "Песня, сгенерированная нейросетью \"Весна\"", 150m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("275f03fa-3a9e-4dda-b691-2652738734b7"), 0, "Видеоурок \"Рисование портретов\"", 3000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("29730f5f-efbc-4c40-b5e2-50f5c838f6bc"), 0, "Видеоурок \"Основы 3D моделирования\"", 2500m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("2aac3e55-0a2a-4be0-8489-665258e591cd"), 0, "Видеоурок \"Песня \"Ромашки\" на гитаре\"", 2000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("2d402b80-7440-40fa-8905-cc7053ecdec9"), 0, "Онлайн урок по рисованию", 1900m, new Guid("a7151783-8922-42ae-a0c7-acc4125c35ab") },
                    { new Guid("33a51587-f0dd-4aad-ad98-68bfea744ce4"), 0, "Реклама", 10000m, new Guid("a7151783-8922-42ae-a0c7-acc4125c35ab") },
                    { new Guid("51b7dc1d-a4f5-4b19-a697-8be253de2752"), 1, "Курс \"2D игровая графика\"", 4000m, new Guid("a7151783-8922-42ae-a0c7-acc4125c35ab") },
                    { new Guid("5336dafc-0b8d-4323-a28d-2005c662fa29"), 0, "Цифровой арт \"Цифровое искусство\"", 5000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("5492760d-7c1c-4fa3-b797-5ab07849abaa"), 1, "Цифровой арт \"Пейзаж с водопадом\"", 5000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("55ef267d-c59c-4271-bce9-355ef9c135e3"), 1, "Цифровой арт \"Пейзаж с озером\"", 5000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("5ba66e0b-0e7d-443e-80ec-501660344535"), 1, "Цифровой арт \"Пейзаж с пустыней\"", 3000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("5e91009a-7a44-43e4-b510-4adad4f6ff66"), 1, "Курс \"2D анимация\"", 4000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("65b035d3-229f-4c9a-8318-c0707f2f0687"), 1, "Цифровой арт \"Пейзаж с морем\"", 5000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("67a8abcc-30bc-4406-8d91-c628f4e010fd"), 1, "Цифровой арт \"Пейзаж с вулканом\"", 5000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("6d6856d0-1cd9-45ac-a77b-bdf0d319e092"), 0, "Курс \"Графика в игре\"", 4500m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("6db310a6-c70c-4be3-b858-d1eeaea37457"), 0, "Цифровой арт \"Закат на пляже\"", 4000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("6fffb46f-bf2f-4e63-b2ad-3ea3da940ece"), 0, "Видеоурок \"Рисование в Photoshop\"", 1500m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("76d51a18-000e-435f-856e-de51bed5d9d1"), 1, "Видеоурок \"Рисование в Sketchbook\"", 3000m, new Guid("a7151783-8922-42ae-a0c7-acc4125c35ab") },
                    { new Guid("782752fe-debc-4f01-8d95-eda33d1a1915"), 1, "Цифровой арт \"Пейзаж с лесом\"", 2500m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("7f316017-7080-4162-9b6a-e33f326e9b38"), 0, "Курс \"Художник за месяц\"", 6000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("81cb76d3-e683-4ee3-9866-9466fbc32997"), 0, "Цифровой арт \"Ночной город\"", 3500m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("835c17f3-e2f2-4f6f-806e-cf73578bc5b4"), 1, "Курс \"3D моделирование\"", 4500m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("9c41aff6-8bb3-4682-9dc0-ac4fc48458f2"), 0, "Цифровой арт \"Летний день\"", 2000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("9de68a4e-0c80-4d7b-8ce7-2836bd75096d"), 0, "Видеоурок \"Как сделать первый 3D дизайн\"", 2000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("a02e4ad1-a9f5-4b99-923b-df09483cf0d0"), 0, "Курс \"3D анимация\"", 6000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("a0386209-348a-4f5c-ab1e-98ed798caa1a"), 1, "Цифровой арт \"Пейзаж с горами\"", 3000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("a560fcd3-3782-4958-87fe-f72862272c18"), 0, "Цифровой арт \"Красивый город\"", 5000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("b1444211-97c8-4b09-ad3d-911c936a0444"), 0, "Цифровой арт \"Зимний лес\"", 5000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("b27418d2-8ea3-4336-88d8-a3a0784ff5c5"), 1, "Видеоурок \"Рисование в PaintTool SAI\"", 2500m, new Guid("a7151783-8922-42ae-a0c7-acc4125c35ab") },
                    { new Guid("bf1ab1a3-f3dd-4708-82c5-b4390eb9ae1c"), 1, "Видеоурок \"Рисование в Procreate\"", 3500m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("c2bc2461-2355-4ec4-92d4-23de2bf81883"), 1, "Цифровой арт \"Городской пейзаж\"", 2500m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("c3f9bc6a-9285-455f-a6ef-ff40165ef981"), 0, "Песня, сгенерированная нейросетью", 100m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("e8b1d2a0-34e6-486f-a138-9b811a00b5c5"), 1, "Видеоурок \"Рисование в Affinity Designer\"", 3500m, new Guid("a7151783-8922-42ae-a0c7-acc4125c35ab") },
                    { new Guid("f54678df-6c42-42e3-8ab3-3f0faccff11d"), 1, "Видеоурок \"Рисование в Illustrator\"", 2000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") },
                    { new Guid("fb49c797-b5a9-4286-b1fc-8665c4533603"), 0, "Цифровой арт \"Далекое будущее\"", 5000m, new Guid("d8f9b99f-810b-442e-b54c-366f4e802635") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("0585064b-1897-4279-8584-21eec028e4ee"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("0bff72e1-e5e9-4f45-9384-3cb1a66549d1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("0d4656a5-1bc2-449c-93f7-4bb76dfe248b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("3aa693a5-555c-48a5-bb3e-1654489b725b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("40648d8b-8165-421c-b5fd-1a7b7820e3cc"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("6fe84a6b-6f8a-4748-9cb7-0dfa0790414e"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("7cca5697-1bc9-4e3d-b197-86c1d425abcf"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("ad469ac4-782e-443a-a345-90342d7ca37c"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("bc87df8b-23d5-4ba5-800a-04c93db1afd1"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e540c01f-9eae-40a7-9680-4321b2157867"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3baf39c5-f284-4ac7-8374-e5711cfb04a5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("43c08780-a723-4b0a-95cd-ac9583bd6f8f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("58fd8d05-0977-4b76-826c-3be682edf72c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8062754b-ac45-4fda-bcb5-744371d6bdc3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a165c982-4ea8-4c8d-8fdd-76368c86dc21"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b253aee2-7d4c-4ba1-9268-8fc37794b99e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b25f053b-e25a-4336-8ac3-61c6fd3e8bb2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b623868e-855e-497a-b0e2-622acd4a9042"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e5db2dfd-b6d8-477f-971c-2344b3a36efd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f58a4811-85e0-4110-9cbc-06172ab10395"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fec4789d-1b7e-4f90-b6ac-cfd5ae9aefad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0231531e-cbda-416c-b842-b8bde9acce79"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("204c9e90-cd1b-4437-a3ae-0633d1904191"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("240af5a4-6101-45eb-809f-5491b75ef970"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24b3225b-62ac-40fe-bd0b-1ab10b760803"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("275f03fa-3a9e-4dda-b691-2652738734b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29730f5f-efbc-4c40-b5e2-50f5c838f6bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2aac3e55-0a2a-4be0-8489-665258e591cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d402b80-7440-40fa-8905-cc7053ecdec9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33a51587-f0dd-4aad-ad98-68bfea744ce4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51b7dc1d-a4f5-4b19-a697-8be253de2752"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5336dafc-0b8d-4323-a28d-2005c662fa29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5492760d-7c1c-4fa3-b797-5ab07849abaa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55ef267d-c59c-4271-bce9-355ef9c135e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ba66e0b-0e7d-443e-80ec-501660344535"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e91009a-7a44-43e4-b510-4adad4f6ff66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65b035d3-229f-4c9a-8318-c0707f2f0687"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67a8abcc-30bc-4406-8d91-c628f4e010fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d6856d0-1cd9-45ac-a77b-bdf0d319e092"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6db310a6-c70c-4be3-b858-d1eeaea37457"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fffb46f-bf2f-4e63-b2ad-3ea3da940ece"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76d51a18-000e-435f-856e-de51bed5d9d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("782752fe-debc-4f01-8d95-eda33d1a1915"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f316017-7080-4162-9b6a-e33f326e9b38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("81cb76d3-e683-4ee3-9866-9466fbc32997"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("835c17f3-e2f2-4f6f-806e-cf73578bc5b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c41aff6-8bb3-4682-9dc0-ac4fc48458f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9de68a4e-0c80-4d7b-8ce7-2836bd75096d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a02e4ad1-a9f5-4b99-923b-df09483cf0d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0386209-348a-4f5c-ab1e-98ed798caa1a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a560fcd3-3782-4958-87fe-f72862272c18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1444211-97c8-4b09-ad3d-911c936a0444"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b27418d2-8ea3-4336-88d8-a3a0784ff5c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf1ab1a3-f3dd-4708-82c5-b4390eb9ae1c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2bc2461-2355-4ec4-92d4-23de2bf81883"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3f9bc6a-9285-455f-a6ef-ff40165ef981"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8b1d2a0-34e6-486f-a138-9b811a00b5c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f54678df-6c42-42e3-8ab3-3f0faccff11d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb49c797-b5a9-4286-b1fc-8665c4533603"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("143526d3-7ab5-4336-9012-6b81111e90e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a24319d-c152-44a2-8e56-f4634dd8f806"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e200f3e-59bc-4df4-8530-05e4b910f909"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a7652c4-9c01-436a-9d35-b49c5d5b0fc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f1181a8-00dd-4ab1-917c-7b91c524d5da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3fe7d971-d151-4473-ab37-488137be1a95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4080739a-5f17-4923-9434-6d703fdc4283"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4436a233-0afb-4f39-b429-434a41150770"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55141aa4-3bcf-4bae-8cb5-40f9cbe4a3c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6234efdd-7e0d-4960-a6f2-5790f9c3eaa2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("695ea249-6811-46e6-a75c-9651fdda0078"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f822fd4-a732-436c-a1c9-3ff027af4c1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70d23143-4e89-4b4f-b081-aa9181fb4cc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76e2296f-9e00-413f-810e-5c36efa8ab81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77841083-0886-4650-a566-ff0373016690"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fcdb4aa-41e6-4cd1-b68e-cca514a45b0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81273bbb-b01c-4021-8130-3cdeda08680d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b59c903-c56f-41ef-b251-1eeaff61aa95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ab84e037-7581-46f3-bdf7-6d1dd7bc724f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd793179-0438-4543-ad2e-dc0adefe595b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1d9326d-443c-4fa1-a680-1fdcdb1c2ce7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4a4c953-eae2-47fe-a46a-eccacab63664"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("a7151783-8922-42ae-a0c7-acc4125c35ab"));

            migrationBuilder.DeleteData(
                table: "TypeProducts",
                keyColumn: "Id",
                keyValue: new Guid("d8f9b99f-810b-442e-b54c-366f4e802635"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0624610f-5328-4031-917a-7cbab13aef2a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("162c8f6d-8338-43a1-bc84-287bac130d12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1946b329-421c-4b15-b568-9bf3119c1f1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d9a4f5d-e1d9-4ffb-9bac-9ce326b0d5af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26850ef6-41c5-459a-a65c-c24fc614b34f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("43dd2077-331d-40fd-94fb-ade6162034f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5af78c8b-2e16-4658-b00a-007be62424cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d409dc9-763f-4ea4-8e94-3ba76dc886ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a71e29f2-e471-4543-a26d-d3cd12cb855a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce705f63-720e-4d3f-a6d0-e42ced0a1469"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e220796c-1e69-45ad-b7b8-2703fb4311e7"));

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
    }
}
