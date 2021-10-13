using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.DirectoresTecnicos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDT _repoDT;
        public DirectorTecnico directorTecnico {get; set;}
        public CreateModel(IRepositorioDT repoDT)
        {
            _repoDT = repoDT;
        }

        public void OnGet()
        {
            directorTecnico = new DirectorTecnico();
        }

        public IActionResult OnPost(DirectorTecnico directorTecnico)
        {
            if (ModelState.IsValid)
            {
                _repoDT.AddDT(directorTecnico);
                return RedirectToPage("Index");
            }else
            {
                return Page();
            }
            
        }
    }
}
