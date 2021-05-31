using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class AddRawDataForAddressCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: "3798");

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: "6209");

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: "6411");

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: "6826");

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: "8691");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 27, 16, 39, 24, 521, DateTimeKind.Local).AddTicks(5354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 22, 51, 40, 199, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistricstId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Districst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardsId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressCardId);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressCardId", "City", "CityId", "Districst", "DistricstId", "FullName", "UserId", "UserName", "Ward", "WardsId", "address", "phoneNumber", "status" },
                values: new object[] { 1, "Thành phố Hà Nội", "01", "Quận Hoàng Mai", "008", "Nguyễn Quyết Thắng", "11BD711F-9506-45BA-B5B7-F00649BE00DE", null, "Phường Hoàng Văn Thụ", "00322", "353 Đường Tam Trinh", "0328025122", 0 });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 16, 39, 24, 955, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 16, 39, 24, 955, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 16, 39, 24, 576, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 16, 39, 24, 576, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 16, 39, 24, 576, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 27, 16, 39, 24, 576, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "eb91d7a6-a06c-4fa1-b1dd-466d47b51e3a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "40266571-8856-4b4c-9cf3-2690872ba25b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "f1c4dbd4-22e9-4c8b-8557-a76c11a85f23");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "8247c8a9-2140-42c3-8d0d-735e6e0917eb");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 941, DateTimeKind.Local).AddTicks(5402), "b568e08f-09d6-498c-b7ab-d5fb8bcef3e5", "AQAAAAEAACcQAAAAECmDGo9iJFntkDx6DffPiB+mANpzXG5AXeAUsdVwQtTqmaMhRujKs/OT5WC8ego6Kw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 595, DateTimeKind.Local).AddTicks(4507), "cb3f493e-0b4f-40cb-a838-aa66b0a50a6c", "AQAAAAEAACcQAAAAELeobjVthhIHLfzxDxg5wsbmYbPt7+4jvN4kOGFEKtZSwbEqenVE1KJQIvs8HCOrwA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 611, DateTimeKind.Local).AddTicks(3306), "8d38631d-122e-4068-94cf-e96e0c0833d7", "AQAAAAEAACcQAAAAEGYaXHS/gWSZtzPWLvY7B4S0yGtjEpf/AE6yas3PIyA5DaOW3AbI2Y1KD1fZBROy3g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 624, DateTimeKind.Local).AddTicks(7657), "cfc8faba-6c9b-4011-a0d3-df2a876eb258", "AQAAAAEAACcQAAAAEJikV7EZcv2F8RKO48jujz7V3/CoUGnuEsra/05UwDQEpxwd3prBbMcKsvCI7u1wTQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 635, DateTimeKind.Local).AddTicks(7015), "212921a8-46f5-4266-bcb4-9a9c6baebd11", "AQAAAAEAACcQAAAAEBfDGz9MHSjcueh11hstBLnT4gwBXtE/nbfihmON74AAocwYNEiQBxJnRhuqVMceGQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 647, DateTimeKind.Local).AddTicks(3215), "3cc4c13e-7131-4ce6-88db-e47c1017645c", "AQAAAAEAACcQAAAAEJ47kfO6/UwhA+lwKbCr8zexhlBgjVa7WAWWRhEK+Bj5OX3FF0watNee+wbyFWYLXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 660, DateTimeKind.Local).AddTicks(9130), "db552cea-f326-45f7-8426-cdb89d76e1b6", "AQAAAAEAACcQAAAAEH+unk60o961bNanoVmhgc8f+Kv4ZuwoKy4n97JtORC+RokEah5fe5jtBH18BaAdjg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 674, DateTimeKind.Local).AddTicks(4896), "b95b43a2-948f-40f2-9a05-3bdcd28c7cd5", "AQAAAAEAACcQAAAAEKAwtW6d/0YtN1NCs16+GTssVW1FyXwDxckfvkM4kdqfQMZL7t6NfRDrksZOnVYg1g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 685, DateTimeKind.Local).AddTicks(8283), "b1b1dc1b-2a62-4ebd-8d73-c33214cae6a6", "AQAAAAEAACcQAAAAEJg/MWz8i0qiLz1d4V7cxbSR+OanUI24zwHSL+Xl3XTKSxgHJ4k31RmDpMVr4eEMXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 701, DateTimeKind.Local).AddTicks(815), "ba8b263e-bdb6-4d75-a790-a4902eda1af4", "AQAAAAEAACcQAAAAEIiPiMlXzkxt0yUi3bdv1L46T5SdcIAV6YC+JeaLSW+51w3OOqFIPMy0K/gT4DO5Cw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 712, DateTimeKind.Local).AddTicks(2235), "58624dd5-2417-45cd-9ec9-a3e5b86a676e", "AQAAAAEAACcQAAAAEICoYmDheloyXX725ste0IB1cZeBePqOn17lwJMVKerAcaSVxC61t904+wGWLA4Yqw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 726, DateTimeKind.Local).AddTicks(3648), "aa19f0b1-3777-4c7a-943a-544b88feb375", "AQAAAAEAACcQAAAAELuk1exjbSaiyQnuVDUmkhTVkMw3woW9j9dfssiYYue1CfdqolctfdKiEzheMKe5jQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 737, DateTimeKind.Local).AddTicks(6602), "3c305803-5cd8-4c47-be5c-9bb8151bff98", "AQAAAAEAACcQAAAAEMxsXzzCDw4AloXSuWBZBtrcTqZQjBMyYV+Pk7ZTOLS7RhVF0tvg27N5x/WpDeTPQQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 750, DateTimeKind.Local).AddTicks(4378), "df506117-e574-4e91-a8ee-b32936edcef5", "AQAAAAEAACcQAAAAEFWfC90kEG8A0+qjd0kN6eFMFgZ1rVP60TNcl6pQeUK/IgKHmz1RNvoF0a6LqHFBHw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 760, DateTimeKind.Local).AddTicks(3043), "84418fdd-ff5a-44c9-abdd-8b14edef70af", "AQAAAAEAACcQAAAAELHGIs5xiSXkYd3und+67WcATqv9sg7qj5JJKQQT6btSY6Ufh0jPW6paef6wMc2sIg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 772, DateTimeKind.Local).AddTicks(1209), "67880249-1843-41e3-bced-a7cce93ba1e0", "AQAAAAEAACcQAAAAENXPUBUbGqWovk6ApCGNzfj8AVGBRe1cZDJQTq5hpGwOqP5w9XoEn3JhbH9GdjzYNw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 783, DateTimeKind.Local).AddTicks(9466), "c7c74d84-71a6-4d18-aace-ef6de2643619", "AQAAAAEAACcQAAAAEA3tVYDyVBjCl2ovvHSWnkCIDH2HQCawn1fReZuWAjnwzwWYMOrnYlFfdb0JE2hW1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 796, DateTimeKind.Local).AddTicks(1456), "5c9cd19f-f4f7-47c2-b0a2-e23f864f2044", "AQAAAAEAACcQAAAAENZqYvayufSeIKxHZhfu8if9rIsNZhxoFrfRvTOoGROo/LFqGSSqKx6ZEt2Rh8Dm+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 809, DateTimeKind.Local).AddTicks(892), "5507fa2c-d812-42b1-899f-3bdd2e1a4472", "AQAAAAEAACcQAAAAEDENE2Vr9iHUK0iVDhp3Xjmq8OdqsKdbwIuK9EqgrMJbSCW8IDz3qtH6w5rQDdWFIQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 821, DateTimeKind.Local).AddTicks(398), "4f6b74f6-be00-4855-9b43-30b9bbec4cdb", "AQAAAAEAACcQAAAAEGovXPswlXNaCy6/LRWP67s7FRD9kIsY1L/5UE8Q2aN90w1724Tbr6uqnETH5/qcaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 835, DateTimeKind.Local).AddTicks(1480), "9411de56-1dfa-4ab1-a085-caabcb0d90d0", "AQAAAAEAACcQAAAAEKr2nwLu+NkVdNcw95c3de/q6z7QZsxe5XNywMFGgPqdAdKTMKu5LUYnmrSzkEg/2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 899, DateTimeKind.Local).AddTicks(477), "a04b3891-1d14-4f19-b26d-0eeae6d6925e", "AQAAAAEAACcQAAAAEFBv+Nb/F7zHP6AxLYppS8mwr5owywuwE18j2UKvZHviDkk5SfhLfP1iGDPXOCZVJQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 887, DateTimeKind.Local).AddTicks(5704), "177704f7-bf37-40ab-8c8b-4e008b570590", "AQAAAAEAACcQAAAAEGHVzesLfcipUdB5pvfoVHBDEKeoIniqHq/LvdfFvkDn+eR2dXbGB4LvpVgPApLkrg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 912, DateTimeKind.Local).AddTicks(8459), "4bbe6a03-3e12-4c3c-954b-1c2871cc70d0", "AQAAAAEAACcQAAAAEA0qa2THWv2jVgqNWzICi9u8N7qZ8+cWGgy6tUXvcSvjQFN1nlXdaaH10T7UIg6O2g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 954, DateTimeKind.Local).AddTicks(6280), "57febe01-a164-4e31-84b4-a01204cf0067", "AQAAAAEAACcQAAAAEEaiCZZ/wCJkIf4McGR1F0eTLE6JJPPJ5xlh6WKalStMpePMxb9BWnKyU0xNdrfK+Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 862, DateTimeKind.Local).AddTicks(7899), "0790ecd6-bcd6-49e5-988c-b403cb9ff50c", "AQAAAAEAACcQAAAAEMNeWIIQj/JN9T2XkAa21KPqoxDJtojjU5xFmRpb5c3N0cjbkYHUjBgolthakvq7SQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 876, DateTimeKind.Local).AddTicks(3349), "7b0543b2-bcc1-49f1-84bf-28acb2947860", "AQAAAAEAACcQAAAAECfdT7LUCj8JXiSnDknM5sSrqHzKpL5C/O1PsdSuDT9P6TRDGmfN7kx0tyqwMzZtng==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 927, DateTimeKind.Local).AddTicks(3875), "6ef4aa3e-20e5-481b-85e1-f486c269f77d", "AQAAAAEAACcQAAAAEJTCLObTRjOB2pYfPpb9UwM/48BBEXL0q69WZKdfDjegftq7Ec0PU1prYH6B2HZIaQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 27, 16, 39, 24, 849, DateTimeKind.Local).AddTicks(4623), "9bf1b0eb-c04e-48f4-b6f0-7534b5d7072f", "AQAAAAEAACcQAAAAEDMkOOcyj2W/TkaemOhcgmXoJtMOb755/cWIha2e0q2Hgq64OULMJr8dfiGNt90k0A==" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CityId", "DistrictId", "Level", "Name" },
                values: new object[,]
                {
                    { "2", "45", "471", "Huyện", null },
                    { "1", "31", "318", "Huyện", null }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CityId", "DistrictId", "Level", "Name" },
                values: new object[] { "3", "48", "498", "Huyện", null });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CityId", "DistrictId", "Level", "Name" },
                values: new object[] { "5", "77", "755", "Huyện", null });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CityId", "DistrictId", "Level", "Name" },
                values: new object[] { "4", "51", "536", "Huyện", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Ward",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 22, 51, 40, 199, DateTimeKind.Local).AddTicks(9697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 27, 16, 39, 24, 521, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 22, 51, 40, 608, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" },
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 22, 51, 40, 608, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 22, 51, 40, 247, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 22, 51, 40, 247, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 22, 51, 40, 246, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 26, 22, 51, 40, 247, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "e6c46c69-3c5b-463b-974e-03e297c7fa2e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "177871c3-6705-42d0-945d-cf8b561220af");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "00ab8386-0ca1-47bb-918d-ce618c7100f0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "88b3f8ef-cbdb-4a5e-a5f2-ae95e12e7279");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 599, DateTimeKind.Local).AddTicks(1196), "cfbd365f-add6-4efa-97e3-d259769811f0", "AQAAAAEAACcQAAAAEEEJ6dcXq/DSwSfjP1e/zbcVWwVaNbCuAIa0R2uvlaCfEJdSCjX7nA9k0DDls+Hl2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 265, DateTimeKind.Local).AddTicks(4073), "2cea60fe-a853-431a-a002-7049c9867b4a", "AQAAAAEAACcQAAAAEIwwxBd/hWMz1kb5OOlITugYDtKqlDPygi8DjLGnWNHUNzjhoWnMqdD7bADSswT8iw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 278, DateTimeKind.Local).AddTicks(6031), "5d20d155-9bc3-45b4-8474-255b46e6e887", "AQAAAAEAACcQAAAAEMNHUJGYluEBh6gFFLxqYMLwUAoIfSz4LPslOVhA9kNYHsQW+o3ZWpC/Iz/lV1w8Tw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 290, DateTimeKind.Local).AddTicks(3836), "ce8ac3d5-7fb3-41f0-9dd8-6317375ed423", "AQAAAAEAACcQAAAAECwVrF+elH8F7JqgpPWMOhY4+MGopsVRFULb+hH6/V7nM9kEUjwHkmlN7RgWj74T6Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 303, DateTimeKind.Local).AddTicks(6172), "4d43ff5f-9844-49a3-97f6-b33270c13d24", "AQAAAAEAACcQAAAAEHiDPy+RF2Xx8O4z2k41m+BNH4EXKfYM0SvXoMpfpj6J5EmOP4wLR2kjS4sxL/6qQA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 315, DateTimeKind.Local).AddTicks(6204), "7f8da552-748a-4998-a3fa-c1f16a315493", "AQAAAAEAACcQAAAAEDdYjvkifhpA+7x8naJwdd3y4UZSPCS+XpNr/YUSrvfYr5SpO7+57xapXAHOwIVR0w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 334, DateTimeKind.Local).AddTicks(8779), "1f00724a-5d11-4210-a5b3-439b760ea3d6", "AQAAAAEAACcQAAAAEPuqpC9bNgiWVFfHN5OHL21u4RPOiAYOypVSTjxWc24xUR7mpLJb+mC18G79iZW3og==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 347, DateTimeKind.Local).AddTicks(5078), "910931b7-c2d7-4cc5-a142-8dd5ac51b876", "AQAAAAEAACcQAAAAEPTyWqqKsj6frMuEgvqF0FG6Zv1H8LpMhxl8Uyb6+eACJiWN8B77+7wg8mlo5NVxWw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 360, DateTimeKind.Local).AddTicks(1284), "5abd9a07-59ee-418d-ad58-fd75cc6c2ad2", "AQAAAAEAACcQAAAAEEEdws3luIO+we+eYomNTf2jcpV03iiW7CROeAJ/GMYtPHf77pi+4f6LZ7mld6qzaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 368, DateTimeKind.Local).AddTicks(7393), "40917306-ff7f-4642-b7b1-ec1a792b049a", "AQAAAAEAACcQAAAAENZe140uHd+7bm9qNK1FB2aY+fs1wyqW7Gtgla/CsQTsYS756jntP2V6KAtFADw8yA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 378, DateTimeKind.Local).AddTicks(4682), "13cce9cf-ef31-46c0-8dc6-a8cc40f20358", "AQAAAAEAACcQAAAAECO7OITBVRDTaY+72kV+bLSt26REhAxGJTBrtfL/udPtURdxOdfZvm4jyCXv+G91Fg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 391, DateTimeKind.Local).AddTicks(8734), "d2cb2fa8-250d-4d52-a7b9-aec051a94013", "AQAAAAEAACcQAAAAEOn00LyNAAxQz7wS3JNRZl2sna9iC46A//gpId7lVO8dDboEfRRB7a40Id7XhOyEUw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 404, DateTimeKind.Local).AddTicks(7131), "356a00a7-f9bf-4776-97e4-f4f71a229db3", "AQAAAAEAACcQAAAAEBmBJbzjzT838Kjdig1dsMoncoW8+QTqRCmWYegkGW7RiziTjm7WUZKZBn9QB8wc5w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 420, DateTimeKind.Local).AddTicks(1178), "163dd9ed-5b5b-4244-81f9-0ae1bc1e2506", "AQAAAAEAACcQAAAAEO766v+TSgnLwmfUmHlyye3OTM+++EeLYtMw3nOeIE2OA7vRxS9X8h3BirCEtjrBvA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 430, DateTimeKind.Local).AddTicks(4104), "25f68035-6341-4621-bb98-14233b880ec7", "AQAAAAEAACcQAAAAEGEFRU8eyOVBEahYd8+IqgSyRyh2MTfkJZ2ty9jJRksIFDhPbzNN6Ve8KesBAwEeUA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 441, DateTimeKind.Local).AddTicks(2456), "340c0c6d-9f63-4724-bce1-0de0246ccdc3", "AQAAAAEAACcQAAAAEBdbmRxHYw5EsD9Z8CgpgmkYH9E3R4gKKL6KY6Z8WRG8tp/4UBXD9GVjtiS0RNBE8A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 451, DateTimeKind.Local).AddTicks(6755), "19983a15-9745-4cc9-8988-9b73200593f5", "AQAAAAEAACcQAAAAELoaUQoDKxdHbLB3dDm0Sna7G/j24iiebwfFwef60gxK1LVqJho+A13rB9NFXSPzjg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 464, DateTimeKind.Local).AddTicks(5499), "e6f0bbcf-8e8e-4077-8c82-dc3118ddb4ca", "AQAAAAEAACcQAAAAEJ2psA4hzTVHluQtcbo73Flz67udBbG5aSZdxM0Gzs68pcAJUySAT58zTmn0rZ0URA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 475, DateTimeKind.Local).AddTicks(6591), "71867f52-9adf-4a28-af56-dcbb47a4e773", "AQAAAAEAACcQAAAAEBw3P00UZT5EL/54hM86wkDwl0Xw6oKNCyGyGt9oDRWUnJFO6Bdmqfnr35uyu/cFhw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 488, DateTimeKind.Local).AddTicks(9484), "697a689c-d837-474d-994c-7284bad72d65", "AQAAAAEAACcQAAAAEIdXYiT8wKc0U9ruyYQtc3DcNskX+ToPytBnvtUzSmBUmWSJm7TrqL/Eg+p5xbxxRA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 502, DateTimeKind.Local).AddTicks(1148), "8777061f-8c10-49cc-a323-ad35212b330d", "AQAAAAEAACcQAAAAEKeTU4LSOF4ny4bgtZcPsmpNUkpDZPTr8454V1o2HP0ZZbOPKpfVemgmTLT7n5qHiw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 561, DateTimeKind.Local).AddTicks(8931), "6307c7dd-c92d-4fcf-a84c-6e77bb7e712a", "AQAAAAEAACcQAAAAEAJBlT+mYRorQFsVYCe3qhwXq7gXv1azLFR9biU8NE+SjRpnl9uY9WyYe/rN7hl25Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 552, DateTimeKind.Local).AddTicks(3812), "df5f9fa4-f579-425f-909c-5c07a941b678", "AQAAAAEAACcQAAAAEPRQ+vLdtKvbxiXJMJ3p7MuXkG1AwmFn/2qj4k+/VAYwPqqOfCZfMwLava6wuh/vZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 574, DateTimeKind.Local).AddTicks(1271), "a5f939a3-0575-4e54-83f2-bd9735faae9d", "AQAAAAEAACcQAAAAEILtEfkGDSfLW0ucRdqAoAENE6c08t5ookeWu0HooCzoPFAVNOBliasBFXmahhO6jA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 607, DateTimeKind.Local).AddTicks(8719), "255717ec-9029-41f6-87d7-c0cc45bfa903", "AQAAAAEAACcQAAAAEGhBFR0iodDZv04qthq70LRVs0IX48/O0fHimpHnZvpcV2NYvSOgvzO4aoDMFgNP6A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 525, DateTimeKind.Local).AddTicks(5809), "c7319ab3-9cd5-4c07-9453-d7b9638098ba", "AQAAAAEAACcQAAAAEEP6Q1t9J5VA7XT3RI3QkIeoCL3sB+GCw8KN16+xA4GcnGqcEEYL9RRlu3Gk0yBDDw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 539, DateTimeKind.Local).AddTicks(6175), "4a052c68-b47d-45c6-87cf-ad5b4c62b9bc", "AQAAAAEAACcQAAAAENPGgUy5kAXMAs94BExVM09P/uNOcSlWd9ropbykeiEoB0w+nt5ayZAbIRE3sE5Jgw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 585, DateTimeKind.Local).AddTicks(1912), "9bbe1d0b-d559-46df-a43f-2cc75c0a6fae", "AQAAAAEAACcQAAAAEGIg7qx1nRZaFP0gaXHyQdbbLEmc5luaqif0eLc17FgroeBsJfwu7mNGyEJKX48OLA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 26, 22, 51, 40, 511, DateTimeKind.Local).AddTicks(8247), "34f7eb81-e908-47e3-90f4-625f7bf60c7a", "AQAAAAEAACcQAAAAEKs4izOIxylOQArnlhPCJtakxALAOO6FBqolebFXPvWP1iE/3lbvB23YBRfEp5RGCw==" });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CityId", "DistrictId", "Level", "Name" },
                values: new object[,]
                {
                    { "8691", "77", "755", "Huyện", null },
                    { "6826", "51", "536", "Huyện", null },
                    { "6411", "48", "498", "Huyện", null }
                });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CityId", "DistrictId", "Level", "Name" },
                values: new object[] { "6209", "45", "471", "Huyện", null });

            migrationBuilder.InsertData(
                table: "Ward",
                columns: new[] { "Id", "CityId", "DistrictId", "Level", "Name" },
                values: new object[] { "3798", "31", "318", "Huyện", null });
        }
    }
}
