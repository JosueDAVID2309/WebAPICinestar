using WebAPICinestar.Models;
using WebAPICinestar.DTO;
namespace WebAPICinestar.DTO
{
    public class CineDetalleDTO
    {
        public Cine cine {  get; set; }
        public List<CinePeliculaDTO> Peliculas { get; set; }
        public List<CineTarifaDTO> Tarifas { get; set; }
    }
}
