using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Migracion_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fechaContratacion",
                table: "Empleados");

            migrationBuilder.RenameColumn(
                name: "Salario",
                table: "Empleados",
                newName: "salario");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Empleados",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "Empleados",
                newName: "foto");

            migrationBuilder.RenameColumn(
                name: "ApPaterno",
                table: "Empleados",
                newName: "apPaterno");

            migrationBuilder.AddColumn<string>(
                name: "apMaterno",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fechaContrato",
                table: "Empleados",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "apMaterno",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "fechaContrato",
                table: "Empleados");

            migrationBuilder.RenameColumn(
                name: "salario",
                table: "Empleados",
                newName: "Salario");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Empleados",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "foto",
                table: "Empleados",
                newName: "Foto");

            migrationBuilder.RenameColumn(
                name: "apPaterno",
                table: "Empleados",
                newName: "ApPaterno");

            migrationBuilder.AddColumn<string>(
                name: "fechaContratacion",
                table: "Empleados",
                type: "TEXT",
                nullable: true);
        }
    }
}
