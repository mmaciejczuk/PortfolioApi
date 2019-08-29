using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    ISINCode = table.Column<string>(maxLength: 12, nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Currency = table.Column<string>(type: "char(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => new { x.ISINCode, x.Date });
                    table.UniqueConstraint("AK_Portfolios_Date_ISINCode", x => new { x.Date, x.ISINCode });
                });

            migrationBuilder.CreateTable(
                name: "PositionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Currency = table.Column<string>(type: "char(3)", nullable: false),
                    MarketValue = table.Column<decimal>(type: "decimal(16 ,2)", nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Country = table.Column<string>(type: "char(2)", nullable: false),
                    PortfolioISINCode = table.Column<string>(nullable: true),
                    PortfolioDate = table.Column<DateTime>(nullable: true),
                    PositionTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_PositionTypes_PositionTypeId",
                        column: x => x.PositionTypeId,
                        principalTable: "PositionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Positions_Portfolios_PortfolioISINCode_PortfolioDate",
                        columns: x => new { x.PortfolioISINCode, x.PortfolioDate },
                        principalTable: "Portfolios",
                        principalColumns: new[] { "ISINCode", "Date" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Positions_PositionTypeId",
                table: "Positions",
                column: "PositionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_PortfolioISINCode_PortfolioDate",
                table: "Positions",
                columns: new[] { "PortfolioISINCode", "PortfolioDate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "PositionTypes");

            migrationBuilder.DropTable(
                name: "Portfolios");
        }
    }
}
