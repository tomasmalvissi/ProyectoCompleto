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

namespace UsersAPI
{
	public class DbContext : IdentityDbContext
	{
		public DbContext(DbContextOptions<DbContext> options)
			: base(options)
		{ }

		public DbSet<Empresa> Empresas { get; set; }
		public DbSet<Persona> Personas { get; set; }
		public DbSet<Participante> Participantes { get; set; }


	}
}
