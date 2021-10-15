using System.Collections.Generic;
using Torneo.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Torneo.App.Persistencia
{
    public class RepositorioNovedad : IRepositorioNovedad
    {
        private readonly AppContext _appContext = new AppContext();

        //Crear novedad
        public Novedad AddNovedad(Novedad novedad)
        {
            var novedadAdicionado = _appContext.Novedades.Add(novedad);
            _appContext.SaveChanges();
            return novedadAdicionado.Entity;
        }

        //Eliminar novedad
        public void DeleteNovedad(int id)
        {
            var novedadEncontrado = _appContext.Novedades.Find(id);
            if (novedadEncontrado == null)
                return;
            _appContext.Novedades.Remove(novedadEncontrado);
            _appContext.SaveChanges();
        }

        //Mostrar todos las novedaes
        public IEnumerable<Novedad> GetAllNovedades()
        {
            return _appContext.Novedades;
        }
        // Se define el metodo buscar Novedad
        IEnumerable<Novedad> IRepositorioNovedad.SearchNovedad(string nombre)
        {
            return _appContext.Novedades
                .Where(n => n.nombre.Contains(nombre));
        }        

        //Mostrar una novedad
        Novedad IRepositorioNovedad.GetNovedad(int id)
        {
            var novedad = _appContext.Novedades
                .Where(n => n.id == id)
                .Include(n => n.jugador)
                .FirstOrDefault();
            return novedad;
        }

        //Actualizar novedad
        Novedad IRepositorioNovedad.UpdateNovedad(Novedad novedad)
        {
            var novedadEncontrada = _appContext.Novedades.Find(novedad.id);
            if (novedadEncontrada != null)
            {
                novedadEncontrada.nombre = novedad.nombre;
                novedadEncontrada.minuto = novedad.minuto;
                _appContext.SaveChanges();
            }
            return novedadEncontrada;
        }
        // Asignar Jugador a Novedad
        Jugador IRepositorioNovedad.AsignarNovedad_Jugador(int id_novedad, int id_jugador)
        {
            var n_encontrado=_appContext.Novedades.FirstOrDefault(n=>n.id==id_novedad);
            if(n_encontrado!= null)
            {
             var j_encontrado=_appContext.Jugadores.FirstOrDefault(j=>j.id==id_jugador);
             if(j_encontrado!=null)
             {
               n_encontrado.jugador=j_encontrado;
               _appContext.SaveChanges();
             }
             return j_encontrado;
            }
            return null;
        }        
    }
}