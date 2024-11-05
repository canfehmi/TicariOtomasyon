using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicariOtomasyon.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Saat",
                table: "Faturalars",
                type: "Char(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<decimal>(
                name: "Toplam",
                table: "Faturalars",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Toplam",
                table: "Faturalars");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Saat",
                table: "Faturalars",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Char(5)",
                oldMaxLength: 5);
        }
    }
}
