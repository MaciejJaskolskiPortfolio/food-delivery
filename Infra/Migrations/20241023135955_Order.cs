using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Order : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    RestaurantId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MenuItemId = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_MenuItem_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderItemId = table.Column<int>(type: "integer", nullable: false),
                    MenuItemOptionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItemOption_MenuItemOption_MenuItemOptionId",
                        column: x => x.MenuItemOptionId,
                        principalTable: "MenuItemOption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItemOption_OrderItem_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Consultant", "0995", "Port Chasity", "40376", "00107-8969", "Tessie Grove" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "552", "Isomhaven", "756", "08853", "Welch Meadow" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Peru", "19593", "Rueckerberg", "4425", "24941", "Lockman Junctions" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Credit Card Account", "0711", "West Jaquelinebury", "4761", "09915-7995", "Metz Overpass" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "monitor", "23876", "North Beverlytown", "04542", "46094-3956", "Cormier Squares" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "3876", "Jammieland", "464", "29526", "Schulist Falls" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Wooden", "931", "Port Mario", "53117", "62454-2926", "Vicente Forges" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "global", "424", "Port Donnellshire", "25449", "87172", "Kassulke Tunnel" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "188", "New Tracyborough", "5473", "09681", "Efrain Corners" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "24 hour", "237", "Lake Delphine", "675", "83493", "Chester Terrace" });

            migrationBuilder.CreateIndex(
                name: "IX_Order_RestaurantId",
                table: "Order",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_MenuItemId",
                table: "OrderItem",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemOption_MenuItemOptionId",
                table: "OrderItemOption",
                column: "MenuItemOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemOption_OrderItemId",
                table: "OrderItemOption",
                column: "OrderItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItemOption");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Generic Concrete Computer", "5708", "South Guiseppeport", "9998", "07443-0261", "Breana Course" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Licensed Cotton Fish", "133", "Eunamouth", "24395", "18893", "Jalyn Row" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "7997", "New Nicholas", "83673", "46187-1997", "DuBuque Rapid" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "180", "Reichertmouth", "7777", "82272", "Monahan Views" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "683", "Kozeystad", "8767", "31475", "Bonnie Locks" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "73844", "Maudeborough", "99428", "16223-0267", "Isidro Grove" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "359", "Port Carole", "736", "87101-5413", "Helena Unions" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "29632", "Kleinmouth", "0084", "52809", "Mills Place" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Avon", "55704", "Spencerstad", "8126", "44505-9330", "Abagail Cape" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "impactful", "09335", "West Edisonstad", "3807", "10826-6231", "Rhett Island" });
        }
    }
}
