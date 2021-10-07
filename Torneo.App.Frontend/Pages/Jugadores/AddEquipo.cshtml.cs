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
    public class AddEquipoModel : PageModel
    {
        private readonly IRepositorioJugador _RepoJugador;
        private readonly IRepositorioEquipo _RepoEquipo;
        public Jugador jugador {get; set;}
        public IEnumerable<Equipo> equipos {get; set;}
        public AddEquipoModel(IRepositorioJugador repoJugador, IRepositorioEquipo repoEquipo)
        {
            _RepoJugador = repoJugador;
            _RepoEquipo = repoEquipo;

        }
        public void OnGet(int id)
        {
            jugador = _RepoJugador.GetJugador(id);
            equipos = _RepoEquipo.GetAllEquipos();
        }
        public IActionResult OnPost(int id_jugador, int id_equipo)
        {
            _RepoJugador.AsignarJugador_Equipo(id_jugador, id_equipo);
            return RedirectToPage("Details", new{id = id_jugador});
        }        
    }
}
