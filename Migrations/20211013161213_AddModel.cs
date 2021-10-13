using Microsoft.EntityFrameworkCore.Migrations;

namespace CancionesWebAPI.Prueba.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cancion",
                columns: table => new
                {
                    CancionID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lyrics = table.Column<string>(type: "nvarchar(max)", maxLength: 90000, nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancion", x => x.CancionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cancion");
        }
    }
}
