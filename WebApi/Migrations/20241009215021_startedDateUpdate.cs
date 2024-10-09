using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiMigrations
{
    /// <inheritdoc />
    public partial class startedDateUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
