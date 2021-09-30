using System;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioArbitro _RepositorioArbitro = new RepositorioArbitro();
        private static IRepositorioMunicipio _RepositorioMunicipio = new RepositorioMunicipio();
        private static IRepositorioDT  _repositorioDTecnico= new RepositorioDT();
        private static IRepositorioPartido _respositorioPartido = new RepositorioPartido();
        private static IRepositorioJugador _repositorioJugador = new RepositorioJugador();
        static void Main(string[] args)
        {

            int opcion;
            do{
                Console.WriteLine("Bienvenido ingrese su menu deseado");
                Console.WriteLine("1. Gestionar Municipios");
                Console.WriteLine("2. Gestionar Arbitros ");
                Console.WriteLine("3. Gestionar Directores Tecnicos ");
                Console.WriteLine("4. Gestion de Partidos");
                Console.WriteLine("5. Gestion de Equipos");
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
                            int operacion1;
                            do{
                                Console.WriteLine("Seleccione la opcion que desea de municipio");
                                Console.WriteLine("1.  Insertar municipio");
                                Console.WriteLine("2.  Buscar municipio");
                                Console.WriteLine("3.  Mostrar munipio");
                                Console.WriteLine("4.  Actualizar municipio");
                                Console.WriteLine("5.  Eliminar municipio");
                                Console.WriteLine("0.  Salir del municipio");
                                Console.WriteLine("Ingrese la operación que desea ejecutar");
                                operacion1 = int.Parse(Console.ReadLine());

                                switch(operacion1){

                                    case 1: 
                                        String nombreMun;
                                        Console.WriteLine("Digite nombre Municipio");
                                        nombreMun = (Console.ReadLine());
                                        AdicionarMunicipio(nombreMun);
                                    break;

                                    case 2:
                                        int codigoMun;
                                        Console.WriteLine("Digite codigo Municipio");
                                        codigoMun = int.Parse(Console.ReadLine());
                                        BuscarMunicipio(codigoMun);
                                    break;

                                    case 3: 
                                        mostrarMunicipio();
                                    break;

                                    case 4: 
                                        int idMuni;
                                        String nombreMuni;
                                        Municipio objmunicipio = new Municipio();
                                        Console.WriteLine("Digite ID a editar");
                                        idMuni = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite nuevo nombre");
                                        nombreMuni = (Console.ReadLine());
                                        objmunicipio.id = idMuni;
                                        objmunicipio.nombre = nombreMuni;
                                        ModificarMunicipio(objmunicipio);
                                    break;

                                    case 5: 
                                        int id2;
                                        Console.WriteLine("Digite ID a eliminar");
                                        id2 = int.Parse(Console.ReadLine());
                                        EliminarMunicipio(id2);
                                    break;
                      
                                }//cierre swich municipio
                            }while ( operacion1 != 0); 
                    break;
                    case 2: 
                            int operacion2;
                            do{
                                Console.WriteLine("Seleccione la opcion que desea de Arbitro");
                                Console.WriteLine("1.  Insertar Arbitro");
                                Console.WriteLine("2.  Buscar Arbitro");
                                Console.WriteLine("3.  Mostrar Arbitro");
                                Console.WriteLine("4.  Actualizar Arbitro");
                                Console.WriteLine("5.  Eliminar Arbitro");
                                Console.WriteLine("0.  Salir opción Arbitro");
                                Console.WriteLine("Ingrese la operación que desea ejecutar");
                                operacion2 = int.Parse(Console.ReadLine());

                                switch(operacion2){

                                    case 1: 
                                        int telefono1, documento1;
                                        String nombre1, colegio1;
                                        Console.WriteLine("Digite Nombre");
                                        nombre1 = (Console.ReadLine());
                                        Console.WriteLine("Digite Documento");
                                        documento1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite Telefono");
                                        telefono1 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite Colegio");
                                        colegio1 = Console.ReadLine();
                                        AdicionarArbitro(nombre1, documento1, telefono1, colegio1);
                                    break;

                                    case 2:
                                        int codigoArbi;
                                        Console.WriteLine("Digite codigo Albitro");
                                        codigoArbi = int.Parse(Console.ReadLine());
                                        BuscarArbitro(codigoArbi);
                                    break;

                                    case 3: // test
                                        mostrarArbitro();
                                    break;

                                    case 4: 
                                        int id, telefono, documento;
                                        String nombre, colegio;
                                        Arbitro objarbitro = new Arbitro();
                                        Console.WriteLine("Digite ID a editar");
                                        id = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite nuevo nombre");
                                        nombre = (Console.ReadLine());
                                        Console.WriteLine("Digite nuevo documento");
                                        documento = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite nuevo telefono");
                                        telefono = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite nuevo colegio");
                                        colegio = Console.ReadLine();
                                        objarbitro.id = id;
                                        objarbitro.nombre = nombre;
                                        objarbitro.documento = documento;
                                        objarbitro.telefono = telefono;
                                        objarbitro.colegio = colegio;
                                        ModificarArbitro(objarbitro);
                                    break;

                                    case 5: 
                                        int id1;
                                        Console.WriteLine("Digite ID a eliminar");
                                        id1 = int.Parse(Console.ReadLine());
                                        EliminarArbitro(id1);
                                    break;
                      
                                 }//cierre swich arbitro
                            }while ( operacion2 != 0); 
                            
                     break;
                    case 3: 
                            int operacion3;
                            do{
                                Console.WriteLine("Seleccione la opcion que desea de Director Tecnico");
                                Console.WriteLine("1.  Insertar Director Tecnico");
                                Console.WriteLine("2.  Buscar Director Tecnico");
                                Console.WriteLine("3.  Mostrar Director Tecnico");
                                Console.WriteLine("4.  Actualizar Director Tecnico");
                                Console.WriteLine("5.  Eliminar Director Tecnico");
                                Console.WriteLine("0.  Salir opción Director Tecnico");
                                Console.WriteLine("Ingrese la operación que desea ejecutar");
                                operacion3 = int.Parse(Console.ReadLine());

                                switch(operacion3)
                                {
                                    case 1:
                                      
                                      int telefono_Dt, documento_Dt;
                                        String nombre_Dt;
                                        Console.WriteLine("Digite Nombre");
                                        nombre_Dt = (Console.ReadLine());
                                        Console.WriteLine("Digite Documento");
                                        documento_Dt = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite Telefono");
                                        telefono_Dt = int.Parse(Console.ReadLine());
                                        AdicionarDTecnico(nombre_Dt, documento_Dt, telefono_Dt);
                                     break;
                                    case 2: 
                                    int id_dt;
                                        Console.WriteLine("Digite id de Director Tecnico");
                                        id_dt = int.Parse(Console.ReadLine());
                                        BuscarDt(id_dt);
                                    break;
                                    case 3: 
                                    mostrarDTecnico();
                                    break;
                                    case 4:
                                    int id_DTecnico, telefono_DTecnico, documento_DTecnico;
                                        String nombre_DTecnico;
                                        DirectorTecnico directorTecnico = new DirectorTecnico();
                                        Console.WriteLine("Digite ID a editar");
                                        id_DTecnico = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite nuevo nombre");
                                        nombre_DTecnico = (Console.ReadLine());
                                        Console.WriteLine("Digite nuevo documento");
                                        documento_DTecnico = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite nuevo telefono");
                                        telefono_DTecnico = int.Parse(Console.ReadLine());
                                        directorTecnico.id = id_DTecnico;
                                        directorTecnico.nombre = nombre_DTecnico;
                                        directorTecnico.documento = documento_DTecnico;
                                        directorTecnico.telefono = telefono_DTecnico;
                                        ModificarDTecnico(directorTecnico);
                                    break;
                                    case 5:
                                    int id_DirectorTecnico;
                                        Console.WriteLine("Digite ID a eliminar");
                                        id_DirectorTecnico = int.Parse(Console.ReadLine());
                                        EliminarDTecnico(id_DirectorTecnico);
                                    break;





                                }
                            }while(operacion3 != 0);
                 break;
                  case 4:
                  int operacion4;
                            do{
                                Console.WriteLine("Seleccione la opcion que desea de Partidos");
                                Console.WriteLine("1.  Insertar Partidos");
                                Console.WriteLine("2.  Asignar Arbitro . equipo y otras entidades");
                                Console.WriteLine("3.  Mostrar Partidos");
                                Console.WriteLine("4.  Actualizar Partidos");
                                Console.WriteLine("5.  Eliminar Partidos");
                                Console.WriteLine("0.  Salir opción Partidos");
                                Console.WriteLine("Ingrese la operación que desea ejecutar");
                                operacion4 = int.Parse(Console.ReadLine());

                                switch(operacion4)
                                {
                                    case 1:
                                        int marcadorInicalEL;
                                        String nombre_Partido, fecha_Parido, marcadorIEV;
                                        Console.WriteLine("Digite Nombre");
                                        nombre_Partido = (Console.ReadLine());
                                        Console.WriteLine("Digite la Fecha del partido");
                                        fecha_Parido = (Console.ReadLine());
                                        Console.WriteLine("Digite Maracador Incial de Equipo Local");
                                        marcadorInicalEL = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite Maracador Incial de Equipo Visitante");
                                        marcadorIEV = (Console.ReadLine());
                                        AdicionarPartido(nombre_Partido, fecha_Parido, marcadorInicalEL,marcadorIEV);
                                      
                                     break;
                                    case 2: 
                                       int id_arbitro, id_partido, id_equipo;
                                       Console.WriteLine("Digite id Partido");
                                       id_partido =int.Parse(Console.ReadLine());
                                       Console.WriteLine("Digite id Arbitro");
                                       id_arbitro = int.Parse(Console.ReadLine());
                                       Console.WriteLine("Digite  id Equipo");
                                       id_equipo = int.Parse(Console.ReadLine());
                                       AsignarArbitro_Partido(id_partido,id_arbitro);
                                       AsignarEquipo_A(id_partido,id_equipo);

                                    
                                    break;
                                    case 3: 
                                    
                                    break;
                                    case 4:
                                    
                                    break;
                                    case 5:
                                    
                                    break;
                                    
                                }
                            }while(operacion4 != 0);
                  
                  break;
                 case 5:
                  int operacion5;
                            do{
                                Console.WriteLine("Seleccione la opcion que desea de Partidos");
                                Console.WriteLine("1.  Insertar Juagodores");
                                Console.WriteLine("2.  Asignar Jugadores a Equipo");
                                Console.WriteLine("3.  Mostrar Partidos");
                                Console.WriteLine("4.  Actualizar Partidos");
                                Console.WriteLine("5.  Eliminar Partidos");
                                Console.WriteLine("0.  Salir opción Partidos");
                                Console.WriteLine("Ingrese la operación que desea ejecutar");
                                operacion5 = int.Parse(Console.ReadLine());

                                switch(operacion5)
                                {
                                    case 1:
                                        Console.WriteLine("Hola");
                                      
                                     break;
                                    case 2: 
                                       int id_jugador,idEquipo;
                                       Console.WriteLine("Digite id Jugador");
                                       id_jugador =int.Parse(Console.ReadLine());
                                       Console.WriteLine("Digite id Equipo");
                                       idEquipo = int.Parse(Console.ReadLine());
                                       Asignar_Jugador_Equipo(id_jugador,idEquipo);
                                    break;
                                    case 3: 
                                    
                                    break;
                                    case 4:
                                    
                                    break;
                                    case 5:
                                    
                                    break;
                                    
                                }
                            }while(operacion5 != 0);
                  
                  break;
                  default:
                  case 6:
                  break;

                 };//cierre switch principal 
            } while (opcion != 0);

        }


        //////////// MOSTRAR ///////////////////////
        private static void mostrarArbitro()
        {
            var arbitros = _RepositorioArbitro.GetAllArbitros();
            foreach (var arbitro in arbitros)
            {
                Console.WriteLine(arbitro.nombre + " " + arbitro.documento + " " + arbitro.telefono + " " + arbitro.colegio);
            }
        }
        private static void mostrarMunicipio()
        {
            var municipios = _RepositorioMunicipio.GetAllMunicipios();
            foreach (var municipio in municipios)
            {
                Console.WriteLine(municipio.nombre + " ");
            }
        }
        //////////// BUSCAR ///////////////////////
        private static void BuscarArbitro(int id)
        {
            var arbitros = _RepositorioArbitro.GetArbitro(id);

            Console.WriteLine(arbitros.nombre + " " + arbitros.documento + " " + arbitros.telefono + " " + arbitros.colegio);
        }
        private static void BuscarMunicipio(int id)
        {
            var municipios = _RepositorioMunicipio.GetMunicipio(id);

            Console.WriteLine(municipios.nombre + " ");
        }
        //////////// INSERTAR ///////////////////////        
        private static void AdicionarArbitro(String nombre, int documento, int telefono, String colegio)
        {
            var arbitro = new Arbitro
            {
                nombre = nombre,
                documento = documento,
                telefono = telefono,
                colegio = colegio
            };
            _RepositorioArbitro.AddArbitro(arbitro);
        }
        private static void AdicionarMunicipio(String nombre)
        {
            var municipio = new Municipio
            {
                nombre = nombre
            };
            _RepositorioMunicipio.AddMunicipio(municipio);
        }
        //////////// ELIMINAR /////////////////////// 
        private static void EliminarArbitro(int id)
        {
            _RepositorioArbitro.DeleteArbitro(id);
        }
        private static void EliminarMunicipio(int id)
        {
            _RepositorioMunicipio.DeleteMunicipio(id);
        }   
        //////////// MODIFICAR ///////////////////////  
        private static void ModificarArbitro(Arbitro arbitro)
        {
            _RepositorioArbitro.UpdateArbitro(arbitro);
            Console.WriteLine(arbitro.nombre);
            Console.WriteLine(arbitro.documento);
            Console.WriteLine(arbitro.telefono);
            Console.WriteLine(arbitro.colegio);
        }
        private static void ModificarMunicipio(Municipio municipio)
        {
            _RepositorioMunicipio.UpdateMunicipio(municipio);
            Console.WriteLine(municipio.nombre);
        } 
        private static void BuscarDt(int id)
        {

         var directorTecnico = _repositorioDTecnico.GetDT(id);
         Console.WriteLine(directorTecnico.nombre + " " + directorTecnico.documento + " "+ directorTecnico.telefono);
        } 
        private static void AdicionarDTecnico(String nombre, int documento, int telefono)
        {
            var dTecnico = new DirectorTecnico
            {
                nombre = nombre,
                documento = documento,
                telefono = telefono,
                
            };
            _repositorioDTecnico.AddDT(dTecnico);
        }
        private static void mostrarDTecnico()
        {
            var dTecnicos = _repositorioDTecnico.GetAllDT();
            foreach (var dTecnico in dTecnicos)
            {
                Console.WriteLine(dTecnico.nombre + " " + dTecnico.documento + " " + dTecnico.telefono);
            }
        }
        private static void ModificarDTecnico(DirectorTecnico dTecnico)
        {
            _repositorioDTecnico.UpdateDT(dTecnico);
            Console.WriteLine(dTecnico.nombre);
            Console.WriteLine(dTecnico.documento);
            Console.WriteLine(dTecnico.telefono);
            
        }
        private static void EliminarDTecnico(int id)
        {
            _repositorioDTecnico.DeleteDT(id);
        }

        private static void AdicionarPartido(String nombre, String fecha, int marcadorIEL, String marcadorIEV)
        {
            var partidosadd = new Partido
            {
               nombre=nombre,
               fecha=fecha,
               marcadorInicalEL=marcadorIEL,
               marcadorInicialEV=marcadorIEV
                
            };
            _respositorioPartido.AddPartido(partidosadd);
        }

        private static void AsignarArbitro_Partido(int id_partido, int id_arbitro)
        {
            var arbitro= _respositorioPartido.AsignarArbitro(id_partido, id_arbitro);
            Console.WriteLine(arbitro.nombre + " "+ arbitro.documento);
        }

        private static void AsignarEquipo_A(int id_partido, int id_equipo)
        {
            var equipo= _respositorioPartido.AsignarEquipoA(id_partido,id_equipo);
            Console.WriteLine(equipo.nombre);

        }
        private static void Asignar_Jugador_Equipo(int id_jugador, int id_equipo)
        {
          var equipo= _repositorioJugador.AsignarJugador_Equipo(id_jugador, id_equipo);
          Console.WriteLine(equipo.nombre);
        }
    }
}
