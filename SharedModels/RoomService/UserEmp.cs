using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedModels.RoomService
{

    public class UserEmp : EntityBase
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public List<Asistencia> Asistencia { get; set; }
        [NotMapped]
        public List<Sala> Salas { get; set; }
        public List<SalaUserEMPRESA> SalaUserEMPRESAS { get; set; }
        public Roles Rol { get; set; }

        //El UserEmp es el Participante - Una empresa puede tener muchas salas 
    }
    public enum Roles
    {
        Propietario = 1,
        Administrador = 2,
        Invitado = 3,
        Oyente = 4
    };

}

