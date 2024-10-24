using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicariOtomasyon.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uruns_Kategoris_KategoriId",
                table: "Uruns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategoris",
                table: "Kategoris");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Kategoris",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategoris",
                table: "Kategoris",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Uruns_Kategoris_KategoriId",
                table: "Uruns",
                column: "KategoriId",
                principalTable: "Kategoris",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uruns_Kategoris_KategoriId",
                table: "Uruns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategoris",
                table: "Kategoris");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Kategoris",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategoris",
                table: "Kategoris",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Uruns_Kategoris_KategoriId",
                table: "Uruns",
                column: "KategoriId",
                principalTable: "Kategoris",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
