using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioDesempeno
    {
        IEnumerable<Desempeno> GetAllDesempenos();
        Desempeno AddDesempeno(Desempeno desempeno);
        Desempeno UpdateDesempeno(Desempeno desempeno, Partido partido);
        void DeleteDesempeno(int id);    
        Desempeno GetDesempeno(int id);
    }
}