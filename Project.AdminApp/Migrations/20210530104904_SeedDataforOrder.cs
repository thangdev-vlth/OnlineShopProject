using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class SeedDataforOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 30, 17, 48, 54, 942, DateTimeKind.Local).AddTicks(6800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 28, 14, 0, 17, 190, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.AddColumn<string>(
                name: "CityId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerNote",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistricstId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffNote",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WardsId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "size",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "total",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "size",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);

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
                table: "Orders",
                columns: new[] { "Id", "CityId", "CustomerNote", "DistricstId", "OrderDate", "ShipAddress", "ShipEmail", "ShipName", "ShipPhoneNumber", "StaffNote", "Status", "UserId", "WardsId" },
                values: new object[] { 1, "01", null, "008", new DateTime(2021, 5, 30, 17, 48, 55, 569, DateTimeKind.Local).AddTicks(6907), "353 Đường Tam Trinh", "rawaccountstaff0@gmail.com", "Nguyễn Quyết Thắng", "0328025122", null, 0, "11BD711F-9506-45BA-B5B7-F00649BE00DE", "00322" });

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
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity", "size", "total" },
                values: new object[] { 1, -2, 20000m, 2, "M", 0m });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity", "size", "total" },
                values: new object[] { 1, -1, 20000m, 2, "M", 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, -2 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, -1 });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerNote",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DistricstId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "StaffNote",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "WardsId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "size",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "total",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "size",
                table: "Carts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 28, 14, 0, 17, 190, DateTimeKind.Local).AddTicks(9006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 30, 17, 48, 54, 942, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 5, 28, 14, 0, 17, 539, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 5, 28, 14, 0, 17, 539, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 28, 14, 0, 17, 265, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 28, 14, 0, 17, 265, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 28, 14, 0, 17, 265, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 28, 14, 0, 17, 265, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "cc053243-4ad1-4954-bc56-e396752a49af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "271b5ce8-9a8f-4919-a64a-bd789f0d9cca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "428244b8-2ec9-4ef4-8cc7-6fe1e9b50f31");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "f40992fd-1be9-4185-b913-69b16afcdbff");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 530, DateTimeKind.Local).AddTicks(1786), "fca74f07-2490-4856-aece-8540c61ce9cf", "AQAAAAEAACcQAAAAEDhtJx0GqT5QvARBOggyMidaQ/WpRpEJqN+SBYzO8dqzG8LmS2yN5W2XognqinLPow==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 284, DateTimeKind.Local).AddTicks(7354), "0196b51d-609b-4289-ad7f-7b883534499b", "AQAAAAEAACcQAAAAEICl1+sL7DyKD1LTgoGpqbubETuAXCGDcaUzXbNSKvL5p3PDMXbmhpA9bTnzy7bV4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 296, DateTimeKind.Local).AddTicks(8044), "e23cdaf4-0c3a-4892-8936-fb9c6f385267", "AQAAAAEAACcQAAAAEBNojSfx+vtn6ziefEYnNxMsnQQVFlkYuxQc2XtQMLmd7Lo6bvKqE4Nx3fb8qU1V3w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 309, DateTimeKind.Local).AddTicks(6484), "053bc3e0-0cdb-4d59-801a-dd313cd7afd2", "AQAAAAEAACcQAAAAENkPFvHJEnSf2qJ6OaryTDhsMJ6Kkm0KKFS4Ntb/fAKqVZJSHbD3zUMQ1d/xp1bm1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 322, DateTimeKind.Local).AddTicks(6676), "18ad15cc-cbb7-43c4-a518-e292e9964aff", "AQAAAAEAACcQAAAAECDRzkHbASDELBGWg8O3RwIfpyC5JkQQU9eiaAbZUDmsi3jhiT45YVo74JoEiNxn4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 335, DateTimeKind.Local).AddTicks(7780), "92ce19dc-148c-483f-9bfc-0b9fbf4105c4", "AQAAAAEAACcQAAAAEHwicCPSk4yVaw6Qf3Tb0FpNTytCIkJ0ldYfLuTFo1/CnNjMGe1HHFfsmZEBxIgSNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 346, DateTimeKind.Local).AddTicks(722), "06ec1a74-89a7-4248-996f-076057c6f9d7", "AQAAAAEAACcQAAAAEEd8ZyoDPQKnuRQJRi7OKeVOHow9u+hZGFJW6ib1b4eZsUIaT7iuMoLVvKbPSg6SyQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 356, DateTimeKind.Local).AddTicks(3628), "3ff038c0-263a-40d2-a54f-04f11657e5a5", "AQAAAAEAACcQAAAAEIxR2bO2zvb3MjlTywOCqPoe0ommKRUq0iREd5ov5NgxB+4SNrzh7tVBUSHFV7lU4g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 366, DateTimeKind.Local).AddTicks(4488), "b90ad6c1-57cd-4444-a515-c884acf02f6c", "AQAAAAEAACcQAAAAECujualdXBHs2h2zjgV3GaJN6WvlBlPdjTNq2gihFrEVuioyQgi/R+hKQb3FSqGozw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 375, DateTimeKind.Local).AddTicks(8332), "3dfd482f-3fea-42c6-ba1c-76f673c2e107", "AQAAAAEAACcQAAAAEJEIYuS6G8yHl4xFPjF2qR367jOJ77BCzJ1PsPh6gVUVQ622s90OHAzovHvPBCDSLA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 383, DateTimeKind.Local).AddTicks(7815), "c3f13774-4b77-4fc7-9e53-70eb824cfa7e", "AQAAAAEAACcQAAAAEDhcUiSUdqscZNUCmmU49BssLwRLNmo7BbSt6FckOPDN5wxTdngPsXdjQdYmiet4HA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 392, DateTimeKind.Local).AddTicks(2424), "c0f95607-fa11-4981-865a-c89a9051eeef", "AQAAAAEAACcQAAAAEOaRNvkQq+vE2UIfGVjCQSf4gX0ncKACuHNrEnJBgI5PM6ArVMFqAESYbeHC5L6LoA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 400, DateTimeKind.Local).AddTicks(2017), "cbf4b147-e95f-4851-ab52-c25556b54816", "AQAAAAEAACcQAAAAEGjN5UP58yyuTDa5HpVuH+q77pqo81QkafUPbOQEqwJSzfMcks/SHvpXZu/JgkxB9w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 408, DateTimeKind.Local).AddTicks(4118), "c648f002-e7e8-41fa-92be-9852a1fc6fe4", "AQAAAAEAACcQAAAAEL5RbB/8UAKIkIlt2OkC4GcGBakz0JlmuwnUvnoqF0mEFke9qDdx3Y564rIiJ03PJg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 416, DateTimeKind.Local).AddTicks(3026), "b22b9351-7f4b-4a45-8c67-a6f20192dad2", "AQAAAAEAACcQAAAAEJQ6pDYUEGHh7/p00+5r9Cbe+QB1x7cmdwZRaYphQpGI1IU7xothzn51lvXWVQqplQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 424, DateTimeKind.Local).AddTicks(4669), "0a9906e9-0236-41e1-b45d-fe5cefd65bc4", "AQAAAAEAACcQAAAAEEhg1sTwbXS/cU6zQVUNoMlJ0FbZkAbjDcww7Sl5gaXHycyejji7TkgIOSBKeB7/BA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 432, DateTimeKind.Local).AddTicks(3522), "530ecbe7-7320-43fc-bb3c-4bfb3bebd297", "AQAAAAEAACcQAAAAED6zNSNGIRfSDNc7PTwaQAMqYqUj92HU+SV7bBvg4q5famfMZUV6JfS0xZsViczbWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 440, DateTimeKind.Local).AddTicks(6258), "f87cf80e-4d38-405c-a5f5-a15f8219f16f", "AQAAAAEAACcQAAAAEH1KAQQX4Xjbpl5bgRoQPROlo5AYhXskpCn6ohL/nfz3iZkglx4M5MbAo1Oo+bUeXA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 448, DateTimeKind.Local).AddTicks(5432), "f3adea01-2e42-4241-8198-614f56dae0d5", "AQAAAAEAACcQAAAAEDzfWFkpVt3z7lBjMvdKvLSpf2Zp46n4i90OEFKfYDQGdK82RjzvVm3zXqUKawiQPw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 456, DateTimeKind.Local).AddTicks(6962), "27f22522-a0ee-4d5d-97ab-55f17cf83c05", "AQAAAAEAACcQAAAAEHTbbo1pZqMIbzSOOv//hhB1dMmAVuD5KVi1Ui0XAjP0+6Cskx3yrkewFH1+oAtHtg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 464, DateTimeKind.Local).AddTicks(6648), "a9b40227-8e23-46e2-b402-4641bd71f62d", "AQAAAAEAACcQAAAAEKc5znCmBV9o21mdalSNpWVfKmguVH6Il1bRC8fuX06RLvn3GCkNHvfnVzhW974dlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 505, DateTimeKind.Local).AddTicks(6870), "d219b1c8-062c-48f8-ae74-c659aa9280fd", "AQAAAAEAACcQAAAAECGiopCrCNvU2UFiUrf368Wyj7nOtypO6CX7UkWsY1hrBsjZMwEOgZWWaqYzOU6JIg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 497, DateTimeKind.Local).AddTicks(4725), "a111c2dc-0ff4-478c-8ee5-5e19ab828c04", "AQAAAAEAACcQAAAAEBGrqeC4Nx+wD8VG+TfZYHTJpMwyK7Ey0Qcm3D/5aaQ6bULhYKaoLzQ4g0FJ8AvKQQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 513, DateTimeKind.Local).AddTicks(7479), "9f4300c3-a838-497c-be39-7e1f17b57277", "AQAAAAEAACcQAAAAEGJOKYH3yDGDOeSs47wBZt/HNHuyFhRrUMMVWZEXgmeo6xcf9EjXoQeYiZaEWjFE4Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 538, DateTimeKind.Local).AddTicks(4775), "fd470dfe-1843-4580-b8e4-0aae9d700199", "AQAAAAEAACcQAAAAEPU+M5vx7HmGaN9YXKVJ8xrNWPXvPHt1XsQU9oU1wobSVvZHKo6dQN0iNUpGaFdpUw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 480, DateTimeKind.Local).AddTicks(7815), "ba02c8ac-9bd5-4f0c-a528-8395b0432df3", "AQAAAAEAACcQAAAAEFTpRCfu7G/m4uWo+i0OKVYFxuBfr9qDn1DwHC5svtcFLq3nngsE4RPTCDZonQfOyw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 489, DateTimeKind.Local).AddTicks(4493), "70870257-d6c6-4842-ae2f-8cbffd771510", "AQAAAAEAACcQAAAAEN0ApyxluOKAr5buDjVzgF7c81T7Pn3TIyz3SnftqOLDAhR9zf1ap8RBJ+/8bM9ilg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 521, DateTimeKind.Local).AddTicks(9147), "7747e3d8-c695-4fa6-afdf-54a60769dd5e", "AQAAAAEAACcQAAAAEEnojRdOtv1DCPHpXnY/9+I9QwEJBrQeHqLyI8BOQGYPH3jJYiJ6dY9qbMC9pGjEVA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 28, 14, 0, 17, 472, DateTimeKind.Local).AddTicks(8787), "5b4e231f-30a5-4c4b-8c8e-743a2cf78a5e", "AQAAAAEAACcQAAAAEIHogQezPrup9a7VR+6UrzHWyl8l9sO7UaHYZWCwkelt54sU831Sq0PuGys8quHnpQ==" });
        }
    }
}
