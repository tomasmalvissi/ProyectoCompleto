using SharedModels.UserService;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.RoomService
{
    public class SalaUserEMPRESA : EntityBase
    {
        public int Id_Sala { get; set; }
        public int Id_UserEMPRESA { get; set; }
        public Sala Sala { get; set; }
        public Participante Participante { get; set; }

    }
}
