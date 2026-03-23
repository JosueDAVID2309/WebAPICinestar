using Microsoft.AspNetCore.Mvc;
using WebAPICinestar.Controllers.dao;
using WebAPICinestar.DTO;

namespace WebAPICinestar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CineController : Controller
    {
        daoCine daoCine = new daoCine();

        [HttpGet]
        public IActionResult GetCines()
        {
            var cines = daoCine.getCines();
            return Ok(cines);
        }

        [HttpGet("{id}")]
        public IActionResult GetCine(int id)
        {
            var cine = daoCine.getCine(id);
            if (cine == null)
                return NotFound();

            var result = new CineDetalleDTO
            {
                cine = cine,
                Tarifas = daoCine.getCineTarifas(id),
                Peliculas = daoCine.getCinePeliculas(id)
            };

            return Ok(result);
        }
    }
}
