using Microsoft.EntityFrameworkCore.Migrations;

namespace APIBE.Migrations.Database
{
    public partial class DeleteFKOnFloor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Floor_Company_ConpanyId",
                table: "Floor");

            migrationBuilder.DropIndex(
                name: "IX_Floor_ConpanyId",
                table: "Floor");

            migrationBuilder.DropColumn(
                name: "ConpanyId",
                table: "Floor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConpanyId",
                table: "Floor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Floor_ConpanyId",
                table: "Floor",
                column: "ConpanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Floor_Company_ConpanyId",
                table: "Floor",
                column: "ConpanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
