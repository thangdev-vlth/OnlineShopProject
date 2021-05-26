using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class AddrawDataforCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 24, 22, 13, 28, 81, DateTimeKind.Local).AddTicks(9907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 24, 16, 53, 24, 198, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "ProductId", "UserId", "DateCreated", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE", new DateTime(2021, 5, 24, 22, 13, 28, 357, DateTimeKind.Local).AddTicks(162), 20000m, 2 },
                    { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE", new DateTime(2021, 5, 24, 22, 13, 28, 357, DateTimeKind.Local).AddTicks(752), 20000m, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 24, 22, 13, 28, 112, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 24, 22, 13, 28, 112, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 24, 22, 13, 28, 111, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 24, 22, 13, 28, 112, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "4fcdf222-a6c6-4354-93b3-1f117972bb56");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "d1a517c5-7138-4f45-acda-664d4a4138b6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "511f3090-48e5-47d9-a5be-d5f8b9748c1e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "14d65359-35b5-4519-9e4b-9542e95f2a48");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 345, DateTimeKind.Local).AddTicks(6574), "6c5bee3e-2bad-4bd0-9681-0314d5d3a68c", "AQAAAAEAACcQAAAAELdU2QUILvJDVP3Gb+BfZfMxB+0BGfRxMjYwuAwsDehBjc2PDULLTqLygAWhh0aSLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 125, DateTimeKind.Local).AddTicks(1016), "76a6b815-d331-4a74-9969-816fcc1d7bfe", "AQAAAAEAACcQAAAAECvDdSLkaOHRbafetAiBNUuSqLFBpwFbuKuYhu/K9hJuvMPgZQOW/zqM50ZZH3mDEg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 133, DateTimeKind.Local).AddTicks(5017), "a7026117-50d8-473f-a776-32ceeb190b5f", "AQAAAAEAACcQAAAAECdczCdHCkSjuW+DXkSMnXuO+aQ0g4r/dXbBuvsjd8K07jCLK+7d/Cs37kLQKt7EIA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 141, DateTimeKind.Local).AddTicks(4314), "a31b9ea2-3837-4106-8af1-22943d926760", "AQAAAAEAACcQAAAAEJSoHQdsPrqaok9OP7XIIA73JUWnm6TjB2SmYxWoxP5Cs4vm8+QQ3dBC6i0+xRUolg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 150, DateTimeKind.Local).AddTicks(1529), "a0ba2c3f-a60b-4c51-ac4a-1e833813077c", "AQAAAAEAACcQAAAAEKuIVXRczWk0pcu4l3ahW4ARXIxZRJGlTNlglgjKNiLN3LuRM4+0vNszR8CckvUEjQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 158, DateTimeKind.Local).AddTicks(5099), "3dd19b8c-df5f-496a-83b4-c710b009dcec", "AQAAAAEAACcQAAAAENcWtQvNspJcXnyuLCg5VK9NT2TKCbj78jPP/EDiLl5jKIIB1jSpk3yhDwFxBVyn+w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 168, DateTimeKind.Local).AddTicks(8325), "ed3f05be-0654-4e5f-a756-6857e296ba44", "AQAAAAEAACcQAAAAEHdZlVZezvUl5FY+zm6CJenHdEjBtXX75pTVcoXi78OKXSMdUz75ZiXiRBw3Ysi2Qg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 176, DateTimeKind.Local).AddTicks(6382), "456e4e62-c45f-4899-a9a5-8201d30528c6", "AQAAAAEAACcQAAAAENsNdJBrjCJnGACYtT6nIBTEo/MLwlD/Dz4OtyzlL97Mat8KVCBl+m5XjCIFIqFKcA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 184, DateTimeKind.Local).AddTicks(6672), "47831caf-9641-4c08-a9dd-c0d38c9cf868", "AQAAAAEAACcQAAAAEHizKOqZMb9c7WBx8N/iBI4mrYl1WwQrqKTNd5An9mscmfTPI6APesdWonybx4ezAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 192, DateTimeKind.Local).AddTicks(5928), "25c246da-d4ef-455b-b229-31355464294c", "AQAAAAEAACcQAAAAEADiVCpy6ujyMLjdt5LqH0Gqxpxw9pgQOncIHvEmS7poyKlZflhkrJoQ8zoNQWkDeQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 200, DateTimeKind.Local).AddTicks(8429), "5cceda97-bb30-415e-9fb9-315a2ad6c33a", "AQAAAAEAACcQAAAAEFQn+CUd0Ho2gDe6B1HsCztsAKrClWeRO/lTJ4ur1+zHrSJf7Il38+owGN67igg5QA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 208, DateTimeKind.Local).AddTicks(9192), "0a877671-4f01-4b31-a6fc-a57c237cbc14", "AQAAAAEAACcQAAAAEIoj1zOL6EBJ2QT1KPgHgdKbM/BodeVaP+MtiTjqVHtWD6u/DS+Vb6Gz9FrXqZDiZA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 216, DateTimeKind.Local).AddTicks(8438), "ca95af3a-0f0c-47fa-a880-804a490d37bc", "AQAAAAEAACcQAAAAENZfFjpCzu1bwLyQNOLDxjX2B1LJbrwl1F4oPqLvwyDk0OWp6dq0LNa4x3vzeYAz9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 224, DateTimeKind.Local).AddTicks(6173), "a74e0765-f93e-428e-8906-4abdcb8c16e4", "AQAAAAEAACcQAAAAEGnSRo3DrgU0+cHH7OnLgIDr5rx6jmhmYtKIkC166r1FHRiefo2MKdGS2LCMN7cpgg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 232, DateTimeKind.Local).AddTicks(5089), "008887fd-b090-4c48-bc1a-36ac96f43320", "AQAAAAEAACcQAAAAEFIjLmzEyW5fTg8P4Omej7SEsFUUoKs9NhEdy3f0EKrqqH5fMt5TUg3723O4KtYL5g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 240, DateTimeKind.Local).AddTicks(8172), "b2163bc2-0b84-488a-9f58-c4bf268259b9", "AQAAAAEAACcQAAAAEI2PTzDxIWeD8hZOFXLlE7/nnV8m6tI0t+XBNsmC7fWS9FuLn0aqY7PuSWQT5ulU4w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 248, DateTimeKind.Local).AddTicks(9916), "e6132a14-29ce-4f02-b12e-b33b82381034", "AQAAAAEAACcQAAAAEH/7rwgRPTv7HsZPoPWVBMSlbocuMIsl5bLlEhM5i5u+B71g4xBObH24i6GwrIGZNA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 257, DateTimeKind.Local).AddTicks(1209), "e7f2fbe2-c1c5-411a-b6b1-f837db654a22", "AQAAAAEAACcQAAAAEGUGJfBUkE/uWrWLF5g9jJc196WJgretg9s/sD0Q2zmzclbUrc/wKkx077buZb52tQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 265, DateTimeKind.Local).AddTicks(612), "d575db21-f793-48d5-a415-8b2c9f06241a", "AQAAAAEAACcQAAAAEFdLUh+sDfiRiHV0VsZZ+d76RryG8BcWbC5ErZCAWCOAyX/DteNr4TEaISVz15ciFQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 273, DateTimeKind.Local).AddTicks(4211), "18177b89-3032-4dab-ba2d-e52760b1face", "AQAAAAEAACcQAAAAEOezcRhCTorhJVlggNMIBE1/L1w0U19a6EmnyP62nhzszTbAoVGMVoOzw0zOzB+M2A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 281, DateTimeKind.Local).AddTicks(3821), "c14e768b-8666-4f62-b0a7-30d0e8b83d34", "AQAAAAEAACcQAAAAEAot9j7m4Zuf5vSRPpxZwO7bLybP41auKJ4YqM82+GdeqkpVG2cr9H8hm+/OwDe+Mg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 321, DateTimeKind.Local).AddTicks(6329), "c2f794df-84d9-4ed0-ae3e-6d14f72ae514", "AQAAAAEAACcQAAAAEKZX0SpYLGWsNz4iJXDnaXmymcSDu6aouzEibB0dsXN49KHdizQvo7/2XYCoLZBfwA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 313, DateTimeKind.Local).AddTicks(2613), "f9dbd18e-827b-4ac8-90d6-7ae88d8bb08c", "AQAAAAEAACcQAAAAEJQFtgPPZXWwWnP/1wMkPres2X/pXEsS7m/NRdhLnkK1HitKYnqqlHSv7E5hRUqyHQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 329, DateTimeKind.Local).AddTicks(4639), "d300fd17-438e-4c9c-a774-67fcca12fda6", "AQAAAAEAACcQAAAAEB6EEFLlPH+F9xoJcd7V4HfXVD7e4qWojtmB2eltVwPpDhPrzHvguBzdhVSAN8O1EQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 356, DateTimeKind.Local).AddTicks(3691), "ff1bd513-c022-4276-b343-2215495b048e", "AQAAAAEAACcQAAAAEK0R4cZgsO4Y4TdPCpFXVhH22wGOQn82kSiN/+pESsq2KasNQYjjYIUmPKxAWL8DuQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 297, DateTimeKind.Local).AddTicks(2377), "acfc1108-b838-4951-9172-a210572d132c", "AQAAAAEAACcQAAAAEO02eM54FnwI1wWAa+stRhZhnv0WTwsUwSRcfqpxSmzZt8e3MZd9sxu00Ct9ATEYyw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 305, DateTimeKind.Local).AddTicks(3609), "4e4129e7-050c-4ada-a2bf-3b631234d1a9", "AQAAAAEAACcQAAAAEJoN+pA5oxvC6d0mF4hWQS3DVaoff/fkhnd7OgQ25i9bzOmPFZoHWaGxO0KxYYr8/g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 337, DateTimeKind.Local).AddTicks(5328), "bbceb7e5-8a8e-45d6-9582-3618c0748376", "AQAAAAEAACcQAAAAEKHYUGNjFtyv3zvpklLMYyNEDEn2ITbf/n4ya30aHH93K3y/+qJw6MUR3Gg1crzG7w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 22, 13, 28, 289, DateTimeKind.Local).AddTicks(4227), "a0a257ae-d777-483e-b10c-9f9c583d880c", "AQAAAAEAACcQAAAAELgZC7403KLOKwTNFSWTMsqJB6/j9jqKxsKdpAuLbK2R8MEPLUEv0f4J1uPhQ4XuNA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -2, "11BD711F-9506-45BA-B5B7-F00649BE00DE" });

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumns: new[] { "Id", "ProductId", "UserId" },
                keyValues: new object[] { 1, -1, "11BD711F-9506-45BA-B5B7-F00649BE00DE" });

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 24, 16, 53, 24, 198, DateTimeKind.Local).AddTicks(4238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 24, 22, 13, 28, 81, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 24, 16, 53, 24, 263, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 24, 16, 53, 24, 263, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 24, 16, 53, 24, 262, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 24, 16, 53, 24, 263, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "fb933b6c-5410-47f7-ae93-f7b57d533b00");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "71a0a34c-efef-42ae-969f-83fe38f95ca2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "5c83788e-4c62-48ed-a129-78c03aa22c64");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "ac3a56a1-c574-48ab-ba6d-3aa252de272e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 731, DateTimeKind.Local).AddTicks(6188), "5b2b1b21-4334-48ff-bf4e-79004b74d87b", "AQAAAAEAACcQAAAAEGSEzii7+8pB+UR3ywnenj8jv5aAfwSzQODv7tDzo23GExaMq6CV5hgyHI219Ygg/A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 282, DateTimeKind.Local).AddTicks(5836), "58ce5305-eb04-431f-a2ae-828a270a3564", "AQAAAAEAACcQAAAAEPmNkoWfIgMz2nFhb8W2VMQjthO+q06oQpv2WR+v1CkrtYziaJGHB4xHpBYAK9pZDg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 298, DateTimeKind.Local).AddTicks(603), "c27eb6ba-e261-43e9-8d89-1432ae1b9bde", "AQAAAAEAACcQAAAAEBxTdizyIu8FPkbydpJc/oU/fOF4SKdwc5C9hd25k+sKs+/9hanu+G2zBowdBEEuRg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 313, DateTimeKind.Local).AddTicks(7198), "669c57c5-aead-4e5e-ac7f-d49cd2d7fe39", "AQAAAAEAACcQAAAAEEMoGPL1mvFpodYh7DDv7G+fH0mV0ATOoBlYPN1jrQv3eQiUtSJiGvIBO2nz9NBybw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 328, DateTimeKind.Local).AddTicks(8197), "576c3981-9fa7-4893-ade5-8b1896600003", "AQAAAAEAACcQAAAAECaQRRFw0nwIdinwb79Xskm6Va3d9LIPJfKal6G0b1KY/Q0mRE7NkLB1d+l4sOBHTg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 346, DateTimeKind.Local).AddTicks(3319), "f1436f0a-40a1-434a-81a6-ce72f2381d33", "AQAAAAEAACcQAAAAEPnFCP6TCzKRY8xQNJDWfaTbsgJ85F0T+X1oCyfhA4VYOPsehycdxeZaw58mYfgiLQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 361, DateTimeKind.Local).AddTicks(6099), "7557a816-95f7-4ade-ad83-e96576ff11d6", "AQAAAAEAACcQAAAAEOSyjpGb7Ci1AtPNhU9QuMPSeHJwVeZSV5IdyAj8csTw49DbkPnxBisUlolFQfV0ug==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 380, DateTimeKind.Local).AddTicks(603), "4e91f12d-a335-40bb-ba9c-ee1d34086a1e", "AQAAAAEAACcQAAAAEHViQaI2OP8IBJZWckkrnHuevnUNAiuQ1Gcis+vIJ2D84/yi7K4Q6PNEjh7VqOgoMQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 395, DateTimeKind.Local).AddTicks(8056), "bcd8f243-0442-4d02-87d1-27851d7966e7", "AQAAAAEAACcQAAAAEH63Rv4o6fkCtzeTJfAsECTVVjX+MGxA35TI+DK+/3lBjNJ4vsTpt3AyyKU8ZFi8GQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 410, DateTimeKind.Local).AddTicks(5036), "931660e9-042f-4b68-9aad-a7a7a7699b47", "AQAAAAEAACcQAAAAEBIFr5q3EXgaP5uEFlgoFyVYkd0XMoqyVqLj6y8DaL9irw2GqM8pNdE4FXJfLTYp/w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 427, DateTimeKind.Local).AddTicks(2265), "4c48518d-aef1-4045-bb3c-05c5e1e2219c", "AQAAAAEAACcQAAAAECV0xBLXBkZBntZ29wzFgK7W0Rp/RHg5c2HEAeXRIMr7xoNeEAfrlQHEX6NF/tf8ew==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 442, DateTimeKind.Local).AddTicks(4221), "2c5097e0-c563-4981-99f9-fd9102a3d62f", "AQAAAAEAACcQAAAAEKZbcjJYrw34BXO+l62iWEENRY5KA3FbQC1f1U8now7k/brHilUs7EFy2f1Wp0c9iA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 452, DateTimeKind.Local).AddTicks(8023), "0d9bfd96-1594-4c3d-9539-e3bb0cb25ae7", "AQAAAAEAACcQAAAAEET86X3DGO7CWQP8/FPJZbgoWuQfbXZeMrSdu6bY97eYOXNUCw+UOB3mXIp7sH3S9Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 466, DateTimeKind.Local).AddTicks(4235), "74969d0f-b674-4d43-a965-00f3798316ea", "AQAAAAEAACcQAAAAEGXSEkjoiPbc7mF+dXjFuhRLlOrODTRET5qj1PfqUIGdiSnJ4J4+IurdT4jUOiuJjw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 480, DateTimeKind.Local).AddTicks(4325), "319fb0d3-f0ce-4ad8-ad5b-4d008d951aee", "AQAAAAEAACcQAAAAEPR+NjxapKXyrtlAYKTLWWrNVYA4ghARWXjd4BDY2Zb+/ACRM1RamDFkxPWxd8UGcg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 496, DateTimeKind.Local).AddTicks(5437), "55654be9-477b-46c3-801d-73e6505fca3a", "AQAAAAEAACcQAAAAEG65F8w+f8YRFPsrQfc79VM9O+kF8gQPftBSM6ia+yYXN5qSMT6DVIgWJAG1/6oiXg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 511, DateTimeKind.Local).AddTicks(3562), "a7e7a026-d094-47ed-8bd8-1616557f1acb", "AQAAAAEAACcQAAAAEPOO9gI1kXc+cyk4X9DSVcHQ7vEEU/DWk7JQqM5qUA6AR4nW3CrwFJpIFjqiNsX8Hg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 532, DateTimeKind.Local).AddTicks(17), "1f0414d7-97dc-4068-9c07-52d4270f59d2", "AQAAAAEAACcQAAAAEG0aEJv1DNRoWcKHNjQ2jHcB7nocJKlaNKf8h0hVntsfc6MmA2FLLVV5RxGWuEwLyg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 550, DateTimeKind.Local).AddTicks(696), "272b6c83-3507-4a6f-ac8f-9a804e854b3a", "AQAAAAEAACcQAAAAEI/ZibbAdgKXI1pOmUvnISWS6TDBEFAOB9IepaHBq1Vmg4vcsCEbiyinN3oj7vhn5A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 566, DateTimeKind.Local).AddTicks(5517), "f082c666-5e94-41f8-9231-b9f518191a26", "AQAAAAEAACcQAAAAEP+qcN8NsUsBtLUDL1fzv9v3cPEVY81UIiZu23pyksfiGYo6jCRvV7JeXeHAOjJCKg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 582, DateTimeKind.Local).AddTicks(7430), "6faa8135-0a9b-443c-ad09-e2dee3217895", "AQAAAAEAACcQAAAAEB8Q5Ex8e0pkUFQpDoilSllwQwhR23I0MIrXj60ZJ4dT1WAq5GV4d4aBnUXNqbTPpg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 679, DateTimeKind.Local).AddTicks(1436), "74ad7e81-9158-46da-879b-aafdbc46a2c8", "AQAAAAEAACcQAAAAEJtrL04Xg6tEatAlLBsNrJtvCJOFtKP4N2/sq2hMZcpoBPN5UGX2quvW51T9ODP4kA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 660, DateTimeKind.Local).AddTicks(9978), "11a3c9e7-17e8-45af-b1eb-3b57220537f0", "AQAAAAEAACcQAAAAEJYeeoCu5uza2K4RaagOy9adMunwgOaeUYfvo2NpCmd4Ff2oACh8aMYf+mjAIxyqzw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 696, DateTimeKind.Local).AddTicks(4020), "dffc644c-175a-4040-82e9-c1000e739764", "AQAAAAEAACcQAAAAEMpp1loPRBAFWQimvIWA8CevdzNmPrY4ZqRncNdMObA9FEMPMBes2SpCjwszbqtyaw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 748, DateTimeKind.Local).AddTicks(188), "ffa12d44-f60a-48bb-9d64-78defab2b7bf", "AQAAAAEAACcQAAAAENQQ5pYn3XSWYHqDNLRjw8osEb5gHDAuFBAEcP14L5bAGzzGQSi+an0Und7QNzuePA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 625, DateTimeKind.Local).AddTicks(2960), "5b5a812f-f6f4-4604-8576-7530c605fee1", "AQAAAAEAACcQAAAAEGOYg59Hi5hhf/0TrlSMoH7hpS09lGfYzkHUi39DE20RDHdQ1OmvEHYEawZ03TC5Uw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 640, DateTimeKind.Local).AddTicks(9308), "9f8ddd4d-39c7-4d60-8a49-9860335d2325", "AQAAAAEAACcQAAAAEI/Xe7DXZMDCHRPhy49CUmOb4piL5HSnsAT4lByK25rQBagj+ciohukx3eqdV6oSNw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 714, DateTimeKind.Local).AddTicks(94), "f4ec68f7-15bf-48c4-b37e-ea36ab1096a3", "AQAAAAEAACcQAAAAEB23v279XaXrrv1vrJa08ro0Lv79r+WInhdLt4WZCY0YzCyHmm/Kbc7iLPC8ObhMmg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 24, 16, 53, 24, 600, DateTimeKind.Local).AddTicks(2076), "b49bad58-9186-468b-8fa2-200983aa45bf", "AQAAAAEAACcQAAAAEGWUuHvwANC3+e/CogtVO613zf2vKnyyh9CuEpiz4W6L/n/f7iSe1OhI0EX9SKr+zQ==" });
        }
    }
}
