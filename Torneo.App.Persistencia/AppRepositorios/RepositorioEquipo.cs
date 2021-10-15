using System.Collections.Generic;
using System.Linq;
using Torneo.App.Dominio;
using Microsoft.EntityFrameworkCore;
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
        // Se define el metodo buscar Equipo
        IEnumerable<Equipo> IRepositorioEquipo.SearchEquipo(string nombre)
        {
            return _appContext.Equipos
                .Where(e => e.nombre.Contains(nombre));
        }        
        //Mostrar un equipo
        public Equipo GetEquipo(int id)
        {
            var equipo = _appContext.Equipos
            .Where(e => e.id == id)
            .Include(e => e.directorTecnico)
            .FirstOrDefault();
            equipo = _appContext.Equipos
            .Where(e => e.id == id)
            .Include(e => e.municipio)
            .FirstOrDefault();            
            return _appContext.Equipos.Find(id);
        }
        //Actualizar equipo
        public Equipo UpdateEquipo(Equipo equipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(equipo.id);            
            if (equipoEncontrado != null)
            {
                equipoEncontrado.nombre = equipo.nombre;
                _appContext.SaveChanges();
            }
            return equipoEncontrado;
        }
        //Asignar DT a equipo
        public DirectorTecnico AsignarDirectorTecnico(int idEquipo, int idDirectorTecnico)
        {
            var e_encontrado = _appContext.Equipos.FirstOrDefault(e=>e.id==idEquipo);
            if(e_encontrado!=null)
            {
             var dt_encontrado=_appContext.DirectoresTecnicos.FirstOrDefault(dt=>dt.id==idDirectorTecnico);
             if(dt_encontrado!=null)
             {
                 e_encontrado.directorTecnico=dt_encontrado;
                 _appContext.SaveChanges();
             }
             return dt_encontrado;
            }
            return null;
        }
        //Asignar Municipio a equipo
        public Municipio AsignarMunicipio(int idEquipo, int idMunicipio)
        {
            var e_encontrado = _appContext.Equipos.FirstOrDefault(e=>e.id==idEquipo);
            if(e_encontrado!=null)
            {
             var m_encontrado=_appContext.Municipios.FirstOrDefault(m=>m.id==idMunicipio);
             if(m_encontrado!=null)
             {
                 e_encontrado.municipio=m_encontrado;
                 _appContext.SaveChanges();
             }
             return m_encontrado;
            }
            return null;
        }
        //Asignar Desempeno a equipo
        public Desempeno AsignarDesempeno(int idEquipo, int idDesempeno)
        {
            var e_encontrado = _appContext.Equipos.FirstOrDefault(e=>e.id==idEquipo);
            if(e_encontrado!=null)
            {
             var d_encontrado=_appContext.Desempenos.FirstOrDefault(d=>d.id==idDesempeno);
             if(d_encontrado!=null)
             {
                 e_encontrado.desempeno=d_encontrado;
                 _appContext.SaveChanges();
             }
             return d_encontrado;
            }
            return null;
        }
    }
}