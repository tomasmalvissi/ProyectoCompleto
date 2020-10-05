using Microsoft.AspNetCore.Identity;
using SharedModels;
using SharedModels.RoomService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Sala : EntityBase
{
    public string NombreSala { get; set; }
    public DateTime? FechaBaja { get; set; }
    public DateTime? FechaUltimoUso { get; set; }
    public DateTime? TiempoAcumuladoUso { get; set; }
    [NotMapped]
    public List<Participante> Participante { get; set; }
    public List<SalaParticipante> SalaParticipantes { get; set; }
    public string PasswordSala { get; set; }
    public bool ControlAsistencia { get; set; }
    public bool EsPersistente { get; set; }

 }