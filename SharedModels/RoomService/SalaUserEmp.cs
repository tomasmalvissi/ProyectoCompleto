using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.RoomService
{
    public class SalaUserEmp : EntityBase
    {
        public int Id_Sala { get; set; }
        public int Id_UserEmp { get; set; }
        public Sala Sala { get; set;}
        public UserEmp UserEmp { get; set; }

    }
}
