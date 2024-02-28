using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetailShop.Migrations
{
    /// <inheritdoc />
    public partial class AddMiniatureTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mlist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameOne = table.Column<string>(type: "TEXT", nullable: false),
                    NameTwo = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mlist", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mlist");
        }
    }
}
