using Microsoft.AspNetCore.Mvc;
using WebAPICinestar.Controllers.dao;

namespace WebAPICinestar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculaController : Controller
    {
        daoPelicula daoPelicula = new daoPelicula();

        [HttpGet("esatdo/{idEstado}")]
        public IActionResult GetPeliculas(int idEstado)
        {
            var peliculas = daoPelicula.getPeliculas(idEstado);
            return Ok(peliculas);
        }

        [HttpGet("{id}")]
        public IActionResult GetPelicula(int id)
        {
            var pelicula = daoPelicula.getPelicula(id);
            if (pelicula == null)
                return NotFound();

            return Ok(pelicula);
        }
    }
}
