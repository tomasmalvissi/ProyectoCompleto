using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StreamingAPI;

namespace RoomServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalasControllers : ControllerBase
    {
        private readonly StreamingAPI.DbContext dataContext;

        public SalasControllers(StreamingAPI.DbContext context)
        {
            this.dataContext = context;
        }


        [HttpGet]
        public async Task<List<Sala>> GetAll()
        {

            List<Sala> listaSalas = await dataContext.Salas.ToListAsync();
            return listaSalas;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Sala>> GetAllbyId(int idSala)
        {
            {
                var sala = await dataContext.Salas.FindAsync(idSala);
                if (sala == null)
                    return NotFound();

                return sala;
            }
        }

        [HttpDelete("{idSala}")]
        public async Task<ActionResult<Sala>> DeleteRoom(int idSala)
        {
            var sala = await dataContext.Salas.FindAsync(idSala);
            if (sala == null)
                return NotFound();

            dataContext.Salas.Remove(sala);
            await dataContext.SaveChangesAsync();
            return sala;
        }

        [HttpGet("{Usuario}")]
        public async Task<List<UserEMPRESA>> GetUsers()
        {
            List<UserEMPRESA> listaUsuarios = await dataContext.userEMPRESAS.ToListAsync();
            return listaUsuarios;      
        }
    }
}
