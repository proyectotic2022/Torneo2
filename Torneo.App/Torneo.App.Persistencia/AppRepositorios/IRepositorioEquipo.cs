using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioEquipo
    {
        IEnumerable<Equipo> GetAllEquipos();
        Equipo AddEquipo(Equipo equipo);
        Equipo UpdateEquipo(Equipo equipo);
        void DeleteEquipo(int id);    
        Equipo GetEquipo(int id);
        DirectorTecnico AsignarDirectorTecnico(int id_Equipo, int id_DirectorTecnico);
        Municipio AsignarMunicipio(int id_Equipo, int id_Municipio);
        Desempeno AsignarDesempeno(int id_Equipo, int id_Desempeno);
    }
}