using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Persistence;
using ProEventos.Domain;
using ProEventos.Application.Contratos





namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        
        private readonly IEventoService _eventoService;

        public EventosController(IEventoService eventoService)
        { 
            _eventoService = eventoService;

        }

        [HttpGet]
        public IEnumerable<Evento>Get()
        {
            try
            {
                    
            }
            catch (System.Exception)
            {
                    
           throw;
            }
        }
        
        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.Id == id);       
        }
        
        [HttpPost]
        public string Post()
        {
           return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de put com id = {id}";
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de delete com id = {id}";
        }
    }
}
