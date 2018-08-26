using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNetCoreLessons.Migrations
{
    public partial class AddContactStreetFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetNumber",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "StreetNumber",
                table: "Contacts");
        }
    }
}
