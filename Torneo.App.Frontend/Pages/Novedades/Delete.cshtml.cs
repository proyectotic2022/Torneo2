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
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioNovedad _RepoNovedad;
        private readonly IRepositorioJugador _RepoJugador;
        public Novedad novedad {get; set;}
        public IEnumerable<Jugador> jugadores {get; set;}       
        public DeleteModel(IRepositorioNovedad repoNovedad, IRepositorioJugador repoJugador)
        {
            _RepoNovedad = repoNovedad;
            _RepoJugador = repoJugador;
        }        
        public IActionResult OnGet(int id)
        {
            novedad = _RepoNovedad.GetNovedad(id);
            if(novedad == null)
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
            _RepoNovedad.DeleteNovedad(id);
            return RedirectToPage("Index");
            //return RedirectToPage("Delete", new {id = 1});
        } 
    }
}
