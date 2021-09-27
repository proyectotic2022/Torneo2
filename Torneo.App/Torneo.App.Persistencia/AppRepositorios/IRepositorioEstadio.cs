using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioEstadio
    {
        IEnumerable<Estadio> GetAllEstadios();
        Estadio AddEstadio(Estadio estadio);
        Estadio UpdateEstadio(Estadio estadio);
        void DeleteEstadio(int id);    
        Estadio GetEstadio(int id);
    }
}