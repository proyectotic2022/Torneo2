using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.DirectoresTecnicos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _RepoDT;
        public DirectorTecnico directorTecnico {get; set;}
        public CreateModel(IRepositorioDirectorTecnico repoDT)
        {
            _RepoDT = repoDT;
        }
        public void OnGet()
        {
            directorTecnico = new DirectorTecnico();
        }
        public IActionResult OnPost(DirectorTecnico directorTecnico)
        {
            if(ModelState.IsValid)
            {
                _RepoDT.AddDT(directorTecnico);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }          
    }
}
