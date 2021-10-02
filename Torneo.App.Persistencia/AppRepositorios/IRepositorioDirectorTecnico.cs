using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
        IEnumerable<DirectorTecnico> GetAllDT();
        DirectorTecnico AddDT(DirectorTecnico directortecnico);
        DirectorTecnico UpdateDT(DirectorTecnico directortecnico);
        void DeleteDT(int id);    
        DirectorTecnico GetDT(int id);
    }
}