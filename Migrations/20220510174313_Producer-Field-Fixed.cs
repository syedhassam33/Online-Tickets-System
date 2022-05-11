using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineTicketSystem.Migrations
{
    public partial class ProducerFieldFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducersActId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ActPictureURL",
                table: "Producers",
                newName: "ProdPictureURL");

            migrationBuilder.RenameColumn(
                name: "ActFullName",
                table: "Producers",
                newName: "ProdFullName");

            migrationBuilder.RenameColumn(
                name: "ActId",
                table: "Producers",
                newName: "ProdId");

            migrationBuilder.RenameColumn(
                name: "ProducersActId",
                table: "Movies",
                newName: "ProducersProdId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducersActId",
                table: "Movies",
                newName: "IX_Movies_ProducersProdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducersProdId",
                table: "Movies",
                column: "ProducersProdId",
                principalTable: "Producers",
                principalColumn: "ProdId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducersProdId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProdPictureURL",
                table: "Producers",
                newName: "ActPictureURL");

            migrationBuilder.RenameColumn(
                name: "ProdFullName",
                table: "Producers",
                newName: "ActFullName");

            migrationBuilder.RenameColumn(
                name: "ProdId",
                table: "Producers",
                newName: "ActId");

            migrationBuilder.RenameColumn(
                name: "ProducersProdId",
                table: "Movies",
                newName: "ProducersActId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducersProdId",
                table: "Movies",
                newName: "IX_Movies_ProducersActId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducersActId",
                table: "Movies",
                column: "ProducersActId",
                principalTable: "Producers",
                principalColumn: "ActId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
