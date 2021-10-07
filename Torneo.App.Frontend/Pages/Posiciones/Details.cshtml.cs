using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Posiciones
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioPosicion _RepoPosicion;
        public Posicion posicion {get; set;}
        public DetailsModel(IRepositorioPosicion repoPosicion)
        {
            _RepoPosicion = repoPosicion;
        }
        public IActionResult OnGet(int id)
        {
            posicion = _RepoPosicion.GetPosicion(id);
            if(posicion == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
    }
}
