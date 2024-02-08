using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_DEMO_code_first.Migrations
{
    public partial class cuarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfesorId",
                table: "Cursos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    ProfesorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.ProfesorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_ProfesorId",
                table: "Cursos",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Profesor_ProfesorId",
                table: "Cursos",
                column: "ProfesorId",
                principalTable: "Profesor",
                principalColumn: "ProfesorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Profesor_ProfesorId",
                table: "Cursos");

            migrationBuilder.DropTable(
                name: "Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_ProfesorId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Cursos");
        }
    }
}
