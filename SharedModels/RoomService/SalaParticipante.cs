using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.RoomService
{
    public class SalaParticipante : EntityBase
    {
        public int Id_Sala { get; set; }
        public int Id_Participante { get; set; }
        public Sala Sala { get; set;}
        public Participante Participante { get; set; }
    }
}
