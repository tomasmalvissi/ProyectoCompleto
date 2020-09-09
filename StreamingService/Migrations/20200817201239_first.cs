using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreamingAPI.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asistencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Asistencia = table.Column<int>(type: "int", nullable: false),
                    ParticipanteId = table.Column<int>(type: "int", nullable: true),
                    Id_Salas = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaEgreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Rol_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConferenceRecordFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoRoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConferenceRecordFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoRooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Participante = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    VideoRoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participante_VideoRooms_VideoRoomId",
                        column: x => x.VideoRoomId,
                        principalTable: "VideoRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencia_ParticipanteId",
                table: "Asistencia",
                column: "ParticipanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ConferenceRecordFiles_OwnerId",
                table: "ConferenceRecordFiles",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ConferenceRecordFiles_VideoRoomId",
                table: "ConferenceRecordFiles",
                column: "VideoRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Participante_VideoRoomId",
                table: "Participante",
                column: "VideoRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoRooms_OwnerId",
                table: "VideoRooms",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencia_Participante_ParticipanteId",
                table: "Asistencia",
                column: "ParticipanteId",
                principalTable: "Participante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConferenceRecordFiles_Participante_OwnerId",
                table: "ConferenceRecordFiles",
                column: "OwnerId",
                principalTable: "Participante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConferenceRecordFiles_VideoRooms_VideoRoomId",
                table: "ConferenceRecordFiles",
                column: "VideoRoomId",
                principalTable: "VideoRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoRooms_Participante_OwnerId",
                table: "VideoRooms",
                column: "OwnerId",
                principalTable: "Participante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoRooms_Participante_OwnerId",
                table: "VideoRooms");

            migrationBuilder.DropTable(
                name: "Asistencia");

            migrationBuilder.DropTable(
                name: "ConferenceRecordFiles");

            migrationBuilder.DropTable(
                name: "Participante");

            migrationBuilder.DropTable(
                name: "VideoRooms");
        }
    }
}
