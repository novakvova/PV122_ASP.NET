using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShop.Migrations
{
    /// <inheritdoc />
    public partial class AddtabletblRealeStateComercials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblRealeStateComercials",
                columns: table => new
                {
                    RealeStateId = table.Column<int>(type: "integer", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRealeStateComercials", x => x.RealeStateId);
                    table.ForeignKey(
                        name: "FK_tblRealeStateComercials_tblRealeStates_RealeStateId",
                        column: x => x.RealeStateId,
                        principalTable: "tblRealeStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblRealeStateComercials");
        }
    }
}
