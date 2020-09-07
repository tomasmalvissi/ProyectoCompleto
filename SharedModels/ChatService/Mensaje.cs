using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.ChatService
{
    public class Mensaje : EntityBase
    {
        public int SalaId { get; set; }
        //public Sala Sala { get; set; }
        public int ParticipanteId { get; set; }
        //public Participante Participante { get; set; }
        public string Contenido { get; set; }
        public DateTime Hora_Fecha_Envio { get; set; }
        public string Url_Archivo { get; set; }
        public bool Privado { get; set; }
    }
}