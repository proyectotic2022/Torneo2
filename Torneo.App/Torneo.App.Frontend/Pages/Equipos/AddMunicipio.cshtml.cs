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
    public class AddMunicipioModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Equipo equipo {get; set;}
        public IEnumerable<Municipio> municipios {get; set;}
        public AddMunicipioModel(IRepositorioEquipo repoEquipo, IRepositorioMunicipio repoMunicipio)
        {
            _repoEquipo = repoEquipo;
            _repoMunicipio = repoMunicipio;
        }

        public void OnGet(int id)
        {
            equipo = _repoEquipo.GetEquipo(id);
            municipios = _repoMunicipio.GetAllMunicipios();
        }

        public IActionResult OnPost(int idEquipo, int idMunicipio)
        {
            _repoEquipo.AsignarEquipo_Municipio(idEquipo, idMunicipio);
            return RedirectToPage("Details", new{id = idEquipo});
        }
    }
}
