using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Desempenos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDesempeno _repoDesempeno;
        public Desempeno desempeno {get; set;}
        public CreateModel(IRepositorioDesempeno repoDesempeno)
        {
            _repoDesempeno = repoDesempeno;
        }
        public void OnGet()
        {
            desempeno = new Desempeno();
        }
        public IActionResult OnPost(Desempeno desempeno)
        {
            if (ModelState.IsValid)
            {
                _repoDesempeno.AddDesempeno(desempeno);
                return RedirectToPage("Index");
            }else
            {
                return Page();
            }            
        }
    }
}
