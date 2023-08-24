using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMVCADS2023.Migrations
{
    /// <inheritdoc />
    public partial class AlunosV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Cursos_cursoid",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "cursoid",
                table: "Alunos",
                newName: "cursoID");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_cursoid",
                table: "Alunos",
                newName: "IX_Alunos_cursoID");

            migrationBuilder.AlterColumn<string>(
                name: "periodo",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Alunos",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Cursos_cursoID",
                table: "Alunos",
                column: "cursoID",
                principalTable: "Cursos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Cursos_cursoID",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Alunos");

            migrationBuilder.RenameColumn(
                name: "cursoID",
                table: "Alunos",
                newName: "cursoid");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_cursoID",
                table: "Alunos",
                newName: "IX_Alunos_cursoid");

            migrationBuilder.AlterColumn<string>(
                name: "periodo",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Cursos_cursoid",
                table: "Alunos",
                column: "cursoid",
                principalTable: "Cursos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
