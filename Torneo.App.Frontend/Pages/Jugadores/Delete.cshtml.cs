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
        private readonly IRepositorioEquipo _RepoEquipo;
        private readonly IRepositorioPosicion _RepoPosicion;
        public Jugador jugador {get; set;}
        public IEnumerable<Equipo> equipos {get; set;}
        public IEnumerable<Posicion> posiciones {get; set;}        
        public DeleteModel(IRepositorioJugador repoJugador, IRepositorioEquipo repoEquipo, IRepositorioPosicion repoPosicion)
        {
            _RepoJugador = repoJugador;
            _RepoEquipo = repoEquipo;
            _RepoPosicion = repoPosicion;            
        }
        public IActionResult OnGet(int id)
        {
            jugador = _RepoJugador.GetJugador(id);
            if(jugador == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(int id)
        {
            _RepoJugador.DeleteJugador(id);
            return RedirectToPage("Index");
            //return RedirectToPage("Delete", new {id = 1});
        }   
    }
}
