using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class SeedforP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, -2 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, -1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, -1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 3, 21, 44, 48, 991, DateTimeKind.Local).AddTicks(837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 30, 17, 48, 54, 942, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingFee",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "cancleReason",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "total",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Addresses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IsShowOnHome", "Name", "ParentId", "SortOrder", "Status" },
                values: new object[,]
                {
                    { -1, "Jean", true, "Jean", null, 1, 1 },
                    { -2, "Váy", true, "Váy", null, 2, 1 },
                    { -3, "StreetStyle", false, "StreetStyle", null, 3, 1 },
                    { -4, "Áo Phông", false, "TShirt", null, 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 6, 3, 21, 44, 49, 776, DateTimeKind.Local).AddTicks(8898));

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "Description", "Details", "IsFeatured", "Name", "Price", "sold" },
                values: new object[,]
                {
                    { -3, new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5848), "Chủ nhật là Sunday \n Thứ hai là Monday \n Ngày nào cũng xinh đẹp là Emday", null, true, "EmDay", 200000m, 0 },
                    { -5, new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5853), "Emwear là thương hiệu quần jean và thời trang Nữ hằng ngày đa dụng . Sử dụng chính chất liệu co dãn cao cấp, thiết kế quyến rũ, sang trọng.", null, true, "EmWear", 200000m, 0 },
                    { -6, new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5855), "Cá tính là yếu tố tạo nên sự cuốn hút của Marid \n Marid sẽ mang lại cho người mặc một cảm giác trẻ trung, tươi mát, năng động", null, true, "Marid", 200000m, 0 },
                    { -4, new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5850), "Một thoáng hương tình dịu ngọt \n Một chút nhẹ nhàng bay bổng và hết sức yêu kiều \n Một item thật sự gây lưu luyến đó các tình iuuu", null, true, "Flash", 200000m, 0 },
                    { -7, new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5857), "Vẫn là một sản phẩm của bộ sưu tập jean tháng 7, BELLE sẽ ôm sát và tôn lên những đường cong quyến rũ của bạn. Bằng chất liệu co dãn ,BELLE sẽ không làm bạn bị khó chịu mất tự tin", null, true, "BELLE", 200000m, 0 },
                    { -13, new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5871), "Mượn mà , mang lại cảm giác tươi mát, sản phẩm là lựa chọn hàng đâu cho mùa hè này ", null, true, "Smooth", 200000m, 0 },
                    { -12, new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5869), "Là Một sản phẩm được cung cấp bởi thương hiệu thời trang phụ nữ Tartarus , ELiS vừa mang chất Ý vừa mang chất Việt. Chúng tôi đảm bảo đây sẽ là sản phẩm xu hướng trong tương lai", null, true, "ELiS", 200000m, 0 },
                    { -11, new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5866), "Sự kết hợp hài hòa các màu sắc với nhau, mang nét riêng đậm chất Pháp tạo nên sự rung cảm cho người nhìn", null, true, "JAQUAIN", 200000m, 0 },
                    { -10, new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5863), "Đúng như tên gọi của nó, MOON sẽ thu hút mọi ánh nhìn của những người xung quanh bằng sự quyến rũ nhẹ nhàng", null, true, "MOON", 200000m, 0 },
                    { -9, new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5861), "Với tông màu trẻ trung, sản phẩm sẽ là người bạn đồng hành của bạn trong những buổi dạo phố cuối tuần", null, true, "BNW", 200000m, 0 },
                    { -8, new DateTime(2021, 6, 3, 21, 44, 49, 54, DateTimeKind.Local).AddTicks(5859), "Set đồ được cung cấp từ hãng thời trang nổi tiếng Tartarus, Đây sẽ là set đồ nên xuất hiện trong tủ đồ của bạn", null, true, "LIMMA Set", 200000m, 0 }
                });

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

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { -1, 1 },
                    { -4, -11 },
                    { -1, -10 },
                    { -1, -9 },
                    { -4, -8 },
                    { -3, -7 },
                    { -3, -6 },
                    { -2, -6 },
                    { -1, -6 },
                    { -4, -12 },
                    { -3, -5 },
                    { -4, -4 },
                    { -4, -3 },
                    { -3, -3 },
                    { -2, -1 },
                    { -2, 1 },
                    { -1, 2 },
                    { -1, -1 },
                    { -1, -2 },
                    { -4, -5 },
                    { -2, -13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -4, -12 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -4, -11 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -4, -8 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -4, -5 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -4, -4 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -4, -3 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -3, -7 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -3, -6 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -3, -5 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -3, -3 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -2, -13 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -2, -6 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -2, -1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -2, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -1, -10 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -1, -9 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -1, -6 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -1, -2 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -1, -1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryProduct",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { -1, 2 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DropColumn(
                name: "ShippingFee",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "cancleReason",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "total",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 30, 17, 48, 54, 942, DateTimeKind.Local).AddTicks(6800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 3, 21, 44, 48, 991, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 5, 30, 17, 48, 55, 318, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 5, 30, 17, 48, 55, 318, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IsShowOnHome", "Name", "ParentId", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, "Sản phẩm áo thời trang nam", true, "Áo nữ", null, 1, 1 },
                    { 2, "Sản phẩm áo thời trang nam", true, "Áo nam", null, 2, 1 },
                    { 3, "Sản phẩm áo thời trang nam", false, "Áo nam", null, 3, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 5, 30, 17, 48, 55, 569, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 30, 17, 48, 54, 983, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 30, 17, 48, 54, 983, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 30, 17, 48, 54, 983, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 30, 17, 48, 54, 983, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "7bdbefdf-5471-4091-85ed-8e6404474e36");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "60649572-e2d6-4949-bf16-ef2e421f8225");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "81d2e9bc-0524-4869-b420-0d3cacfe3462");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "740fe7a8-798c-43da-8eb9-17a004bdccf7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 308, DateTimeKind.Local).AddTicks(1115), "29f5680a-29cf-445e-b3f1-cab74f459969", "AQAAAAEAACcQAAAAEHIgp6Y4f3GIV032mPMjCtD8g45dfXHnTJ3sf/7wib1n7xYRN+A/NtRPdfjh+YNmIA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 54, 995, DateTimeKind.Local).AddTicks(6943), "01a5fc60-53ac-4e8e-915c-66978de3c455", "AQAAAAEAACcQAAAAEB3M4+EK8MRINYNpBgDEKDUXM1c3JYS/efAFHE5mx5u1qaurtmpHTqzOOcgCiwOfrA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 10, DateTimeKind.Local).AddTicks(3086), "b21633cf-4bd6-4ebc-a22d-2aa20ecfa7b7", "AQAAAAEAACcQAAAAEDUQsx5+NFmazQebGiCxeZx5Ucr0UWXgrwe5EyuUPWAFBUNbwi2HQG9wJmAWsS521A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 24, DateTimeKind.Local).AddTicks(4443), "827bdff8-ee40-414e-8696-bbef6a215359", "AQAAAAEAACcQAAAAEMyC+aMVeuYtokwKBD8SqGCCiOhouDNZSCIWG0byIpqs/uEefdA2HawQoz9ZDMNIPw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 36, DateTimeKind.Local).AddTicks(6982), "010a9bc7-9854-4a51-a260-91f99f3f6248", "AQAAAAEAACcQAAAAEH6HbwncJyBmeDUgCWvsuK164SgL+paGS9iTq2jnmyXmFH+VZ5WMkJgxXfh5h8K/sA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 48, DateTimeKind.Local).AddTicks(901), "b351f459-6e1d-4d8a-a657-56de92046fb2", "AQAAAAEAACcQAAAAEPYIQ+Ju6s2Hhumawj0eq37ntMTyUOrBR2A6QAaE+aedH/EUPY7cUXsCLbr0dgZMSg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 62, DateTimeKind.Local).AddTicks(1425), "8e5d8233-6a8c-4382-8f47-ebc806d2615e", "AQAAAAEAACcQAAAAEBrpwsjQMe4X2lLFYAEQkn+Hv/FnnGzC/dVzHQilMhRsG8zGIA6qsgkl5GBzMf5flA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 75, DateTimeKind.Local).AddTicks(2806), "2449d893-cf27-49a1-8229-354a167978dc", "AQAAAAEAACcQAAAAECxBoYpWhvSpDZgLkV+u3QRGBBiX+QX4lYO2jNbhxgM43xsNyunTxrh0HlZCbmpiKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 85, DateTimeKind.Local).AddTicks(8676), "d802cf8c-2a37-44c0-a478-76392b158e5c", "AQAAAAEAACcQAAAAEG68lksXpFOw9hKccK8MYhs4iuBGyomwmw38IkCzbVRi3sHEQWqrDgOo3eN8/YFd6A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 100, DateTimeKind.Local).AddTicks(1615), "2f2faada-ee51-43ec-89dd-9f634af29dc2", "AQAAAAEAACcQAAAAEIvunEoinI7oBLyUc+JduRUr2Zbwtm+3czM9sUz0ufIlK7tXbjJlplKEheeSGwf/Cg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 112, DateTimeKind.Local).AddTicks(5559), "49fb05b7-5125-4af2-8207-f2d44d950dc0", "AQAAAAEAACcQAAAAEE2+VM6D/DvevssBKGqMYjOm2HcfLEoTd3vK9nLW+r2niMM6nT6KWVpm6yjHMadjWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 127, DateTimeKind.Local).AddTicks(260), "1d979eef-1e7e-4c0d-a920-97d2c7ed63a0", "AQAAAAEAACcQAAAAENXdD0cIXKMJ6kUVlVVKJYvQtQn3SGRpYm0B0wzZyeNhqfHFJqf9OQ4ievXxKVQIgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 140, DateTimeKind.Local).AddTicks(7307), "b8e59d0d-6391-4f39-ba04-0e9dfd07a060", "AQAAAAEAACcQAAAAEHIXAI9Ptd076ymYZvQYnVQH8vYkGzkQolODGgjBmyp6FRnlkq6v2HelEvJLH4FQmg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 153, DateTimeKind.Local).AddTicks(8639), "00ebef3e-92a6-43fa-9fe3-c1d456b6cd63", "AQAAAAEAACcQAAAAENGuXty6PQ9J9VQfoK+K/Qg2zXqdV60X0gryN5RPYh4gTnO+TtfBAufywCVCAx1Ymw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 161, DateTimeKind.Local).AddTicks(8552), "3fdcb6cd-dd6e-4f02-9dc4-e29e6004cac2", "AQAAAAEAACcQAAAAEO4/kVt4yk7cOmQr3J30EvTXWJExfUgLomQg4fiiJul4NXYDXKYRVbwbXMy5Q2OuMQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 177, DateTimeKind.Local).AddTicks(4710), "c31ba903-29d7-442f-bf8c-7da457868cef", "AQAAAAEAACcQAAAAENiIjUXQlRbboWNq8gZxU6U+Lb+7Dz12Lc4sGfER/xZVwWpm6kvi8hW+7gbewVelqQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 187, DateTimeKind.Local).AddTicks(9040), "5bc26130-b6a9-415c-a9c0-c2526de650f4", "AQAAAAEAACcQAAAAEAkIQ3ndWo0dB63CBVg9MfOp7E4U/A6iw7GRvC953BHNVxVqtZ5+jx+eFVw9nsX0gQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 195, DateTimeKind.Local).AddTicks(9460), "154ef1e5-e4f6-4496-9036-a30771f3a0b1", "AQAAAAEAACcQAAAAEAp07fvMqPtW44gofWefPngb6U32QEYTltNw+W+cQTlE36ZlZzLqKGcwynnEdCvp8A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 209, DateTimeKind.Local).AddTicks(6081), "9541c919-4844-4517-83ca-9e751904facf", "AQAAAAEAACcQAAAAEIphkckbqVd+mrJUeUKdwf+fDCybBTv4aMFWQfUeiozCGFgDjKGmj934xbOc5sjP0A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 219, DateTimeKind.Local).AddTicks(9968), "4fbb26f0-aab0-46a0-a0be-8f71089ac273", "AQAAAAEAACcQAAAAEFR3wU+61a1F3QU3nA66gq0HLOSGMNuDcvufeqyU737OEilRJOiJh8cvPS4s3QPxDQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 227, DateTimeKind.Local).AddTicks(9625), "70ac7223-e4c2-4304-acdd-78c108f579a0", "AQAAAAEAACcQAAAAECLrpCgpJ4wdKe5YD0Vsc08oFeBSOQlnL7CKtjrrqW0aYrCOH5mk6BrLbPFs/AhObw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 276, DateTimeKind.Local).AddTicks(341), "8e612958-f074-4494-bb1a-2319e0082e53", "AQAAAAEAACcQAAAAEN+nzQA/jzZPJJD5s5Mv8WB6UmBeUvOmEMYHa6tPM00AI3hjcuMPF0kxPElvxWaozQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 263, DateTimeKind.Local).AddTicks(1029), "8812e729-b660-47f0-9faa-01790bcfc115", "AQAAAAEAACcQAAAAECAii61A8hNl5ziQno2h3HvuY0JH6QMvDMtl9ljG3UObcCE27u2QjE1TQ0chDJmnIQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 288, DateTimeKind.Local).AddTicks(8140), "fafd37e6-8d3c-4fe0-aced-d9403d15d65c", "AQAAAAEAACcQAAAAEIRq95ptuhkzb9YuNM9aL8mL6YbbNPox+bBTQ6dFU3XsXvBu1MRy15fMaUwMWqIZGw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 318, DateTimeKind.Local).AddTicks(2319), "c0f08061-1444-475b-b1f5-b44036a27ebd", "AQAAAAEAACcQAAAAEIJ6WWK7KB+PCZkr1h09D2A079ozbQEqzfcFiJtrx+AroIrNcVTcF8vERsIMGaB2Ig==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 244, DateTimeKind.Local).AddTicks(8065), "0bf2f976-9bb9-4070-83cb-e9ed9a03d826", "AQAAAAEAACcQAAAAEAfFYfAFkedW9wgtHgTDqr34/lt141/Qdr2pQ7lNtob5jJZv6xtT5yD14cuZJYpIXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 254, DateTimeKind.Local).AddTicks(5798), "a32b96e4-69ba-4243-9443-3e529388824d", "AQAAAAEAACcQAAAAEPiKmMnlk7itSorlDaEBN6+v4Pt2LqLxoV1Dr/yeG/wAfaOdXINsngPuzoI+fY416g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 300, DateTimeKind.Local).AddTicks(1068), "c8ea250f-9b11-4028-946c-615582f1f4d6", "AQAAAAEAACcQAAAAEEU7OEZwjnhZS6mOh7d6I41JnAp1z0CEMqL/zaYeBt8sSfqVfV3jq3JSDD6Bx4Xb9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 30, 17, 48, 55, 236, DateTimeKind.Local).AddTicks(7922), "99f8e773-0ae6-4070-94c8-20271e72c1f7", "AQAAAAEAACcQAAAAECv9mFVcAoXUN3QDIoc2Fv8DsqXxvRexTh+ck1mClfdtwhrxTVDutFPO1Gm8LGWT+w==" });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, -2 },
                    { 1, -1 },
                    { 2, 1 },
                    { 2, -1 }
                });
        }
    }
}
