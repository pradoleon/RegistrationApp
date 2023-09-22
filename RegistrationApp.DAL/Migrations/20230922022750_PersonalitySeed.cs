using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistrationApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class PersonalitySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Personality(Title) Values('Normal')");
            migrationBuilder.Sql("INSERT INTO Personality(Title) Values('Funny')");
            migrationBuilder.Sql("INSERT INTO Personality(Title) Values('Serious')");
            migrationBuilder.Sql("INSERT INTO Personality(Title) Values('Angry')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
