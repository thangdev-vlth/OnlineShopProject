using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.AdminApp.Migrations
{
    public partial class fixImgerror : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 21, 9, 39, 19, 155, DateTimeKind.Local).AddTicks(1161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 21, 2, 41, 15, 634, DateTimeKind.Local).AddTicks(9952));

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

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { -67, "Image", new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7588), 0L, "/user-content/default/product-1.jpg", true, 1, 0 },
                    { -75, "Image", new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7602), 0L, "/user-content/default/product-9.jpg", true, 2, 0 },
                    { -73, "Image", new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7598), 0L, "/user-content/default/product-7.jpg", true, 2, 0 },
                    { -72, "Image", new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7597), 0L, "/user-content/default/product-6.jpg", true, 2, 0 },
                    { -71, "Image", new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7595), 0L, "/user-content/default/product-5.jpg", true, 1, 0 },
                    { -70, "Image", new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7593), 0L, "/user-content/default/product-4.jpg", true, 1, 0 },
                    { -69, "Image", new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7591), 0L, "/user-content/default/product-3.jpg", true, 1, 0 },
                    { -68, "Image", new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7590), 0L, "/user-content/default/product-2.jpg", true, 1, 0 },
                    { -76, "Image", new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7604), 0L, "/user-content/default/product-10.jpg", true, 2, 0 },
                    { -74, "Image", new DateTime(2021, 6, 21, 9, 39, 19, 227, DateTimeKind.Local).AddTicks(7600), 0L, "/user-content/default/product-8.jpg", true, 2, 0 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 21, 2, 41, 15, 634, DateTimeKind.Local).AddTicks(9952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 21, 9, 39, 19, 155, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 997, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 997, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "date",
                value: new DateTime(2021, 6, 21, 2, 41, 16, 289, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2021, 6, 21, 2, 41, 16, 289, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 6, 21, 2, 41, 16, 288, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 697, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 21, 2, 41, 15, 696, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 2, 41, 16, 290, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 2, 41, 16, 291, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 3,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 2, 41, 16, 291, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 4,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 2, 41, 16, 291, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 5,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 2, 41, 16, 291, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 6,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 2, 41, 16, 291, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 7,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 2, 41, 16, 291, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 8,
                column: "FromDate",
                value: new DateTime(2021, 6, 21, 2, 41, 16, 291, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "6578db15-87b9-4756-b961-f6093e4ed030");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "8827ddba-cf58-410c-9c14-967218c9ad8f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "12375434-ad70-482e-8924-7191477c9e51");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "b6c6d301-fd34-4426-af29-6c6323fd3770");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 987, DateTimeKind.Local).AddTicks(6168), "404ed6cb-bf24-4e34-8f46-c2a15208e84f", "AQAAAAEAACcQAAAAEKpXydfWdnnWy1FeEeuxjYR58MDSWCs4MXkSgwsjGFHR/ZNznYxetsr7xgUveUATHw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 710, DateTimeKind.Local).AddTicks(6500), "4282f94e-f1b0-4032-9151-a16bbcdb70e8", "AQAAAAEAACcQAAAAEN0iegmBpxySXlB9fMZ/Pkwv7VrHtF0hVnzZjUtPQAG9dka2Hs7T6dx3nAdrmH7M5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 722, DateTimeKind.Local).AddTicks(314), "98a4cb9e-322e-40be-a76e-421535237758", "AQAAAAEAACcQAAAAEDtxxa2+eJEEFwAa2b3MWR+DCn+xZUCthDfVDe2R5AKJEyok1yG+iWOwDsOOaUh6JQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 730, DateTimeKind.Local).AddTicks(9397), "ae986a93-c32f-48fe-81dc-67d4cc46955b", "AQAAAAEAACcQAAAAEEJjhThBmKR64rYj2vjGJrgP78+EEE97Ii0DJ/hfiI/Mqq+I7Vi5NF7MDhrVqrAMaw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 741, DateTimeKind.Local).AddTicks(6542), "5d056bf7-63a2-47be-9231-444994c4fad2", "AQAAAAEAACcQAAAAECUjp+UguHpvS1li8PCNGaEhZRmpV8VS+zRaNPtCXzF/Y9sZ+MQ2rg7uLWag655rNg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 751, DateTimeKind.Local).AddTicks(8580), "3e22f575-7d69-43db-90a3-68c676cc266e", "AQAAAAEAACcQAAAAENaus2ypU5SDFCRlrRKoCtzDE49qAHWxg9WMa4W4E924ROpNkQuOoOUVoa8SskJz3Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 763, DateTimeKind.Local).AddTicks(1215), "bcaabbe9-093b-4d3a-bee0-0ec03a61d855", "AQAAAAEAACcQAAAAEOrbSrXgULrO0mzYp65F7iWbhPtO1nnefikX0jxQeaoa6B/JfyqDW2YD8JOd2rZ9tg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 776, DateTimeKind.Local).AddTicks(761), "6aa537ad-f92e-4224-b42e-c4f57fe679a2", "AQAAAAEAACcQAAAAEE8QEQ8O3ik+PJMHzQsmEhhYX0ewJIsT37EXnT9jBRWZ/FSTBZwRpy8TQlFuZ6aeHg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 786, DateTimeKind.Local).AddTicks(4399), "4088cc42-f6ed-4940-bbb8-3859a97b9205", "AQAAAAEAACcQAAAAEF6hIbBgeZiRRW9kTUBi/FY2tOhjNKoVSuqc9/e48TdAKpzqw8zKiBPqlPtNItLugQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 795, DateTimeKind.Local).AddTicks(5133), "63956bad-2ee4-4661-a201-2d9bc0a690d0", "AQAAAAEAACcQAAAAEKX39DbpCSVdir+ROcTXlz3qgge+8vxxnn+bYevV1SmDEukVBcIz5En3KATxzleo9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 806, DateTimeKind.Local).AddTicks(5293), "ad277ead-3097-481e-902b-c15ffd01430d", "AQAAAAEAACcQAAAAEH9j0NH+lNdRbjydAM1O5bBtsfNTnigCaFxN5tv9d1nztLBDKGrWCDzArK6WAbc51w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 816, DateTimeKind.Local).AddTicks(5258), "4c0ec074-afbb-43a7-8c39-23c9bdc1d52b", "AQAAAAEAACcQAAAAEPp7QRgomBmVO7xqCjiS0xEf1OeTPWnuXWYR6fB51yxjRUTUF5VJJapDV69wc2fhjQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 826, DateTimeKind.Local).AddTicks(7523), "0d9f03db-de83-4a33-ba48-b51a2ba5f5b5", "AQAAAAEAACcQAAAAEHCSnAyG+0zC90VrzMHUliwDRbBtai7aLtkfi1ELYMIquLTg/LeK0prFjzAAFKI7tw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 836, DateTimeKind.Local).AddTicks(865), "a9caa91b-1b1d-4523-bae9-7c7c555d3960", "AQAAAAEAACcQAAAAEPLQPmb+vuEQzjw0ighoQg7c50AuMIllBq6C5pakERTYJd8EfRfQl4C0s9JSFxOE/A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 845, DateTimeKind.Local).AddTicks(1226), "cc78db6e-068c-46d2-b517-764f6d8caa11", "AQAAAAEAACcQAAAAECN2wGZlr3w0n4rYEhhdVkCQbhZFDEXAkRPkun5WUp59z1oqa27yaw09jhkxYbpZcg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 855, DateTimeKind.Local).AddTicks(6395), "c8aa490c-6ee4-4995-a052-db3fa5f7450e", "AQAAAAEAACcQAAAAEPUYOIVoN90+Gisj6ZDWh/jPieuuAnKAgbfkOMhIt9HgZ+V1PZhGzb1BXlscQrJ7qw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 865, DateTimeKind.Local).AddTicks(1751), "c392571c-2a35-4903-983b-b2975130cc2a", "AQAAAAEAACcQAAAAEID1o4Y97/1Yr8B3+L3oXIxLGVqjDabB8fNjHJAjvmKPWVjpj0Pf8pAtresijnvoPA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 875, DateTimeKind.Local).AddTicks(7897), "d750fb1a-f00c-4ef6-89bc-8d390f43ccc4", "AQAAAAEAACcQAAAAELtWXPT0l/ARU875xXEcwHbgL9QPZpOXN7CF4HdiIkruzjFHDmEDn1Oka+NRJhh7Mg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 886, DateTimeKind.Local).AddTicks(1818), "a6f6fdcd-ea4a-49e5-b7d8-ced21c3bc0e6", "AQAAAAEAACcQAAAAEO9DcjUsd89k84EbDISOhHlauf06YNDm7gdr+Na4kiMi4GFuynGM7pMDrPqkB+bg/w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 897, DateTimeKind.Local).AddTicks(9199), "bec7c878-bb6e-4e9f-b9cb-058b75250332", "AQAAAAEAACcQAAAAEL18U6qhLFByuaTgr/N6M5enPyjCrXeVpXXPeSUQo8aa2wIvEXaBHK7VdASevSWidg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 908, DateTimeKind.Local).AddTicks(5117), "460835bd-7745-41ba-a6c2-d50a2b1cf73e", "AQAAAAEAACcQAAAAEO/Ilmb/t6ID2plkuiH6rEhX9kjMXLVDFtE4Q4vsSBSI0OFUzR2N+S/owQpzGA1Uag==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 958, DateTimeKind.Local).AddTicks(4698), "fa47f815-6eb0-4706-9bd7-9f6ced71ec6a", "AQAAAAEAACcQAAAAEHMC152mczLp7ICQE2Oa5VPIzLdWTLmPZMmRfzuutKnnIeoZGEZHr9ESiYV9Cm1J7Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 946, DateTimeKind.Local).AddTicks(4084), "c9911ee5-da80-4f4b-a447-7ccb215ee7da", "AQAAAAEAACcQAAAAEFAyVMrUncnxzk9JJxhLyAOq2QRDOseEJLd1XvUb0/NZ0Px3qx2y8mrjqoPuDKrGYQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 967, DateTimeKind.Local).AddTicks(1270), "9c4b2b30-edfc-4729-858d-9a1436de0d97", "AQAAAAEAACcQAAAAEAucn41oHsZui83lbsCPUpiHYhzmXgpb/2tq6I62KPXnVZEeUCnRssimtIpHbfop5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 996, DateTimeKind.Local).AddTicks(7123), "8b07c908-561b-4ab5-bda4-c8c3d22746c3", "AQAAAAEAACcQAAAAEA5ZI/pS5qyyYVzRSirsW7lgYmbt/N5CYDZKsRg7tJOh2nX6ggg7sJ0SqzhVd2Pzsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 925, DateTimeKind.Local).AddTicks(8404), "096ce2ea-fb7a-4d08-bc59-aa4ca0f36b0c", "AQAAAAEAACcQAAAAEPxUL5rl4+XjY4f4YAyKUBUEmC4+zCvGGG2w4jDmb6jhcTEeIQedt8piLa+RZtJKKw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 936, DateTimeKind.Local).AddTicks(4743), "87fb3744-2e28-4b93-b72a-1cec15ad1d94", "AQAAAAEAACcQAAAAEFU73ThhYmb9OM37p2MTSrYjHhhaujKKOH+ocCaFpXFTRzvk/frdAon6u0KCbhcLAg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 976, DateTimeKind.Local).AddTicks(5239), "de53b77b-9b6f-43a2-9a5f-a449ccc7927c", "AQAAAAEAACcQAAAAEH78Vvrqxzv/OzlW8Gt6W/o4R8afgYjz2B6dJtq2wc7lVbkfamIguI0tDha2JdkLyQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 21, 2, 41, 15, 916, DateTimeKind.Local).AddTicks(8116), "1a221c53-5418-48db-95f6-161e411505dc", "AQAAAAEAACcQAAAAED6cJJvSiCPrO71cNluv+3+NxbASlCYnSm3/GgyM+jHX1iDMjjyz5l6brmdF9SCTQg==" });
        }
    }
}
