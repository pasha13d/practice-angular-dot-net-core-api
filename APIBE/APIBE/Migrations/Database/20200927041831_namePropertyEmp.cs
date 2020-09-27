using Microsoft.EntityFrameworkCore.Migrations;

namespace APIBE.Migrations.Database
{
    public partial class namePropertyEmp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stateName",
                table: "State",
                newName: "StateName");

            migrationBuilder.RenameColumn(
                name: "countryName",
                table: "Country",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "cityName",
                table: "City",
                newName: "CityName");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Salary = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.RenameColumn(
                name: "StateName",
                table: "State",
                newName: "stateName");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Country",
                newName: "countryName");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "City",
                newName: "cityName");
        }
    }
}
