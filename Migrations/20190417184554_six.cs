using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginReg.Migrations
{
    public partial class six : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeddingId",
                table: "Associations",
                newName: "RateId");

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    RateId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rating = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.RateId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Associations_RateId",
                table: "Associations",
                column: "RateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Rate_RateId",
                table: "Associations",
                column: "RateId",
                principalTable: "Rate",
                principalColumn: "RateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Rate_RateId",
                table: "Associations");

            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.DropIndex(
                name: "IX_Associations_RateId",
                table: "Associations");

            migrationBuilder.RenameColumn(
                name: "RateId",
                table: "Associations",
                newName: "WeddingId");
        }
    }
}
