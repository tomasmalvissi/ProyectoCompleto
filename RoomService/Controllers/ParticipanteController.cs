using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedModels.RoomService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipanteController : ControllerBase
    {
        private readonly DataContext context;

        public ParticipanteController(DataContext context)
        {
            this.context = context;
        }

        //GET api/Patricipante
        //Retorna la lista de participanes de la sala

        [HttpGet("Participantes")]
        public ActionResult<IEnumerable<Participante>> Get()
        {
            return context.Participantes.ToList();

        }
    }
}

