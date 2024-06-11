using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirFlight2.Repository.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 1, null, "Turkey", null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 2, null, "USA", null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[] { 3, null, "Germany", null });

            migrationBuilder.InsertData(
                table: "AirPorts",
                columns: new[] { "Id", "AirPortName", "CountryId", "CreatedDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Şakirpaşa Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4246), null },
                    { 2, "Ankara Esenboğa Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4258), null },
                    { 3, "Antalya Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4259), null },
                    { 4, "Gazipaşa Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4260), null },
                    { 5, "Balıkesir Koca Seyit Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4261), null },
                    { 6, "Bursa Yenişehir Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4262), null },
                    { 7, "Çanakkale Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4263), null },
                    { 8, "Denizli Çardak Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4264), null },
                    { 9, "Diyarbakır Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4265), null },
                    { 10, "Elazığ Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4266), null },
                    { 11, "Erzurum Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4267), null },
                    { 12, "Hasan Polatkan Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4268), null },
                    { 13, "Gaziantep Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4269), null },
                    { 14, "Hatay Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4270), null },
                    { 15, "Isparta Süleyman Demirel Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4271), null },
                    { 16, "İstanbul Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4272), null },
                    { 17, "Sabiha Gökçen Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4274), null },
                    { 18, "Adnan Menderes Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4275), null },
                    { 19, "Kars Harakani Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4276), null },
                    { 20, "Erkilet Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4277), null },
                    { 21, "Cengiz Topel Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4278), null },
                    { 22, "Konya Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4279), null },
                    { 23, "Zafer Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4280), null },
                    { 24, "Malatya Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4281), null },
                    { 25, "Dalaman Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4282), null },
                    { 26, "Milas-Bodrum Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4283), null },
                    { 27, "Nevşehir Kapadokya Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4284), null },
                    { 28, "Ordu-Giresun Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4285), null },
                    { 29, "Rize-Artvin Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4286), null },
                    { 30, "Samsun Çarşamba Havalimanı	", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4288), null },
                    { 31, "Sinop Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4289), null },
                    { 32, "Sivas Nuri Demirağ Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4290), null },
                    { 33, "Şanlıurfa GAP Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4291), null },
                    { 34, "Tekirdağ Çorlu Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4292), null },
                    { 35, "Trabzon Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4293), null },
                    { 36, "Uşak Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4294), null },
                    { 37, "Van Ferit Melen Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4295), null },
                    { 38, "Zonguldak Havalimanı", 1, new DateTime(2024, 6, 4, 12, 37, 4, 249, DateTimeKind.Local).AddTicks(4296), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AirPorts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
