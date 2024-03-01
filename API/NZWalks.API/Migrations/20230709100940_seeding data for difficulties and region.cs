using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class seedingdatafordifficultiesandregion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8bc052db-714a-4c2b-b26c-1106a8b98597"), "Hard" },
                    { new Guid("99006a6e-561a-4a87-9050-1c8992b89de0"), "Medium" },
                    { new Guid("e82b4d39-2e1e-472b-be59-25e19c099cb0"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("002a59c7-2dbc-4b67-94f4-234f0fce958d"), "RR", "Ranga reddy", "txt.jpg" },
                    { new Guid("24d71b13-414c-4c1c-b43b-6600ae26b793"), "Knr", "Karimnagar", "txt.jpg" },
                    { new Guid("9147610d-af6d-416e-8461-0837b6069e27"), "Wrg", "Warangal", "txt.jpg" },
                    { new Guid("c2fa540e-127b-48d3-bd17-9f45cbcfc4fc"), "Hyd", "Hyderabad", "txt.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("8bc052db-714a-4c2b-b26c-1106a8b98597"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("99006a6e-561a-4a87-9050-1c8992b89de0"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("e82b4d39-2e1e-472b-be59-25e19c099cb0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("002a59c7-2dbc-4b67-94f4-234f0fce958d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("24d71b13-414c-4c1c-b43b-6600ae26b793"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("9147610d-af6d-416e-8461-0837b6069e27"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c2fa540e-127b-48d3-bd17-9f45cbcfc4fc"));
        }
    }
}
