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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNovedad _RepoNovedad;
        public IEnumerable<Novedad> novedades {get; set;}
        public string bActual { get; set; }
        public IndexModel(IRepositorioNovedad repoNovedad)
        {
            _RepoNovedad = repoNovedad;
        }        
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                novedades = _RepoNovedad.GetAllNovedades();
            }
            else
            {
                bActual = b;
                novedades = _RepoNovedad.SearchNovedad(b);
            }
        }
    }
}
