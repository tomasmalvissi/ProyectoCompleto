using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SharedModels.ChatService;
using SharedModels.UserService;
using SharedModels.StreamingService;
using System;
using System.Collections.Generic;
using System.Text;
using SharedModels.RoomService;

namespace StreamingAPI
{
    public class DbContext : IdentityDbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        //Conexion de muchos a muchos entre Sala y Participante 
        protected override void OnModelCreating(ModelBuilder Modelbuilder)
        {
            Modelbuilder.Entity<SalaParticipante>().HasKey(x => new { x.Id_Sala, x.Id_Participante });
        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<ConferenceRecordFile> ConferenceRecordFiles { get; set; }
        public DbSet<VideoRoom> VideoRooms { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<SalaParticipante> SalaParticipantes { get; set; }

    }
}

