using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
           new Evento (){
                EventoId = 1,
                Tema = "angular 11 e core 5",
                Local = "Taubate",
                Lote = "1",
                QtdPessoas = 14,
                DataEvento = DateTime.Now.AddDays(2).ToString()

            },
            new Evento (){
                EventoId = 2,
                Tema = "angular 11 e core 5 - 2",
                Local = "Taubate - 2",
                Lote = "2",
                QtdPessoas = 20,
                DataEvento = DateTime.Now.AddDays(4).ToString()

            }
        };


        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(x=>x.EventoId == id);
        }

        
        [HttpPost]
        public String Post()
        {
            return "retorna post";
        }

        
        [HttpPut("{id}")]
        public String Put(int id)
        {
            return $"retorna put: {id}";
        }

        
        [HttpDelete("{id}")]
        public String Delete(int id)
        {
            return $"retorna Delete: {id}";
        }
    }
}
