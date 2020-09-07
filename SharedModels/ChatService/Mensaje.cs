using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModels.ChatService
{
    public class Mensaje : EntityBase
    {
        public Participante Participante { get; set; }
        public string Contenido { get; set; }
        public DateTime Hora_Fecha_Envio { get; set; }
        public string Url_Archivo { get; set; }
        public bool Privado { get; set; }
    }
}