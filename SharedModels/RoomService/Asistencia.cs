using Microsoft.AspNetCore.Identity;
using SharedModels;
using System;

public class Asistencia : EntityBase
{
    public UserEmp UserEmp { get; set; }
    public int Id_Salas { get; set; }
    public DateTime? FechaIngreso { get; set; }
    public DateTime? FechaEgreso { get; set; }
    public Roles Rol_Usuario { get; set; }
}