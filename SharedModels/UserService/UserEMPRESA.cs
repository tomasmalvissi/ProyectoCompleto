using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SharedModels.UserService
{
    public class UserEMPRESA
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public Empresa IdEmpresa { get; set; }
        [Required]
        public IdentityUser IdUser { get; set; }
    }
}
