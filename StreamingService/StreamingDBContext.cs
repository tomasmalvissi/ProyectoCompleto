using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SharedModels.ChatService;
using SharedModels.StreamingService;
using SharedModels.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingAPI
{
	public class StreamingDBContext : IdentityDbContext
	{
		public StreamingDBContext(DbContextOptions<StreamingDBContext> options)
			: base(options)
		{ }

		public DbSet<Empresa> Empresas { get; set; }
		public DbSet<Persona> Personas { get; set; }
		public DbSet<Mensaje> Mensajes { get; set; }
		public DbSet<ConferenceRecordFile> ConferenceRecordFiles { get; set; }
		public DbSet<VideoRoom> VideoRooms { get; set; }
		public DbSet<Sala> Salas { get; set; }
		public DbSet<Participante> Participantes { get; set; }
		public DbSet<Asistencia> Asistencias { get; set; }

	}
}
