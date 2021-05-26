using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class modifyConstraininCartEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 24, 16, 53, 24, 198, DateTimeKind.Local).AddTicks(4238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 11, 15, 12, 41, 878, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                columns: new[] { "Id", "ProductId", "UserId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 11, 15, 12, 41, 878, DateTimeKind.Local).AddTicks(4619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 24, 16, 53, 24, 198, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 15, 12, 41, 925, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 15, 12, 41, 925, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 15, 12, 41, 925, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 5, 11, 15, 12, 41, 925, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "26bfb4e3-d69d-442b-affc-0a8d514fe97f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                column: "ConcurrencyStamp",
                value: "67132fb9-6738-4946-84e7-0c33bd7506e7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "d43c0ea4-74ff-4c74-a863-a1412f474268");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                column: "ConcurrencyStamp",
                value: "3fcf5bea-fb4a-4276-9c4d-9a43c36727e0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 296, DateTimeKind.Local).AddTicks(5128), "7bad66c3-c5d1-4c71-b573-c1c6aae8169d", "AQAAAAEAACcQAAAAEBlaBwiQ3AEOlvz5GCunfV7/R36t8XGbiBNY0/70tN4WOvcSdfioKIlQ+8VPMqe/eg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 947, DateTimeKind.Local).AddTicks(7873), "7e74dc2c-9aac-4073-8c67-34776d4e6dfe", "AQAAAAEAACcQAAAAEMi5Tt9DBNk2AzlUslop/GRglbbS9zPmPCeDsXTM3cZdt99i3RuHtsXfNmFbsEk9mg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 961, DateTimeKind.Local).AddTicks(2141), "dfbed6e2-2cbc-4f21-816d-e9498ad5e8cc", "AQAAAAEAACcQAAAAELU+dUgEZXniT4JIH3v3VOP4WtBcggrPyoe8VWAuTEpVgQYvjH6E9LQDH9GymvrefA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 975, DateTimeKind.Local).AddTicks(643), "894c452d-f75d-4dbf-ab45-525713eb8418", "AQAAAAEAACcQAAAAEKaDDQZovPAQecAzn/s6xhoztXUw8GpWI0GrU5MCfK600cjX6iCSHWdDOsje3IAFGw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 987, DateTimeKind.Local).AddTicks(582), "b9b66388-1d1e-4397-a326-1427452a7899", "AQAAAAEAACcQAAAAEJCugtL508cqnxC/PjrjISbzUYXzRh7+Mb/WESXDkr39zz8D3wZA1ojxwZuxS07Tgw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 41, 998, DateTimeKind.Local).AddTicks(2106), "2ca1672d-c8db-4da7-952b-2ecc635f6f22", "AQAAAAEAACcQAAAAEIFwfZicxMLXKPItK3NPTncwtgLr3iazwhyxDJbBJDZ9sQk+9DsTNTQEy518xfv6vQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 10, DateTimeKind.Local).AddTicks(2333), "318b0803-e5e6-495f-aa6a-b2c3983a528b", "AQAAAAEAACcQAAAAEMvwQW+ZJ/k5Iv/XLdXhhOuNY6rjg+qMsDpbUzqKnIzZN9m7HAw97EMgfuYxt071eQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 25, DateTimeKind.Local).AddTicks(1743), "e523cfda-1102-45ac-9ec6-ac808e8d416a", "AQAAAAEAACcQAAAAEBcFG1CEaCK2u8XfMGaUkUC8Mq9Pvc8CdDRvS9vcrpqEMGEL8jM/zog1ZJBRJpjRmg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 38, DateTimeKind.Local).AddTicks(6544), "712b7d8b-ddc6-4bef-801f-fe9e70d88d24", "AQAAAAEAACcQAAAAEFTCoqC2C1PxqXjG9NtBrxkIb+w+FONfvtkfKU67cOoHfc6NzWQVh+AewX40Ci64vg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 51, DateTimeKind.Local).AddTicks(3934), "593b9798-18df-4767-9a4a-b40c32732765", "AQAAAAEAACcQAAAAECoVmnFccmtWHsXRU/2PEMbQpjmwd5znFIjUdw/S3cWWYmzs7hO8zzSvD9uDMjh21w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10BD711F-9576-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 67, DateTimeKind.Local).AddTicks(9150), "d3afa44e-ac0b-47e9-a9aa-0d4063f0f911", "AQAAAAEAACcQAAAAEFpdqrtd4GAwQ6/YgtZJ0gc9oNzbPagHUI9LmrqKtb4mhvWR1g0GPec8j/3fxSBoSg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 82, DateTimeKind.Local).AddTicks(1643), "e780f2c0-f226-4fa5-bbd1-3284b7e995d3", "AQAAAAEAACcQAAAAEFChYst4u9zPYVzb/tDsF6cqt0LUGQXi9IqB37aR8kKq1fvt/WGcCZPZdp0Ndl0pUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9516-45BA-B5B7-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 93, DateTimeKind.Local).AddTicks(6760), "bb0c9707-d405-4657-9baa-713eb3ba604b", "AQAAAAEAACcQAAAAEFChmoPy9Y9M+0N5NNDEhbfqJ4BVb9fmskSziCaJmzEgL3ls64WXOGPqh9JwNyLw8Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9526-45BA-B5B7-F00649BE02DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 107, DateTimeKind.Local).AddTicks(1019), "5c6bc3b7-db53-454f-a5e1-259e0981ee0b", "AQAAAAEAACcQAAAAEMJHtaBlCBkhm1y0aJn//Ao1c3QS782BLETKXmI+38D4RfTXFIYuPGv4gzXKb0VmAg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9536-45BA-B5B7-F00649BE03DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 116, DateTimeKind.Local).AddTicks(4505), "3d9105a7-7f11-4eca-8577-5b1396966bba", "AQAAAAEAACcQAAAAEMKvz0p13/1JFwi9dtoz9+omahFJrmI1lB8FWu0TA8Scmx7pH0JAtEOqEJ/zydvblA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9546-45BA-B5B7-F00649BE04DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 129, DateTimeKind.Local).AddTicks(766), "d11a475e-0729-4654-bd41-5a3fd8a7b9a7", "AQAAAAEAACcQAAAAELHjGP1d4+zh4QdssOpex5+P89Q8S3uQ9PMV2O9jmkWVv1mRKVV6ZNw6OullxeZItw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9556-45BA-B5B7-F00649BE05DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 142, DateTimeKind.Local).AddTicks(8649), "e30c191b-08d7-4e7b-89fd-d987c2451203", "AQAAAAEAACcQAAAAEN1G0kaGm9GAMWYP6FvDo3l3Xm40eKfVPUoXCbGiX33ZIEb/aTHg7mqPTslehlmY0g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9566-45BA-B5B7-F00649BE06DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 155, DateTimeKind.Local).AddTicks(5615), "a9fb6446-1976-4162-873e-b8282bc84742", "AQAAAAEAACcQAAAAECFhvsI8hclukcfIxCwx5QWkc+inHbKG9wJnslgpDY5Zz7SiU9507gY6+m5tNqUPaw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9576-45BA-B5B7-F00649BE07DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 168, DateTimeKind.Local).AddTicks(8209), "bbe9064f-7c32-48a8-8970-d9f318456ca8", "AQAAAAEAACcQAAAAEJg49U9y/POOc6Vlk2ZkUbUQHAwu17A/M8vr/YrvON0xoV3SuyqJvkhU1r9Hvch7zQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9586-45BA-B5B7-F00649BE08DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 182, DateTimeKind.Local).AddTicks(4489), "459f3405-0a94-4438-9677-56a9a73bc485", "AQAAAAEAACcQAAAAEJKvZOXWGG1RU3/Z6M9RjPvijSHG2WhW9L538+A2Dfwd/T0PAbrxzWkadRmx2B/ifA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11BD711F-9596-45BA-B5B7-F00649BE09DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 197, DateTimeKind.Local).AddTicks(5983), "95702bbe-a1df-433b-aa9f-af0b31fe1439", "AQAAAAEAACcQAAAAEGWJIBFzoIOcHcz7CBrRm4gcRD6l8uBFh5OihtzGN0m+7KrexJkX46BrnqkwYZthDw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 258, DateTimeKind.Local).AddTicks(607), "cf21053a-3dcc-4979-af84-770be77d0e40", "AQAAAAEAACcQAAAAENruCC8n7eHVhAiydKVeOVznFp68Qm746VQpJidC4oV7mHf+Vh/yk0BFOIwrrUpoIg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 245, DateTimeKind.Local).AddTicks(9213), "cc875d28-1ed6-4e67-b47b-67bea50cdf60", "AQAAAAEAACcQAAAAEHoRWy0kBG9xAxZ/7uUPH+3jOBh8pN7lf50jelGgBRl/PQv++LO5fK6KBDsanfoVpg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 271, DateTimeKind.Local).AddTicks(477), "b6ffdabc-d12d-49ba-9052-f514fb7500b8", "AQAAAAEAACcQAAAAED4pXyrQPQ9qjxSeEEgcRW1CRpO2EMVDME1bUrMiNNu23+yazSqgL8T5H2rh3HC7mw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 307, DateTimeKind.Local).AddTicks(394), "e5453c71-5f33-4a62-ab4a-b21bbfc1f090", "AQAAAAEAACcQAAAAEGfDOT3tVPfS9XNzADY29v+LPxaEwFFE7K2L07nBzSI64n3IkqdHCWGbF7Qf8KO9jg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 219, DateTimeKind.Local).AddTicks(3783), "b2abf4ca-cad8-4894-8e86-b5f86ebea63e", "AQAAAAEAACcQAAAAEI2702GikctGg/EYGNXYFBX3uM15las+6xgdfGh2GINb0YBgULTe7I22IrhaXe8P9g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 232, DateTimeKind.Local).AddTicks(6131), "9e9232fb-9e55-4cac-9641-11aa053c71f0", "AQAAAAEAACcQAAAAEAw7eL4l59fqtkWnPFoKwpTMZni4Uk6TUtV7oGvJ0NX0ZpQGo/jXVOlOauvor7i2sg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 285, DateTimeKind.Local).AddTicks(3246), "5182edd8-b83f-47af-b3bd-b2fb3bf75a20", "AQAAAAEAACcQAAAAEKsI/kXZpZeH/RffR5xwqml4xfSAtjtpe//DNfTjD0e4h4Ow3eVmQ4v7xt7ceaJ1vA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                columns: new[] { "Birthday", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 12, 42, 209, DateTimeKind.Local).AddTicks(3251), "cfd10cf2-445a-403b-986d-076fdb9df02f", "AQAAAAEAACcQAAAAEGO8+z1sxJohvIW+No9cd6kIKITzgKcRTnhGToJYausaTHtpRGZXnnpl3bqpOXW/zg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
