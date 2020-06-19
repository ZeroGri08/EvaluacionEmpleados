using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beneficiarios",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(nullable: true),
                    apPaterno = table.Column<string>(nullable: true),
                    apMaterno = table.Column<string>(nullable: true),
                    parentesco = table.Column<string>(nullable: true),
                    fecNacimiento = table.Column<string>(nullable: true),
                    sexo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiarios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    foto = table.Column<string>(nullable: true),
                    nombre = table.Column<string>(nullable: true),
                    apPaterno = table.Column<string>(nullable: true),
                    apMaterno = table.Column<string>(nullable: true),
                    puesto = table.Column<string>(nullable: true),
                    salario = table.Column<int>(nullable: false),
                    estatus = table.Column<string>(nullable: true),
                    fecCont = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficiarios");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
