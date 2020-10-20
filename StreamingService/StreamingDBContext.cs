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
		public StreamingDBContext(DbContextOptions<DbContext> options)
			: base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder Modelbuilder)
		{
			Modelbuilder.Entity<SalaUserEMPRESA>().HasKey(x => new { x.Id_Sala, x.Id_UserEMPRESA });
		}

		public DbSet<Mensaje> Mensajes { get; set; }
		public DbSet<ConferenceRecordFile> ConferenceRecordFiles { get; set; }
		public DbSet<VideoRoom> VideoRooms { get; set; }
		public DbSet<Sala> Salas { get; set; }
		public DbSet<SalaUserEMPRESA> SalaParticipantes { get; set; }
		public DbSet<Asistencia> Asistencias { get; set; }

	}
}
