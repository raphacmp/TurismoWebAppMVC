using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TurismoWebAppMVC.Migrations
{
    public partial class SeedingService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Estados");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Estados",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Estados",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UF",
                table: "Estados",
                maxLength: 2,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Estados");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Estados",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Estados",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
