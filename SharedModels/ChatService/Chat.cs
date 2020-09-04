using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.ChatService
{
    class Chat : EntityBase
    {
        public int Id_Chat { get; set; }
        //FK
        public int SalaId { get; set; }
        public List<Participante> Participantes { get; set; }
        public List<Mensaje> Mensajes { get; set; }
    }
}