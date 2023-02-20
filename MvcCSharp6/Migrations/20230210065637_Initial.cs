using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCSharp6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    movieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<ushort>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.movieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "drama", "John Lasseter", false, null, "super emotional", "G", "Cars 2", (ushort)2011 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "comedy", "Tom McGrath", false, null, "greatest movie ever made", "PG", "Megamind", (ushort)2010 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "action", "Steven Spielberg", false, null, "wow", "R", "Saving Private Ryan", (ushort)1998 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
