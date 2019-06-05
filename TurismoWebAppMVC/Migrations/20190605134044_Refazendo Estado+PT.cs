using Microsoft.EntityFrameworkCore.Migrations;

namespace TurismoWebAppMVC.Migrations
{
    public partial class RefazendoEstadoPT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Estado");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Estado",
                newName: "UF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UF",
                table: "Estado",
                newName: "Descricao");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "Estado",
                nullable: false,
                defaultValue: 0);
        }
    }
}
