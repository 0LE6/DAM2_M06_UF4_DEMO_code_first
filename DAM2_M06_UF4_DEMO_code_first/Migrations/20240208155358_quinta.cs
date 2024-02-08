using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_DEMO_code_first.Migrations
{
    public partial class quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Profesor_ProfesorId",
                table: "Cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profesor",
                table: "Profesor");

            migrationBuilder.RenameTable(
                name: "Profesor",
                newName: "Profesores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profesores",
                table: "Profesores",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Profesores_ProfesorId",
                table: "Cursos",
                column: "ProfesorId",
                principalTable: "Profesores",
                principalColumn: "ProfesorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Profesores_ProfesorId",
                table: "Cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profesores",
                table: "Profesores");

            migrationBuilder.RenameTable(
                name: "Profesores",
                newName: "Profesor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profesor",
                table: "Profesor",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Profesor_ProfesorId",
                table: "Cursos",
                column: "ProfesorId",
                principalTable: "Profesor",
                principalColumn: "ProfesorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
