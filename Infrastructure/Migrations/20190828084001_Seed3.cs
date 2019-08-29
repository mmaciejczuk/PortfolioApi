using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Infrastructure.Migrations
{
    public partial class Seed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Fill Positions
            migrationBuilder.Sql($"INSERT INTO Positions " +
                $"(Currency, MarketValue, Name, Country, StorePercentage, PortfolioDate, PortfolioISINCode, PositionTypeId) " +
                $"VALUES " +
                $"('ARM', 1.1, 'Pos_1', 'AR', 20, '2018-02-21', 'ARM037833100', 1)," +
                $"('ARM', 1.1, 'Pos_2', 'AR', 20, '2018-02-21', 'ARM037833100', 2)," +
                $"('ARM', 1.1, 'Pos_3', 'AR', 20, '2018-02-21', 'ARM037833100', 3)," +

                $"('USA', 1.1, 'Pos_4', 'US', 20, '2018-02-22', 'US0378331005', 3)," +
                $"('USA', 1.1, 'Pos_5', 'US', 20, '2018-02-22', 'US0378331005', 4)," +
                $"('USA', 1.1, 'Pos_6', 'US', 20, '2018-02-22', 'US0378331005', 5)," +

                $"('SAU', 1.1, 'Pos_1', 'SA', 20, '2018-02-23', 'SAU037833100', 1)," +
                $"('SAU', 1.1, 'Pos_2', 'SA', 20, '2018-02-23', 'SAU037833100', 2)," +
                $"('SAU', 1.1, 'Pos_3', 'SA', 20, '2018-02-23', 'SAU037833100', 3)," +

                $"('BHS', 1.1, 'Pos_4', 'BH', 20, '2018-02-24', 'BHS037833100', 3)," +
                $"('BHS', 1.1, 'Pos_5', 'BH', 20, '2018-02-24', 'BHS037833100', 4)," +
                $"('BHS', 1.1, 'Pos_6', 'BH', 20, '2018-02-24', 'BHS037833100', 5)," +

                $"('BGD', 1.1, 'Pos_1', 'BG', 20, '2018-02-25', 'BGD037833100', 1)," +
                $"('BGD', 1.1, 'Pos_2', 'BG', 20, '2018-02-25', 'BGD037833100', 2)," +
                $"('BGD', 1.1, 'Pos_3', 'BG', 20, '2018-02-25', 'BGD037833100', 3)," +

                $"('PHL', 1.1, 'Pos_4', 'PH', 20, '2018-02-26', 'PHL037833100', 3)," +
                $"('PHL', 1.1, 'Pos_5', 'PH', 20, '2018-02-26', 'PHL037833100', 4)," +
                $"('PHL', 1.1, 'Pos_6', 'PH', 20, '2018-02-26', 'PHL037833100', 5)," +

                $"('GRD', 1.1, 'Pos_7', 'GR', 20, '2018-02-27', 'GRD037833100', 1)," +
                $"('GRD', 1.1, 'Pos_8', 'GR', 20, '2018-02-27', 'GRD037833100', 2)," +
                $"('GRD', 1.1, 'Pos_9', 'GR', 20, '2018-02-27', 'GRD037833100', 3)"
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Positions");
        }
    }
}
