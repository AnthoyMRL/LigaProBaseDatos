using LigaProBaseDatos.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LigaProBaseDatos.Data;
using Microsoft.EntityFrameworkCore;

namespace LigaProBaseDatos.Controllers
{
    public class EstadisticaController : Controller
    {
        private readonly ILogger<EstadisticaController> _logger;
        private readonly LigaProTallerContext _context; // Contexto de la base de datos

        // Constructor
        public EstadisticaController(ILogger<EstadisticaController> logger, LigaProTallerContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Acción Index que pasa los datos de equipos y jugadores goleadores
        public async Task<IActionResult> Index()
        {
            var equipos = await _context.Equipo.ToListAsync();
            var jugadoresGoleadores = await _context.Jugador
                .OrderByDescending(j => j.Goles)
                .Take(10) // Cambia el número según lo que necesites
                .ToListAsync();

            var modelo = new
            {
                Equipos = equipos,
                JugadoresGoleadores = jugadoresGoleadores
            };

            return View(modelo); // Pasamos los datos a la vista
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
