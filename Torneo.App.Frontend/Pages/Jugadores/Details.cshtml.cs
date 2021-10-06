using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Jugadores
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioJugador _RepoJugador;
        public Jugador jugador {get; set;}
        public DetailsModel(IRepositorioJugador repoJugador)
        {
            _RepoJugador = repoJugador;
        }
        public IActionResult OnGet(int id)
        {
            jugador = _RepoJugador.GetJugador(id);
            if(jugador == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
    }
}
