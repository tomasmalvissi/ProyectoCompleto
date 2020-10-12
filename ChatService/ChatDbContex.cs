using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedModels.ChatService;
using SharedModels.RoomService;
using SharedModels.StreamingService;
using SharedModels.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatService
{
    public class ChatDbContex : IdentityDbContext
    {
        public ChatDbContex(DbContextOptions<DbContext> options) : base(options)
        {

        }

        //Conexion de muchos a muchos entre Sala y UserEmp 
        protected override void OnModelCreating(ModelBuilder Modelbuilder)
        {
           Modelbuilder.Entity<SalaUserEMPRESA>().HasKey(x => new { x.Id_Sala, x.Id_UserEMPRESA });
        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<UserEMPRESA> UserEMPRESAS { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<ConferenceRecordFile> ConferenceRecordFiles { get; set; }
        public DbSet<VideoRoom> VideoRooms { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<UserEMPRESA> userEMPRESAS { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<SalaUserEMPRESA> salaUserEMPRESAS { get; set; }

    }
}