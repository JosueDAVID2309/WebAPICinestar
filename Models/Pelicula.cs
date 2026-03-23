namespace WebAPICinestar.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string? FechaEstreno { get; set; }
        public string? Director { get; set; }
        public string? Generos { get; set; }
        public int? IdClasificacion { get; set; }
        public int? IdEstado { get; set; }
        public bool? Eliminado { get; set; }
        public string? Duracion { get; set; }
        public string Link { get; set; }
        public string? Reparto { get; set; }
        public string Sinopsis { get; set; }
        public string? Geneross { get; set; }
    }
}
