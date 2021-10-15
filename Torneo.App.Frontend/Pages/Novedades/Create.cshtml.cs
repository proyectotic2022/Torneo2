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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioNovedad _RepoNovedad;
        public Novedad novedad {get; set;}
        public CreateModel(IRepositorioNovedad repoNovedad)
        {
            _RepoNovedad = repoNovedad;
        }
        public void OnGet()
        {
            novedad = new Novedad();
        }
        public IActionResult OnPost(Novedad novedad)
        {
            if(ModelState.IsValid)
            {
                _RepoNovedad.AddNovedad(novedad);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }


    }
}
