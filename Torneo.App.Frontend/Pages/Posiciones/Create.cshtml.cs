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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPosicion _RepoPosicion;
        public Posicion posicion {get; set;}
        
        public CreateModel(IRepositorioPosicion repoPosicion)
        {
            _RepoPosicion = repoPosicion;
        }
        public void OnGet()
        {
            posicion = new Posicion();
        }
        public IActionResult OnPost(Posicion posicion)
        {
            if(ModelState.IsValid)
            {
                _RepoPosicion.AddPosicion(posicion);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }        
    }
}
