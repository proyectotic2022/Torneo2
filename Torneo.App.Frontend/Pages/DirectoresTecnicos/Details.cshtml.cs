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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _RepoDT;
        public DirectorTecnico directorTecnico {get; set;}
        public DetailsModel(IRepositorioDirectorTecnico repoDT)
        {
            _RepoDT = repoDT;
        }        
        public IActionResult OnGet(int id)
        {
            directorTecnico = _RepoDT.GetDT(id);
            if(directorTecnico == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
    }
}
