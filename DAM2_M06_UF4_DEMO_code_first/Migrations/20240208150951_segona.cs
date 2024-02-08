using Microsoft.EntityFrameworkCore.Migrations;

namespace DAM2_M06_UF4_DEMO_code_first.Migrations
{
    public partial class segona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "NotaFinal",
                table: "Alumnos",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotaFinal",
                table: "Alumnos");
        }
    }
}
