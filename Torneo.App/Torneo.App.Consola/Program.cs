using System;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Consola
{
    class Program
    {
        static private    IRepositorioposicion  _repoPosicion =  new  Repositorioposicion ();
        static private    IRepositorioMunicipio  _repoMunicipio =  new  RepositorioMunicipio ();
        static private    IRepositorioEstadio  _repoEstadio =  new  RepositorioEstadio ();

        static void Main(string[] args)
        {
            int opcion;
            do{
            Console.WriteLine("Bienvenido ingrese su menu deseado");
            Console.WriteLine("1. Municipio");
            Console.WriteLine("2. Posicion ");
            Console.WriteLine("3. Estadio");
            Console.WriteLine("4.  ");
            Console.WriteLine("5.  ");
            Console.WriteLine("6.  ");
            Console.WriteLine("7.  ");
            Console.WriteLine("8.  ");
            Console.WriteLine("9.  ");
            Console.WriteLine("10. ");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Ingrese su menu deseado");
            opcion = int.Parse(Console.ReadLine());


                switch(opcion){

                    case 1: 
                            int operacion2;
                            do{
                                Console.WriteLine("Seleccione la opcion que desea de municipio");
                                Console.WriteLine("1.  Insertar municipio");
                                Console.WriteLine("2.  Buscar municipio");
                                Console.WriteLine("3.  Mostrasr munipio");
                                Console.WriteLine("4.  Actualizar municipio");
                                Console.WriteLine("5.  Eliminar municipio");
                                Console.WriteLine("0.  Salir del munu municipio");
                                Console.WriteLine("Ingrese la opereacion que desea ejecutar");
                                operacion2 = int.Parse(Console.ReadLine());

                                switch(operacion2){

                                    case 1: 
                                        string nombreMun;
                                        Console.WriteLine("Digite nombre Municipio");
                                        nombreMun = (Console.ReadLine());
                                        AddMunicipio(nombreMun);
                                        
                                    break;

                                    case 2:
                                       int id_BM;
                                        Console.WriteLine("Ingrese el id que desea buscar");
                                        id_BM = int.Parse(Console.ReadLine());
                                        BuscarMunicipio (id_BM);
                                    break;

                                    case 3: 
                                        MostrarMunicipio () ;
                                    break;

                                    case 4: 
                                        int code;
                                        Municipio objmunicipio = new Municipio();
                                        Console.WriteLine("Ingrese el codigo a actualizar");
                                        code = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese nombre municipio");
                                        String nombre;
                                        nombre = Console.ReadLine();
                                        objmunicipio.id= code;
                                        objmunicipio.nombreMunicipio = nombre;
                                        ActualizarMunicipio(objmunicipio);
                                    break;

                                    case 5: 
                                         int id_E;
                                         Console.WriteLine("Ingrese el codigo a eliminar");
                                         id_E = int.Parse(Console.ReadLine());
                                         EliminarMunicipio(id_E);
                                    break;

                      
                                }//cierre swich municipio

                            }while ( operacion2 != 0); 
                    break;

                    case 2: 
                            int operacion3;
                            do{
                                Console.WriteLine("Seleccione la opcion que desea de posicion");
                                Console.WriteLine("1.  Insertar posicion");
                                Console.WriteLine("2.  Buscar posicion");
                                Console.WriteLine("3.  Mostrasr posicion");
                                Console.WriteLine("4.  Actualizar posicion");
                                Console.WriteLine("5.  Eliminar posicion");
                                Console.WriteLine("0.  Salir del menu posicion");
                                Console.WriteLine("Ingrese la opereacion que desea ejecutar");
                                operacion3 = int.Parse(Console.ReadLine());

                                switch(operacion3){
                                    case 1:
                                        string nposicion;
                                        Console.WriteLine("Digite la posicion");
                                        nposicion = (Console.ReadLine());
                                        AddPosicion(nposicion);
                                    break;

                                    case 2:
                                        int id_Po;
                                        Console.WriteLine("Ingrese el id que desea buscar");
                                        id_Po = int.Parse(Console.ReadLine());
                                        BuscarPosicion (id_Po);
                                    break;

                                    case 3:
                                        MostrarPosicion();
                                    break;

                                    case 4: 
                                        int code;
                                        Posicion objposicion = new Posicion();
                                        Console.WriteLine("Ingrese el codigo a actualizar");
                                        code = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Ingrese nombre posicion");
                                        String nombre;
                                        nombre = Console.ReadLine();
                                        objposicion.id= code;
                                        objposicion.nombreposicion = nombre;
                                        Actualizarposicion(objposicion);
                                    break;

                                    case 5:
                                         int id_E;
                                         Console.WriteLine("Ingrese el codigo a eliminar");
                                         id_E = int.Parse(Console.ReadLine());
                                         EliminarPosicion(id_E);
                                    break;
                                }
                            }while(operacion3 != 0);    


                    break;  //ciere break 2 principal
                    
                    case 3: 
                        int operacion4;
                            do{
                                Console.WriteLine("Seleccione la opcion que desea de estadio");
                                Console.WriteLine("1.  Insertar estadio");
                                Console.WriteLine("2.  Asignar municipio del estadio");
                                Console.WriteLine("3.  Buscar estadio");
                                Console.WriteLine("4.  Mostrar estadio");
                                Console.WriteLine("5.  Actualizar estadio");
                                Console.WriteLine("6.  Eliminar estadio");
                                Console.WriteLine("0.  Salir del menu estadio");
                                Console.WriteLine("Ingrese la opereacion que desea ejecutar");
                                operacion4 = int.Parse(Console.ReadLine());

                                switch(operacion4){
                                    
                                    case 1: 
                                        string nombreEs;
                                        string direccionEs;
                                        //int id;
                                        Console.WriteLine("Digite el nombre del estadio");
                                        nombreEs = (Console.ReadLine());
                                        Console.WriteLine("Digite la direccion del estadio");
                                        direccionEs = (Console.ReadLine());
                                        //Console.WriteLine("Digite el municipio del estadio");
                                        //id = int.Parse(Console.ReadLine());
                                        //MunicipioEs = int.Parse(Console.ReadLine());
                                        AddEstadio(nombreEs,direccionEs);

                                    break;

                                    case 2: 
                                            int  id_municipio, id_estadio;
                                            Console . WriteLine ( " Digite id municipio" );
                                            id_municipio  = int . Parse ( Console . ReadLine ());
                                            Console . WriteLine ( " Digite id estadio" );
                                            id_estadio  = int . Parse ( Console . ReadLine ());
                                            AsignarMunicipio ( id_municipio,id_estadio); //Voy aqui
                                    break;

                                    case 3: 
                                            int id_Es;
                                            Console.WriteLine("Ingrese el id que desea buscar");
                                            id_Es = int.Parse(Console.ReadLine());
                                            BuscarEstadio (id_Es);

                                    break;

                                    case 4: 
                                            MostrarEstadio();

                                    break;

                                    case 5:
                                            int code_es;
                                            String nombre_es;
                                            String dir_es;
                                            int code_esMun;
                                            Estadio objestadio = new Estadio();
                                            Municipio objmunicipio_2 = new Municipio();
                                            Console.WriteLine("Ingrese el codigo del estadio a actualizar");
                                            code_es = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Ingrese el nombre del estadio a actualizar");
                                            nombre_es = Console.ReadLine();
                                            Console.WriteLine("Ingrese la direccion del estadio a actualizar");
                                            dir_es = Console.ReadLine();
                                            Console.WriteLine("Ingrese el id del municipio a actualizar en estadio");
                                            code_esMun = int.Parse(Console.ReadLine());
                                            objestadio.id = code_es;
                                            objestadio.nombreEstadio = nombre_es;
                                            objestadio.direccionEstadio = dir_es;
                                            objmunicipio_2.id = code_esMun;
                                            ActualizarEstadio(objestadio,objmunicipio_2);



                                    break;

                                    case 6:
                                            int id_Est;
                                            Console.WriteLine("Ingrese el codigo a eliminar");
                                            id_Est = int.Parse(Console.ReadLine());
                                            EliminarEstadio(id_Est);


                                    break;
                                
                        
                                }

                            }while(operacion4 != 0);
                    break;



                     
                }    //cierre switch principal 

                
            } while (opcion != 0);

        }
               
         //Agrego posicion
        private static void AddPosicion (string posicionj ) 
         {
            var  posicion  =  new  Posicion
            {
                nombreposicion  =  posicionj ,
                
            };
            _repoPosicion . AddPosicion ( posicion );
        }

         //Busco posicion
        private static void BuscarPosicion ( int id )  
         {
            var  posicion  =  _repoPosicion . GetPosicion ( id );
            Console . WriteLine ( posicion . nombreposicion + "  " );
         }


         private static void MostrarPosicion () 
         {
            var  posiciones  =  _repoPosicion . GetAllPosiciones ();
            foreach ( var  posicion  in  posiciones )
            {
                Console . WriteLine ( posicion . nombreposicion + "  " );
            }    
         }

         private static void Actualizarposicion (Posicion posicion){
             _repoPosicion . UpdatePosicion (posicion);
            Console . WriteLine ( posicion . nombreposicion  );
         }
         
         private static void EliminarPosicion(int id){
            
            _repoPosicion . DeletePosicion (id);
         }

        //Proceso Municipio

        private static void AddMunicipio (string nombre) 
         {
            var  municipio  =  new  Municipio
            {
                nombreMunicipio  =  nombre
                
            };
            _repoMunicipio . AddMunicipio ( municipio );
        }

        
         private static void BuscarMunicipio ( int id )  
         {
            var  municipio  =  _repoMunicipio . GetMunicipio ( id );
            Console . WriteLine ( municipio . nombreMunicipio + "  " );

         }

        private static void MostrarMunicipio () 
         {
            var  municipios  =  _repoMunicipio . GetAllMunicipios ();
            foreach ( var  municipio  in  municipios )
            {
                Console . WriteLine ( municipio . nombreMunicipio + "  " );
            }    
         } 


        private static void ActualizarMunicipio (Municipio municipio){
             _repoMunicipio . UpdateMunicipio (municipio);
            Console . WriteLine ( municipio . nombreMunicipio  );


        }

        private static void EliminarMunicipio(int id){
            
            _repoMunicipio . DeleteMunicipio (id);
        }


        //Estadio 


        private static void AddEstadio (string nombreEs, string direccionEs ) 
        {
            var  estadio  =  new  Estadio
            {
                nombreEstadio  =  nombreEs,
                direccionEstadio = direccionEs,
                
            };
          _repoEstadio . AddEstadio ( estadio ); 

        }

        private static void  AsignarMunicipio ( int id_Est , int id_municipio )   
        {
            var  municipio =  _repoEstadio . AsignarMunicipio ( id_Est , id_municipio );
            Console . WriteLine ( municipio . nombreMunicipio  +  "  "  );
        }

        private static void BuscarEstadio ( int id )  
         {
            var  estadio  =  _repoEstadio . GetEstadio ( id );
            Console . WriteLine ( estadio . nombreEstadio + "  " );

         }

        private static void MostrarEstadio () 
         {
            var  estadios  =  _repoEstadio . GetAllEstadios ();
            foreach ( var  estadio  in  estadios )
            {
                Console . WriteLine ( estadio . nombreEstadio + "  " );
            }    
         } 

        private static void ActualizarEstadio (Estadio estadio, Municipio municipio){
             _repoEstadio . UpdateEstadio (estadio,municipio);
             //_repoMunicipio . UpdateEstadio
            Console . WriteLine ( estadio . nombreEstadio);
            Console . WriteLine ( estadio . direccionEstadio);
            Console . WriteLine ( municipio . id );

        }

        /*public Estadio   ActualizarEstadio_Municipio ( Estadio  estadio , Municipio municipio)
         {
             _repoEstadio . UpdateEstadio (estadio);
             _repoMunicipio . UpdateMunicipio (municipio);
                Console . WriteLine ( estadio . nombreEstadio);
                Console . WriteLine ( estadio . direccionEstadio);
                Console . WriteLine ( municipio . id);
                //_appContext . SaveChanges (); //Guardo 
                //return  estadioEncontrado ;
        }*/
            
        //}

        private static void EliminarEstadio(int id){
            
            _repoEstadio . DeleteEstadio (id);
        }

    }  
     
}



         
        