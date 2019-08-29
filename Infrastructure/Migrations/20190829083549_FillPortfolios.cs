using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Infrastructure.Migrations
{
    public partial class FillPortfolios : Migration
    {
        //Fill Portfolios
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency) VALUES ('ARM037833100', '2018-02-21', 'ARM')");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency) VALUES ('US0378331005', '2018-02-22', 'USA')");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency) VALUES ('SAU037833100', '2018-02-23', 'SAU')");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency) VALUES ('BHS037833100', '2018-02-24', 'BHS')");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency) VALUES ('BGD037833100', '2018-02-25', 'BGD')");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency) VALUES ('PHL037833100', '2018-02-26', 'PHL')");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency) VALUES ('GRD037833100', '2018-02-27', 'GRD')");
            migrationBuilder.Sql($"INSERT INTO Portfolios (ISINCode, Date, Currency) VALUES ('GEO037833100', '2018-02-28', 'GEO')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Portfolios");
        }
    }
}
