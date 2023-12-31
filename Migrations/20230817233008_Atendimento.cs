﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMVCADS2023.Migrations
{
    /// <inheritdoc />
    public partial class Atendimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    alunoid = table.Column<int>(type: "int", nullable: true),
                    salaid = table.Column<int>(type: "int", nullable: true),
                    data_hora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.id);
                    table.ForeignKey(
                        name: "FK_Atendimento_Alunos_alunoid",
                        column: x => x.alunoid,
                        principalTable: "Alunos",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Atendimento_Salas_salaid",
                        column: x => x.salaid,
                        principalTable: "Salas",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_alunoid",
                table: "Atendimento",
                column: "alunoid");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_salaid",
                table: "Atendimento",
                column: "salaid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atendimento");
        }
    }
}
