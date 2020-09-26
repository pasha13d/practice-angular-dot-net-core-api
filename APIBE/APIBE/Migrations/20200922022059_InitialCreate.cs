using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace APIBE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paymentDetails",
                columns: table => new
                {
                    PMId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardOwnerName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(16)", nullable: false),
                    ExpirationDate = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentDetails", x => x.PMId);
                });
            //    string procedure = @"CREATE PROCEDURE spGetPaymentById
            //                            @Id INT
            //                            AS
            //                            BEGIN
            //                             SELECT * FROM paymentDetails
            //                             WHERE PMId=@Id
            //                            END";
            //    migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paymentDetails");

            //string procedure = @"DROP PROCEDURE spGetPaymentById";
            //migrationBuilder.Sql(procedure);
        }
    }
}
