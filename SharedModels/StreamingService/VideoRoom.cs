using System;
using System.Collections.Generic;

namespace SharedModels.StreamingService
{
	public class VideoRoom : EntityBase
	{
		public List<Participante> Participantes { get; set; }
		public Participante Duenio { get; set; }
		public string Nombre { get; set; }
		public TimeSpan Duracion { get; set; }

	}
}
