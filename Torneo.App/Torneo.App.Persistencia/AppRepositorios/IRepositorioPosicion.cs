using System;
using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public interface IRepositorioPosicion
    {
        IEnumerable<Posicion> GetAllPosiciones();
        Posicion AddPosicion(Posicion posicion);
        Posicion UpdatePosicion(Posicion posicion);
        void DeletePosicion(int id);    
        Posicion GetPosicion(int id);
    }
}