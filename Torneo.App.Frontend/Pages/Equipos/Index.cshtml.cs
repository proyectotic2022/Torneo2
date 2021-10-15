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
        public string bActual { get; set; }
        public IndexModel(IRepositorioEquipo repoEquipo)
        {
            _RepoEquipo = repoEquipo;
        }
        public void OnGet(string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                equipos = _RepoEquipo.GetAllEquipos();
            }
            else
            {
                bActual = b;
                equipos = _RepoEquipo.SearchEquipo(b);
            }
        }
    }
}
