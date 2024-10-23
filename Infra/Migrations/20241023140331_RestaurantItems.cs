using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "MenuItem",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "785", "West Emmaleefurt", "979", "34389-4846", "Herminia Overpass" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "624", "Lake Lacey", "54392", "07693", "Alia Plain" });

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
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "61155", "Eileenshire", "41901", "32018", "Tyshawn Haven" });

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
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "37575", "Dickinsonbury", "801", "55166", "Jermain Loop" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "63807", "Gerholdside", "661", "94607-8902", "Buckridge Mountains" });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_RestaurantId",
                table: "MenuItem",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItem_Restaurant_RestaurantId",
                table: "MenuItem",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItem_Restaurant_RestaurantId",
                table: "MenuItem");

            migrationBuilder.DropIndex(
                name: "IX_MenuItem_RestaurantId",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "MenuItem");

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
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "552", "Isomhaven", "756", "08853", "Welch Meadow" });

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
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "3876", "Jammieland", "464", "29526", "Schulist Falls" });

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
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "188", "New Tracyborough", "5473", "09681", "Efrain Corners" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "24 hour", "237", "Lake Delphine", "675", "83493", "Chester Terrace" });
        }
    }
}
