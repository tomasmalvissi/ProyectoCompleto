using System.ComponentModel.DataAnnotations;

namespace SharedModels.UserService
{
    public class ClienteEmpresa : EntityBase
    {

        
        public Empresa Empresa { get; set; }
      
        public Cliente Cliente { get; set; }
    }
}
