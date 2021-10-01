/*using System.Collections.Generic;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioArbitro: IRepositorioArbitro
    {
        
        private readonly AppContext _appContext;
        public RepositorioArbitro (AppContext appContext)
        {
            _appContext = appContext;
        }
        // Agregar arbitro
        public Arbitro AddArbitro (Arbitro arbitro)
        {
            var arbitroAdicionado = _appContext.Arbitros.Add (arbitro);
            _appContext.SaveChanges ();
            return arbitroAdicionado.Entity;
        }

        // Eliminar arbitro
        public void DeleteArbitro (int id){ 

            var arbitroEncontrado = _appContext.Arbitros.Find (id);
            if (arbitroEncontrado == null)
                regreso;
            _appContext.Arbitros.Remove (arbitroEncontrado);
            _appContext.SaveChanges ();
        }


        // Mostrar todos los arbitros
        public IEnumerable <Arbitro> GetAllArbitros ()
        {
            return _appContext.Arbitros;
        }
        // Mostrar un arbitro
        public Arbitro GetArbitro (int id)
        {
            return _appContext.Arbitros.Find (id);
        }
        // Actualizar arbitro
        
        public Arbitro  UpdateArbitro (Arbitro arbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find (arbitro.id);
            // var idcolegio = _appContext.Colegio.Find (colegio.id);
            if (arbitroEncontrado! = null)
            {
                arbitroEncontrado.nombre = arbitro.nombre;
                arbitroEncontrado.documento = arbitro.documento;
                arbitroEncontrado.telefono = arbitro.telefono;
                arbitroEncontrado.colegio = arbitro.colegio;
                //idcolegio.id = colegio.id;                
            }
            return arbitroEncontrado;
        }
    }
}*/

using  System . Collections . Generic ;
using  Torneo . App . Dominio ;

namespace  Torneo . App . Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        //este es el constructor
        private  readonly  AppContext  _appContext  =  new  AppContext ();

    
         
        
       public  Arbitro  AddArbitro ( Arbitro  arbitro )
        {
            var  arbitroAdicionado  =  _appContext . Arbitros . Add ( arbitro );
            _appContext . SaveChanges (); //Guardo 
            return  arbitroAdicionado . Entity ;
        }
        
        
        
        public  void  DeleteArbitro ( int  id )  
        {
           var  arbitroEncontrado  =  _appContext . Arbitros . Find ( id ); 
            if ( arbitroEncontrado  ==  null )
                return ;
            _appContext . Arbitros . Remove ( arbitroEncontrado );
            _appContext . SaveChanges (); //Guardo 
        }

        public  IEnumerable < Arbitro > GetAllArbitros ()
        {
            return _appContext . Arbitros  ;
        }

        public  Arbitro  GetArbitro ( int  id ) //aqui id arbitro 
        {
            return _appContext . Arbitros . Find ( id );
        }

         public Arbitro   UpdateArbitro ( Arbitro  arbitro )
        {
            var  arbitroEncontrado  =  _appContext . Arbitros . Find ( arbitro . id ); 
            if ( arbitroEncontrado  !=  null )
            {
                /*Aqui traigo todos los campos a excepacion de la llave primaria porque la llave primaria no
                se puede modificar*/
                arbitroEncontrado.nombreArbitro = arbitro.nombreArbitro;
                arbitroEncontrado.documentoArbitro = arbitro.documentoArbitro;
                arbitroEncontrado.telefonoArbitro = arbitro.telefonoArbitro;
                arbitroEncontrado.colegioArbitro = arbitro.colegioArbitro;
                _appContext . SaveChanges (); //Guardo 
            }
            return  arbitroEncontrado ;
        }
    }
}