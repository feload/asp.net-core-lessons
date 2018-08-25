using Microsoft.EntityFrameworkCore.Migrations;

namespace asp.netcorelessons.Migrations
{
    public partial class BookISBNUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "UniqueIsbn",
                table: "Books",
                column: "Isbn",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UniqueIsbn",
                table: "Books");
        }
    }
}
