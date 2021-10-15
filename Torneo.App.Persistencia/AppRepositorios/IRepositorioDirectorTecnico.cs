using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
        IEnumerable<DirectorTecnico> GetAllDT();
        IEnumerable<DirectorTecnico> SearchDirectorTecnico(string nombre);
        DirectorTecnico AddDT(DirectorTecnico directortecnico);
        DirectorTecnico UpdateDT(DirectorTecnico directortecnico);
        void DeleteDT(int id);    
        DirectorTecnico GetDT(int id);
    }
}