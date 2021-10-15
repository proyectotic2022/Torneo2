using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Posiciones
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioPosicion _RepoPosicion;
        public Posicion posicion {get; set;}
        public IEnumerable<Posicion> posiciones {get; set;}
        public EditModel(IRepositorioPosicion repoPosicion)
        {
            _RepoPosicion = repoPosicion;
        }
        public IActionResult OnGet(int id)
        {
            posicion = _RepoPosicion.GetPosicion(id);
            posiciones = _RepoPosicion.GetAllPosiciones();
            if(posicion == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Posicion posicion)
        {
            _RepoPosicion.UpdatePosicion(posicion);
            return RedirectToPage("Details", new{id = posicion.id});
        }
    }
}
