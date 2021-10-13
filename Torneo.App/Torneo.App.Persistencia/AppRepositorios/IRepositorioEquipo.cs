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
        DirectorTecnico AsignarEquipo_DirectorTecnico(int idEquipo, int idDirectorTecnico);
        Municipio AsignarEquipo_Municipio(int idEquipo, int idMunicipio);
        Desempeno AsignarEquipo_Desempeno(int idEquipo, int idDesempeno);
    }
}