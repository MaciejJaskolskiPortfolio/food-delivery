using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class DeliveryAndClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Order",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryDriverId",
                table: "Order",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryDriver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryDriver", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "133", "Trinitychester", "2048", "41610", "Euna Port" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "green", "085", "North Dale", "357", "28738-7172", "Bette Mission" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "implement", "49794", "Lockmanview", "1710", "66821-5865", "Fidel Route" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "6111", "North Colemouth", "535", "54983-2225", "Clementine Port" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "synergy", "01092", "Monahanshire", "06306", "53928", "Berry Key" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Netherlands Antilles", "8159", "Isaacfort", "6779", "54762-3370", "Margarett Landing" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Steel", "44208", "Port Kaitlynchester", "096", "23585", "Johnson Motorway" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "stable", "317", "Lake Rasheedport", "278", "50424", "Donnelly Summit" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Argentina", "3024", "New Rowenaview", "946", "34961-7101", "Norwood Way" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "0903", "Trantowburgh", "921", "45820", "Marquis Park" });

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientId",
                table: "Order",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_DeliveryDriverId",
                table: "Order",
                column: "DeliveryDriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Client_ClientId",
                table: "Order",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_DeliveryDriver_DeliveryDriverId",
                table: "Order",
                column: "DeliveryDriverId",
                principalTable: "DeliveryDriver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Client_ClientId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_DeliveryDriver_DeliveryDriverId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "DeliveryDriver");

            migrationBuilder.DropIndex(
                name: "IX_Order_ClientId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_DeliveryDriverId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeliveryDriverId",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "785", "West Emmaleefurt", "979", "34389-4846", "Herminia Overpass" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "624", "Lake Lacey", "54392", "07693", "Alia Plain" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "1144", "Leonelmouth", "418", "37539-3748", "German Cove" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "61155", "Eileenshire", "41901", "32018", "Tyshawn Haven" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "withdrawal", "577", "Kelsishire", "855", "38620", "Hessel Road" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Investment Account", "038", "Hermistonburgh", "31196", "65677", "Ferne Canyon" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "318", "Feilview", "1381", "53563-4949", "Libby Springs" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Automotive", "427", "East Penelope", "04795", "92816", "Mante Fork" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "37575", "Dickinsonbury", "801", "55166", "Jermain Loop" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "63807", "Gerholdside", "661", "94607-8902", "Buckridge Mountains" });
        }
    }
}
