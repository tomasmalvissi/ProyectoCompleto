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

namespace StreamingAPI
{
	public class StreamingDBContext  : DbContext
	{
		public StreamingDBContext(DbContextOptions<StreamingDBContext> options)
			: base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder Modelbuilder)
		{
			Modelbuilder.Entity<SalaParticipante>().HasKey(x => new { x.Id_Sala, x.Id_Participante });
		}

		public DbSet<Mensaje> Mensajes { get; set; }
		public DbSet<ConferenceRecordFile> ConferenceRecordFiles { get; set; }
		public DbSet<VideoRoom> VideoRooms { get; set; }
		public DbSet<Sala> Salas { get; set; }
		public DbSet<SalaParticipante> SalaParticipantes { get; set; }
		public DbSet<Asistencia> Asistencias { get; set; }

	}
}
