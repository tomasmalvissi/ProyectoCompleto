using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingAPI
{
	public class StreamingDBContext : DbContext
	{
		public StreamingDBContext(DbContextOptions<StreamingDBContext> options)
			: base(options)
		{ }



	}
}
