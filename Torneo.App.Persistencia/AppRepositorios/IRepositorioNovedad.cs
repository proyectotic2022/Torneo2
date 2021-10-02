using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioNovedad
    {
        IEnumerable<Novedad> GetAllNovedades();
        Novedad AddNovedad(Novedad novedad);
        Novedad UpdateNovedad(Novedad novedad, Jugador jugador);
        void DeleteNovedad(int id);    
        Novedad GetNovedad(int id);
    }
}