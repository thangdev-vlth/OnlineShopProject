using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class addNofifiandPromotionRule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 7, 9, 1, 13, 986, DateTimeKind.Local).AddTicks(3843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 4, 22, 21, 0, 119, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Targetstr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Targetint = table.Column<int>(type: "int", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplyForAll = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ApplyForProductIds = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ApplyForCategoryIds = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ApplyForOrderTotal = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DiscountPercent = table.Column<int>(type: "int", nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductsPromotionId = table.Column<int>(type: "int", nullable: true),
                    CategoriesPromotionId = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumDiscountAmountForPecentCoupon = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaximumDiscountPercentForAmountCoupon = table.Column<int>(type: "int", nullable: true),
                    MinimumTotalOrder = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPromotion",
                columns: table => new
                {
                    PromotionId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPromotion", x => new { x.PromotionId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CategoryPromotion_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPromotion_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPromotion",
                columns: table => new
                {
                    PromotionId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPromotion", x => new { x.PromotionId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductPromotion_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductPromotion_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 370, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 370, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Status", "Targetint", "Targetstr", "Type", "UserId", "content", "date" },
                values: new object[,]
                {
                    { 1, 0, 1, null, 1, "11BD711F-9506-45BA-B5B7-F00649BE00DE", "Đơn hàng #1 đã sẵn sàng để giao đến quý khách. Chúng tôi vừa bàn giao đơn hàng của quý khách đến đối tác vận chuyển eShops Team. Đơn hàng sẽ được giao trước 23:59 ngày 18/12/2020", new DateTime(2021, 6, 7, 9, 1, 14, 647, DateTimeKind.Local).AddTicks(6857) },
                    { 2, 0, 1, null, 0, "11BD711F-9506-45BA-B5B7-F00649BE00DE", "Bạn có một mã giảm giá chưa sử dụng", new DateTime(2021, 6, 7, 9, 1, 14, 647, DateTimeKind.Local).AddTicks(9064) }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 646, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 69, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -10,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -9,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 67, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 7, 9, 1, 14, 68, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "ApplyCode", "ApplyForCategoryIds", "CategoriesPromotionId", "Description", "DiscountAmount", "DiscountPercent", "FromDate", "MaximumDiscountAmountForPecentCoupon", "MaximumDiscountPercentForAmountCoupon", "MinimumTotalOrder", "Name", "ProductsPromotionId", "Status", "ToDate", "quantity" },
                values: new object[] { 6, "11BD711F-9506-45BA-B5B7-F00649BE06DE", true, null, "Giảm giá 50% trên giá trị của  sản phẩm thuộc danh mục xxx không quá  10000 trên giá trị sản phẩm", null, 50, new DateTime(2021, 6, 7, 9, 1, 14, 648, DateTimeKind.Local).AddTicks(9908), 10000m, null, null, "Mã giảm giá 50% cho  các sản phẩm thuộc danh mục xxx trong cửa hàng", null, 0, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "ApplyCode", "ApplyForOrderTotal", "CategoriesPromotionId", "Description", "DiscountAmount", "DiscountPercent", "FromDate", "MaximumDiscountAmountForPecentCoupon", "MaximumDiscountPercentForAmountCoupon", "MinimumTotalOrder", "Name", "ProductsPromotionId", "Status", "ToDate", "quantity" },
                values: new object[,]
                {
                    { 7, "11BD711F-9506-45BA-B5B7-F00649BE07DE", true, null, "Giảm giá 50% trên giá trị của  đơn hàng từ 10.000 không quá 10.000", null, 50, new DateTime(2021, 6, 7, 9, 1, 14, 649, DateTimeKind.Local).AddTicks(525), 10000m, null, 10000m, "Mã giảm giá 50% cho  đơn hàng từ 10.000", null, 0, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "11BD711F-9506-45BA-B5B7-F00649BE08DE", true, null, "Giảm giá 10.000vđ trên giá trị của  đơn hàng từ 10.000vnđ ", 10000m, null, new DateTime(2021, 6, 7, 9, 1, 14, 649, DateTimeKind.Local).AddTicks(534), null, 100, 10000m, "Mã giảm giá 10.000vnđ cho  đơn hàng từ 10.000vnđ", null, 0, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "ApplyCode", "ApplyForProductIds", "CategoriesPromotionId", "Description", "DiscountAmount", "DiscountPercent", "FromDate", "MaximumDiscountAmountForPecentCoupon", "MaximumDiscountPercentForAmountCoupon", "MinimumTotalOrder", "Name", "ProductsPromotionId", "Status", "ToDate", "quantity" },
                values: new object[] { 4, "11BD711F-9506-45BA-B5B7-F00649BE03DE", true, null, "Giảm giá 50000 trên giá trị của  sản phẩm có mã hợp lệ không quá  25% trên giá trị sản phẩm", 50000m, null, new DateTime(2021, 6, 7, 9, 1, 14, 648, DateTimeKind.Local).AddTicks(9896), null, 25, null, "Mã giảm giá 50000 cho  các sản phẩm có mã hợp lệ trong cửa hàng", null, 0, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "ApplyCode", "ApplyForCategoryIds", "CategoriesPromotionId", "Description", "DiscountAmount", "DiscountPercent", "FromDate", "MaximumDiscountAmountForPecentCoupon", "MaximumDiscountPercentForAmountCoupon", "MinimumTotalOrder", "Name", "ProductsPromotionId", "Status", "ToDate", "quantity" },
                values: new object[] { 5, "11BD711F-9506-45BA-B5B7-F00649BE04DE", true, null, "Giảm giá 50000 trên giá trị của  sản phẩm thuộc danh mục xxx không quá  10% trên giá trị sản phẩm", 50000m, null, new DateTime(2021, 6, 7, 9, 1, 14, 648, DateTimeKind.Local).AddTicks(9905), null, 10, null, "Mã giảm giá 50000 cho  các sản phẩm thuộc danh mục xxx trong cửa hàng", null, 0, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "ApplyCode", "ApplyForAll", "CategoriesPromotionId", "Description", "DiscountAmount", "DiscountPercent", "FromDate", "MaximumDiscountAmountForPecentCoupon", "MaximumDiscountPercentForAmountCoupon", "MinimumTotalOrder", "Name", "ProductsPromotionId", "Status", "ToDate", "quantity" },
                values: new object[,]
                {
                    { 1, "11BD711F-9506-45BA-B5B7-F00649BE00DE", true, null, "Giảm giá 50% giá trị sản phẩm không quá 50.000 vnđ", null, 50, new DateTime(2021, 6, 7, 9, 1, 14, 648, DateTimeKind.Local).AddTicks(4486), 50000m, null, null, "Mã giảm giá 50% cho tất cả các sản phẩm trong cửa hàng", null, 0, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "11BD711F-9506-45BA-B5B7-F00649BE01DE", true, null, "Giảm giá 50.000vnđ trên giá trị sản phẩm không quá  25% giá trị sản phẩm", null, null, new DateTime(2021, 6, 7, 9, 1, 14, 648, DateTimeKind.Local).AddTicks(9323), null, 25, null, "Mã giảm giá 50.000 cho tất cả các sản phẩm trong cửa hàng", null, 0, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "ApplyCode", "ApplyForProductIds", "CategoriesPromotionId", "Description", "DiscountAmount", "DiscountPercent", "FromDate", "MaximumDiscountAmountForPecentCoupon", "MaximumDiscountPercentForAmountCoupon", "MinimumTotalOrder", "Name", "ProductsPromotionId", "Status", "ToDate", "quantity" },
                values: new object[] { 3, "11BD711F-9506-45BA-B5B7-F00649BE02DE", true, null, "Giảm giá 50% trên giá trị của  sản phẩm có mã hợp lệ không quá  25.000vnđ trên giá trị sản phẩm", null, 50, new DateTime(2021, 6, 7, 9, 1, 14, 648, DateTimeKind.Local).AddTicks(9337), 25000m, null, null, "Mã giảm giá 50% cho  các sản phẩm có mã hợp lệ trong cửa hàng", null, 0, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "85def7e1-8750-49a0-85bd-80669b484dc8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "c8568acb-b4bc-4426-87e4-8c9b35f713d7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "ccbb0573-8cdf-4d2d-b67e-4f7ad97cc7c5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "afa743c5-d3b5-4216-a789-da588ab490cb");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 358, DateTimeKind.Local).AddTicks(9838), "2f356f76-f15d-4bb2-b106-8151424b51c0", "AQAAAAEAACcQAAAAEN2ToF26NZ38A0yCmOCBtQ+nGrnkGD/lAEqSXz3vwC42fVXV9i9GO9OhIi62iZPP1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 85, DateTimeKind.Local).AddTicks(6656), "44bf9270-bf4a-4ca2-811f-2e186c799066", "AQAAAAEAACcQAAAAEEuNn7djtkcPeWZ6Kly2Y+2rM+gp/7EnEfl4aJsg7Yj9VsKjn4bWqc5KHobjv8hDug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 99, DateTimeKind.Local).AddTicks(4158), "d5bd2f7e-caf4-4880-80f2-6a47bc1ad010", "AQAAAAEAACcQAAAAEDigORK+gsyICjPeSq3k15SQJkFAUoRks4Hhcl0qtCn3OEUiHGMNGrErUvgXtxG28g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 107, DateTimeKind.Local).AddTicks(4624), "a9ae9e2f-bfeb-47f7-acb9-7569f1debe93", "AQAAAAEAACcQAAAAEKp8T/UY5h5FPrAaI84FldveqJ5gX3URgiKa39XzG8VNEWSZsUOZQgkxcgZBI4v/8Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 119, DateTimeKind.Local).AddTicks(281), "ad75df85-c145-4a3b-a5bc-0876228ebae5", "AQAAAAEAACcQAAAAEF7tlmNPvZmmP4TlzLkjQtZ0jX80xvhDQNc1SLDovvqHrV0w5W6OsZH9bxyJSOHQ1A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 132, DateTimeKind.Local).AddTicks(2738), "933e7cd7-fc37-4abd-a06e-9f82d692e0a7", "AQAAAAEAACcQAAAAEDNgtWuAw6W40l+dkZcSbH6Qn8mmS9jprTwcp5JVMHkTCdJTqBLOHN5GEFMODcmRrQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 140, DateTimeKind.Local).AddTicks(2318), "ba977578-e406-4aee-bf3c-cea9eb7b98eb", "AQAAAAEAACcQAAAAEP//RNOsNz+FZWug18Y7t5aKJU9Frups4kMR8hU8yv4bAOOT4jqiOL5/K8Vn1DlmlA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 152, DateTimeKind.Local).AddTicks(6112), "3c25706c-e3c6-4635-8fda-dace21dc65c5", "AQAAAAEAACcQAAAAELls2bKXRTWrx/60R8Rir/eg+pYbB7tW9dt7NEaEiYxtLu6p905kf5sim0yTjMoo6w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 164, DateTimeKind.Local).AddTicks(4090), "da6221f4-8bd1-4f17-b062-9d4d0ae64fb6", "AQAAAAEAACcQAAAAEGvYUaMT3tSXU7/QHcnWfPJ1Stx5BwtZTzuiLII7ZKfLMwS1LmulmysOuCyjf+053Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 172, DateTimeKind.Local).AddTicks(3439), "cbcb4018-4d92-4e38-87b4-9b04d9877f88", "AQAAAAEAACcQAAAAEMvE70JA2br+pJNhIkk36KYNjljHC+SieUGn9ZQ5KZTp1bjpOFd+jf2UyaL+s7kfuw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 181, DateTimeKind.Local).AddTicks(8524), "10ed5cfb-42dc-4956-80ee-e39e1091c58f", "AQAAAAEAACcQAAAAEO9QqYk/a3jJ17pT56VcsHewuoIfJcgmzspgxYKsL+eFTNKT6uhuin7q30SpV9U0JQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 190, DateTimeKind.Local).AddTicks(7782), "75dbfd11-98e3-44a6-bbe7-1847f8b578bd", "AQAAAAEAACcQAAAAEKqyBaUxrpH81LkPUqZT9LVOqneNPad6YHD3BpPOMyVVsgN5tPhHZm5P19KuSICD6Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 199, DateTimeKind.Local).AddTicks(3847), "b6c8159d-4206-43d2-8cef-4d2c5b618210", "AQAAAAEAACcQAAAAEAkXWM6XQKq7k8QVSh+zCL8fjIUGzaJgX3x/NNcKzS5VTh2eJhe/GaHz1GtzXUyLiw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 208, DateTimeKind.Local).AddTicks(861), "50b4ea84-0c98-4731-b292-ff17dc893590", "AQAAAAEAACcQAAAAEOglLgDc/gUhTjFlmb367ldVtfHpLPuTPacEwhEnOlZq6AmiTjfStxoIFGprNyYJdQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 218, DateTimeKind.Local).AddTicks(934), "38dd9a5b-d1f4-4d59-8e71-e0f8fb4c3047", "AQAAAAEAACcQAAAAEHxCTr4d6h+3m4qRSa3wldaxm3oFbQaA1NAITPJgSiJ4WRomQq78E7lat4K83vNZOw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 228, DateTimeKind.Local).AddTicks(3046), "51da7ca8-cc58-4535-ad4d-c41739d824c2", "AQAAAAEAACcQAAAAELlnAomSfrKrfyR4zcWHnwNqJLetipnTR+mdBgJEytOuBnbO75lpENC9DG0/TUYcOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 236, DateTimeKind.Local).AddTicks(6608), "43546275-29ef-44ba-9385-b7b3928c3a36", "AQAAAAEAACcQAAAAELNu5lBXrcrfXRz7EwaogTMZ5rIWr8wfd9XzID3gTbfegHJfbUSRiG7eurQzzrAJ7w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 247, DateTimeKind.Local).AddTicks(5567), "74032084-a118-4a00-95f9-075261b09038", "AQAAAAEAACcQAAAAEL7hxmCJPbrrT/X79+q0Oi/W7UTVlH7qUneHF3IN1iQBE+Mq4RQDFceUea/5uFeOiA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 258, DateTimeKind.Local).AddTicks(6386), "75574c2c-2712-483d-9338-dfd16a595a48", "AQAAAAEAACcQAAAAEN3FFWM+XrzGTafsa77z/Q464N2L2GIFh7X+m72XyoT5URYtrn2EoOAGpS/2w+641w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 268, DateTimeKind.Local).AddTicks(277), "eac0f2b9-1572-405d-a2fa-e174ef042e07", "AQAAAAEAACcQAAAAENmFxxZW6WV7HHqYV9tokngqBmgOlz1XHAO5/EgLSfqwFpLjFgjS8qvCpIKJbxTGfA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 276, DateTimeKind.Local).AddTicks(9443), "8bf01472-3db9-4359-870e-5004b2553e9d", "AQAAAAEAACcQAAAAEIuDXcrGcgPoD8JRNuBxd2O1il9aBidpOcO2XlmpkQa+rSRo7D+HoFBqyUI5aBk09w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 330, DateTimeKind.Local).AddTicks(1632), "35d78ef4-4698-46a3-82f4-fbe78da5555f", "AQAAAAEAACcQAAAAECcHcIO099HbCwP0UomdhUt+FXt5tzAuQcTwhC14A4ScAWiTUJYI4vkQ7qMha5RGxA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 321, DateTimeKind.Local).AddTicks(4645), "5dcba648-b0ab-471d-a67f-ec1ebb6cf021", "AQAAAAEAACcQAAAAEAqgrbKwqdzkoheIDT8EskGE/ZXTCDfJV0QMvkBtjtHzUCp52z8okX34q4zQiBgnqg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 338, DateTimeKind.Local).AddTicks(6383), "300264d2-cdbd-4bad-911a-f726dd30b006", "AQAAAAEAACcQAAAAEIa5hMBqxsLQvfRFzgYeVQdoXZNzzrz3L9ix4/uZHcmMrUFOwtjMGpsSNtpm9M0Uaw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 369, DateTimeKind.Local).AddTicks(1466), "803f0b99-4554-43b0-b0f2-9622db25134a", "AQAAAAEAACcQAAAAEBt8xh0rG/tF7eelWvo1zCCKb/hc7KkDH1J8uCjXFuxXkEqBRhLGEsgXiAnkLXhwSw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 301, DateTimeKind.Local).AddTicks(8237), "daf1b2da-50b9-4472-8367-1f67409a16a7", "AQAAAAEAACcQAAAAEEH9jNsbEn99dtpE6F/4G8RY91l2mnjhluEsRwKERpbFpBNrubaeZFwPpM0NEazi6g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 311, DateTimeKind.Local).AddTicks(2560), "86c9fa3f-6f98-4488-9319-d1774d4dcd9b", "AQAAAAEAACcQAAAAEAeWJxi0G+DdPnxxxpzNN8zPLLGsQKBJZSntsEo1siiK9O+cpABygpmN3UBprr3KoA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 347, DateTimeKind.Local).AddTicks(2165), "e2e2d288-8fde-42f1-8df1-eef5a21c60ba", "AQAAAAEAACcQAAAAEJB25BWg6x416LapNKzmxW6U43RC6MJLjBZ5Gl342eg47QFyBM6hDzDKLNgRVK8WWQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 6, 7, 9, 1, 14, 289, DateTimeKind.Local).AddTicks(8612), "b0690638-3489-4f5a-b497-0a0425388813", "AQAAAAEAACcQAAAAELN3T64Z3znTMd0Q4D+7H6M9a2QLvo7hSpNvKzL12Gafi2mMkm53fWGL+7zqq3c/ug==" });

            migrationBuilder.InsertData(
                table: "CategoryPromotion",
                columns: new[] { "CategoryId", "PromotionId" },
                values: new object[,]
                {
                    { -1, 5 },
                    { -4, 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductPromotion",
                columns: new[] { "ProductId", "PromotionId" },
                values: new object[,]
                {
                    { -1, 3 },
                    { -2, 3 },
                    { -3, 4 },
                    { -4, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPromotion_CategoryId",
                table: "CategoryPromotion",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPromotion_ProductId",
                table: "ProductPromotion",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryPromotion");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "ProductPromotion");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 4, 22, 21, 0, 119, DateTimeKind.Local).AddTicks(4951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 7, 9, 1, 13, 986, DateTimeKind.Local).AddTicks(3843));

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
                column: "OrderDate",
                value: new DateTime(2021, 6, 4, 22, 21, 0, 947, DateTimeKind.Local).AddTicks(1662));

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
    }
}
