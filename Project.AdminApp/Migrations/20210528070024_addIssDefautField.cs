using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.WebApp.Migrations
{
    public partial class addIssDefautField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 28, 14, 0, 17, 190, DateTimeKind.Local).AddTicks(9006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 27, 16, 39, 24, 521, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.AddColumn<bool>(
                name: "isDefault",
                table: "Addresses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressCardId",
                keyValue: 1,
                column: "isDefault",
                value: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDefault",
                table: "Addresses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastSignIn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 27, 16, 39, 24, 521, DateTimeKind.Local).AddTicks(5354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 28, 14, 0, 17, 190, DateTimeKind.Local).AddTicks(9006));

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
        }
    }
}
