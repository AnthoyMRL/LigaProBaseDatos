using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LigaProBaseDatos.Models;

namespace LigaProBaseDatos.Data
{
    public class LigaProTallerContext : DbContext
    {
        public LigaProTallerContext (DbContextOptions<LigaProTallerContext> options)
            : base(options)
        {
        }

        public DbSet<LigaProBaseDatos.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<LigaProBaseDatos.Models.Jugador> Jugador { get; set; } = default!;
    }
}
