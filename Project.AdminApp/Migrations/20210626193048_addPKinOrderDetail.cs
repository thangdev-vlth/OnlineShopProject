using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.AdminApp.Migrations
{
    public partial class addPKinOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 27, 2, 30, 40, 461, DateTimeKind.Local).AddTicks(4948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 21, 9, 39, 19, 155, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.AlterColumn<string>(
                name: "size",
                table: "OrderDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "size" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 922, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 922, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "date",
                value: new DateTime(2021, 6, 27, 2, 30, 41, 186, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2021, 6, 27, 2, 30, 41, 186, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 6, 27, 2, 30, 41, 185, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -76,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -75,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -74,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -73,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -72,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -71,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -70,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -69,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -68,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -67,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 545, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 27, 2, 30, 40, 544, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "FromDate",
                value: new DateTime(2021, 6, 27, 2, 30, 41, 187, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                column: "FromDate",
                value: new DateTime(2021, 6, 27, 2, 30, 41, 188, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                column: "FromDate",
                value: new DateTime(2021, 6, 27, 2, 30, 41, 188, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 4,
                column: "FromDate",
                value: new DateTime(2021, 6, 27, 2, 30, 41, 188, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 5,
                column: "FromDate",
                value: new DateTime(2021, 6, 27, 2, 30, 41, 188, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 6,
                column: "FromDate",
                value: new DateTime(2021, 6, 27, 2, 30, 41, 188, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 7,
                column: "FromDate",
                value: new DateTime(2021, 6, 27, 2, 30, 41, 189, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 8,
                column: "FromDate",
                value: new DateTime(2021, 6, 27, 2, 30, 41, 189, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "f1f0c0cc-8782-41f4-a456-7765d755caf7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "6cbd8b36-009a-4f9d-8087-84a416687451");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "b9732d40-8916-4752-b471-ea151e32685c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "b4bf91cf-e94e-4ad0-8a72-b22c6539e8d7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 907, DateTimeKind.Local).AddTicks(7069), "95f18246-5710-489f-967c-954527c594c3", "AQAAAAEAACcQAAAAEIe2EBsKP3F+63OZeeghkPIwcbmcGfRjBPp/fqFfmYdvJf1A22Wzk5y7LvierY/9jw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 563, DateTimeKind.Local).AddTicks(6817), "a038a6af-d479-40c4-8f6e-57f1cc7f84ec", "AQAAAAEAACcQAAAAEJtQ5jUKvv5Gx6END0NNh1/BHzis8kfZAfqbbNl8KcSvH0Z09rHuz+LOZGlcvH+Otg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 577, DateTimeKind.Local).AddTicks(2105), "e2b39435-1507-4cd7-b1f0-3994bfb4400f", "AQAAAAEAACcQAAAAEL40OBWZc/d+pl1XegjKBj+4jES7T+WZsNVaOmsWq4RrBsMQVxqqJrmvQdf3dvuUVg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 590, DateTimeKind.Local).AddTicks(1821), "3e6341db-1fd1-43d8-b186-253a05277523", "AQAAAAEAACcQAAAAEBPl/1Z0iI/PkWxwZlTy4IDM87pNcVOMKUiFn8ffCdMCgKlB6uUyw01CSFTkKLp9NA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 600, DateTimeKind.Local).AddTicks(4177), "2ecbe707-8de9-4194-b2fc-8d53d6e507f8", "AQAAAAEAACcQAAAAECa7UGllAuiCI3A5cC0T0Opy22DGJiZ/o4AxerNc227+i1aY80xDJvXhhEF03rYwzA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 613, DateTimeKind.Local).AddTicks(3305), "07b5c45d-9b33-47c5-9318-c123dd364f1f", "AQAAAAEAACcQAAAAECZ4eLgAz/dZivVKFdqE9dvFuYtf7zvDaVxeKmt5oz/WKDMHM9Hf17gAAjTDaU0ijg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 626, DateTimeKind.Local).AddTicks(1609), "d9b64f7c-2594-4339-bd5d-d7390818fa5a", "AQAAAAEAACcQAAAAEN5TWORvAKXOi20BMZe5gwnHkfWm7BuZa2x5OQCSTdlIGGwejW8lPymT9Ve+Pl6H+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 638, DateTimeKind.Local).AddTicks(6471), "92a3e56b-137a-4ca5-a6b0-7faacccef424", "AQAAAAEAACcQAAAAEF+ubU4Dv9HMf5otDO+jXYHfCz+akb3WKJUA+K2Aw1onVsAIImghJ+3gCNLCEX0dAw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 656, DateTimeKind.Local).AddTicks(8728), "e33b9db8-a08f-42e8-aeaa-8a736dcc8e68", "AQAAAAEAACcQAAAAEFMFWg0/eLf/QyT0chSgddm7+YNk625/4AVS6UUbev4AQQCl5fnSWNAKNn9iGIIF4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 670, DateTimeKind.Local).AddTicks(2520), "307d46e3-d9c5-40c2-b336-8b166c86c2fa", "AQAAAAEAACcQAAAAEOApxZAEt+ZeIbPvjbuIffzlFVNMfv04nbniwqdi2g1iC7IzrQ1JvES9ZorRupPy1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 683, DateTimeKind.Local).AddTicks(8519), "8119bb84-7bbf-4365-9ebe-408c0fce0ac5", "AQAAAAEAACcQAAAAEONXaGQUxMFqJdm7xmSue6vzm6gL+tIc1n0gd6cGNe9GvkhvWhEf7RQUpbIsKiSWeQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 694, DateTimeKind.Local).AddTicks(2137), "ba9cdb3b-ab8a-44bd-b387-f3e0bfa0760d", "AQAAAAEAACcQAAAAEMqIjIFAO9AyFy+9AWJXGtR+tcjCC9FW/XLVU+8DsdCbxvwv7eeXPJ1NaPRHDXTSQg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 706, DateTimeKind.Local).AddTicks(9610), "eb8cada0-5547-47bc-8cf0-f75bc2df812d", "AQAAAAEAACcQAAAAEI/4yYMq01PsxeS7BK34/wNiPwM6sR0pqDOLDNCMQHimKxYBg0t1vsQCyLP4JrIGQw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 718, DateTimeKind.Local).AddTicks(7909), "b6c69b0f-df9b-45c4-9a73-3bd541169c20", "AQAAAAEAACcQAAAAEAF+vMYm/imBqDOCCjBR13zswsiJPHFSH357bmGHDLvKyXcpoiPC4D+XACnGJG953Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 729, DateTimeKind.Local).AddTicks(3008), "30619b50-e457-40d6-a68e-36970daa5e06", "AQAAAAEAACcQAAAAEFpCHGPckr9tC/PdzuJ+JyaCyCYcI7cDTeja2hf+lPIt9+Te/Z8j47NoS/QKNpGs7w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 743, DateTimeKind.Local).AddTicks(2115), "be8899ae-37bc-4db1-b644-16efb50536fb", "AQAAAAEAACcQAAAAEEdGhRJcIcXYenPCKHiWJDwGsozTdbS6gXYVz+UcLNfk8IeH9sULHMAf2N55rTINdQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 753, DateTimeKind.Local).AddTicks(9868), "e6359500-f5db-4a66-9cbc-be938f31ddd2", "AQAAAAEAACcQAAAAECCQQuRXkMnSXVz4e2dpEc9aSS45ptrf7orycbrdDRZO7g0Rzugz17exP8ENaauGWQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 766, DateTimeKind.Local).AddTicks(6694), "5f8e912a-6caa-4013-8890-ba567c084085", "AQAAAAEAACcQAAAAEMztZcNXIDNnWu7NQvm6cgeSVqpgpvU37LWsb7UDEiX3QrewRCE6imj4cN5CWF8aeg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 775, DateTimeKind.Local).AddTicks(6372), "d7fc9b77-93c9-49a0-acdc-2e5aa3a7e210", "AQAAAAEAACcQAAAAEEZmn/OWGsuAixaYd1rS9Ym8gd0gcveGkUe/kDcFsougDK/dbP9rYJxLjhHEORtSgA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 788, DateTimeKind.Local).AddTicks(484), "7912e759-a498-4653-926f-3b80cd6756ac", "AQAAAAEAACcQAAAAEPoBF9I5Og/9uT/Wi0lmr0TfdPLO4jiCSgEaMBxhgDkToJw59PziWfCp24hl2tdpKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 798, DateTimeKind.Local).AddTicks(3516), "7d3273ee-ce03-4093-a79d-95cd472c42d8", "AQAAAAEAACcQAAAAEGsL4K8x0kTeosf+VqZW0767s0woNr2xjbH7wrZJmfD3nXtkXvYiCJXksYYOq5nTjg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 865, DateTimeKind.Local).AddTicks(5262), "17240a0f-85ed-49f9-962d-a9481247bf66", "AQAAAAEAACcQAAAAEP7bcrX1rcQbCbkJC+6Tvzd0vLh+4ctxjTJd6MDjs7qjIiCDb6qQjrFmbKJnTvSmpg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 851, DateTimeKind.Local).AddTicks(2633), "8cc78f4b-3112-42e5-9bc8-0b1a81f01f3b", "AQAAAAEAACcQAAAAEPB8qbolMbDuxmhdeJBeO5tjYJ6874fC84uh/PygCPj6aAfT+m+JNFcs3Ci7+F0zNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 878, DateTimeKind.Local).AddTicks(6035), "e9fa66b0-6a89-4693-af0d-d3659a945842", "AQAAAAEAACcQAAAAEIc1jXUq3r5Ogg8KVmn6Gc06YMKYTtEvPk3nojTI6Tu3i8I/RxoDISsLuGaTy+spEg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 921, DateTimeKind.Local).AddTicks(3547), "e6d8153d-4d65-4b1c-afc1-db09fabcc292", "AQAAAAEAACcQAAAAEEVFPq4rRr/+eFEXeKtjGKAryVosaLal53xHk2Qi4W4xzoIWjx0SryCyo+s+fKjyYw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 824, DateTimeKind.Local).AddTicks(8544), "02062cd2-2b8c-441f-a3dd-1f6caa24bd1f", "AQAAAAEAACcQAAAAEIUVEuFIXj+8GZbFfTYj2JgI0OickbDNebLKjSWP+66IB8ZAU2vec4Q6xiRZ0GK0Iw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 837, DateTimeKind.Local).AddTicks(9120), "57844ffb-9efa-481c-acc5-01757cf144ab", "AQAAAAEAACcQAAAAEKzOPyO0zYiSu2vh4OecTRHTPzkcK6CdWDeKP+KqFJSLokJay6f8oJm2p5FZ7sD8Tg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 894, DateTimeKind.Local).AddTicks(6817), "a654df20-565b-45cc-ba79-fdc0364d83fb", "AQAAAAEAACcQAAAAECwGAyHmE1i41+g6lktGzvooWOaGoFqHZfxGU+vkPM8DlreaslshY7qlWKvraQXvqQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 811, DateTimeKind.Local).AddTicks(2347), "6d6a0a23-e53d-4090-94cc-33adf236f419", "AQAAAAEAACcQAAAAEPPD3bLP77qZjtRvWAlPlJqDmhdUDi9FPHua99AlafEbWY1SGxiR4RQjhMVCxuwumw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 21, 9, 39, 19, 155, DateTimeKind.Local).AddTicks(1161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 27, 2, 30, 40, 461, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.AlterColumn<string>(
                name: "size",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 499, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 499, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "date",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 828, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 828, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 827, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -76,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -75,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -74,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -73,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -72,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -71,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -70,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -69,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -68,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -67,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 225, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 226, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 829, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 830, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 830, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 4,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 830, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 5,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 830, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 6,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 830, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 7,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 830, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 8,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 9, 39, 19, 830, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "4bf81def-0d6b-458c-8fba-41e326297e57");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "559d2e76-6fd2-4a46-ba95-3ffcf8936116");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "7a41199a-644c-4c6b-8a13-2a5cef24eb55");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "5b4de317-dbbb-42a1-84d2-6a3226d09cf4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 488, DateTimeKind.Local).AddTicks(211), "a2638228-65ab-4d92-93cc-dbca889bcfa4", "AQAAAAEAACcQAAAAEFD2z9qTxb5jRk0NxC2B2+b+u9jxyPCtNmPHz52QciXn13We9Tc92ciEC9ngCWpvQg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 240, DateTimeKind.Local).AddTicks(7932), "d8dcbdc5-c6d1-4376-a186-523862377c37", "AQAAAAEAACcQAAAAECnNALwUoQkhUd696r5CeNs5VvZCbE8htOxrXShvO5FdsYmD7iL0IKWNi1sPRhHo8A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 252, DateTimeKind.Local).AddTicks(6251), "a761e738-a5af-4d56-ba4b-dbc50fddf677", "AQAAAAEAACcQAAAAEBPXm/79//UOLCuxkPYJCkx1NQUBCpmuUiMM++duwgakRrl/CFaHhMGw1N4tQCIkPg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 262, DateTimeKind.Local).AddTicks(8023), "3de84b60-e0a0-4ccc-a3fe-c0bfdafd9bf6", "AQAAAAEAACcQAAAAEGzKPXVihKYIzW+PdIEWUCgndgugSkL5zNR2pJJWbcfgEz4P2byM3BC3vQtRI5Xdig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 271, DateTimeKind.Local).AddTicks(5642), "767d072e-6bf7-4c48-80c3-602709e506cf", "AQAAAAEAACcQAAAAELikNW9QqeyBT13EIlGTnpXNuuBuu+s/xXHz2n3Pt6XjT3S9mb6GmEK7Ik3dKQA4Dw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 279, DateTimeKind.Local).AddTicks(7357), "f31d057f-6ac5-4966-a6dc-210932e72218", "AQAAAAEAACcQAAAAEE1OZ9b9YNfShW/0JUxyIjf/425BVTM7tZinRljNBDdrPQ5PMJxGD0U141L/cRT6KA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 288, DateTimeKind.Local).AddTicks(5212), "d6000808-483f-4c93-9183-b7cb9b218e9c", "AQAAAAEAACcQAAAAEE4iNiEypIc2ee+bImH/j28g5HWxswyCxLnRQNf7H5PZ8Rk0n6BfVjI9lCatc/+Zyw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 296, DateTimeKind.Local).AddTicks(6625), "a0fcffba-c15d-41aa-8d9a-96790b6df292", "AQAAAAEAACcQAAAAEDWf/Wh7URMHI2zclIWNsAhHhTMIF5dyHXyOVjQzeN3iDSI4HxCH5Y7RpOdQebPtGA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 306, DateTimeKind.Local).AddTicks(878), "117d4647-e9ad-4b7e-8d34-f085de74ae27", "AQAAAAEAACcQAAAAEGzAYdqLHEbb0aZNiLjfqwcYUIlRfICNAI/yOadJxAJX7YfGsqGZU9NYIIEfY4Ffgw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 314, DateTimeKind.Local).AddTicks(2268), "f26e070a-82ce-4da7-a952-c5dcf5af2e4a", "AQAAAAEAACcQAAAAEKRGnqsgFVlfI8hbYacb0wrlCw3Cw6Lm8hsj0EbOzlcUIrH+gEl1xgwy9/zgXvV7DQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 323, DateTimeKind.Local).AddTicks(404), "e527035e-e659-4201-95f9-e3a66b1f36a7", "AQAAAAEAACcQAAAAEK5v/P4G8i23hkOH6374vKLAbP5o5ppTMiKRNK1XGli1u3JFgA34CccJvhFS1BcqcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 331, DateTimeKind.Local).AddTicks(1671), "787c5810-fac3-4dc9-9721-015c90bc6253", "AQAAAAEAACcQAAAAEIfIA/YeugLcYAH6upuSXQb7Kl9mICtcjUgbQi8ZK+Mgb5tExHz6VrsYaKoIpb9AqA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 340, DateTimeKind.Local).AddTicks(731), "2e7ee79d-5396-4760-8fa5-30c55c364ba0", "AQAAAAEAACcQAAAAELhG+8cuBZyhI36eoPbGvt1qfdCccd1MT3yNKPEvBMBZkZpTN6sDbU0IPswwsxBvTw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 348, DateTimeKind.Local).AddTicks(2611), "a1d97030-6fb3-4ba2-889f-b2d98cff1f68", "AQAAAAEAACcQAAAAEM8UdCPe3FtPwcXE+0Xp3qCvPJmN9B4L1lEFl+SkhchcLzzHWZ4VYnv2mLWXY3XAag==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 357, DateTimeKind.Local).AddTicks(5047), "e6865813-23d1-4d71-941c-bef19d40f70b", "AQAAAAEAACcQAAAAEMBuA8pSKOZrbjSYb/4fHAN6we3W0axojHP4RJrNtETEXVoJNwvNl3H2rrg8cq4F5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 365, DateTimeKind.Local).AddTicks(9729), "b0793231-a798-45c3-8c16-6e017a601079", "AQAAAAEAACcQAAAAEG+b+ezPb8M4mZoLD3Vnnkquar1GW8d+cUQIIniNz1npsiJi2nUqH+1BltCNx96JRg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 375, DateTimeKind.Local).AddTicks(1696), "b400c3db-4560-409e-add5-e26b3f20ba6b", "AQAAAAEAACcQAAAAEBmTWtuGEpYaYXjrYq47phKQWoql2IIlCOygKu9nK/V6MELydmJj1XU7yuc0NOr6XQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 382, DateTimeKind.Local).AddTicks(9463), "4cd934c5-e04c-4367-bb99-5ecb92f7c7fa", "AQAAAAEAACcQAAAAECBvwVKaMN1Gim3Z+WduPbuc8khNDSsiHJYepaoglmbtG8UZWZvVk/cOXUw9q15XiA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 393, DateTimeKind.Local).AddTicks(4374), "6433c07f-9e1f-4d7f-9d79-11aa647489a6", "AQAAAAEAACcQAAAAEF5f8nDXFEdhH0d43lCLYgJZkX1JM8sUNVmTpN2vhj3MlAmKitulSp0X0kSYc1bCMQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 402, DateTimeKind.Local).AddTicks(7332), "b0418fa3-339e-4748-b1d6-be765b3c0d93", "AQAAAAEAACcQAAAAEJPPBFj9hlLSNAtlhuj0EcpBezwHjpHpHjGT9CBAU9DyZd95YtqLWYLDBfALfpJtSg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 411, DateTimeKind.Local).AddTicks(3710), "0209f0a2-9de5-4bc5-8e69-01471e73f399", "AQAAAAEAACcQAAAAEC0hvSd9gYLHN6EboZ9npoRW2C1XhmygNdcrr/2q2F/pO5CqDwctZTY0m/g7IRFQgA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 459, DateTimeKind.Local).AddTicks(1570), "9a48e418-b6c6-4c7c-93f7-d29990a4dac4", "AQAAAAEAACcQAAAAEIfPKBYojZ7Wzloq0EDPI3qUeGkseLF8WYucSGNmGBO/RGvyDK/utO7oZoHfECX2KQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 448, DateTimeKind.Local).AddTicks(7046), "fab4bdfc-5bb9-4fa8-98f2-54c37c6a80d5", "AQAAAAEAACcQAAAAEGihTOF15Ub3TilDBYfLlKsJyiilPXXZFxjcqrEb6w4u+gHzya+pVkhnt1m058VK0w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 467, DateTimeKind.Local).AddTicks(7718), "07e1fed1-9065-47f4-ac6f-059ab16f474a", "AQAAAAEAACcQAAAAEKrgvBLE7FAKJl4GpNDQ+B+IrNvUUAyL9ABNs5xC6lmgc3cnnoFMs/WUCaire+2ctA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 498, DateTimeKind.Local).AddTicks(7294), "e965edb0-4569-4550-a25a-8440086a1345", "AQAAAAEAACcQAAAAELyq5mg5cTVCdzRZkf5mu++TO6ydBHwTggzBpUge0gKhLX3iQmpmtluVQ5hPGzsUsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 430, DateTimeKind.Local).AddTicks(7332), "f67fc434-493f-4a77-a143-8c03eb891fbf", "AQAAAAEAACcQAAAAEBaL7gmJzG6idhompqkguJGIX8ff+JgZlw89ymfc3tCkH3F/9FC30hfdd+zz75dKQA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 440, DateTimeKind.Local).AddTicks(3701), "2c87b28c-58af-4963-9db0-a2d44797c3d0", "AQAAAAEAACcQAAAAEDN14pu6IHgp/y4jl2kAENMNjH9bXU81fwryc5tHFWZJ931EffgJQHJ5EQqyPxU1Rg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 476, DateTimeKind.Local).AddTicks(6695), "2d2691a0-adad-4b0b-9366-a3921ffd1fc7", "AQAAAAEAACcQAAAAEPwpSEXeRjLFoiaUz4gP1jHfsKX3M8RIIM+bPXHH2XTcO5cHc/7GQsh6Um350QJ7uA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 9, 39, 19, 422, DateTimeKind.Local).AddTicks(6236), "0e5f3a82-8c0e-43d7-afc8-87e521029fee", "AQAAAAEAACcQAAAAEGG8nYpwcK1UQCTgExJt7xvKFJJl0cNJmewUVFyZHb2lQvtFidHsVGzc23GTu4+bxA==" });
        }
    }
}
