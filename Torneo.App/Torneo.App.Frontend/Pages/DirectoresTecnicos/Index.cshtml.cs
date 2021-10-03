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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDT _RepoDT;
        public IEnumerable<DirectorTecnico> directoresTecnicos {get; set;}
        public IndexModel(IRepositorioDT repoDT)
        {
            _RepoDT = repoDT;
        }

        public void OnGet()
        {
            directoresTecnicos = _RepoDT.GetAllDT();
        }
    }
}
