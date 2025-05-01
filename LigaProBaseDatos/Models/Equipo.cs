using System.ComponentModel.DataAnnotations;

namespace LigaProBaseDatos.Models
{
    public class Equipo
    {
        [Key]
        public int EquipoId { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosEmpatados { get; set; }
        public int PartidosPerdidos { get; set; }
        public string LogoUrl { get; set; }

        public int Puntos
        {
            get
            {
                return (PartidosGanados * 3) + (PartidosEmpatados * 1);
            }
        }

        // Relación: Un equipo tiene muchos jugadores
        public virtual ICollection<Jugador> Jugadores { get; set; }
    }
}
