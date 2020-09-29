using Microsoft.EntityFrameworkCore.Migrations;

namespace APIBE.Migrations.Login
{
    public partial class addAuthId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthValue",
                table: "Login",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthValue",
                table: "Login");
        }
    }
}
