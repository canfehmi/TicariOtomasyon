using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicariOtomasyon.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Kategoris",
                newName: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KategoriId",
                table: "Kategoris",
                newName: "Id");
        }
    }
}
