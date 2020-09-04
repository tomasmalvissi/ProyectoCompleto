using System;
using System.Collections.Generic;

namespace SharedModels.StreamingService
{
	public class VideoRoom : EntityBase
	{
		public List<Participante> Users { get; set; }
		public Participante Owner { get; set; }
		public string Name { get; set; }
		public TimeSpan Duration { get; set; }

	}
}
