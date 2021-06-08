using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class addProductName2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 4, 22, 21, 0, 119, DateTimeKind.Local).AddTicks(4951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 4, 21, 22, 20, 447, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Districst",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wards",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 606, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 606, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Districst", "OrderDate", "Wards", "total" },
                values: new object[] { "Thành phố Hà Nội", "Quận Hoàng Mai", new DateTime(2021, 6, 4, 22, 21, 0, 947, DateTimeKind.Local).AddTicks(1662), "Phường Hoàng Văn Thụ", 40000m });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 206, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 204, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 205, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "3d01a7fe-2a99-435c-97cd-92056709043b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "a8eb7ecc-b7d5-48cd-8c3b-89b322a552ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "879dabda-c9f9-476c-8bdc-cf036a70feb3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "8c9aa8b1-6bc4-46dc-a7b4-ff978224d3d3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 590, DateTimeKind.Local).AddTicks(2766), "ea19361e-ad77-4a8d-a3ae-632f3746fa74", "AQAAAAEAACcQAAAAEH/8ezhlt2Qfv2HzdjsTIoKVKhPZoUoKwxSqdr8JX7sz6/h/Hltc/V5QL/FG75EGsA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 225, DateTimeKind.Local).AddTicks(1930), "08dc15bb-37c6-4f3f-927e-687446af29a6", "AQAAAAEAACcQAAAAEKz0hAnmZCy3PTbdp62vsVw2NpwZCdVsWO3wxxzflHZeKECpwecPaKgBoNHPBkPtxg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 239, DateTimeKind.Local).AddTicks(8655), "bbb5af94-dcda-4c39-91c2-5793ed95c728", "AQAAAAEAACcQAAAAEFAjqottuCgSQaE6lAJqjNSIYQzlZUu8sVscXslq3zryQxKQzwne/o2FxlHIktvbKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 254, DateTimeKind.Local).AddTicks(2048), "d5f309a7-b270-4a17-bf35-7be7ea1ca6a2", "AQAAAAEAACcQAAAAEFs60/wjgTPr6CdjG+4kSaiIXRxoYUQepYj0g6FCUKju63wtdyMoJd1IUy+AXT27Vg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 267, DateTimeKind.Local).AddTicks(4158), "73a1972d-6300-4f7c-bf0c-7824eb5a64c6", "AQAAAAEAACcQAAAAEN2ERL30yUzp++q0GGu8G4u4DLATybAJ0+UnXoGQvziKyzwYBc/EHx2sSZxZJHhOLg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 279, DateTimeKind.Local).AddTicks(5672), "91690cd4-633f-49da-a126-8a786691ca17", "AQAAAAEAACcQAAAAEBSShhFz5lzueifAtIC4u2bkIMaRYPNpNKDnHFyLfs+oPto6KJugMmxmyGyGarMUwg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 290, DateTimeKind.Local).AddTicks(6935), "7776dbce-637a-4e40-a432-9bc8ff0dccb0", "AQAAAAEAACcQAAAAEAZdVxvuGElnUsUDvEkJ5ZmRhITHeCnKa0Xos5ZMUESObalbwOdL9U9+oj24ltS6ew==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 303, DateTimeKind.Local).AddTicks(2742), "acceb527-2e0b-4640-a62f-c60365d7be28", "AQAAAAEAACcQAAAAEGdssx9nf5NeYgAlbAetHq+Pb/qY9/lFaMuLbDvRRWoRbXDhllLxrT7Rn1MH0/nBMQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 316, DateTimeKind.Local).AddTicks(8277), "1e5d8dce-3163-4d2f-a62a-b0ea8966581a", "AQAAAAEAACcQAAAAEJdjDrejle6z3XGZiqAwNzOmH1A3katwZV4nWz42MyfJtIjAamId+SfMRh1yYI6idQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 329, DateTimeKind.Local).AddTicks(9717), "1dec1afb-cb62-48da-b835-2577a7f2a38c", "AQAAAAEAACcQAAAAECHPLYMgik/tTJu8Cbz6vxuX094M6inS1F0zCnlw6yd5lkJgGZTYwLQurJY3MKgKIA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 344, DateTimeKind.Local).AddTicks(5961), "5dfd709c-d4fd-45a2-a4ef-00e7e80daab4", "AQAAAAEAACcQAAAAEPXNBYBqCQKptv2WteaW8mnM17GnEf0bw6G6dxzDT7crrLVo7FhOYA5aomxxx9YHLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 357, DateTimeKind.Local).AddTicks(6314), "6c559cdf-c45b-4a0d-989a-3f7fd72f0827", "AQAAAAEAACcQAAAAEFYrTelE6RcTKBBs5b8fwJWaz4oEOw1GWtWlPrzVQwJPrVQybjlzgSO1p8autJTn3Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 371, DateTimeKind.Local).AddTicks(1361), "2c0d5f25-1b3c-496a-9eaf-088e371ab797", "AQAAAAEAACcQAAAAEBKRIrg2RexTEO/xb6rNif3/FAKztFKzOWHAvpbCj7ksnZkR0r1+X84rTE3kldbwAw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 385, DateTimeKind.Local).AddTicks(7096), "8a551c2b-deb4-411d-ad46-1eea55235bc5", "AQAAAAEAACcQAAAAEI5JbSV0gBfLTPYtWxUiE3VcxvaSkBjsXrKHwS0b8pQC7i4TN9yebbbrwNIBPpSiRg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 399, DateTimeKind.Local).AddTicks(5788), "62b011fc-6bc0-46fc-bc34-4ea03e3b6c67", "AQAAAAEAACcQAAAAEE4S9aIxHeOl6IWDyVQA7vf8fokwcmEPrvG37x94h800hJ1Oh6FBL4eY67x357dX6w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 412, DateTimeKind.Local).AddTicks(5812), "933ce93c-aaba-45ad-ad42-63c9eccbe97d", "AQAAAAEAACcQAAAAEBLF+qSLjWcxK7FJ8RmT/d19lZ9Wc2cOygbZKXQ5Z6mCe9zEZDz6r0NY7JfQIQxGTg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 426, DateTimeKind.Local).AddTicks(1091), "aacd4668-60fd-4bf5-933d-b66b9b0d17fc", "AQAAAAEAACcQAAAAEE3h6pO/G2UPV3/j0glQFpYuuSkX3lH6az/KvEW/Pfk+jjFI5O9hkB8Bdvk+Lx0/UA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 439, DateTimeKind.Local).AddTicks(1094), "7a6fb770-74f4-4484-b591-5c90ba009f0a", "AQAAAAEAACcQAAAAEHQAzodhZRYTllNX3GEi1BDUo71sl6jnyEWCzTfhVF9lfxrvpUtTh4d3/rlTiwQNew==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 452, DateTimeKind.Local).AddTicks(3660), "0966b3cd-1fb2-48ba-86d3-88021b20de15", "AQAAAAEAACcQAAAAENZltMZ6GGbM0Z/f036ioRb1gTDlMnGDkTizb8rlXjUBomsB1tFk3QtkW47wUjJO0A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 463, DateTimeKind.Local).AddTicks(5156), "9d11b45f-8f57-4e08-936f-68fbdd3f8674", "AQAAAAEAACcQAAAAEIr4oC3oFc1nOetRNDcirifH+OvkRHIqb9O3Gjb/akz6c5h4lV9vPwU/cK0byj30qQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 477, DateTimeKind.Local).AddTicks(1070), "596841c2-8dbe-456c-b922-6c6cbcd2f493", "AQAAAAEAACcQAAAAEGBDHrkBTsw3ZTeV817CVP3mRzbqYv7kAJdPqGUMO7kjzaaewfBRhaPBW6q/teEZrA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 545, DateTimeKind.Local).AddTicks(6811), "1e275e3b-b7f9-4c4f-a8be-2830490c983c", "AQAAAAEAACcQAAAAEJkb7UpYbgTPc8joT04fVNeg9Uo1cJzrmM0VZahU4VPXLpH3a1UN1lXYcDb7hypi0Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 532, DateTimeKind.Local).AddTicks(5810), "f57e57a3-d5f0-4f37-8ab2-ad6dfe0b5be5", "AQAAAAEAACcQAAAAEBXLcFgcsyLyQx2oLrIWq1i4XEMf+cV5P/A7OpX6mmnWXNxpG0n7FOT7kejK8LHxhQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 559, DateTimeKind.Local).AddTicks(6628), "3ee74a1b-7169-4136-a897-5ff00db6d358", "AQAAAAEAACcQAAAAENk5U/sT8apkTGiM+Z4JCuvJFq2FjaaVq4iGxBCkHVcaQal8gWQcd3RX9IfHgJQTSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 605, DateTimeKind.Local).AddTicks(138), "aac15d21-dc1f-443b-b179-c2bdd829abb7", "AQAAAAEAACcQAAAAEH72CXooL9Nz00c4pDZht9SrQooNIzz5weXSEVjO6yMEVkFgALan3zNFZhZ9TyupiA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 505, DateTimeKind.Local).AddTicks(815), "4685b0b4-e0e8-4978-bd90-def0787f7cc5", "AQAAAAEAACcQAAAAECfpHLCo9PhzDykmiKj3WsQ4b5Yb88LOpwAWYaEFPZdgLaW88OeOgLmf23+mhEXaOg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 519, DateTimeKind.Local).AddTicks(1884), "7e8781fe-afc2-4944-b0a9-98f36dd1f388", "AQAAAAEAACcQAAAAENOxoLbxUCfp9CqYZKanmqSTtAUaa6U7tjuzO6wC5Wc2kiexsUTgdrQIYUzFTPDeVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 573, DateTimeKind.Local).AddTicks(8581), "ad90d255-b910-4c6d-a262-0be4597e84aa", "AQAAAAEAACcQAAAAEGyLVT3WWUmnIHsLzxKsopIjCuIEdOQXv6OjAdYEeGTy6D50nnn441ukY5bfF3lC4w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 22, 21, 0, 490, DateTimeKind.Local).AddTicks(9307), "00e3ec03-18e8-46ed-b06b-25f14f99360f", "AQAAAAEAACcQAAAAEMZRQ1KpVLGp966HoYFDMTXryjuR6lNgbJ18EnMWZ9rNufee4vw8sAKDY0jSiIw7mA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Districst",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Wards",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 4, 21, 22, 20, 447, DateTimeKind.Local).AddTicks(1487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 4, 22, 21, 0, 119, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 21, 46, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 21, 46, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OrderDate", "total" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 21, 349, DateTimeKind.Local).AddTicks(3485), 0m });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 4, 21, 22, 20, 713, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "d77ae721-0179-4b8b-ba56-c66d7ce3cb08");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "f732a766-6d2f-47df-928b-a23a15c86f2b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "bb122389-f45a-4560-9111-86a47a5323d3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "bdc5ce9f-3d81-4bf2-a211-cae238dd3be5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 21, 32, DateTimeKind.Local).AddTicks(6757), "d6385357-db6f-458e-8ba2-7da193c2a5b2", "AQAAAAEAACcQAAAAEIGVKR2zfBm3dmz3YjHvb6T2rIUq2U0QaqEHjlBZBx4HytAYu5lUMhcXdNleLajrsQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 729, DateTimeKind.Local).AddTicks(6053), "5df96edb-2f87-49df-9c3e-ed16f8338a57", "AQAAAAEAACcQAAAAENzjeXM6NhnMXciDe18COM/CcAlgFHzjNackAX43X38BsDDIagIEeTy5XSYy29VJZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 740, DateTimeKind.Local).AddTicks(2579), "93e5ab34-0b5d-4a5f-a2a5-07cee5314c85", "AQAAAAEAACcQAAAAEKjK8KFDLNO2mOFrbCQvpA6ifk++9AjtUhJVE4RKKS/SVwgtI/9nYZp2SSxgCmgeOw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 750, DateTimeKind.Local).AddTicks(2574), "6a306c41-57a5-4b72-9895-05f74767565e", "AQAAAAEAACcQAAAAEON963WsAtnbUWlLA70qYFFDqrjbV7CPQwAFlaEglYhHAkZaYFXZM6f6UIsUTv1vgg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 760, DateTimeKind.Local).AddTicks(8763), "63ca6954-29af-4a12-ac4c-19e38a0a8289", "AQAAAAEAACcQAAAAEGZObqhKJKQQav9XsOj/FAKaW3kXetrembSZKHfENJdZdvkrWnE1oY40kSQVXFlZTg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 772, DateTimeKind.Local).AddTicks(4712), "11ab0adf-79c4-43da-9890-d18b62825a23", "AQAAAAEAACcQAAAAEFDCYhSn/YRfgmGhehCvD4I55dq4vjdbX94Xby19eWTt8L5yvjW4ZD5qFoYl+OVjVA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 783, DateTimeKind.Local).AddTicks(3559), "cce10c1b-5977-4667-98d1-96fc282753fe", "AQAAAAEAACcQAAAAEFhzFqmTYoeHxwzrBaBvQ9otMIvaa38PQZb8tdFpGSxqOfOglkcIJxMfZJWVnvhoBw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 794, DateTimeKind.Local).AddTicks(4399), "b9e1453d-11ed-441a-afe8-4f0237291e9a", "AQAAAAEAACcQAAAAEGZK+YzoL/jd8ve/HaZNWIWpOd538uwbbtJOkn6l7Xy1QbXHKndLEcIGG9JpmuChUA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 804, DateTimeKind.Local).AddTicks(9411), "692c76f3-f0c1-4507-8f1a-15842949d922", "AQAAAAEAACcQAAAAEPGMzTcyRNdY5zaMNM71POmphHw3GsFeJgbGX5ixZ/UY/JNocVgmUY6wDrd8ojKWMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 816, DateTimeKind.Local).AddTicks(5785), "f0042db0-7123-4573-bda5-f4b0729ef668", "AQAAAAEAACcQAAAAEPDKWkWbWDvDgTam1ApGdYt2C+BGV72TjJarWhmi5KVi2l+rq49VJkAgsvJF8O9qaw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 827, DateTimeKind.Local).AddTicks(5787), "dc8d17fa-97e2-47bc-ab64-72bd558c47f6", "AQAAAAEAACcQAAAAENcFXetd5muRSS4rrzD6NfY7hg5C5s6P8joX98ez3S9gozHkw36Oy8CWpJEr19ziXw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 837, DateTimeKind.Local).AddTicks(4035), "dad00c43-c1d5-4681-87ef-f67da71d81c8", "AQAAAAEAACcQAAAAENbIqTzaer7X83oQ/cfUP7u7G4biUYKhImkKwE9KJeEnvLith0ktA9Sr5cpIPvBPdw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 851, DateTimeKind.Local).AddTicks(8364), "2b86ab33-faf0-4b8c-9260-bd3c42131af7", "AQAAAAEAACcQAAAAEKoPFWx74f70QgLv9knLuGW4ciR6A+yJl+Y3lp334vAR3nDsbWYMLrVFutojGHZT7Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 864, DateTimeKind.Local).AddTicks(2696), "78b0d3a9-cfb1-45bb-b3bf-d7981014e2f4", "AQAAAAEAACcQAAAAEHFf35RKHuwVEHSiSyv2z/CGhRHqrM+z9mJRBmWkcfFYyfoF2uWb/bXmiW4rYFbscQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 874, DateTimeKind.Local).AddTicks(5857), "83244fde-b130-427a-891b-3990439f30fa", "AQAAAAEAACcQAAAAEBTg0QVPOB+X1qMiYOdnr+3TemLvEf4w3NYwUVIJY3VuNpLXGBy8C6kCaV6IqGkuxQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 884, DateTimeKind.Local).AddTicks(2538), "25d47f97-1012-4721-844a-7ab6d464ed70", "AQAAAAEAACcQAAAAENt8zRdWl/v/fcqE81MlBVG3K//Omv8h7MkIfQZXmSUjvKGlANMlnCYpz1N1MxySWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 895, DateTimeKind.Local).AddTicks(8917), "8abafaab-75d5-4602-91c5-8a7d3006f0d2", "AQAAAAEAACcQAAAAEF2y+0Ew766ZjQWuOU3EpzRy0vG81g2vHbb3tEGlyfm8N59Lyja0921ri86G/SGYmg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 908, DateTimeKind.Local).AddTicks(4210), "0e32ac29-ac05-46a5-beb7-d0eb732e7ad2", "AQAAAAEAACcQAAAAEHedOfpFKDrkEEHiQe7fU4t69M7BbtUSwLWkCM7+cJYDuPEmgfyVNIoHgMXxkb4ZWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 918, DateTimeKind.Local).AddTicks(184), "12f6ca48-f63e-42a1-8667-05ba80f7e842", "AQAAAAEAACcQAAAAEANlUTYwZnUZ9z4CdwhFoIprQcuNyP5j9wOMQEB+2UXxlBsT8JixhSqDXILt56a8eQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 929, DateTimeKind.Local).AddTicks(7695), "99774c53-7a02-4242-9110-d5714b609f85", "AQAAAAEAACcQAAAAEDfkqxntums2Xfh2Y5ZUGKVgv0S2JCYB4WKcvW19fBx1IJy6obxdZMGGTmANM/ZM9w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 941, DateTimeKind.Local).AddTicks(3957), "34dc1090-4393-4551-983a-6726ae35a0d2", "AQAAAAEAACcQAAAAECoovRyH7yIx8zaHw4v1PKoH7FW+N3lAYDCWI1GctyDCrdfF5KUOsfu9yBIUhObo/A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 999, DateTimeKind.Local).AddTicks(248), "6f2b66d2-33da-4cb2-8e64-3ed4265b900c", "AQAAAAEAACcQAAAAEKMn3+/zcf6ffmJxkt+8Kqa35biT6e6e92P0vSujPxRfd1UoL1Y7nKoQvy9BoH3b4A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 986, DateTimeKind.Local).AddTicks(7128), "da3e6f88-a47d-4282-b608-49358f5325c2", "AQAAAAEAACcQAAAAEK3xTH3Z3C3v7SGORv/T0VqhlLF81c5KNDa45fd1D4WhzxyX7ZyBFmB+jt3g0MTHTQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 21, 11, DateTimeKind.Local).AddTicks(2122), "79d27694-5238-435f-8f21-0f8a3d6938ea", "AQAAAAEAACcQAAAAEKmoeHSL8OrX9gA+fzw9cPmDVjDXuISyNDBvRzRKAHBIHnvQYFZtJfmhKm41uoOGvA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 21, 45, DateTimeKind.Local).AddTicks(3089), "4d6b0bc3-0e8b-4af2-85b4-26a067abfc28", "AQAAAAEAACcQAAAAEAfh62OPEBycLz7f6QjGhxXv5HZCI0klTgBVXomwFl49wMru6ZrSP1+qvlz4+ZBLtA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 964, DateTimeKind.Local).AddTicks(2149), "f626fc40-85d2-4ae8-95a5-fea631ac9a6b", "AQAAAAEAACcQAAAAEG/EqMsrL63dffAVsTyNbPmJ0w/ApsEDe9uAj3fou2T2+t4XlXAzk5F7OSom2asUeg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 976, DateTimeKind.Local).AddTicks(7335), "695721f5-4519-43f1-bc49-29946476eb78", "AQAAAAEAACcQAAAAEFoOtvVNKCIlJnqZxuhzxpZmC3M6c2QHVP3VnjmIW5o1e2qhz7LMS8ewqfgLzFOuHQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 21, 22, DateTimeKind.Local).AddTicks(7692), "8be67dfb-78b3-4aac-99b0-649ffdd7ada3", "AQAAAAEAACcQAAAAEB01twfKjslo0lZSUc7PoXzB15I6jUHD9HWkjpwE+bIwxhHrk1f8eh5i80W5EkmpKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 951, DateTimeKind.Local).AddTicks(2819), "7a962013-8d4d-49a3-97ca-39b230e76cf6", "AQAAAAEAACcQAAAAEGhJe23vlvYHOoR7fsm7jmgPMSnlcrW7UIH6ptiz1Gxee6BQf4wGh+09kAYjA0sP1A==" });
        }
    }
}
