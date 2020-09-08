using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SharedModels.ChatService;
using SharedModels.UserService;
using SharedModels.StreamingService;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.Data
{
    public class DbContext : IdentityDbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<ConferenceRecordFile> ConferenceRecordFiles { get; set; }
        public DbSet<VideoRoom> VideoRooms { get; set; }
    }
}
