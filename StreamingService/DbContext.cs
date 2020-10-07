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

        //Conexion de muchos a muchos entre Sala y UserEmp 
        protected override void OnModelCreating(ModelBuilder Modelbuilder)
        {
            Modelbuilder.Entity<SalaUserEmp>().HasKey(x => new { x.Id_Sala, x.Id_UserEmp });
        }
        
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<UserEMPRESA> UserEMPRESAS { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<ConferenceRecordFile> ConferenceRecordFiles { get; set; }
        public DbSet<VideoRoom> VideoRooms { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<UserEmp> UserEmps { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<SalaUserEmp> SalaUserEmps { get; set; }

    }
}

