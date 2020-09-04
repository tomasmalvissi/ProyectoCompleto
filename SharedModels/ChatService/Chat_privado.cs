using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.ChatService
{
    class Chat_privado : EntityBase
    {
        public int Id_ChatPrivado { get; set; }
        //FK
        public int SalaId { get; set; }
        //FK
        public int ParticipanteA { get; set; }
        //FK
        public int ParticipanteB { get; set; }
        public List<Mensaje> Mensajes { get; set; }
    }
}