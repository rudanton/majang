using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace majang.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "ItemDatas");

            migrationBuilder.CreateTable(
                name: "SaleDatass",
                columns: table => new
                {
                    SaleDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DictionaryJson = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDatass", x => x.SaleDate);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleDatass");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "ItemDatas",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
