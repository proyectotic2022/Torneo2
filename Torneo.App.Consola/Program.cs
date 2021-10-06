using System;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioArbitro _RepositorioArbitro = new RepositorioArbitro();
        private static IRepositorioMunicipio _RepositorioMunicipio = new RepositorioMunicipio();
        private static IRepositorioPosicion _RepositorioPosicion = new RepositorioPosicion();
        private static IRepositorioJugador _RepositorioJugador = new RepositorioJugador();
        private static IRepositorioEquipo _RepositorioEquipo = new RepositorioEquipo();
        private static IRepositorioPartido _RepositorioPartido = new RepositorioPartido();
        private static IRepositorioDirectorTecnico _RepositorioDirectorTecnico = new RepositorioDirectorTecnico();
        static void Main(string[] args)
        {
            
            int opcion;
            do
            {
                Console.WriteLine("Bienvenido ingrese su menu deseado");
                Console.WriteLine("1. Municipio");
                Console.WriteLine("2. Arbitro ");
                Console.WriteLine("3. Posicion ");
                Console.WriteLine("4. Jugador ");
                Console.WriteLine("5. Equipo ");
                Console.WriteLine("6. Estadio ");
                Console.WriteLine("7. Partido ");
                Console.WriteLine("8. Director Tecnico ");
                Console.WriteLine("9. Novedad ");
                Console.WriteLine("10. Desempeño");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Ingrese su menu deseado");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {

                    case 1:
                        int operacion1;
                        do
                        {
                            Console.WriteLine("Seleccione la opcion que desea de municipio");
                            Console.WriteLine("1.  Insertar municipio");
                            Console.WriteLine("2.  Buscar municipio");
                            Console.WriteLine("3.  Mostrar munipio");
                            Console.WriteLine("4.  Actualizar municipio");
                            Console.WriteLine("5.  Eliminar municipio");
                            Console.WriteLine("0.  Salir del municipio");
                            Console.WriteLine("Ingrese la operación que desea ejecutar");
                            operacion1 = int.Parse(Console.ReadLine());

                            switch (operacion1)
                            {

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

                            }//cierre switch municipio
                        } while (operacion1 != 0);
                        break;
                    case 2:
                        int operacion2;
                        do
                        {
                            Console.WriteLine("Seleccione la opcion que desea de Arbitro");
                            Console.WriteLine("1.  Insertar Arbitro");
                            Console.WriteLine("2.  Buscar Arbitro");
                            Console.WriteLine("3.  Mostrar Arbitro");
                            Console.WriteLine("4.  Actualizar Arbitro");
                            Console.WriteLine("5.  Eliminar Arbitro");
                            Console.WriteLine("0.  Salir opción Arbitro");
                            Console.WriteLine("Ingrese la operación que desea ejecutar");
                            operacion2 = int.Parse(Console.ReadLine());

                            switch (operacion2)
                            {

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

                                case 3:
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

                            }//cierre switch arbitro
                        } while (operacion2 != 0);
                        break;
                    case 3:
                        int operacion3;
                        do
                        {
                            Console.WriteLine("Seleccione la opcion que desea de posicion");
                            Console.WriteLine("1.  Insertar posicion");
                            Console.WriteLine("2.  Buscar posicion");
                            Console.WriteLine("3.  Mostrar posicion");
                            Console.WriteLine("4.  Actualizar posicion");
                            Console.WriteLine("5.  Eliminar posicion");
                            Console.WriteLine("0.  Salir de posicion");
                            Console.WriteLine("Ingrese la operación que desea ejecutar");
                            operacion3 = int.Parse(Console.ReadLine());

                            switch (operacion3)
                            {

                                case 1:
                                    String nombrePos;
                                    Console.WriteLine("Digite nombre de posicion");
                                    nombrePos = (Console.ReadLine());
                                    AdicionarPosicion(nombrePos);
                                break;

                                case 2:
                                    int codigoPos;
                                    Console.WriteLine("Digite codigo Posicion");
                                    codigoPos = int.Parse(Console.ReadLine());
                                    BuscarPosicion(codigoPos);
                                break;

                                case 3:
                                    mostrarPosicion();
                                break;

                                case 4:
                                    int idPosi;
                                    String nombrePosi;
                                    Posicion objposicion = new Posicion();
                                    Console.WriteLine("Digite ID a editar");
                                    idPosi = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite nueva posicion");
                                    nombrePosi = (Console.ReadLine());
                                    objposicion.id = idPosi;
                                    objposicion.nombre = nombrePosi;
                                    ModificarPosicion(objposicion);
                                break;

                                case 5:
                                    int id3;
                                    Console.WriteLine("Digite ID a eliminar");
                                    id3 = int.Parse(Console.ReadLine());
                                    EliminarPosicion(id3);
                                break;

                            }//cierre switch posicion
                        } while (operacion3 != 0);
                        break;
                    case 4:
                        int operacion4;
                        do
                        {
                            Console.WriteLine("Seleccione la opcion que desea de jugador");
                            Console.WriteLine("1.  Insertar jugador");
                            Console.WriteLine("2.  Asignar Equipo y Posicion");
                            Console.WriteLine("3.  Buscar jugador");
                            Console.WriteLine("4.  Mostrar jugador");
                            Console.WriteLine("5.  Actualizar jugador");
                            Console.WriteLine("6.  Eliminar jugador");
                            Console.WriteLine("0.  Salir de jugador");
                            Console.WriteLine("Ingrese la operación que desea ejecutar");
                            operacion4 = int.Parse(Console.ReadLine());

                            switch (operacion4)
                            {

                                case 1:
                                    String nombreJug;
                                    int numeroJug;
                                    Console.WriteLine("Digite nombre de Jugador");
                                    nombreJug = (Console.ReadLine());
                                    Console.WriteLine("Digite numero de Jugador");
                                    numeroJug = int.Parse(Console.ReadLine());
                                    AdicionarJugador(nombreJug, numeroJug);
                                break;

                                case 2:
                                    int id_jugador, id_equipo, id_posicion;
                                    Console.WriteLine("Digite id jugador");
                                    id_jugador = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite id Equipo");
                                    id_equipo = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite id posicion");
                                    id_posicion = int.Parse(Console.ReadLine());
                                    Asignar_Jugador_Equipo(id_jugador, id_equipo);
                                    Asignar_Posicion_Jugador(id_jugador, id_posicion);
                                break;

                                case 3:
                                    int codigoJug;
                                    Console.WriteLine("Digite codigo Jugador");
                                    codigoJug = int.Parse(Console.ReadLine());
                                    BuscarJugador(codigoJug);
                                break;

                                case 4:
                                    mostrarJugador();
                                break;

                                case 5:
                                    Jugador jugador = new Jugador();
                                    Console.WriteLine("Digite ID jugador a editar");
                                    id_jugador = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite nombre del nuevo jugador");
                                    nombreJug = (Console.ReadLine());
                                    Console.WriteLine("Digite nuevo numero del jugador");
                                    numeroJug = int.Parse(Console.ReadLine());
                                    jugador.id = id_jugador;
                                    jugador.nombre = nombreJug;
                                    jugador.numero = numeroJug;
                                    ModificarJugador(jugador);
                                    Console.WriteLine("Digite ID equipo a editar");
                                    id_equipo = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite ID posicion a editar");
                                    id_posicion = int.Parse(Console.ReadLine());
                                    Asignar_Jugador_Equipo(id_jugador, id_equipo);
                                    Asignar_Posicion_Jugador(id_jugador, id_posicion);
                                break;

                                case 6:
                                    int idjugador;
                                    Console.WriteLine("Digite ID a eliminar");
                                    idjugador = int.Parse(Console.ReadLine());
                                    EliminarJugador(idjugador);
                                break;
                            }//cierre switch jugador
                        } while (operacion4 != 0);
                        break;
                    case 5:
                        int operacion5;
                        do
                        {
                            Console.WriteLine("Seleccione la opcion que desea de Equipo");
                            Console.WriteLine("1.  Insertar Equipo");
                            Console.WriteLine("2.  Asignar Director tecnico, municipio y desempeno");
                            Console.WriteLine("3.  Buscar Equipo");
                            Console.WriteLine("4.  Mostrar Equipos");
                            Console.WriteLine("5.  Actualizar Equipos");
                            Console.WriteLine("6.  Eliminar Equipos");
                            Console.WriteLine("0.  Salir opción Equipos");
                            Console.WriteLine("Ingrese la operación que desea ejecutar");
                            operacion5 = int.Parse(Console.ReadLine());

                            switch (operacion5)
                            {
                                case 1:
                                    String nombreEquipo;
                                    Console.WriteLine("Digite Nombre");
                                    nombreEquipo = (Console.ReadLine());
                                    AdicionarEquipo(nombreEquipo);
                                break;

                                case 2:
                                    int id_Equipo, id_DTecnico, id_Municipio, id_Desempeno;
                                    Console.WriteLine("Digite id Equipo");
                                    id_Equipo = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite id Director tecnico");
                                    id_DTecnico = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite id Municipio");
                                    id_Municipio = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite  id Desempeno");
                                    id_Desempeno = int.Parse(Console.ReadLine());
                                    AsignarDirectorTecnico_Equipo(id_Equipo, id_DTecnico);
                                    AsignarMunicipio_Equipo(id_Equipo, id_Municipio);
                                    AsignarDesempeno_Equipo(id_Equipo, id_Desempeno);
                                break;

                                case 3:
                                    int idEquipo;
                                    Console.WriteLine("Digite id Equipo");
                                    idEquipo = int.Parse(Console.ReadLine());
                                    BuscarEquipo(idEquipo);
                                break;

                                case 4:
                                    mostrarEquipos();
                                break;

                                case 5:
                                    String nombre_equipo;
                                    Equipo equipo = new Equipo();
                                    Console.WriteLine("Digite ID a editar");
                                    id_Equipo = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite nuevo nombre");
                                    nombre_equipo = (Console.ReadLine());
                                    equipo.id = id_Equipo;
                                    equipo.nombre = nombre_equipo;
                                    ModificarEquipo(equipo);
                                    Console.WriteLine("Digite id Director tecnico");
                                    id_DTecnico = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite id Municipio");
                                    id_Municipio = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite  id Desempeno");
                                    id_Desempeno = int.Parse(Console.ReadLine());
                                    AsignarDirectorTecnico_Equipo(id_Equipo, id_DTecnico);
                                    AsignarMunicipio_Equipo(id_Equipo, id_Municipio);
                                    AsignarDesempeno_Equipo(id_Equipo, id_Desempeno);
                                break;

                                case 6:
                                    int id_equipo;
                                    Console.WriteLine("Digite ID a eliminar");
                                    id_equipo = int.Parse(Console.ReadLine());
                                    EliminarEquipo(id_equipo);
                                break;
                            }//cierre switch equipo                                
                        } while (operacion5 != 0);
                        break;
                    case 8:
                        int operacion8;
                        do
                        {
                            Console.WriteLine("Seleccione la opcion que desea de Director Tecnico");
                            Console.WriteLine("1.  Insertar Director Tecnico");
                            Console.WriteLine("2.  Buscar Direcro Tecnico");
                            Console.WriteLine("3.  Mostrar Directores Tecnicos");
                            Console.WriteLine("4.  Actualizar Director Tecnico");
                            Console.WriteLine("5.  Eliminar Director Tecnico");
                            Console.WriteLine("0.  Salir opción Director Tecnico");
                            Console.WriteLine("Ingrese la operación que desea ejecutar");
                            operacion8 = int.Parse(Console.ReadLine());

                            switch (operacion8)
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
                                    AdicionarDirectorTecnico(nombre_Dt, documento_Dt, telefono_Dt);
                                break;

                                case 2:
                                    int id_dt;
                                    Console.WriteLine("Digite id de Director Tecnico");
                                    id_dt = int.Parse(Console.ReadLine());
                                    BuscarDirectorTecnico(id_dt);
                                break;

                                case 3:
                                    mostrarDirectorTecnico();

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
                                    ModificarDirectorTecnico(directorTecnico);                                    
                                break;

                                case 5:
                                    int id_DirectorTecnico;
                                    Console.WriteLine("Digite ID a eliminar");
                                    id_DirectorTecnico = int.Parse(Console.ReadLine());
                                    EliminarDirectorTecnico(id_DirectorTecnico);
                                break;
                            }//cierre switch DirectorTecnico                                
                        } while (operacion8 != 0);
                        break;                        
                }//cierre switch principal 
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
        private static void mostrarPosicion()
        {
            var posiciones = _RepositorioPosicion.GetAllPosiciones();
            foreach (var posicion in posiciones)
            {
                Console.WriteLine(posicion.nombre + " ");
            }
        }
        private static void mostrarJugador()
        {
            var jugadores = _RepositorioJugador.GetAllJugadores();
            foreach (var jugador in jugadores)
            {
                Console.WriteLine(jugador.nombre + " " + jugador.numero + " ");
            }
        }
        private static void mostrarEquipos()
        {
            var equipos = _RepositorioEquipo.GetAllEquipos();
            foreach (var equipo in equipos)
            {
                Console.WriteLine(equipo.nombre);
            }
        }
        private static void mostrarDirectorTecnico()
        {
            var dTecnicos = _RepositorioDirectorTecnico.GetAllDT();
            foreach (var dTecnico in dTecnicos)
            {
                Console.WriteLine(dTecnico.nombre + " " + dTecnico.documento + " " + dTecnico.telefono);
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
        private static void BuscarPosicion(int id)
        {
            var posiciones = _RepositorioPosicion.GetPosicion(id);
            Console.WriteLine(posiciones.nombre + " ");
        }
        private static void BuscarJugador(int id)
        {
            var jugadores = _RepositorioJugador.GetJugador(id);
            Console.WriteLine(jugadores.nombre + " " + jugadores.numero + " ");
        }
        private static void BuscarEquipo(int id)
        {
            var equipo = _RepositorioEquipo.GetEquipo(id);
            Console.WriteLine(equipo.nombre);
        }
        private static void BuscarDirectorTecnico(int id)
        {
            var directorTecnico = _RepositorioDirectorTecnico.GetDT(id);
            Console.WriteLine(directorTecnico.nombre + " " + directorTecnico.documento + " " + directorTecnico.telefono);
        }
        //////////// INSERTAR - ADICIONAR ///////////////////////        
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
        private static void AdicionarPosicion(String nombre)
        {
            var posicion = new Posicion
            {
                nombre = nombre
            };
            _RepositorioPosicion.AddPosicion(posicion);
        }
        private static void AdicionarJugador(String nombre, int numero)
        {
            var jugador = new Jugador
            {
                nombre = nombre,
                numero = numero,
            };
            _RepositorioJugador.AddJugador(jugador);
        }
        private static void AdicionarEquipo(String nombre)
        {
            var equipo = new Equipo
            {
                nombre = nombre,
            };
            _RepositorioEquipo.AddEquipo(equipo);
        }
        private static void AdicionarPartido(String nombre, String fecha, int marcadorIEL, String marcadorIEV)
        {
            var partidosadd = new Partido
            {
                nombre = nombre,
                fecha = fecha,
                marcadorInicalEL = marcadorIEL,
                marcadorInicialEV = marcadorIEV

            };
            _RepositorioPartido.AddPartido(partidosadd);
        }
        private static void AdicionarDirectorTecnico(String nombre, int documento, int telefono)
        {
            var dTecnico = new DirectorTecnico
            {
                nombre = nombre,
                documento = documento,
                telefono = telefono,
                
            };
            _RepositorioDirectorTecnico.AddDT(dTecnico);
        }        
        /////////////// ASIGNAR /////////////////////// 
        private static void AsignarArbitro_Partido(int id_partido, int id_arbitro)
        {
            var arbitro = _RepositorioPartido.AsignarArbitro(id_partido, id_arbitro);
            Console.WriteLine(arbitro.nombre + " " + arbitro.documento);
        }
        private static void AsignarEquipo_A(int id_partido, int id_equipo)
        {
            var equipo = _RepositorioPartido.AsignarEquipoA(id_partido, id_equipo);
            Console.WriteLine(equipo.nombre);

        }
        private static void AsignarDirectorTecnico_Equipo(int id_Equipo, int id_DirectorTecnico)
        {
            var directorTecnico = _RepositorioEquipo.AsignarDirectorTecnico(id_Equipo, id_DirectorTecnico);
            Console.WriteLine(directorTecnico.nombre + " " + directorTecnico.documento);
        }
        private static void AsignarMunicipio_Equipo(int id_Equipo, int id_Municipio)
        {
            var municipio = _RepositorioEquipo.AsignarMunicipio(id_Equipo, id_Municipio);
            Console.WriteLine(municipio.nombre);
        }

        private static void Asignar_Jugador_Equipo(int id_jugador, int id_equipo)
        {
            var equipo = _RepositorioJugador.AsignarJugador_Equipo(id_jugador, id_equipo);
            Console.WriteLine(equipo.nombre);
        }
        private static void Asignar_Posicion_Jugador(int id_jugador, int id_posicion)
        {
            var jugador = _RepositorioJugador.AsignarPosicion_Jugador(id_jugador, id_posicion);
            Console.WriteLine(jugador.nombre);
        }
        private static void AsignarDesempeno_Equipo(int id_Equipo, int id_Desempeno)
        {
            var desempeno = _RepositorioEquipo.AsignarDesempeno(id_Equipo, id_Desempeno);
            Console.WriteLine(desempeno.id);
        }

        /////////////// ELIMINAR /////////////////////// 
        private static void EliminarArbitro(int id)
        {
            _RepositorioArbitro.DeleteArbitro(id);
        }
        private static void EliminarMunicipio(int id)
        {
            _RepositorioMunicipio.DeleteMunicipio(id);
        }
        private static void EliminarPosicion(int id)
        {
            _RepositorioPosicion.DeletePosicion(id);
        }
        private static void EliminarJugador(int id)
        {
            _RepositorioJugador.DeleteJugador(id);
        }
        private static void EliminarEquipo(int id)
        {
            _RepositorioEquipo.DeleteEquipo(id);
        }
        private static void EliminarDirectorTecnico(int id)
        {
            _RepositorioDirectorTecnico.DeleteDT(id);
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
        private static void ModificarPosicion(Posicion posicion)
        {
            _RepositorioPosicion.UpdatePosicion(posicion);
            Console.WriteLine(posicion.nombre);
        }
        private static void ModificarEquipo(Equipo equipo)
        {
            _RepositorioEquipo.UpdateEquipo(equipo);
            Console.WriteLine(equipo.nombre);
        }
        private static void ModificarJugador(Jugador jugador)
        {
            _RepositorioJugador.UpdateJugador(jugador);
            Console.WriteLine(jugador.nombre);
            Console.WriteLine(jugador.numero);
        }
        private static void ModificarDirectorTecnico(DirectorTecnico dTecnico)
        {
            _RepositorioDirectorTecnico.UpdateDT(dTecnico);
            Console.WriteLine(dTecnico.nombre);
            Console.WriteLine(dTecnico.documento);
            Console.WriteLine(dTecnico.telefono);            
        }        
    }
}
