using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class Fixbugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId1",
                table: "Actors_Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actors_Movies_ActorId1",
                table: "Actors_Movies");

            migrationBuilder.DropColumn(
                name: "ActorId1",
                table: "Actors_Movies");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.AddColumn<int>(
                name: "ActorId1",
                table: "Actors_Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_ActorId1",
                table: "Actors_Movies",
                column: "ActorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId1",
                table: "Actors_Movies",
                column: "ActorId1",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
