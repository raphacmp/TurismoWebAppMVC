using Microsoft.EntityFrameworkCore.Migrations;

namespace TurismoWebAppMVC.Migrations
{
    public partial class AssociadocomEstadoClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UFId",
                table: "PontoTuristico",
                newName: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_PontoTuristico_EstadoId",
                table: "PontoTuristico",
                column: "EstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PontoTuristico_Estado_EstadoId",
                table: "PontoTuristico",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PontoTuristico_Estado_EstadoId",
                table: "PontoTuristico");

            migrationBuilder.DropIndex(
                name: "IX_PontoTuristico_EstadoId",
                table: "PontoTuristico");

            migrationBuilder.RenameColumn(
                name: "EstadoId",
                table: "PontoTuristico",
                newName: "UFId");
        }
    }
}
