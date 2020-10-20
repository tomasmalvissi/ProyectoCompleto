using System.ComponentModel.DataAnnotations;

namespace SharedModels.UserService
{
    public class UserEMPRESA
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public int IdUser { get; set; }
        [Required]
        public Empresa IdEmpresa { get; set; }
        [Required]
        public Cliente IdCliente { get; set; }
    }
}
