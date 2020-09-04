using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.ChatService
{
    class Mensaje : EntityBase
    {
        public int Id_Mensaje { get; set; }
        //FK
        public int ChatId { get; set; }
        //FK
        public int ParticipanteId { get; set; }
        public string Contenido { get; set; }
        public DateTime Hora_Envio { get; set; }
    }
}