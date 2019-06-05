using Microsoft.EntityFrameworkCore.Migrations;

namespace TurismoWebAppMVC.Migrations
{
    public partial class ColocandoPontoTuristicoUFIdcomochaveestrangeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uf",
                table: "PontoTuristico");

            migrationBuilder.AddColumn<int>(
                name: "UFId",
                table: "PontoTuristico",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UFId",
                table: "PontoTuristico");

            migrationBuilder.AddColumn<string>(
                name: "Uf",
                table: "PontoTuristico",
                nullable: true);
        }
    }
}
