using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoomService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AsistenciaController : ControllerBase
    {
        private readonly DataContext context;

        public AsistenciaController(DataContext context)
        {
            this.context = context;
        }
      
       

        // GET api/<AsistenciaController>/5
        [HttpGet("{id}")]
        public Asistencia Get(int id)
        {
            return context.Asistencias.FirstOrDefault(x => x.Id == 1);
        }

        // POST api/<AsistenciaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AsistenciaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AsistenciaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
