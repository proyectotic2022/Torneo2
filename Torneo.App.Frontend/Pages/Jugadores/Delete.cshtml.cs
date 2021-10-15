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
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioJugador _RepoJugador;
        public Jugador jugador {get; set;}
        public DeleteModel(IRepositorioJugador repoJugador)
        {
            _RepoJugador = repoJugador;
        }
        public IActionResult Delete(int id)
        {
            jugador = _RepoJugador.GetJugador(id);
            _RepoJugador.DeleteJugador(id);
            return Page();
        } 
    }
}
