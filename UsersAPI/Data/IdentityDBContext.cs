using Microsoft.AspNetCore.Identity;
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

namespace UsersAPI.Data
{
	public class IdentityDBContext : IdentityDbContext<IdentityUser>
	{
		public IdentityDBContext(DbContextOptions options) : base(options)
		{
			
		}

		public DbSet<Empresa> Empresas { get; set; }
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<UserEMPRESA> UserEMPRESAS { get; set; }

	}
}
