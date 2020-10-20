using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    NombreEmpresa = table.Column<string>(nullable: false),
                    CUIT = table.Column<string>(nullable: false),
                    Pais = table.Column<string>(nullable: false),
                    Provincia = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Logo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    NombreSala = table.Column<string>(nullable: true),
                    FechaBaja = table.Column<DateTime>(nullable: true),
                    FechaUltimoUso = table.Column<DateTime>(nullable: true),
                    TiempoAcumuladoUso = table.Column<DateTime>(nullable: true),
                    PasswordSala = table.Column<string>(nullable: true),
                    ControlAsistencia = table.Column<bool>(nullable: false),
                    EsPersistente = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEmp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    FechaAlta = table.Column<DateTime>(nullable: false),
                    FechaBaja = table.Column<DateTime>(nullable: false),
                    Rol = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEmp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    ParticipanteId = table.Column<int>(nullable: false),
                    Contenido = table.Column<string>(nullable: true),
                    Hora_Fecha_Envio = table.Column<DateTime>(nullable: false),
                    Url_Archivo = table.Column<string>(nullable: true),
                    Privado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mensajes_UserEmp_ParticipanteId",
                        column: x => x.ParticipanteId,
                        principalTable: "UserEmp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEMPRESAS",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    IdEmpresaId = table.Column<int>(nullable: false),
                    IdClienteId = table.Column<int>(nullable: false),
                    VideoRoomId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEMPRESAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEMPRESAS_Clientes_IdClienteId",
                        column: x => x.IdClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEMPRESAS_Empresas_IdEmpresaId",
                        column: x => x.IdEmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asistencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    UserEMPRESAId = table.Column<string>(nullable: true),
                    Id_Salas = table.Column<int>(nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: true),
                    FechaEgreso = table.Column<DateTime>(nullable: true),
                    Rol_Usuario = table.Column<int>(nullable: false),
                    UserEmpId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asistencias_UserEMPRESAS_UserEMPRESAId",
                        column: x => x.UserEMPRESAId,
                        principalTable: "UserEMPRESAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Asistencias_UserEmp_UserEmpId",
                        column: x => x.UserEmpId,
                        principalTable: "UserEmp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "salaUserEMPRESAS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Id_Sala = table.Column<int>(nullable: false),
                    Id_UserEMPRESA = table.Column<int>(nullable: false),
                    SalaId = table.Column<int>(nullable: true),
                    UserEMPRESASId = table.Column<string>(nullable: true),
                    UserEmpId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salaUserEMPRESAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_salaUserEMPRESAS_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salaUserEMPRESAS_UserEMPRESAS_UserEMPRESASId",
                        column: x => x.UserEMPRESASId,
                        principalTable: "UserEMPRESAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_salaUserEMPRESAS_UserEmp_UserEmpId",
                        column: x => x.UserEmpId,
                        principalTable: "UserEmp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoRooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    DuenioId = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Duracion = table.Column<TimeSpan>(nullable: false),
                    SalaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoRooms_UserEMPRESAS_DuenioId",
                        column: x => x.DuenioId,
                        principalTable: "UserEMPRESAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VideoRooms_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConferenceRecordFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    DuenioId = table.Column<string>(nullable: true),
                    NombreArchivo = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    VideoRoomId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConferenceRecordFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConferenceRecordFiles_UserEMPRESAS_DuenioId",
                        column: x => x.DuenioId,
                        principalTable: "UserEMPRESAS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConferenceRecordFiles_VideoRooms_VideoRoomId",
                        column: x => x.VideoRoomId,
                        principalTable: "VideoRooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_UserEMPRESAId",
                table: "Asistencias",
                column: "UserEMPRESAId");

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_UserEmpId",
                table: "Asistencias",
                column: "UserEmpId");

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
                name: "IX_salaUserEMPRESAS_SalaId",
                table: "salaUserEMPRESAS",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_salaUserEMPRESAS_UserEMPRESASId",
                table: "salaUserEMPRESAS",
                column: "UserEMPRESASId");

            migrationBuilder.CreateIndex(
                name: "IX_salaUserEMPRESAS_UserEmpId",
                table: "salaUserEMPRESAS",
                column: "UserEmpId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEMPRESAS_IdClienteId",
                table: "UserEMPRESAS",
                column: "IdClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEMPRESAS_IdEmpresaId",
                table: "UserEMPRESAS",
                column: "IdEmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEMPRESAS_VideoRoomId",
                table: "UserEMPRESAS",
                column: "VideoRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoRooms_DuenioId",
                table: "VideoRooms",
                column: "DuenioId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoRooms_SalaId",
                table: "VideoRooms",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserEMPRESAS_VideoRooms_VideoRoomId",
                table: "UserEMPRESAS",
                column: "VideoRoomId",
                principalTable: "VideoRooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoRooms_UserEMPRESAS_DuenioId",
                table: "VideoRooms");

            migrationBuilder.DropTable(
                name: "Asistencias");

            migrationBuilder.DropTable(
                name: "ConferenceRecordFiles");

            migrationBuilder.DropTable(
                name: "Mensajes");

            migrationBuilder.DropTable(
                name: "salaUserEMPRESAS");

            migrationBuilder.DropTable(
                name: "UserEmp");

            migrationBuilder.DropTable(
                name: "UserEMPRESAS");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "VideoRooms");

            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
