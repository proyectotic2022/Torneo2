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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioNovedad _RepoNovedad;
        public Novedad novedad {get; set;}
        public DetailsModel(IRepositorioNovedad repoNovedad)
        {
            _RepoNovedad = repoNovedad;
        }        
        public IActionResult OnGet(int id)
        {
            novedad = _RepoNovedad.GetNovedad(id);
            if(novedad == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
    }
}
