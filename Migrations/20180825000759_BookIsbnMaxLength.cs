using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNetCoreLessons.Migrations
{
    public partial class BookIsbnMaxLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Books",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Books",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);
        }
    }
}
