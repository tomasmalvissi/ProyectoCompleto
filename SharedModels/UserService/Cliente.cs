﻿using SharedModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Data
{
    public class Cliente : EntityBase
    {
        [Required]
        public string NombreCompleto { get; set; }
        [Required]
        public string CUIL { get; set; }
        [Required]
        public DateTime FechaNac { get; set; }
        [Required]
        public string Pais { get; set; }
        [Required]
        public string Provincia { get; set; }
        [Required]
        public string Localidad { get; set; }
        public string Direccion { get; set; }
        public string Foto { get; set; }

    }
}