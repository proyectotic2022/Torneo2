using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Novedades
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioNovedad _RepoNovedad;
        private readonly IRepositorioJugador _RepoJugador;
        public Novedad novedad {get; set;}
        public IEnumerable<Jugador> jugadores {get; set;}
        public EditModel(IRepositorioNovedad repoNovedad, IRepositorioJugador repoJugador)
        {
            _RepoNovedad = repoNovedad;
            _RepoJugador = repoJugador;
        }
        public IActionResult OnGet(int id)
        {
            novedad = _RepoNovedad.GetNovedad(id);
            jugadores = _RepoJugador.GetAllJugadores();
            if (novedad == null)
            {
                return NotFound();
            }
            else 
            {
                return Page();
            }
        }
        public IActionResult OnPost(Novedad novedad, int id_novedad, int id_jugador)
        {
            _RepoNovedad.UpdateNovedad(novedad);
            _RepoNovedad.AsignarNovedad_Jugador(id_novedad, id_jugador);
            //return RedirectToPage("Index");
            return RedirectToPage("Details", new{id = id_novedad});
        }        
    }
}
