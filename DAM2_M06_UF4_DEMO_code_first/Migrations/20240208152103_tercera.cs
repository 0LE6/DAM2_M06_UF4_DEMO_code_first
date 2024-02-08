using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_DEMO_code_first.Migrations
{
    public partial class tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Alumnos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Ciudad = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_CursoId",
                table: "Alumnos",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Cursos_CursoId",
                table: "Alumnos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Cursos_CursoId",
                table: "Alumnos");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_CursoId",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Alumnos");
        }
    }
}
