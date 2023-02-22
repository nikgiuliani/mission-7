using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCSharp6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    movieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<ushort>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true),
                    categoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.movieId);
                    table.ForeignKey(
                        name: "FK_Responses_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[] { 1, "comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[] { 2, "drama" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[] { 3, "action/adventure" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[] { 4, "romance" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[] { 5, "historical fiction" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[] { 6, "history" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[] { 7, "documentary" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movieId", "categoryId", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, 1, "John Lasseter", false, null, "super emotional", "G", "Cars 2", (ushort)2011 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movieId", "categoryId", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, 2, "Tom McGrath", false, null, "greatest movie ever made", "PG", "Megamind", (ushort)2010 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movieId", "categoryId", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, 5, "Steven Spielberg", false, null, "wow", "R", "Saving Private Ryan", (ushort)1998 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_categoryId",
                table: "Responses",
                column: "categoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
