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
    public class AddDirectorTecnicoModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioDT _repoDT;
        public Equipo equipo {get; set;}
        public IEnumerable<DirectorTecnico> directoresTecnicos {get; set;}
        public AddDirectorTecnicoModel(IRepositorioEquipo repoEquipo, IRepositorioDT repoDT)
        {
            _repoEquipo = repoEquipo;
            _repoDT = repoDT;
        }

        public void OnGet(int id)
        {
            equipo = _repoEquipo.GetEquipo(id);
            directoresTecnicos = _repoDT.GetAllDT();
        }

        public IActionResult OnPost(int id_equipo, int id_DT)
        {
            _repoEquipo.AsignarEquipo_DirectorTecnico(id_equipo, id_DT);
            return RedirectToPage("Details", new{id = id_equipo});
        }   
    }
}
