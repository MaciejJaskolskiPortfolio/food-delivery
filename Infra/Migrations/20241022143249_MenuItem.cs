using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class MenuItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItemCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MenuItemId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItemCategory_MenuItem_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItemOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    MenuItemCategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItemOption_MenuItemCategory_MenuItemCategoryId",
                        column: x => x.MenuItemCategoryId,
                        principalTable: "MenuItemCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "7997", "New Nicholas", "83673", "46187-1997", "DuBuque Rapid" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "180", "Reichertmouth", "7777", "82272", "Monahan Views" });

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
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { null, "73844", "Maudeborough", "99428", "16223-0267", "Isidro Grove" });

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

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "RestaurantId", "Street" },
                values: new object[] { 11, "impactful", "09335", "West Edisonstad", "3807", "10826-6231", null, "Rhett Island" });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemCategory_MenuItemId",
                table: "MenuItemCategory",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemOption_MenuItemCategoryId",
                table: "MenuItemOption",
                column: "MenuItemCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItemOption");

            migrationBuilder.DropTable(
                name: "MenuItemCategory");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "users", "68966", "Howeland", "6436", "04448", "Wilkinson Vista" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "redundant", "1053", "South Marcia", "2792", "32556", "Taya Bridge" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "4329", "North Altaberg", "9786", "75046", "Adams Fort" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "954", "Hoppehaven", "884", "84099-5142", "Zakary Forges" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Grocery & Beauty", "91693", "Port Albertha", "27780", "35156", "Lilla Route" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "implement", "0314", "Whitneybury", "59857", "99621-3705", "Dare Pine" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "Knoll", "7677", "Lake Darionview", "803", "92200-4650", "Kaylee Passage" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "actuating", "719", "Danfort", "470", "24558", "Boyle Ports" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "transparent", "9166", "Rolfsonbury", "37801", "77315", "Krajcik Curve" });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "AdditionalInfo", "ApartmentNumber", "City", "HouseNumber", "PostalCode", "RestaurantId", "Street" },
                values: new object[] { 1, null, "6242", "Vandervortchester", "1714", "76621", null, "Kiehn Islands" });
        }
    }
}
