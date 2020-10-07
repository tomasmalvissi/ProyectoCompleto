using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreamingAPI.Migrations
{
    public partial class adsdas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreSala = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaUltimoUso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TiempoAcumuladoUso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordSala = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControlAsistencia = table.Column<bool>(type: "bit", nullable: false),
                    EsPersistente = table.Column<bool>(type: "bit", nullable: false),
                    IdentityRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salas_IdentityRole_IdentityRoleId",
                        column: x => x.IdentityRoleId,
                        principalTable: "IdentityRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Asistencias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParticipanteId = table.Column<int>(type: "int", nullable: true),
                    Id_Salas = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaEgreso = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConferenceRecordFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuenioId = table.Column<int>(type: "int", nullable: true),
                    NombreArchivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoRoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConferenceRecordFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParticipanteId = table.Column<int>(type: "int", nullable: false),
                    Contenido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hora_Fecha_Envio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Url_Archivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Privado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalaParticipantes",
                columns: table => new
                {
                    Id_Sala = table.Column<int>(type: "int", nullable: false),
                    Id_Participante = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalaId = table.Column<int>(type: "int", nullable: true),
                    ParticipanteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaParticipantes", x => new { x.Id_Sala, x.Id_Participante });
                    table.ForeignKey(
                        name: "FK_SalaParticipantes_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuenioId = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duracion = table.Column<TimeSpan>(type: "time", nullable: false),
                    SalaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoRooms_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Participante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "IX_Asistencias_ParticipanteId",
                table: "Asistencias",
                column: "ParticipanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ConferenceRecordFiles_DuenioId",
                table: "ConferenceRecordFiles",
                column: "DuenioId");

            migrationBuilder.CreateIndex(
                name: "IX_ConferenceRecordFiles_VideoRoomId",
                table: "ConferenceRecordFiles",
                column: "VideoRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Mensajes_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Participante_VideoRoomId",
                table: "Participante",
                column: "VideoRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaParticipantes_ParticipanteId",
                table: "SalaParticipantes",
                column: "ParticipanteId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaParticipantes_SalaId",
                table: "SalaParticipantes",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Salas_IdentityRoleId",
                table: "Salas",
                column: "IdentityRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoRooms_DuenioId",
                table: "VideoRooms",
                column: "DuenioId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoRooms_SalaId",
                table: "VideoRooms",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_Participante_ParticipanteId",
                table: "Asistencias",
                column: "ParticipanteId",
                principalTable: "Participante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConferenceRecordFiles_Participante_DuenioId",
                table: "ConferenceRecordFiles",
                column: "DuenioId",
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
                name: "FK_Mensajes_Participante_ParticipanteId",
                table: "Mensajes",
                column: "ParticipanteId",
                principalTable: "Participante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaParticipantes_Participante_ParticipanteId",
                table: "SalaParticipantes",
                column: "ParticipanteId",
                principalTable: "Participante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoRooms_Participante_DuenioId",
                table: "VideoRooms",
                column: "DuenioId",
                principalTable: "Participante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoRooms_Participante_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropTable(
                name: "Asistencias");

            migrationBuilder.DropTable(
                name: "ConferenceRecordFiles");

            migrationBuilder.DropTable(
                name: "Mensajes");

            migrationBuilder.DropTable(
                name: "SalaParticipantes");

            migrationBuilder.DropTable(
                name: "Participante");

            migrationBuilder.DropTable(
                name: "VideoRooms");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DropTable(
                name: "IdentityRole");
        }
    }
}
