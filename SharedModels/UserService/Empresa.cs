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
        public string CUIL { get; set; }
        [Required]
        public int Miembros { get; set; } //cuantos usuarios crearon una cuenta con los datos de una empresa (puedo comparar con cuil, ver logica)
        [Required]
        public string Pais { get; set; }
        [Required]
        public string Provincia { get; set; }
        [Required]
        public string Direccion { get; set; }
        public string Logo { get; set; }
    }
}
