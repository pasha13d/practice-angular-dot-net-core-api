using Microsoft.EntityFrameworkCore.Migrations;

namespace APIBE.Migrations.Database
{
    public partial class AddCompanyWithFloor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Floor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloorName = table.Column<string>(nullable: true),
                    ConpanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floor_Company_ConpanyId",
                        column: x => x.ConpanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Floor_ConpanyId",
                table: "Floor",
                column: "ConpanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Floor");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
