using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PricetoolAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class idgenerator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Corporates",
                columns: table => new
                {
                    Cvr = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporates", x => x.Cvr);
                });

            migrationBuilder.CreateTable(
                name: "Subsidiary",
                columns: table => new
                {
                    Cvr = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCorporateCvr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subsidiary", x => x.Cvr);
                    table.ForeignKey(
                        name: "FK_Subsidiary_Corporates_ParentCorporateCvr",
                        column: x => x.ParentCorporateCvr,
                        principalTable: "Corporates",
                        principalColumn: "Cvr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Principal = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    SubsidiaryCvr = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Subsidiary_SubsidiaryCvr",
                        column: x => x.SubsidiaryCvr,
                        principalTable: "Subsidiary",
                        principalColumn: "Cvr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Corporates",
                columns: new[] { "Cvr", "Address", "Name" },
                values: new object[,]
                {
                    { 19193614, "8870 Mikayla Springs, Terryhaven, Montenegro", "Nienow Group" },
                    { 35971657, "661 Aimee Freeway, Port Thea, United States of America", "Herzog, Cremin and Tillman" },
                    { 41188917, "673 Dicki River, Cummingsstad, Dominica", "Bednar, Mills and Padberg" },
                    { 46336909, "234 Turcotte Center, Hintzview, San Marino", "Graham, Trantow and Welch" },
                    { 52920408, "19610 Heber Ranch, South Nick, Tunisia", "Green, Adams and Rath" },
                    { 64007232, "9650 Lily Union, Prosaccotown, China", "Upton, D'Amore and Collins" },
                    { 67090884, "90811 Rohan Villages, East Elliott, French Polynesia", "Towne - Spencer" },
                    { 86862377, "004 Kutch Mission, Port Larissamouth, Ireland", "Feil, Ryan and Ruecker" },
                    { 88997282, "812 Kenny Garden, New Daynafort, Canada", "Macejkovic Inc" },
                    { 99423086, "69923 Lehner Forks, Baileyborough, Sri Lanka", "Ankunding, Braun and Kutch" }
                });

            migrationBuilder.InsertData(
                table: "Subsidiary",
                columns: new[] { "Cvr", "Address", "Name", "ParentCorporateCvr" },
                values: new object[,]
                {
                    { 12552824, "796 Frami Lakes, Hickleland, Andorra", "Rosenbaum, Walter and Sawayn", 88997282 },
                    { 19665213, "5134 Camron Mall, West Marcelo, Tanzania", "Jacobs, Boehm and Kreiger", 99423086 },
                    { 29972527, "3304 Jacobson Spring, East Clementfort, Turks and Caicos Islands", "Jerde LLC", 86862377 },
                    { 54399873, "34260 Rolfson Club, Lake Clemensberg, Netherlands Antilles", "Rippin - O'Hara", 64007232 },
                    { 55459288, "8669 Schimmel Parkways, Lake Isomburgh, Gambia", "Reinger, Blanda and Bauch", 41188917 },
                    { 59698292, "93203 Beier Forges, New Lambert, Germany", "Stanton Group", 99423086 },
                    { 65919724, "3660 Marquis Meadows, Zoiemouth, Bouvet Island (Bouvetoya)", "Bernier, Haag and Barrows", 67090884 },
                    { 83892814, "0549 Vivianne Ferry, Croninbury, Brunei Darussalam", "Orn, Jast and Bernhard", 41188917 },
                    { 92296475, "3209 Kihn Prairie, North Viola, Lesotho", "Hyatt, Stokes and Rohan", 52920408 },
                    { 93336309, "400 Luna Station, North Nathanielburgh, Jamaica", "Jast, Wilkinson and Jacobson", 46336909 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubsidiaryCvr",
                table: "Product",
                column: "SubsidiaryCvr");

            migrationBuilder.CreateIndex(
                name: "IX_Subsidiary_ParentCorporateCvr",
                table: "Subsidiary",
                column: "ParentCorporateCvr");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Subsidiary");

            migrationBuilder.DropTable(
                name: "Corporates");
        }
    }
}
