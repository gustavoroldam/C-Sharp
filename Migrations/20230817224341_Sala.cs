using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMVCADS2023.Migrations
{
    /// <inheritdoc />
    public partial class Sala : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "situacao",
                table: "Salas",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "situacao",
                table: "Salas");
        }
    }
}
