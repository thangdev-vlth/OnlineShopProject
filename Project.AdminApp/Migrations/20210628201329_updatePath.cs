using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.AdminApp.Migrations
{
    public partial class updatePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 29, 3, 13, 21, 890, DateTimeKind.Local).AddTicks(2332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 27, 2, 30, 40, 461, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 206, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 206, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "date",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 502, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 502, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 501, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -76,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -75,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -74,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -73,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -72,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -71,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -70,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -69,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -68,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -67,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9446), "/user-content/tshirt/tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9444), "/user-content/tshirt/tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9443), "/user-content/tshirt/tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9441), "/user-content/tshirt/tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9439), "/user-content/tshirt/tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9437), "/user-content/tshirt/tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9435), "/user-content/tshirt/tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9434), "/user-content/tshirt/tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9432), "/user-content/tshirt/tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9430), "/user-content/tshirt/tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9429), "/user-content/tshirt/tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9427), "/user-content/tshirt/tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9425), "/user-content/tshirt/tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9424), "/user-content/tshirt/tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9420), "/user-content/tshirt/tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9418), "/user-content/tshirt/tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9416), "/user-content/tshirt/tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9414), "/user-content/tshirt/tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9413), "/user-content/tshirt/tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9411), "/user-content/tshirt/tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9410), "/user-content/tshirt/tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9407), "/user-content/tshirt/tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9405), "/user-content/tshirt/tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9404), "/user-content/tshirt/tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9402), "/user-content/tshirt/tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9400), "/user-content/tshirt/tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9399), "/user-content/tshirt/tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9397), "/user-content/tshirt/tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9395), "/user-content/tshirt/tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9394), "/user-content/tshirt/tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9392), "/user-content/tshirt/tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9390), "/user-content/tshirt/tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9389), "/user-content/tshirt/tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9387), "/user-content/tshirt/tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9385), "/user-content/tshirt/tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9384), "/user-content/tshirt/tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9382), "/user-content/tshirt/tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9380), "/user-content/tshirt/tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9378), "/user-content/tshirt/tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9376), "/user-content/tshirt/tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9375), "/user-content/tshirt/tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9373), "/user-content/tshirt/tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9371), "/user-content/tshirt/tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9370), "/user-content/tshirt/tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9368), "/user-content/tshirt/tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9366), "/user-content/tshirt/tshirt10.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9364), "/user-content/tshirt/tshirt9.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9363), "/user-content/tshirt/tshirt8.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9361), "/user-content/tshirt/tshirt8.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9359), "/user-content/tshirt/tshirt7.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9358), "/user-content/tshirt/tshirt6.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9356), "/user-content/tshirt/tshirt5.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9354), "/user-content/tshirt/tshirt4.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9351), "/user-content/tshirt/tshirt3.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9350), "/user-content/tshirt/tshirt2.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9348), "/user-content/tshirt/tshirt1.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 947, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 29, 3, 13, 21, 948, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "FromDate",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 502, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                column: "FromDate",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 503, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                column: "FromDate",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 503, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 4,
                column: "FromDate",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 503, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 5,
                column: "FromDate",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 503, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 6,
                column: "FromDate",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 503, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 7,
                column: "FromDate",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 503, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 8,
                column: "FromDate",
                value: new DateTime(2021, 6, 29, 3, 13, 22, 503, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "e4cdf489-c49f-4d4d-a4f3-0aa1698915c6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "62053fbb-f058-421b-b9ae-d21163717cad");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "ffeb84b1-3b24-49f5-8481-6a673da1ba8a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "2a2bd857-2cfa-4122-98da-8cd9a796317c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 197, DateTimeKind.Local).AddTicks(6585), "15d2989e-8538-4fc3-a961-2fe0ac0985b7", "AQAAAAEAACcQAAAAEBPHOHnyRCu9gJ9lEpFGVB7egyxZNK19Ffz4YX8mWaT6P8Y1c35GqLKyH8+FC6GJsA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 960, DateTimeKind.Local).AddTicks(5264), "3fa4a681-afac-47e6-b9ed-39edec51d7c0", "AQAAAAEAACcQAAAAEMsONGZNBJNQXH86715nsxi5aY5mV/PvOtc+d0NLl35MV3KwtoAnuFpC5iIYpposhQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 969, DateTimeKind.Local).AddTicks(1242), "d68c28bd-9391-4a5b-8427-a38435ae4a75", "AQAAAAEAACcQAAAAEBwxUMwXHWKhdgv8BI2OhTAzsPsQdOPg3Qr9CH7c6+NqFvgoMjcLlxIO2JTFulwJ4w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 977, DateTimeKind.Local).AddTicks(3034), "ebd3433e-cc76-4f77-88b0-e227423bbde1", "AQAAAAEAACcQAAAAEKf5aH5k2Rj+eDps1KTAZ0XivxfSTsvMRyZXPtqlZFobNPhF6UTtgsQGT9CUj+YHJQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 985, DateTimeKind.Local).AddTicks(8810), "8e3b9024-7bf0-4936-8851-e3d1dcb19072", "AQAAAAEAACcQAAAAEJDA8/j2ThkZfmbfnZGVRD7PRiux6q98ulWMnUHdKLwjAMA9knS6P5yLV8Hiwa9dgA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 21, 995, DateTimeKind.Local).AddTicks(7444), "6df20fbb-d56c-446e-854f-bc3850c280f3", "AQAAAAEAACcQAAAAEE+C8qhzyEz+Zk8GWeG7sjdJnUhKCFjuQ803cBxLBwG/+W7t+FS5vSENjdAYi3Y7zw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 4, DateTimeKind.Local).AddTicks(2337), "6b305287-78c7-49de-ba1a-8c9eebcfcdcb", "AQAAAAEAACcQAAAAEPHPJdVnFCQ5mego4gU0lRTUMlGAKeC6Qw6QmBg6+5ArS0GWbYOernmll1TAxgxbkA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 13, DateTimeKind.Local).AddTicks(8792), "dfd5f391-856d-4d87-9293-d3a8f15b1de6", "AQAAAAEAACcQAAAAEKH5MvysKYRVXW//7h7sXlvRb+uykHs1RM+LiubgzQhjvQ54/jXOBgIu99n3Qpmx6A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 22, DateTimeKind.Local).AddTicks(1806), "f58834ee-0caf-47f1-a4ac-2c80b11c678b", "AQAAAAEAACcQAAAAEEaM8eLU1d/TpcFgUMlkAdEb4BPrPTGAqWUPRu1DJ3s08AdDxDX0rK1uoOnuPmqVrw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 32, DateTimeKind.Local).AddTicks(7754), "abcff046-5d98-4feb-8844-e7f910d97c8c", "AQAAAAEAACcQAAAAEDTcRko09lBkobznDz+khWtgySOGe8/f084Y1OdFSjy+mW9CeZP0XS8fk0xpD7gpLg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 41, DateTimeKind.Local).AddTicks(2122), "61f4ff17-5d12-461d-848f-91956aa4fb40", "AQAAAAEAACcQAAAAELpYVl3cFbUaYoy+rjjYrDp2PIgAlszqBy6TnoURLcFeLswURnBBpuLCIqzsaSq48Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 49, DateTimeKind.Local).AddTicks(9589), "b5960586-7c4f-46ff-a32d-44f6159f888a", "AQAAAAEAACcQAAAAENjb0tkTKO73OG9EDnyWbAxjh/V+9c4KMWiq56fJCrPh6D5Gbnce+IPOezXMhGVgew==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 58, DateTimeKind.Local).AddTicks(618), "f1f2903b-cbf4-4903-8d01-23774a8cc9f0", "AQAAAAEAACcQAAAAEM/8nQTyyluI8cN758iPo87zrswXfnteD53i3XVZkHAtETy71PEgyvGpdaLoNiSjcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 67, DateTimeKind.Local).AddTicks(9313), "ec5c21aa-3d3f-4183-b570-46952721a344", "AQAAAAEAACcQAAAAEBUvLRWl3tltMz1SiMduoXAEhmFYdi0SqeTdyNjuJrDPDAft0NhkgRAwHwbIUzP7Ow==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 75, DateTimeKind.Local).AddTicks(9092), "f07ac5bf-d54b-4c18-b7a1-8a1120c60f46", "AQAAAAEAACcQAAAAEM6d+OPApduPHtoKHvqyE32awuybVor8t+/LahmBopsFgpq4G6xUiDrif16c1HRNrg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 85, DateTimeKind.Local).AddTicks(1439), "3c1c2800-139e-4118-93f5-df55db3aec4c", "AQAAAAEAACcQAAAAEKqKmYkRuXyXqxwnegzNoIW8Sz1dSMKyzjjzHNWSYkqPujcZ4Zf4vloZj2QQNBeMQw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 93, DateTimeKind.Local).AddTicks(6714), "4aaf75a6-a617-4c97-a612-9fbe961a0461", "AQAAAAEAACcQAAAAEOhwdWRedqX13q032bOYOE5Yo92x2FQFZttnqetTNKn8eeRvEpRLjXyrFgtSmMhWoQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 102, DateTimeKind.Local).AddTicks(5062), "ad6d2dca-798a-43da-8919-b090f98ba2d2", "AQAAAAEAACcQAAAAEACkVqoRLzTIcm4Gr/bzrAgcdnZSWwH8z6woZncZ0aY06lv45R3IFWnEHhaOE3B1Yw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 110, DateTimeKind.Local).AddTicks(9556), "ab047422-774a-43a1-bbee-cfa6fbc39751", "AQAAAAEAACcQAAAAEMHNrKqCLLIxC10piW1vKdU8mC0sbR07SXkEEWt35wfAsyqNM6ufrFb5le+QgDfC6w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 119, DateTimeKind.Local).AddTicks(5870), "65574a28-4dc5-4021-86d5-ee62af758869", "AQAAAAEAACcQAAAAEIoE3QPkUc+AHihcJeFnGmbp9hHe8P2lwQhMIY0VqR7xj4AQ/NDhP1yymSvY9fb1Kw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 127, DateTimeKind.Local).AddTicks(6979), "ad13fa16-c2a8-4a7c-8e35-2d681d1d905e", "AQAAAAEAACcQAAAAEI/R0PXPTZ2nlqpDW7gdAjAFbTfKc446OjS5fH2fLZatM1eKdkSIMymCZDu1SA9cEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 171, DateTimeKind.Local).AddTicks(2148), "ddf4af36-6bfa-4187-a855-6d88e7bf63e1", "AQAAAAEAACcQAAAAEGMWOtfRp7kAO3xPqv5TwxhAFaq5tlOqoYNdW0R8KXwJYxdSZ8zunRImNiN0UWcZkA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 162, DateTimeKind.Local).AddTicks(4324), "aa14ee7a-b1b2-4e93-8db9-c0795efc8cd1", "AQAAAAEAACcQAAAAEBMANE/PZP8aekHOR9a/b2abbbLmtJWnlHyYUQS/GiguQmXVxICyKl1IUcm9jJstdA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 179, DateTimeKind.Local).AddTicks(6761), "b42125d9-f8c2-442a-895a-1930250d85b2", "AQAAAAEAACcQAAAAEDcZ5HWgTOclm8Ql0kAtUCQZkz86ox6fKjGZahy4P2cAToagcjCUD2SG+1vVY7DQbg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 205, DateTimeKind.Local).AddTicks(8006), "e56096b2-f819-42ca-a23f-1d451bac98e5", "AQAAAAEAACcQAAAAEEaH1Jh0RdOELxn3D9RNtn1eTBcAWnpF5XdnorG4K5CZBdwQRAV46SoJHDn4eHpIDA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 145, DateTimeKind.Local).AddTicks(9898), "a1c47e34-04a1-463f-8792-c9da97b5baa7", "AQAAAAEAACcQAAAAEPtx0K4ePjWw/srOTRIKeNAAyNZsFZ/Sp4t8oSzMIntG8cHJR+7T/Xsq2MVRjteuUg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 154, DateTimeKind.Local).AddTicks(2208), "d518a457-2e7e-4600-839a-ea0217a98a99", "AQAAAAEAACcQAAAAECovCHLyDtnVFdhI7RgiuaYnsbfLJxMBA/WYntL5yA22igCKVZ2iwjIfX4/8K9j3BA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 188, DateTimeKind.Local).AddTicks(333), "1a77f3bb-eff6-42d6-adec-2b49008fc5f8", "AQAAAAEAACcQAAAAEKe+6wr/VFwpBAoWVjXC2jn1QqTazcm0ZBLemsichcmAMEsOh7NhTf0UlSkyO14DUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 29, 3, 13, 22, 136, DateTimeKind.Local).AddTicks(8830), "a6dd2b01-7c88-4541-97ec-db9ccf297abf", "AQAAAAEAACcQAAAAELmrybuIZwO0G+t++iHlwGC50v167r6nyuJxTQb+9TM0YKBS4/TQobKGmP5Yo+55WQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 27, 2, 30, 40, 461, DateTimeKind.Local).AddTicks(4948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 29, 3, 13, 21, 890, DateTimeKind.Local).AddTicks(2332));

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
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1078), "/user-content/Tshirt/Tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1075), "/user-content/Tshirt/Tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1072), "/user-content/Tshirt/Tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1070), "/user-content/Tshirt/Tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1068), "/user-content/Tshirt/Tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1066), "/user-content/Tshirt/Tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1064), "/user-content/Tshirt/Tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1061), "/user-content/Tshirt/Tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1059), "/user-content/Tshirt/Tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1057), "/user-content/Tshirt/Tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1055), "/user-content/Tshirt/Tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1053), "/user-content/Tshirt/Tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1050), "/user-content/Tshirt/Tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1048), "/user-content/Tshirt/Tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1046), "/user-content/Tshirt/Tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1042), "/user-content/Tshirt/Tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1040), "/user-content/Tshirt/Tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1037), "/user-content/Tshirt/Tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1035), "/user-content/Tshirt/Tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1033), "/user-content/Tshirt/Tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1031), "/user-content/Tshirt/Tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1029), "/user-content/Tshirt/Tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1027), "/user-content/Tshirt/Tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1025), "/user-content/Tshirt/Tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(1019), "/user-content/Tshirt/Tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(997), "/user-content/Tshirt/Tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(995), "/user-content/Tshirt/Tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(992), "/user-content/Tshirt/Tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(990), "/user-content/Tshirt/Tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(988), "/user-content/Tshirt/Tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(986), "/user-content/Tshirt/Tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(984), "/user-content/Tshirt/Tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(981), "/user-content/Tshirt/Tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(958), "/user-content/Tshirt/Tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(956), "/user-content/Tshirt/Tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(953), "/user-content/Tshirt/Tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(951), "/user-content/Tshirt/Tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(949), "/user-content/Tshirt/Tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(947), "/user-content/Tshirt/Tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(945), "/user-content/Tshirt/Tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(942), "/user-content/Tshirt/Tshirt14.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(940), "/user-content/Tshirt/Tshirt15.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(938), "/user-content/Tshirt/Tshirt13.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(935), "/user-content/Tshirt/Tshirt12.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(933), "/user-content/Tshirt/Tshirt11.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(931), "/user-content/Tshirt/Tshirt10.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(929), "/user-content/Tshirt/Tshirt9.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(925), "/user-content/Tshirt/Tshirt8.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(923), "/user-content/Tshirt/Tshirt8.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(920), "/user-content/Tshirt/Tshirt7.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(917), "/user-content/Tshirt/Tshirt6.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(914), "/user-content/Tshirt/Tshirt5.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(892), "/user-content/Tshirt/Tshirt4.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(888), "/user-content/Tshirt/Tshirt3.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(884), "/user-content/Tshirt/Tshirt2.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 27, 2, 30, 40, 546, DateTimeKind.Local).AddTicks(880), "/user-content/Tshirt/Tshirt1.png" });

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
    }
}
