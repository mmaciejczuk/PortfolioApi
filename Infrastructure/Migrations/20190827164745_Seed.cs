using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Infrastructure.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Fill PositionTypes
            migrationBuilder.Sql($"INSERT INTO PositionTypes (Name) VALUES ('Fund')");
            migrationBuilder.Sql($"INSERT INTO PositionTypes (Name) VALUES ('Share')");
            migrationBuilder.Sql($"INSERT INTO PositionTypes (Name) VALUES ('Bond')");
            migrationBuilder.Sql($"INSERT INTO PositionTypes (Name) VALUES ('Cash')");
            migrationBuilder.Sql($"INSERT INTO PositionTypes (Name) VALUES ('Other')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM PositionTypes");
        }
    }
}
