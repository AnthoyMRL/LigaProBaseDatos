using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LigaProBaseDatos.Models
{
    public class Jugador
    {
        [Key]
        public int JugadorId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int NumeroCamiseta { get; set; }

        public int Goles { get; set; }

        public int Asistencias { get; set; }
        [DataType(DataType.Currency)]
        public decimal Sueldo { get; set; }

        public string Posicion { get; set; } // Característica extra (puede ser: delantero, mediocampista, etc.)

        // Relación: Jugador pertenece a un equipo
       
        public int EquipoId { get; set; }
        [ForeignKey("EquipoId")]
        public virtual Equipo? Equipo { get; set; }
    }
}