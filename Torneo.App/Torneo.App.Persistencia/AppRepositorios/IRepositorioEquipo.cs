using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioEquipo
    {
        IEnumerable<Equipo> GetAllEquipos();
        Equipo AddEquipo(Equipo equipo);
        Equipo UpdateEquipo(Equipo equipo, Municipio municipio, Jugador jugador, DirectorTecnico directortecnico, Desempeno desempeno);
        void DeleteEquipo(int id);    
        Equipo GetEquipo(int id);
    }
}