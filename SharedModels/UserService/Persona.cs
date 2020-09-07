using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SharedModels.UserService
{
    public class Persona : EntityBase
    {
        [Required]
        public int idPersona { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNac { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string FotoPerfil { get; set; }
    }
}
