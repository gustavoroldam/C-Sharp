using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMVCADS2023.Migrations
{
    /// <inheritdoc />
    public partial class Aluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aniversario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cursoid = table.Column<int>(type: "int", nullable: false),
                    periodo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Alunos_Cursos_cursoid",
                        column: x => x.cursoid,
                        principalTable: "Cursos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_cursoid",
                table: "Alunos",
                column: "cursoid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
