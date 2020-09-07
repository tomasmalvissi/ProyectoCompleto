using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SharedModels.UserService
{
    public class Empresa : EntityBase
    {
        [Required]
        public int idEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string CUIL { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public string Logo { get; set; }
    }
}
