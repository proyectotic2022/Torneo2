using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Novedades
{
    public class AddJugadorModel : PageModel
    {
        private readonly IRepositorioNovedad _RepoNovedad;
        private readonly IRepositorioJugador _RepoJugador;
        public Novedad novedad { get; set; }
        public IEnumerable<Jugador> jugadores { get; set; }
        public AddJugadorModel(IRepositorioNovedad repoNovedad, IRepositorioJugador repoJugador)
        {
            _RepoNovedad = repoNovedad;
            _RepoJugador = repoJugador;
        }
        public void OnGet(int id)
        {
            novedad = _RepoNovedad.GetNovedad(id);
            jugadores = _RepoJugador.GetAllJugadores();
        }
        public IActionResult OnPost(int id_novedad, int id_jugador)
        {
            _RepoNovedad.AsignarNovedad_Jugador(id_novedad, id_jugador);
            return RedirectToPage("Details", new { id = id_novedad });
        }
    }
}
