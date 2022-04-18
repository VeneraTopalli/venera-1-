using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCandidates",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gender = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    nationality = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    driverLicense = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    bloodGroup = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCandidates", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DCandidates");
        }
    }
}
