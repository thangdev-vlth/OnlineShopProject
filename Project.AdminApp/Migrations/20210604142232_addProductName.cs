using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class addProductName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 4, 21, 22, 20, 447, DateTimeKind.Local).AddTicks(1487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 3, 21, 55, 59, 619, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.AddColumn<string>(
                name: "productName",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                columns: new[] { "DateCreated", "size" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 21, 46, DateTimeKind.Local).AddTicks(2191), "M" });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                columns: new[] { "DateCreated", "size" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 21, 46, DateTimeKind.Local).AddTicks(3179), "M" });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, -2 },
                column: "productName",
                value: "BOYFRIENDs");

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, -1 },
                column: "productName",
                value: "TOPS");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 6, 4, 21, 22, 21, 349, DateTimeKind.Local).AddTicks(3485));

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
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9591), "/user-content/jean/jean10.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9589), "/user-content/jean/jean9.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9587), "/user-content/jean/jean8.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9585), "/user-content/jean/jean7.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9584), "/user-content/jean/jean6.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9581), "/user-content/jean/jean5.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9579), "/user-content/jean/jean4.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9576), "/user-content/jean/jean3.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(9569), "/user-content/jean/jean2.png" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 4, 21, 22, 20, 714, DateTimeKind.Local).AddTicks(6536), "/user-content/jean/jean1.png" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productName",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 3, 21, 55, 59, 619, DateTimeKind.Local).AddTicks(8635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 4, 21, 22, 20, 447, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                columns: new[] { "DateCreated", "size" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 56, 0, 101, DateTimeKind.Local).AddTicks(7652), null });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                columns: new[] { "DateCreated", "size" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 56, 0, 101, DateTimeKind.Local).AddTicks(9011), null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 6, 3, 21, 56, 0, 468, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6339), "/user-content/jean/jean10.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6336), "/user-content/jean/jean9.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6332), "/user-content/jean/jean8.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6328), "/user-content/jean/jean7.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6323), "/user-content/jean/jean6.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6321), "/user-content/jean/jean5.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6319), "/user-content/jean/jean4.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6316), "/user-content/jean/jean3.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(6306), "/user-content/jean/jean2.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "DateCreated", "ImagePath" },
                values: new object[] { new DateTime(2021, 6, 3, 21, 55, 59, 693, DateTimeKind.Local).AddTicks(3044), "/user-content/jean/jean1.jpg" });

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
    }
}
