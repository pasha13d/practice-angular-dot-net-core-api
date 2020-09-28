using Microsoft.EntityFrameworkCore.Migrations;

namespace APIBE.Migrations.Database
{
    public partial class decSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Employee",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Salary",
                table: "Employee",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
