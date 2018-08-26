using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNetCoreLessons.Migrations
{
    public partial class PersonalLibraryRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalLibraryBooks",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    LibraryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalLibraryBooks", x => new { x.BookId, x.LibraryId });
                    table.ForeignKey(
                        name: "FK_PersonalLibraryBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalLibraryBooks_PersonalLibraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "PersonalLibraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalLibraryBooks_LibraryId",
                table: "PersonalLibraryBooks",
                column: "LibraryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalLibraryBooks");
        }
    }
}
