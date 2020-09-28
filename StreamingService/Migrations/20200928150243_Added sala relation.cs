using Microsoft.EntityFrameworkCore.Migrations;

namespace StreamingAPI.Migrations
{
    public partial class Addedsalarelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "VideoRooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VideoRooms_SalaId",
                table: "VideoRooms",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoRooms_Salas_SalaId",
                table: "VideoRooms",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoRooms_Salas_SalaId",
                table: "VideoRooms");

            migrationBuilder.DropIndex(
                name: "IX_VideoRooms_SalaId",
                table: "VideoRooms");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "VideoRooms");
        }
    }
}
