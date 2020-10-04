using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SharedModels.UserService
{
    public class Empresa : EntityBase
    {
        [Required]
        public string NombreEmpresa { get; set; }
        [Required]
        public string CUIT { get; set; } //CUIT EMPRESARIAL 
        [Required]
        public string Pais { get; set; }
        [Required]
        public string Provincia { get; set; }
        [Required]
        public string Direccion { get; set; }
        public string Logo { get; set; }

    }
}
