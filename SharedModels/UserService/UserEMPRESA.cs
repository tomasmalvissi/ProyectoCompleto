using System.ComponentModel.DataAnnotations;

namespace SharedModels.UserService
{
    public class UserEMPRESA : EntityBase
    {
    
        [Required]
        public Empresa IdEmpresa { get; set; }
        [Required]
        public Cliente IdCliente { get; set; }
    }
}
