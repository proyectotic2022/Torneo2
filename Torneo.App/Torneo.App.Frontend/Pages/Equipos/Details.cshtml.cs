using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Persistencia;
using Torneo.App.Dominio;

namespace Torneo.App.Frontend.Pages.Equipos
{
        public class DetailsModel : PageModel
    {
        private readonly IRepositorioEquipo _RepoEquipo;
        public Equipo equipo {get; set;}
        public DetailsModel(IRepositorioEquipo repoEquipo)
        {
            _RepoEquipo = repoEquipo;
        }

        public IActionResult OnGet(int id)
        {
            equipo = _RepoEquipo.GetEquipo(id);
            if(equipo == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
    }
}
