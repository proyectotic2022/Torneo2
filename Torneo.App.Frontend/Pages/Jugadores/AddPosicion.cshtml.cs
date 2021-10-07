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
    public class AddPosicionModel : PageModel
    {
        private readonly IRepositorioJugador _RepoJugador;
        private readonly IRepositorioPosicion _RepoPosicion;
        public Jugador jugador {get; set;}
        public IEnumerable<Posicion> posiciones {get; set;}
        public AddPosicionModel(IRepositorioJugador repoJugador, IRepositorioPosicion repoPosicion)
        {
            _RepoJugador = repoJugador;
            _RepoPosicion = repoPosicion;
        }
        public void OnGet(int id)
        {
            jugador = _RepoJugador.GetJugador(id);
            posiciones = _RepoPosicion.GetAllPosiciones();
        }
        public IActionResult OnPost(int id_jugador, int id_posicion)
        {
            _RepoJugador.AsignarPosicion_Jugador(id_jugador, id_posicion);
            return RedirectToPage("Details", new{id = id_jugador});
        }   
    }
}
