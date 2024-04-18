using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuoteAPI.Migrations
{
    /// <inheritdoc />
    public partial class QuoteMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    author = table.Column<string>(type: "TEXT", nullable: false),
                    tags = table.Column<string>(type: "TEXT", nullable: false),
                    quote = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
