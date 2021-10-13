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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDesempeno _repoDesempeno;
        public IEnumerable<Desempeno> desempenos {get; set;}
        public IndexModel(IRepositorioDesempeno repoDesempeno)
        {
            _repoDesempeno = repoDesempeno;
        }
        public void OnGet()
        {
            desempenos = _repoDesempeno.GetAllDesempenos();
        }
    }
}
