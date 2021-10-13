using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Equipos
{
    public class AddDesempenoModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioDesempeno _repoDesempeno;
        public Equipo equipo {get; set;}
        public IEnumerable<Desempeno> desempenos {get; set;}
        public AddDesempenoModel(IRepositorioEquipo repoEquipo, IRepositorioDesempeno repoDesempeno)
        {
            _repoEquipo = repoEquipo;
            _repoDesempeno = repoDesempeno;
        }

        public void OnGet(int id)
        {
            equipo = _repoEquipo.GetEquipo(id);
            desempenos = _repoDesempeno.GetAllDesempenos();
        }

        public IActionResult OnPost(int idEquipo, int idDesempeno)
        {
            _repoEquipo.AsignarEquipo_Desempeno(idEquipo, idDesempeno);
            return RedirectToPage("Details", new{id = idEquipo});
        }
    }
}
