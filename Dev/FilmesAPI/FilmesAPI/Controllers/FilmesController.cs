using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController] // definir classe como controladora
    [Route("[controller]")] // rota explicitada 
    public class FilmesController: ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        // verbo Post para add filme, quando estamos criando um recurso novo no sistema
        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] Filme filme) // parametro envia atraves do corpo da requisao... 
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperarFilmePorID), new {Id = filme.Id}, filme);

        }

        // Recuperar uma informação
        [HttpGet]
        public IActionResult RecuperarFilmes()
        {
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarFilmePorID(int id)
        {
            Filme filme = filmes.FirstOrDefault(filme => filme.Id ==id);
            if(filme != null)
            {
                return Ok(filme);
            }
            return NotFound();

        }

    }
}
