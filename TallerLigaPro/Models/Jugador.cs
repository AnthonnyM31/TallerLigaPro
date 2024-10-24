using System.ComponentModel.DataAnnotations;

namespace TallerLigaPro.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }
        public Equipo Equipo { get; set; }
        public int EquipoId { get; set; }
    }
}
