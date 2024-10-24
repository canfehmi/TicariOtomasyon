using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicariOtomasyon.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carilers_SatisHarekets_SatisHareketId",
                table: "Carilers");

            migrationBuilder.DropForeignKey(
                name: "FK_Personels_SatisHarekets_SatisHareketId",
                table: "Personels");

            migrationBuilder.DropForeignKey(
                name: "FK_Uruns_SatisHarekets_SatisHareketId",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Uruns_SatisHareketId",
                table: "Uruns");

            migrationBuilder.DropIndex(
                name: "IX_Personels_SatisHareketId",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Carilers_SatisHareketId",
                table: "Carilers");

            migrationBuilder.DropColumn(
                name: "SatisHareketId",
                table: "Uruns");

            migrationBuilder.DropColumn(
                name: "SatisHareketId",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "SatisHareketId",
                table: "Carilers");

            migrationBuilder.AddColumn<int>(
                name: "CarilerCariId",
                table: "SatisHarekets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonelId",
                table: "SatisHarekets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UrunId",
                table: "SatisHarekets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_CarilerCariId",
                table: "SatisHarekets",
                column: "CarilerCariId");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_PersonelId",
                table: "SatisHarekets",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_SatisHarekets_UrunId",
                table: "SatisHarekets",
                column: "UrunId");

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHarekets_Carilers_CarilerCariId",
                table: "SatisHarekets",
                column: "CarilerCariId",
                principalTable: "Carilers",
                principalColumn: "CariId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHarekets_Personels_PersonelId",
                table: "SatisHarekets",
                column: "PersonelId",
                principalTable: "Personels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SatisHarekets_Uruns_UrunId",
                table: "SatisHarekets",
                column: "UrunId",
                principalTable: "Uruns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SatisHarekets_Carilers_CarilerCariId",
                table: "SatisHarekets");

            migrationBuilder.DropForeignKey(
                name: "FK_SatisHarekets_Personels_PersonelId",
                table: "SatisHarekets");

            migrationBuilder.DropForeignKey(
                name: "FK_SatisHarekets_Uruns_UrunId",
                table: "SatisHarekets");

            migrationBuilder.DropIndex(
                name: "IX_SatisHarekets_CarilerCariId",
                table: "SatisHarekets");

            migrationBuilder.DropIndex(
                name: "IX_SatisHarekets_PersonelId",
                table: "SatisHarekets");

            migrationBuilder.DropIndex(
                name: "IX_SatisHarekets_UrunId",
                table: "SatisHarekets");

            migrationBuilder.DropColumn(
                name: "CarilerCariId",
                table: "SatisHarekets");

            migrationBuilder.DropColumn(
                name: "PersonelId",
                table: "SatisHarekets");

            migrationBuilder.DropColumn(
                name: "UrunId",
                table: "SatisHarekets");

            migrationBuilder.AddColumn<int>(
                name: "SatisHareketId",
                table: "Uruns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SatisHareketId",
                table: "Personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SatisHareketId",
                table: "Carilers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Uruns_SatisHareketId",
                table: "Uruns",
                column: "SatisHareketId");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_SatisHareketId",
                table: "Personels",
                column: "SatisHareketId");

            migrationBuilder.CreateIndex(
                name: "IX_Carilers_SatisHareketId",
                table: "Carilers",
                column: "SatisHareketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carilers_SatisHarekets_SatisHareketId",
                table: "Carilers",
                column: "SatisHareketId",
                principalTable: "SatisHarekets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_SatisHarekets_SatisHareketId",
                table: "Personels",
                column: "SatisHareketId",
                principalTable: "SatisHarekets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uruns_SatisHarekets_SatisHareketId",
                table: "Uruns",
                column: "SatisHareketId",
                principalTable: "SatisHarekets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
