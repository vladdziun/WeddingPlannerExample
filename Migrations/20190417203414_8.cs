using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginReg.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Associations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Associations_MovieId",
                table: "Associations",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Movies_MovieId",
                table: "Associations",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Movies_MovieId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_MovieId",
                table: "Associations");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Associations");
        }
    }
}
