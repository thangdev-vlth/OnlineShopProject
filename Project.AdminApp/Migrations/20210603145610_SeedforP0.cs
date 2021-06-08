using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class SeedforP0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 3, 21, 55, 59, 619, DateTimeKind.Local).AddTicks(8635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 3, 21, 44, 48, 991, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 56, 0, 101, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 56, 0, 101, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 6, 3, 21, 56, 0, 468, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { -1, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(3044), 0L, "/user-content/jean/jean1.jpg", true, -1, 0 },
                    { -49, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6494), 0L, "/user-content/Tshirt/Tshirt13.png", true, -10, 0 },
                    { -48, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6491), 0L, "/user-content/Tshirt/Tshirt12.png", true, -10, 0 },
                    { -47, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6487), 0L, "/user-content/Tshirt/Tshirt11.png", true, -10, 0 },
                    { -46, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6483), 0L, "/user-content/Tshirt/Tshirt14.png", true, -9, 0 },
                    { -45, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6478), 0L, "/user-content/Tshirt/Tshirt15.png", true, -9, 0 },
                    { -44, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6474), 0L, "/user-content/Tshirt/Tshirt13.png", true, -9, 0 },
                    { -42, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6466), 0L, "/user-content/Tshirt/Tshirt11.png", true, -9, 0 },
                    { -50, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6499), 0L, "/user-content/Tshirt/Tshirt15.png", true, -10, 0 },
                    { -41, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6462), 0L, "/user-content/Tshirt/Tshirt14.png", true, -8, 0 },
                    { -40, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6458), 0L, "/user-content/Tshirt/Tshirt15.png", true, -8, 0 },
                    { -39, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6454), 0L, "/user-content/Tshirt/Tshirt13.png", true, -8, 0 },
                    { -38, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6450), 0L, "/user-content/Tshirt/Tshirt12.png", true, -8, 0 },
                    { -43, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6470), 0L, "/user-content/Tshirt/Tshirt12.png", true, -9, 0 },
                    { -51, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6504), 0L, "/user-content/Tshirt/Tshirt14.png", true, -10, 0 },
                    { -53, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6512), 0L, "/user-content/Tshirt/Tshirt12.png", true, -11, 0 },
                    { -37, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6445), 0L, "/user-content/Tshirt/Tshirt11.png", true, -8, 0 },
                    { -54, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6516), 0L, "/user-content/Tshirt/Tshirt13.png", true, -11, 0 },
                    { -55, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6522), 0L, "/user-content/Tshirt/Tshirt15.png", true, -11, 0 },
                    { -56, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6526), 0L, "/user-content/Tshirt/Tshirt14.png", true, -11, 0 },
                    { -57, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6529), 0L, "/user-content/Tshirt/Tshirt11.png", true, -12, 0 },
                    { -58, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6533), 0L, "/user-content/Tshirt/Tshirt12.png", true, -12, 0 },
                    { -60, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6543), 0L, "/user-content/Tshirt/Tshirt15.png", true, -12, 0 },
                    { -61, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6547), 0L, "/user-content/Tshirt/Tshirt14.png", true, -12, 0 },
                    { -62, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6552), 0L, "/user-content/Tshirt/Tshirt11.png", true, -13, 0 },
                    { -63, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6556), 0L, "/user-content/Tshirt/Tshirt12.png", true, -13, 0 },
                    { -64, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6560), 0L, "/user-content/Tshirt/Tshirt13.png", true, -13, 0 },
                    { -65, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6565), 0L, "/user-content/Tshirt/Tshirt15.png", true, -13, 0 },
                    { -66, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6570), 0L, "/user-content/Tshirt/Tshirt14.png", true, -13, 0 },
                    { -52, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6508), 0L, "/user-content/Tshirt/Tshirt11.png", true, -11, 0 },
                    { -36, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6441), 0L, "/user-content/Tshirt/Tshirt14.png", true, -7, 0 },
                    { -59, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6539), 0L, "/user-content/Tshirt/Tshirt13.png", true, -12, 0 },
                    { -34, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6433), 0L, "/user-content/Tshirt/Tshirt13.png", true, -7, 0 },
                    { -3, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6316), 0L, "/user-content/jean/jean3.jpg", true, -1, 0 },
                    { -5, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6321), 0L, "/user-content/jean/jean5.jpg", true, -1, 0 },
                    { -6, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6323), 0L, "/user-content/jean/jean6.jpg", true, -2, 0 },
                    { -7, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6328), 0L, "/user-content/jean/jean7.jpg", true, -2, 0 },
                    { -8, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6332), 0L, "/user-content/jean/jean8.jpg", true, -2, 0 },
                    { -9, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6336), 0L, "/user-content/jean/jean9.jpg", true, -2, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { -10, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6339), 0L, "/user-content/jean/jean10.jpg", true, -2, 0 },
                    { -11, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6345), 0L, "/user-content/Tshirt/Tshirt1.png", true, -3, 0 },
                    { -2, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6306), 0L, "/user-content/jean/jean2.jpg", true, -1, 0 },
                    { -12, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6349), 0L, "/user-content/Tshirt/Tshirt2.png", true, -3, 0 },
                    { -13, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6352), 0L, "/user-content/Tshirt/Tshirt3.png", true, -3, 0 },
                    { -14, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6356), 0L, "/user-content/Tshirt/Tshirt4.png", true, -3, 0 },
                    { -15, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6360), 0L, "/user-content/Tshirt/Tshirt5.png", true, -3, 0 },
                    { -16, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6363), 0L, "/user-content/Tshirt/Tshirt6.png", true, -4, 0 },
                    { -17, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6367), 0L, "/user-content/Tshirt/Tshirt7.png", true, -4, 0 },
                    { -18, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6371), 0L, "/user-content/Tshirt/Tshirt8.png", true, -4, 0 },
                    { -19, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6374), 0L, "/user-content/Tshirt/Tshirt8.png", true, -4, 0 },
                    { -33, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6429), 0L, "/user-content/Tshirt/Tshirt12.png", true, -7, 0 },
                    { -32, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6424), 0L, "/user-content/Tshirt/Tshirt11.png", true, -7, 0 },
                    { -31, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6420), 0L, "/user-content/Tshirt/Tshirt14.png", true, -6, 0 },
                    { -30, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6417), 0L, "/user-content/Tshirt/Tshirt15.png", true, -6, 0 },
                    { -29, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6413), 0L, "/user-content/Tshirt/Tshirt13.png", true, -6, 0 },
                    { -28, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6409), 0L, "/user-content/Tshirt/Tshirt12.png", true, -6, 0 },
                    { -4, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6319), 0L, "/user-content/jean/jean4.jpg", true, -1, 0 },
                    { -27, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6405), 0L, "/user-content/Tshirt/Tshirt11.png", true, -6, 0 },
                    { -25, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6397), 0L, "/user-content/Tshirt/Tshirt15.png", true, -5, 0 },
                    { -24, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6393), 0L, "/user-content/Tshirt/Tshirt13.png", true, -5, 0 },
                    { -23, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6389), 0L, "/user-content/Tshirt/Tshirt12.png", true, -5, 0 },
                    { -22, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6385), 0L, "/user-content/Tshirt/Tshirt11.png", true, -5, 0 },
                    { -21, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6382), 0L, "/user-content/Tshirt/Tshirt10.png", true, -4, 0 },
                    { -20, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6378), 0L, "/user-content/Tshirt/Tshirt9.png", true, -4, 0 },
                    { -26, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6401), 0L, "/user-content/Tshirt/Tshirt14.png", true, -5, 0 },
                    { -35, "Image", new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6437), 0L, "/user-content/Tshirt/Tshirt15.png", true, -7, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 692, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "248db28e-a987-4a30-9787-12e8b5c29c3c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "788f0191-0df7-45fc-a690-500a7215c53f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "93f5968c-376a-4a41-9060-cb83d2ed2bf6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "9a68c1ce-db2d-41cf-99b3-5dc5d32e3164");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 56, 0, 75, DateTimeKind.Local).AddTicks(9558), "280062b3-ba38-438a-af1e-d47743c2d7ee", "AQAAAAEAACcQAAAAEJmAeJAfI/HG4wln3+3DbcFj4ALuiM2PafpZN2NY8F08hj+7ExGH6oiT5mXyLaz6IA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 713, DateTimeKind.Local).AddTicks(7102), "a541e41d-e848-411d-ab9a-b34beeee967a", "AQAAAAEAACcQAAAAENmjWPt84Bt3BKECKu0V2WvdhHWr4e0f/TFR2on1Nur8QQEJUsXUPK48IhIoT/kqWQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 727, DateTimeKind.Local).AddTicks(5945), "16f7a1d4-3f95-4a90-a1e2-3de84df72cb8", "AQAAAAEAACcQAAAAEOl9EFxTt7wZXYDIMNPIz9w4G+vGjsUsunk0+UflGyblEe/w7pMSqXIUMaktPEZ01g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 741, DateTimeKind.Local).AddTicks(4927), "cb8d9e66-a511-4b89-ae4a-57c80ab7b215", "AQAAAAEAACcQAAAAECFlYZ8J9Jx1S14s+qSRhDVOFs1KfJtDgat9FCuyT8ijpnawQYh8mPxu9Vr3kU9MuA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 754, DateTimeKind.Local).AddTicks(1572), "a407a647-217c-47da-b3bb-bb8d35a61623", "AQAAAAEAACcQAAAAECu6WTfFYbvvbDvPv3ytPDits6wqN6ETSukXXQyE+k4GnASe9y6G/HzesLcBGfA4DQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 765, DateTimeKind.Local).AddTicks(6433), "efe0395e-2ba8-4016-a707-4bcc5dd6f897", "AQAAAAEAACcQAAAAEGadhZJ813nLFk1q+czi0tfTfQxZzmPQfIEc/JtKtWySUl4B5bdozAqi46BHyxoTuA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 779, DateTimeKind.Local).AddTicks(1402), "4ca97e2d-fc49-499c-a7d0-bebc210c0d43", "AQAAAAEAACcQAAAAEMwYeWJN/6S1RPdmujyZXclfk9lWge80GqqVnu1viMtcofSJrncA4fc5aHPZgI39Jg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 792, DateTimeKind.Local).AddTicks(1400), "ab7e67bd-a8c7-4255-9b8f-430206b216cc", "AQAAAAEAACcQAAAAEBCK/w5A8iBTKzgAu1PvyF+Duci2WNoL7refUK/f8WFyxgDOUU5vN8OHJEYFRTWQqA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 806, DateTimeKind.Local).AddTicks(7876), "a9506b71-5ef6-48a2-8fe4-06cf3588590c", "AQAAAAEAACcQAAAAEJ9DK+UGlfgWOXLMPkk4b885zRrnn/FZI/LaEkifF2FHe6+60QB3Jo1fy9xsu3ZrMw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 821, DateTimeKind.Local).AddTicks(777), "c474dc7f-d227-4adf-9496-a3b9c0333f3d", "AQAAAAEAACcQAAAAENjkoX2E8/FxKnd/6Tg+mSHBdvjCOhtdvJUDfHm+R64hMVdjj+7Euz9uwDbyjhOBuQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 834, DateTimeKind.Local).AddTicks(4993), "4a872f1c-d8e8-44df-9084-7b5f60460120", "AQAAAAEAACcQAAAAEK0dfTVcLheFg2XAs3lgZzEqkWC60kWPhcbStlGVy92OqlKvfOBv5EsYHtN7oNTOmQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 842, DateTimeKind.Local).AddTicks(6731), "2c76ca84-29d1-4f9b-b2db-264555fc8651", "AQAAAAEAACcQAAAAEOTxZLtGnsqEsYPKyNnEY5jn+6MyxoRO6H/jjrVHn7JOlze6j1fq+AwAGrHxLzwNhw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 855, DateTimeKind.Local).AddTicks(1210), "07b0d304-5eb5-4cb1-a7d8-5a07cc29c1bf", "AQAAAAEAACcQAAAAEJ1Jiv+lUe/coQPJRDi/kIe18P6+6y3ORXC0plRr2/HHdYer+ZoiGSq2M8MrozPgyA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 871, DateTimeKind.Local).AddTicks(4454), "9873be9c-5dbb-4607-bfe7-f4ecfeee0d09", "AQAAAAEAACcQAAAAEC3dnVUKOTTiNO5KpxfSdO4V/y7Lvr/StI0rMylT/BGY8mtr7L1jbUXfYVHw9pkbOw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 884, DateTimeKind.Local).AddTicks(5572), "f0989935-2dbd-496e-81d5-77d12e8dcc08", "AQAAAAEAACcQAAAAEDOe5yPAyEykz6WyFZP0kVoXoD0TTq0PnhukK/XcMMuoNzAQ/guxP1KjzwV6/QnI5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 898, DateTimeKind.Local).AddTicks(5329), "6a18e9de-d23b-4d0a-8ca4-50f225bd11eb", "AQAAAAEAACcQAAAAEHYOyKrGNFyToCxFpijvlQsfeimHLjRkEkEaaTAE8DHUwOZLRLv/mkWE/m2GGivxrw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 911, DateTimeKind.Local).AddTicks(6817), "ea55d636-3993-4db5-9918-8c1bd1d0eb2e", "AQAAAAEAACcQAAAAECFzIBw0VE+Fb2sujfxQ9VzVvyGz9KtaUnug/PTA8lIvMAoYUSC4zfzMOqKbUo0poQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 926, DateTimeKind.Local).AddTicks(4833), "e6928b93-d3db-43db-8a94-ab517672d5f0", "AQAAAAEAACcQAAAAEPxN7X4RNeUqBu7LuYzeyK8In4PXNpLo6HGgkMhzItHGmFAU+FLR5ijGb8hLUoatrA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 939, DateTimeKind.Local).AddTicks(9948), "a786e416-67d8-45fb-a0e1-b58ae0ce26a2", "AQAAAAEAACcQAAAAEGSm5d9Snl/8EEOtVWFD+o2F0ij1XO6BCCAOd2je/DS4sMW0DmOhf3ZsSE6QXGEPbQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 952, DateTimeKind.Local).AddTicks(4955), "b0c226ac-de22-43a8-ae12-61a03795b27b", "AQAAAAEAACcQAAAAEA2jSCwesI/SWWDsbjmEpP9un2bShK7GJTBsm9gAIWf2aUI/XNPnhL3PxxWUmha0Gg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 965, DateTimeKind.Local).AddTicks(1839), "6d11e92d-9dfa-464d-a7cb-c4520a48c73a", "AQAAAAEAACcQAAAAEDuqv2hUvFd+fnAkM3md4aCwBfLRmj+nJp27850hrkGIeqYgeae0VvYDCzeygRglww==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 56, 0, 32, DateTimeKind.Local).AddTicks(6524), "11aaf96f-f981-4be2-bada-d005eb3105b8", "AQAAAAEAACcQAAAAEBFgXmngv/LBfU05W+3Ls8680Nh770rxVHjP3pQ0jSdmBEfzA2Zi1Nb0unGi9ssTfw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 56, 0, 18, DateTimeKind.Local).AddTicks(4981), "25b2f252-d446-448c-9cd9-06a46e438007", "AQAAAAEAACcQAAAAEATq3I0/8siPawRJFtxfclTqzwuWh4H3E7j+TUoWmWj7L8+/qkJPf0ckTpd5d90NKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 56, 0, 45, DateTimeKind.Local).AddTicks(8698), "8fa2cb9d-4e2d-4ef2-b773-245c7ba9f125", "AQAAAAEAACcQAAAAEOhYggSUNDJrkf/tzIToRfAykgiTyNFcp4pSJPgKX/v+89djBDq8jZ5dDQeb23MWLw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 56, 0, 99, DateTimeKind.Local).AddTicks(1908), "ad15f964-50e0-4f60-9902-ce748b6f6e4c", "AQAAAAEAACcQAAAAEE6FDWiTufUdMeRLY3bTRPsa1D41HN7iX62qaIiZb2dEPciEOw/pidySTClqvfvoOg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 991, DateTimeKind.Local).AddTicks(232), "d50761ff-0bd7-449e-902f-3e3216cc08bc", "AQAAAAEAACcQAAAAEGeWUswV7sZfylKxhIJv0iPYhdYbKwAh+jUHgvGHsYtbuc+9Ke07oHfWTypQxjS7HA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 56, 0, 4, DateTimeKind.Local).AddTicks(5016), "9f836d4d-7312-4914-8496-b1ea2d053a89", "AQAAAAEAACcQAAAAEHsrShBEpMxIXzRORrLJbzjVB2eEmPSl2fJXsdmZ2aDIn1xnuzQqPyiFKb6Bvcr4oA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 56, 0, 60, DateTimeKind.Local).AddTicks(5390), "3e0a100b-f008-4d88-8f31-494898ae58d3", "AQAAAAEAACcQAAAAEENkLrOzxTnvohWP2CZwEhk4DU3GIzgJAvLMRrPYjnncSDdjMwjjRxN6bNr+zY4HWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 977, DateTimeKind.Local).AddTicks(8390), "b22bdd97-d9bb-4cb2-b93e-46b76826aa68", "AQAAAAEAACcQAAAAEL5ZbiK615+UntqBbakmDz/+yBjF5MrL/v94j9ml3tFtHapajt/hNKymQWy38FIolQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 3, 21, 44, 48, 991, DateTimeKind.Local).AddTicks(837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 3, 21, 55, 59, 619, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 416, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 416, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 776, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "5f95490d-1d93-4b86-a77c-0ade48e226ee");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "6e37a87e-8fb1-4081-9895-c39b37b76bc5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "c41f09dd-5380-41e6-8217-f98bdcaf295a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "25f4abbb-bb34-4447-8ad9-3e19a1792c88");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 401, DateTimeKind.Local).AddTicks(4375), "adda60ed-6ef8-4ebd-80c2-445234ada869", "AQAAAAEAACcQAAAAENAYPTnoHXaLzdZKaHhPZt4wgZTdY22NvbrhII0b9aemlbrioCuJNKYaAbUpV90/8g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 70, DateTimeKind.Local).AddTicks(3985), "81e78554-c6b9-416d-a7d5-2e14dd0dfe67", "AQAAAAEAACcQAAAAEPVLkqq4QobZ2mL1fFmLlYy84WIZK8EfCkoFDjso+btLoFg4z2ZfSxoL7VO/SBzpWg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 81, DateTimeKind.Local).AddTicks(5705), "a3af7b6a-f762-4779-84de-4360e844ac1e", "AQAAAAEAACcQAAAAEP6EcMnIWVQyy5OFfgE+8SiHTXZ+QpJSu3sn1RKu/oOinowZpUMMwV6mwfbmWJxTnw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 92, DateTimeKind.Local).AddTicks(1478), "c72d8ae3-e870-4801-a0b1-a616d8d63cdf", "AQAAAAEAACcQAAAAEByLLf1Epdd3GOJD+ANoFEbNExMjjVIruCpiwnj8ZeJD+WGjPB6QnQjBvXzl8QRluA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 102, DateTimeKind.Local).AddTicks(3247), "1b2e9bc7-2922-4632-8a3e-a4dbafbb170c", "AQAAAAEAACcQAAAAEDV1bLMct/Lmp5s8hu6B+lxfSm7DhJ32IMcNaV045RaQexE783CICbQ0f/YlEFrtcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 113, DateTimeKind.Local).AddTicks(2630), "6765724c-2d0e-414f-8a47-fd081ecd8e7b", "AQAAAAEAACcQAAAAEOpT2TzHm2qTsoflA7b+UmSGX9Oyol4RcR09bgbw9/Csqnm0rTjyxuGrUsu8vCgsDw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 123, DateTimeKind.Local).AddTicks(348), "3bab4c5a-f0e7-40e1-bea2-b31e53c1df2f", "AQAAAAEAACcQAAAAEHkiuoNzNlDPnJrcRXIAjrI0pxpaFQeHi7yoNLmrKbZFjyGdm2tWrjWR/mrfumBDhQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 133, DateTimeKind.Local).AddTicks(3044), "f602354f-73ea-4d6e-bbc1-9df3f12f2187", "AQAAAAEAACcQAAAAEHmtS0WGaqhtup010PNC6l5a5Q7NlccxNjK3N8cOTCcL+FEjglhIcLuFXTITWu0/aw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 144, DateTimeKind.Local).AddTicks(7886), "f139b5fd-f290-4c01-9644-b2ba1dcea97a", "AQAAAAEAACcQAAAAEECSBr+Y0AULmg7GKzdoU9gw5tyrJlOqjUAHzotV0iTbHwjXhoK0Jkv1Jnjq1U9Z/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 154, DateTimeKind.Local).AddTicks(7796), "818d629d-51c8-4cb9-8b72-17792f0503ea", "AQAAAAEAACcQAAAAEJRams/rrwhi84hl6orM+GLy1pQd6w0CYuc1uwB4p0PRs//Oj0nZXfccwBq6PMe/Uw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 165, DateTimeKind.Local).AddTicks(3038), "4ec99ce9-d82c-4c60-ba1e-544d2cc03d86", "AQAAAAEAACcQAAAAEPuIqJnsCJwfgbeCsjDNNq6Bev3erjYEZ5rA7PDva/hJWibjglaLeKjSlJZ3Ihcjsg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 175, DateTimeKind.Local).AddTicks(6731), "712d6620-d9ce-4d9f-ab6c-60f4eaef3718", "AQAAAAEAACcQAAAAEJzC/1lP2b0Fgtmj/GaJdw0oGYDv6N7ufT7QbU9QpqD+RFPG3BcxmPCykXvrw9uedQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 186, DateTimeKind.Local).AddTicks(5442), "ff70769b-a0d3-4c7a-904c-a5cb2c7bd86f", "AQAAAAEAACcQAAAAEBIUazaLMxG69FQyBc7vDLeumEwuugoj7XXTPWagdQkMth5A3542MitSl63vmAWhZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 197, DateTimeKind.Local).AddTicks(6756), "b7cfc246-c8cd-45fe-befd-b06c2847777b", "AQAAAAEAACcQAAAAENsL7Zs7f6diZdLAbclMECNqfBc6cZ10K52ch3XJClSiPtwEXVJtsHEWrFG0SUmXhA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 208, DateTimeKind.Local).AddTicks(5009), "a724ec1a-98c6-44c0-ac03-e3e7069cc49f", "AQAAAAEAACcQAAAAEHXXYLx+oNTa41LmUFqobo+mic8hy2vnQKRRSopWaj9zr/dpoYSqmOxNsPnkRzJurg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 219, DateTimeKind.Local).AddTicks(131), "3a4a94d0-61d5-4659-9b19-43085ceef95d", "AQAAAAEAACcQAAAAENtF+w15MDJoX2ioH2n6s3JhdyEWte293EJCsNbRm+x0PGacYmZaUw5OCRomvAcv4Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 230, DateTimeKind.Local).AddTicks(4912), "966510a2-89be-4dac-ae42-816a241004c3", "AQAAAAEAACcQAAAAECf3Bw20D1Y3qY5lsKyGjAfm3/MOmPX44E3OEO+pNlKRxwhEWE3twFhBdWA521cVug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 240, DateTimeKind.Local).AddTicks(5117), "b7b02dc5-b347-4bb9-b4a5-1e6b452c8125", "AQAAAAEAACcQAAAAEL87hWMkFOLYce+QnHgUHE2Y454KPkb6aS5Yd81Z6W2pbr93PUngePUMjzQBcjnYuQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 252, DateTimeKind.Local).AddTicks(1279), "ab3edca8-19fe-435a-bffd-ade45f258b06", "AQAAAAEAACcQAAAAEGPjph7U4+6HPLTadn1yYdQY+C2ogaW3WIEukp4ClM9VluHiL5z1cLQCBCeOlY/7OA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 264, DateTimeKind.Local).AddTicks(1833), "e0f3ff06-5ca3-441b-8f19-78d474bea06b", "AQAAAAEAACcQAAAAEGVNDY3lzSMGxxxptfNYPYBmQ7lgYDmptob6X/tP0GWGSvOv609+qUGfLV/MhFcBfQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 278, DateTimeKind.Local).AddTicks(7796), "7649708e-d3de-451a-95b3-4e94d7444899", "AQAAAAEAACcQAAAAEBEmXZ0tYyAV75vWysVYL0gsshWxWXeG2BZdEqjn755DelaMr2wQasZPbcbXySrbUg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 354, DateTimeKind.Local).AddTicks(7607), "a80fe575-d2bc-448b-820c-92b56ced282a", "AQAAAAEAACcQAAAAEDPx0lmTCZjP4Bgrjpv2j/mHQFBXxxu095bcL4qiSZ9N3F74RN+UFpSKKbbezSd+JQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 340, DateTimeKind.Local).AddTicks(5311), "9b7b3cd5-f7d3-48ff-a6ba-f1ff7dbe8522", "AQAAAAEAACcQAAAAENhbhYs5vDaq7PPzd31Wd9vDQrlo7eMSfrdVt2vuwEURZ0VZoQd6lRk+Q6l5Av1KGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 369, DateTimeKind.Local).AddTicks(1796), "94cb4ed4-59b9-4bc1-99c3-7e2882678123", "AQAAAAEAACcQAAAAEHjw1wtWW3SxYo4ei4JPdELW9I8yEI8I/iyh3YlfMcZrXS+uv1Kivu2ygeFA3EBC2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 415, DateTimeKind.Local).AddTicks(4668), "89528925-291e-4662-a266-35d4c56398e7", "AQAAAAEAACcQAAAAEJT+srjXf5pEKxs3NoDfTs20vI7CdV428fHOy3lnaPrr4TL9GlwRuFVEsJvM5/qT3A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 311, DateTimeKind.Local).AddTicks(5762), "aab139d3-75c9-4cdc-9e66-704e859b414a", "AQAAAAEAACcQAAAAEEgVYYKkPbx2xqzlmVhajkfzh0JslLn/w+jcZLOq4J4R1Exl7WGiyffCAx2qTu8XZQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 325, DateTimeKind.Local).AddTicks(5710), "542cfb3b-92bc-4bee-aad3-b5d5efd13ded", "AQAAAAEAACcQAAAAEA4oXMvvLbs2YecWXa0PwIZoY6jcBl3omCUyT47DpX0lUqdWtXPGa0dXax1fqZLFVA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 385, DateTimeKind.Local).AddTicks(1225), "a273b6c8-3edf-4076-b989-38037ae104ae", "AQAAAAEAACcQAAAAENM93c36ja+fIX+iqB2asgtfszxBrDosOW2x/DCRHiKeYynm7NW8fj++A3e535AJCw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 44, 49, 295, DateTimeKind.Local).AddTicks(7788), "783a8541-6df7-4643-9ef6-00c3936541de", "AQAAAAEAACcQAAAAEPBM8qbOcLEkaJkIVd0Lao2fijF6lXhQDz4/WvikIsII+2nvTxBhqC14xN7g3SQWsA==" });
        }
    }
}
