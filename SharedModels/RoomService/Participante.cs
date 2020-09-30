using Microsoft.AspNetCore.Identity;
using SharedModels;
using SharedModels.RoomService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class Participante : EntityBase
{
    public string Email { get; set; }
    public string Token { get; set; }
    public DateTime FechaAlta { get; set; }
    public DateTime FechaBaja { get; set; }
    public List<Asistencia> Asistencia { get; set; }
    [NotMapped]
    public List<Sala> Salas { get; set; }
    public List<SalaParticipante> SalaParticipantes { get; set; }

}

