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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPosicion _RepoPosicion;
        public IEnumerable<Posicion> posiciones { get; set; }
        public string bActual { get; set; }
        public IndexModel(IRepositorioPosicion repoPosicion)
        {
            _RepoPosicion = repoPosicion;
        }
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                posiciones = _RepoPosicion.GetAllPosiciones();
            }
            else
            {
                bActual = b;
                posiciones = _RepoPosicion.SearchPosicion(b);
            }
        }
    }
}
