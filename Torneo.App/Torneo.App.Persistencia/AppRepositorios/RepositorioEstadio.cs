using  System;
using  System . Collections . Generic ;
using  Torneo . App . Dominio ;
using  System . Linq;
 
namespace  Torneo . App . Persistencia
{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        //este es el constructor
        private  readonly  AppContext  _appContext  =  new  AppContext ();
 
        //Inserto Estadio
       public  Estadio  AddEstadio ( Estadio  estadio )
        {
            var  estadioAdicionado  =  _appContext . Estadios . Add ( estadio );
            _appContext . SaveChanges (); //Guardo 
            return  estadioAdicionado . Entity ;
        }
        
        
        //Elimino Estadio
        public  void  DeleteEstadio ( int  id )  
        {
           var  estadioEncontrado  =  _appContext . Estadios . Find ( id ); 
            if ( estadioEncontrado  ==  null )
                return ;
            _appContext . Estadios . Remove ( estadioEncontrado );
            _appContext . SaveChanges (); //Guardo 
        }
        
 
        //Mostrar todos los estadios 
        public  IEnumerable < Estadio > GetAllEstadios ()
        {
            return _appContext . Estadios  ;
        }
       
        //Mostrar un estadio
        public  Estadio  GetEstadio ( int  id ) 
        {
            return _appContext . Estadios . Find ( id );
        }
 
        //Actuslizar estadio 
        public Estadio   UpdateEstadio ( Estadio  estadio , Municipio municipio)
        {
            var  estadioEncontrado  =  _appContext . Estadios . Find ( estadio . id ); 
            var   idMunicipio =  _appContext . Municipios . Find ( municipio . id );
            if ( estadioEncontrado  !=  null )
            {
                /*Aqui traigo todos los campos a excepacion de la llave primaria porque la llave primaria no
                se puede modificar*/
                estadioEncontrado . nombreEstadio  =  estadio . nombreEstadio ;
                estadioEncontrado . direccionEstadio  =  estadio . direccionEstadio ;
                idMunicipio . id = municipio . id ;
                _appContext . SaveChanges (); //Guardo 
            }
            return  estadioEncontrado ;
        }

        //Insertar un municipio para Estadios 
        public Municipio AsignarMunicipio (int id_estadio ,int id_municipio){
            var e_encontrado = _appContext.Estadios.FirstOrDefault(e => e.id == id_estadio);
            if (e_encontrado != null){
                var m_encontrado = _appContext.Municipios.FirstOrDefault(m => m.id == id_municipio);
                if (m_encontrado != null){
                e_encontrado.municipio = m_encontrado;
                _appContext.SaveChanges();
                }
                return m_encontrado;
            }
            return null;
        }
            
            
               
        
    }
}
