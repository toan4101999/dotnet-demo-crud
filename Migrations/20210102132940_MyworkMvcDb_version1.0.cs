using Microsoft.EntityFrameworkCore.Migrations;

namespace MyworkMvc.Migrations
{
    public partial class MyworkMvcDb_version10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imageCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
