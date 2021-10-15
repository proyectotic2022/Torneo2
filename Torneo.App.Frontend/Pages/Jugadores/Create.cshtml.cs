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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioJugador _RepoJugador;
        public Jugador jugador {get; set;}
        public CreateModel(IRepositorioJugador repoJugador)
        {
            _RepoJugador = repoJugador;
        }
        public void OnGet()
        {
            jugador = new Jugador();
        }
        public IActionResult OnPost(Jugador jugador)
        {
            if(ModelState.IsValid)
            {
                _RepoJugador.AddJugador(jugador);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
