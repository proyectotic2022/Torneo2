using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Jugadores
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioJugador _RepoJugador;
        private readonly IRepositorioEquipo _RepoEquipo;
        private readonly IRepositorioPosicion _RepoPosicion;
        public Jugador jugador {get; set;}
        public IEnumerable<Equipo> equipos {get; set;}
        public IEnumerable<Posicion> posiciones {get; set;}
        public EditModel(IRepositorioJugador repoJugador, IRepositorioEquipo repoEquipo, IRepositorioPosicion repoPosicion)
        {
            _RepoJugador = repoJugador;
            _RepoEquipo = repoEquipo;
            _RepoPosicion = repoPosicion;
        }
        public void OnGet(int id)
        {
            jugador = _RepoJugador.GetJugador(id);
            equipos = _RepoEquipo.GetAllEquipos();
            posiciones = _RepoPosicion.GetAllPosiciones();
        }
        public IActionResult OnPost(int id_jugador, int id_equipo, int id_posicion)
        {
            _RepoJugador.AsignarJugador_Equipo(id_jugador, id_equipo);
            _RepoJugador.AsignarPosicion_Jugador(id_jugador, id_posicion);
            return RedirectToPage("Details", new{id = id_jugador});
        }
    }
}
