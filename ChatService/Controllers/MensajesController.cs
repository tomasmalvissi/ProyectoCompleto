using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedModels;
using SharedModels.ChatService;

namespace ChatService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensajesController : ControllerBase
    {
        private readonly DbContext context;

        public MensajesController(DbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Mensaje>> Get()
        {
            return context.Mensajes.ToList();
        }

        [HttpGet("{id}", Name = "ObtenerChatPorId")]
        public ActionResult<Mensaje> Get(int id)
        {
            var mensaje = context.Mensajes.FirstOrDefault(p => p.Id == id);
            if (mensaje == null)
            {
                return NotFound();
            }
            return mensaje;
        }

        [HttpPost]
        public ActionResult<Mensaje> Post([FromBody] Mensaje mensaje)
        {
            mensaje.ParticipanteId = 0;
            mensaje.Contenido = "";
            mensaje.Hora_Fecha_Envio = DateTime.UtcNow;

            context.Mensajes.Add(mensaje);
            context.SaveChanges();

            return new CreatedAtRouteResult("ObtenerChatPorId", new { id = mensaje.Id }, mensaje);
        }

        [HttpPut("{id}")]
        public ActionResult<Mensaje> Put(int id, [FromBody] Mensaje mensaje)
        {
            if (id != mensaje.Id)
            {
                return BadRequest();
            }

            context.Entry(mensaje).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Mensaje> Delete(int id)
        {
            var mensaje = context.Mensajes.FirstOrDefault(p => p.Id == id);
            if (mensaje == null)
            {
                return NotFound();
            }
            context.Mensajes.Remove(mensaje);
            context.SaveChanges();
            return Ok();
        }
    }
}