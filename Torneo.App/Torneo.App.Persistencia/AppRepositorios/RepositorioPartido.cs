using System.Collections.Generic;
using Torneo.App.Dominio;
using System.Linq;

namespace Torneo.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly AppContext _appContext = new AppContext();

        //Agregar partido
        public Partido AddPartido(Partido partido)
        {
            var partidoAdicionado = _appContext.Partidos.Add(partido);
            _appContext.SaveChanges();
            return partidoAdicionado.Entity;
        }

        //Eliminar partido
        public void DeletePartido(int id)
        {
            var partidoEncontrado = _appContext.Partidos.Find(id);
            if (partidoEncontrado == null)
                return;
            _appContext.Partidos.Remove(partidoEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todos los partidos
        public IEnumerable<Partido> GetAllPartidos()
        {
            return _appContext.Partidos;
        }

        //Mostrar un partido
        public Partido GetPartido(int id)
        {
            return _appContext.Partidos.Find(id);
        }

        //Actualizar partido
        public Partido UpdatePartido(Partido partido, Arbitro arbitro, Equipo equipo, Estadio estadio)
        {
            var partidoEncontrado = _appContext.Partidos.Find(partido.id);
            var idArbitro = _appContext.Arbitros.Find(arbitro.id);
            var idEquipoA = _appContext.Equipos.Find(equipo.id);
            var idEquipoB = _appContext.Equipos.Find(equipo.id);
            var idEstadio = _appContext.Estadios.Find(estadio.id);
            if (partidoEncontrado != null)
            {
                partidoEncontrado.nombre = partido.nombre;
                partidoEncontrado.fecha = partido.fecha;
                partidoEncontrado.marcadorInicalEL = partido.marcadorInicalEL;
                partidoEncontrado.marcadorInicialEV = partido.marcadorInicialEV;
                idArbitro.id = arbitro.id;
                idEquipoA.id = equipo.id;
                idEquipoB.id = equipo.id;
                idEstadio.id = estadio.id;
                _appContext.SaveChanges();
            }
            return partidoEncontrado;
        }

        public Arbitro AsignarArbitro(int idpartido, int idarbitro)
        {
            var p_encontrado = _appContext.Partidos.FirstOrDefault(p=>p.id==idpartido);
            if(p_encontrado!=null)
            {
             var a_encontrado=_appContext.Arbitros.FirstOrDefault(a=>a.id==idarbitro);
             if(a_encontrado!=null)
             {
                 p_encontrado.arbitros=a_encontrado;
                 _appContext.SaveChanges();
             }
             return a_encontrado;

            }
            return null;
        }
        public Equipo AsignarEquipoA(int id_partido, int id_equipo)
        {
            var p_encontrado=_appContext.Partidos.FirstOrDefault(p=>p.id==id_partido);
            if(p_encontrado!= null)
            {
             var e_encontrado=_appContext.Equipos.FirstOrDefault(e=>e.id==id_equipo);
             if(e_encontrado!=null)
             {
               p_encontrado.equipoa=e_encontrado;
               _appContext.SaveChanges();
             }
             return e_encontrado;
            }
            return null;
        }

    }
}