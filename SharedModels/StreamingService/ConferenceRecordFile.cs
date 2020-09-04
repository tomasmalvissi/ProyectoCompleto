using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.StreamingService
{
	public class ConferenceRecordFile: EntityBase
	{
		public Participante Owner { get; set; }
		public string FileName { get; set; }
		public string Path { get; set; }
		public VideoRoom VideoRoom { get; set; }
	}
}
