using System.Reflection.Emit;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CadastroDeSeries.Interfaces;

namespace CadastroDeSeries.Web.Controllers
{
    [Route("[controller]")]
    public class SerieController : Controller
    {
        private readonly IRepositorio<Serie> _repositorioSerie;

        public SerieController(IRepositorio<Serie> repositorioSerie)
        {
            _repositorioSerie = repositorioSerie;
        }

        [HttpGet("")]
        public IActionResult Lista()
        {
            return Ok(_repositorioSerie.Lista().Select(s => new SerieModel(s)));
        }

        [HttpPut("{id}")]
        public IActionResult Atualiza(int id, [FromBody] SerieModel model)
        {
            // model.Id = _repositorioSerie.InsereId(id);
            _repositorioSerie.Atualiza(id, model.ToSerie());
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Exclui(int id)
        {
            _repositorioSerie.Exclui(id);
            return NoContent();
        }

        [HttpPost("")]
        public IActionResult Insere(SerieModel model)
        {
            model.Id = _repositorioSerie.ProximoId();

            Serie serie = model.ToSerie();

            _repositorioSerie.Insere(serie);

            return Created("Criado ", serie);
        }

        [HttpGet("{id}")]
        public IActionResult Consulta(int id)
        {
            return Ok(new SerieModel(_repositorioSerie.Lista().FirstOrDefault(s => s.Id == id)));
        }
    }
}