using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Infrastructure.Migrations
{
    public partial class Seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Fill Portfolios
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency, MarketValue) VALUES ('ARM037833100', '2018-02-21', 'ARM', 4.3)");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency, MarketValue) VALUES ('US0378331005', '2018-02-22', 'USA', 6.7)");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency, MarketValue) VALUES ('SAU037833100', '2018-02-23', 'SAU', 8.3)");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency, MarketValue) VALUES ('BHS037833100', '2018-02-24', 'BHS', 3.3)");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency, MarketValue) VALUES ('BGD037833100', '2018-02-25', 'BGD', 9.1)");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency, MarketValue) VALUES ('PHL037833100', '2018-02-26', 'PHL', 4.6)");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency, MarketValue) VALUES ('GRD037833100', '2018-02-27', 'GRD', 7.8)");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency, MarketValue) VALUES ('GEO037833100', '2018-02-28', 'GEO', 2.1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Portfolios");
        }
    }
}
