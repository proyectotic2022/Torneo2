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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEquipo _RepoEquipo;
        public IEnumerable<Equipo> equipos {get; set;}
        public IndexModel(IRepositorioEquipo repoEquipo)
        {
            _RepoEquipo = repoEquipo;
        }

        public void OnGet()
        {
            equipos = _RepoEquipo.GetAllEquipos();
        }
    }
}
