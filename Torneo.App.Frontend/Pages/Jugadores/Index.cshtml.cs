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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioJugador _RepoJugador;
        public IEnumerable<Jugador> jugadores {get; set;}
        public string bActual{get;set;} 
        public IndexModel(IRepositorioJugador repoJugador)
        {
            _RepoJugador = repoJugador;
        }        
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                jugadores = _RepoJugador.GetAllJugadores();
            }
            else
            {
                bActual = b;
                jugadores = _RepoJugador.SearchJugador(b);
            }
        }
    }
}
