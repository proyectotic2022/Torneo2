using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioNovedad
    {
        IEnumerable<Novedad> GetAllNovedades();
        IEnumerable<Novedad> SearchNovedad(string nombre);
        Novedad AddNovedad(Novedad novedad);
        Novedad UpdateNovedad(Novedad novedad);
        void DeleteNovedad(int id);    
        Novedad GetNovedad(int id);
        Jugador AsignarNovedad_Jugador(int id_novedad, int id_jugador);
    }
}