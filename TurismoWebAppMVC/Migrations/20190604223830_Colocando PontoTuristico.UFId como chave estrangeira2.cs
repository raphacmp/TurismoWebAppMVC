using Microsoft.EntityFrameworkCore.Migrations;

namespace TurismoWebAppMVC.Migrations
{
    public partial class ColocandoPontoTuristicoUFIdcomochaveestrangeira2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UFId",
                table: "Estado",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UFId",
                table: "Estado");
        }
    }
}
