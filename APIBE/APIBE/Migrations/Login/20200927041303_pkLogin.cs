using Microsoft.EntityFrameworkCore.Migrations;

namespace APIBE.Migrations.Login
{
    public partial class pkLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_login",
                table: "login");

            migrationBuilder.DropColumn(
                name: "LoginId",
                table: "login");

            migrationBuilder.RenameTable(
                name: "login",
                newName: "Login");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Login",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Login");

            migrationBuilder.RenameTable(
                name: "Login",
                newName: "login");

            migrationBuilder.AddColumn<int>(
                name: "LoginId",
                table: "login",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_login",
                table: "login",
                column: "LoginId");
        }
    }
}
