using Microsoft.EntityFrameworkCore.Migrations;

namespace NetdLab5.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    carID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<int>(type: "int", nullable: false),
                    kilometers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.carID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
