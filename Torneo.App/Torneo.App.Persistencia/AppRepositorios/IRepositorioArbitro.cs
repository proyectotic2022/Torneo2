using System;
using System.Collections.Generic;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioArbitro
    {
        IEnumerable <Arbitro> GetAllArbitros ();
        Arbitro AddArbitro (Arbitro arbitro);
        Arbitro UpdateArbitro (Arbitro arbitro);
        void DeleteArbitro (int id);    
        Arbitro GetArbitro (int id);
    }
}