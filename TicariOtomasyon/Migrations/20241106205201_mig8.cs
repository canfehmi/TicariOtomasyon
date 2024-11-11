using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicariOtomasyon.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Detays",
                columns: table => new
                {
                    DetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    UrunBilgi = table.Column<string>(type: "Varchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detays", x => x.DetayId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detays");
        }
    }
}
