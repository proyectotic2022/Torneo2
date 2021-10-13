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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDesempeno _repoDesempeno;
        public Desempeno desempeno {get; set;}
        public DetailsModel(IRepositorioDesempeno repoDesempeno)
        {
            _repoDesempeno = repoDesempeno;
        }
        
        public IActionResult OnGet(int id)
        {
            desempeno = _repoDesempeno.GetDesempeno(id);
            if(desempeno == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
    }
}
