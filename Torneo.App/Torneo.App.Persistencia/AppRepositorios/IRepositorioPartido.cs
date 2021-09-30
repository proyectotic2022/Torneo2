using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioPartido
    {
        IEnumerable<Partido> GetAllPartidos();
        Partido AddPartido(Partido partido);
        Partido UpdatePartido(Partido partido, Arbitro arbitro, Equipo equipo, Estadio estadio);
        void DeletePartido(int id);    
        Partido GetPartido(int id);
        Arbitro AsignarArbitro(int id_Partido, int id_Arbitro);
        Equipo AsignarEquipoA(int id_partido, int id_equipo);
    }
}