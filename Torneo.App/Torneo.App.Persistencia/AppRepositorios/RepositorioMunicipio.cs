using  System . Collections . Generic ;
using  Torneo . App . Dominio ;

namespace  Torneo . App . Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        //este es el constructor
        private  readonly  AppContext  _appContext  =  new  AppContext ();

    
         
        
       public  Municipio  AddMunicipio ( Municipio  municipio )
        {
            var  municipioAdicionado  =  _appContext . Municipios . Add ( municipio );
            _appContext . SaveChanges (); //Guardo 
            return  municipioAdicionado . Entity ;
        }
        
        
        
        public  void  DeleteMunicipio ( int  id )  
        {
           var  municipioEncontrado  =  _appContext . Municipios . Find ( id ); 
            if ( municipioEncontrado  ==  null )
                return ;
            _appContext . Municipios . Remove ( municipioEncontrado );
            _appContext . SaveChanges (); //Guardo 
        }

        public  IEnumerable < Municipio > GetAllMunicipios ()
        {
            return _appContext . Municipios  ;
        }

        public  Municipio  GetMunicipio ( int  id ) //aqui id posicion 
        {
            return _appContext . Municipios . Find ( id );
        }

         public Municipio   UpdateMunicipio ( Municipio  municipio )
        {
            var  municipioEncontrado  =  _appContext . Municipios . Find ( municipio . id ); 
            if ( municipioEncontrado  !=  null )
            {
                /*Aqui traigo todos los campos a excepacion de la llave primaria porque la llave primaria no
                se puede modificar*/
                 municipioEncontrado . nombreMunicipio  =  municipio . nombreMunicipio ;
                _appContext . SaveChanges (); //Guardo 
            }
            return  municipioEncontrado ;
        }
    }
}