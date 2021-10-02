using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioMunicipio
    {
        IEnumerable<Municipio> GetAllMunicipios();
        Municipio AddMunicipio(Municipio municipio);
        Municipio UpdateMunicipio(Municipio municipio);
        void DeleteMunicipio(int id);    
        Municipio GetMunicipio(int id);
    }
}