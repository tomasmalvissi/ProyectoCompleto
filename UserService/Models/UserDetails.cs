using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Models
{
    public class UserDetails
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public int Id { get; set; }

        [Required]
        public string Provincia { get; set; }

        public string Pais { get; set; }

        [Required]
        public string NombreCompleto { get; set; }
        [Required]
        public string CUIL { get; set; }
        [Required]
        public DateTime FechaNac { get; set; }

        public string Foto { get; set; }

    }
}
