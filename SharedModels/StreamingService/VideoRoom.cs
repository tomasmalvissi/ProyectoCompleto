using SharedModels.UserService;
using System;
using System.Collections.Generic;

namespace SharedModels.StreamingService
{
	public class VideoRoom : EntityBase
	{
		public List<UserEMPRESA> Participantes { get; set; }
		public UserEMPRESA Duenio { get; set; }
		public string Nombre { get; set; }
		public TimeSpan Duracion { get; set; }

		public Sala Sala { get; set; }

	}
}
