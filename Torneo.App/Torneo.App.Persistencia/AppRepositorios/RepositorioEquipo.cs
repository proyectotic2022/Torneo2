using System.Collections.Generic;
using Torneo.App.Dominio;

namespace Torneo.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext = new AppContext();

        //Agregar equipo
        public Equipo AddEquipo(Equipo equipo)
        {
            var equipoAdicionado = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity;
        }

        //Eliminar equipo
        public void DeleteEquipo(int id)
        {
            var equipoEncontrado = _appContext.Equipos.Find(id);
            if (equipoEncontrado == null)
                return;
            _appContext.Equipos.Remove(equipoEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todos los equipos
        public IEnumerable<Equipo> GetAllEquipos()
        {
            return _appContext.Equipos;
        }

        //Mostrar un equipo
        public Equipo GetEquipo(int id)
        {
            return _appContext.Equipos.Find(id);
        }

        //Actualizar equipo
        public Equipo UpdateEquipo(Equipo equipo, Municipio municipio, Jugador jugador, DirectorTecnico directortecnico, Desempeno desempeno)
        {
            var equipoEncontrado = _appContext.Equipos.Find(equipo.id);
            var idMunicipio = _appContext.Municipios.Find(municipio.id);
            var idDT = _appContext.DirectoresTecnicos.Find(directortecnico.id);
             var idJugador = _appContext.Jugadores.Find(jugador.id);
            var idDesempeno = _appContext.Desempenos.Find(desempeno.id);
            if (equipoEncontrado != null)
            {
                equipoEncontrado.nombre = equipo.nombre;
                idDT.id = directortecnico.id;
                idJugador.id = jugador.id;
                idMunicipio.id = municipio.id;
                idDesempeno.id = desempeno.id;
                _appContext.SaveChanges();
            }
            return equipoEncontrado;
        }
    }
}