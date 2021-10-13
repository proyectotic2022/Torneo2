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
    public class EditModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioDT _repoDT;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Equipo equipo {get; set;}
        public IEnumerable<DirectorTecnico> directoresTecnicos {get; set;}
        public IEnumerable<Municipio> municipios {get; set;}
        public EditModel(IRepositorioEquipo repoEquipo, IRepositorioDT repoDT, IRepositorioMunicipio repoMunicipio)
        {
            _repoEquipo = repoEquipo;
            _repoDT = repoDT;
            _repoMunicipio = repoMunicipio;
        }
        public IActionResult OnGet(int id)
        {
            equipo = _repoEquipo.GetEquipo(id);
            directoresTecnicos = _repoDT.GetAllDT();
            municipios = _repoMunicipio.GetAllMunicipios();
            if (equipo == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Equipo equipo, int idEquipo, int idDirectorTecnico, int idMunicipio)
        {
            _repoEquipo.UpdateEquipo(equipo);
            _repoEquipo.AsignarEquipo_DirectorTecnico(idEquipo, idDirectorTecnico);
            _repoEquipo.AsignarEquipo_Municipio(idEquipo, idMunicipio);
            return RedirectToPage("Details", new{id = idEquipo});
        }
    }
}
