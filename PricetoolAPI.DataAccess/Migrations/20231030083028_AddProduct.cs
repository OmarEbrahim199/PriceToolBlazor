using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PricetoolAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 19193614);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 35971657);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 12552824);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 19665213);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 29972527);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 54399873);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 55459288);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 59698292);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 65919724);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 83892814);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 92296475);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 93336309);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 41188917);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 46336909);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 52920408);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 64007232);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 67090884);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 86862377);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 88997282);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 99423086);

            migrationBuilder.InsertData(
                table: "Corporates",
                columns: new[] { "Cvr", "Address", "Name" },
                values: new object[,]
                {
                    { 14439489, "64699 Kamren Islands, Mabelleborough, Mauritania", "Littel, Schultz and Carroll" },
                    { 27871536, "28528 Daniela Roads, New Rosalindaborough, Jamaica", "Torphy, Jacobi and McLaughlin" },
                    { 35710475, "4422 Davonte Lake, North Keltonborough, Philippines", "Hand, Bauch and Greenholt" },
                    { 59897910, "63950 Diamond Alley, New Arjun, Andorra", "O'Conner, Zemlak and Herzog" },
                    { 68075510, "7291 Rau Walks, New Jordaneberg, Central African Republic", "Hamill, Douglas and Bergnaum" },
                    { 70711494, "7612 Mante Camp, Reichelhaven, Saint Helena", "Gibson, Abbott and Reynolds" },
                    { 78740224, "829 Vanessa Squares, Isaiahstad, Bolivia", "Metz LLC" },
                    { 89733793, "2675 Welch Crescent, Moenfort, Swaziland", "Kemmer LLC" },
                    { 91592737, "7993 Cummerata Ranch, South Felton, Cuba", "Murphy - Casper" },
                    { 97686971, "861 Stamm Trail, East Nico, Australia", "Hettinger Inc" }
                });

            migrationBuilder.InsertData(
                table: "Subsidiary",
                columns: new[] { "Cvr", "Address", "Name", "ParentCorporateCvr" },
                values: new object[,]
                {
                    { 17074996, "736 Alejandrin Glen, Cassinville, Mauritius", "Brekke, Blanda and Wilderman", 89733793 },
                    { 24635605, "41538 Kozey Unions, Chandlerberg, Antarctica (the territory South of 60 deg S)", "Kshlerin LLC", 78740224 },
                    { 25771257, "600 Cleora Squares, East Manuelaview, Bahamas", "Ferry Inc", 70711494 },
                    { 30918898, "80689 Maegan Loop, Opheliachester, Tunisia", "Batz, Gleichner and Kovacek", 70711494 },
                    { 60729582, "994 D'Amore Causeway, Hermistonmouth, Thailand", "Bergstrom LLC", 78740224 },
                    { 64152329, "37737 Erna Throughway, Runolfsdottirton, Timor-Leste", "Donnelly - Zemlak", 70711494 },
                    { 72347268, "76677 Elton Parkways, Brannonview, Saudi Arabia", "Dach, Kub and Pacocha", 59897910 },
                    { 87590755, "6156 Jack Ford, Goldnerton, Pakistan", "Runolfsson - Gutkowski", 35710475 },
                    { 91173819, "993 Alexys Fork, Waelchibury, Monaco", "Wolff LLC", 97686971 },
                    { 97262314, "52041 Howell Street, Port Frankchester, Thailand", "Schinner Inc", 27871536 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Name", "Principal", "SubsidiaryCvr", "Type" },
                values: new object[,]
                {
                    { 60, "Practical Frozen Salad", 9911.696248266970000m, 72347268, "Incredible" },
                    { 61, "Awesome Wooden Gloves", 9890.429162391580000m, 60729582, "Ergonomic" },
                    { 62, "Sleek Plastic Salad", 3801.109548321570000m, 17074996, "Fantastic" },
                    { 63, "Licensed Granite Computer", 1493.716253703210000m, 30918898, "Small" },
                    { 64, "Handcrafted Wooden Hat", 2203.463937814440000m, 91173819, "Gorgeous" },
                    { 65, "Practical Wooden Cheese", 461.7082550304620000m, 87590755, "Awesome" },
                    { 66, "Unbranded Fresh Bacon", 3365.204321099990000m, 60729582, "Handmade" },
                    { 67, "Handmade Metal Chips", 7447.783491841160000m, 60729582, "Ergonomic" },
                    { 68, "Gorgeous Concrete Shirt", 8872.024006907140000m, 60729582, "Small" },
                    { 69, "Gorgeous Cotton Hat", 1375.491080924210000m, 24635605, "Sleek" },
                    { 70, "Tasty Fresh Table", 5584.458392295560000m, 60729582, "Licensed" },
                    { 71, "Intelligent Metal Sausages", 5319.42541295850000m, 64152329, "Fantastic" },
                    { 72, "Rustic Metal Fish", 6226.400114628810000m, 97262314, "Refined" },
                    { 73, "Licensed Metal Chair", 1932.197753752340000m, 87590755, "Handcrafted" },
                    { 74, "Tasty Metal Hat", 3271.503882979860000m, 30918898, "Incredible" },
                    { 75, "Gorgeous Concrete Computer", 470.2707225333950000m, 30918898, "Sleek" },
                    { 76, "Licensed Metal Towels", 6839.88369291220000m, 60729582, "Sleek" },
                    { 77, "Handcrafted Plastic Fish", 9259.340255794540000m, 64152329, "Awesome" },
                    { 78, "Refined Steel Fish", 1317.239242025130000m, 97262314, "Tasty" },
                    { 79, "Incredible Soft Hat", 7600.10268325080000m, 97262314, "Refined" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 14439489);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 68075510);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 91592737);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 25771257);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 17074996);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 24635605);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 30918898);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 60729582);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 64152329);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 72347268);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 87590755);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 91173819);

            migrationBuilder.DeleteData(
                table: "Subsidiary",
                keyColumn: "Cvr",
                keyValue: 97262314);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 27871536);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 35710475);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 59897910);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 70711494);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 78740224);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 89733793);

            migrationBuilder.DeleteData(
                table: "Corporates",
                keyColumn: "Cvr",
                keyValue: 97686971);

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
        }
    }
}
