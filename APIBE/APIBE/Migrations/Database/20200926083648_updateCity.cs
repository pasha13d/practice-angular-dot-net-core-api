using Microsoft.EntityFrameworkCore.Migrations;

namespace APIBE.Migrations.Database
{
    public partial class updateCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_State_stateId",
                table: "City");

            migrationBuilder.RenameColumn(
                name: "stateId",
                table: "City",
                newName: "StateId");

            migrationBuilder.RenameIndex(
                name: "IX_City_stateId",
                table: "City",
                newName: "IX_City_StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_State_StateId",
                table: "City",
                column: "StateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_State_StateId",
                table: "City");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "City",
                newName: "stateId");

            migrationBuilder.RenameIndex(
                name: "IX_City_StateId",
                table: "City",
                newName: "IX_City_stateId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_State_stateId",
                table: "City",
                column: "stateId",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
