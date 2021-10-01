using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Torneo.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arbitros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreArbitro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documentoArbitro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefonoArbitro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    colegioArbitro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DirectoresTecnicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documentoDT = table.Column<int>(type: "int", nullable: false),
                    telefonoDT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoresTecnicos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreMunicipio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Posiciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreposicion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posiciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreEquipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipioid = table.Column<int>(type: "int", nullable: true),
                    DirectorTecnicoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Equipos_DirectoresTecnicos_DirectorTecnicoid",
                        column: x => x.DirectorTecnicoid,
                        principalTable: "DirectoresTecnicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Municipios_Municipioid",
                        column: x => x.Municipioid,
                        principalTable: "Municipios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreEstadio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccionEstadio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    municipioid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.id);
                    table.ForeignKey(
                        name: "FK_Estadios_Municipios_municipioid",
                        column: x => x.municipioid,
                        principalTable: "Municipios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Desempenos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipoid = table.Column<int>(type: "int", nullable: true),
                    partidosJ = table.Column<int>(type: "int", nullable: false),
                    partidosG = table.Column<int>(type: "int", nullable: false),
                    partidosP = table.Column<int>(type: "int", nullable: false),
                    partidosE = table.Column<int>(type: "int", nullable: false),
                    golesAFavor = table.Column<int>(type: "int", nullable: false),
                    golesEnContra = table.Column<int>(type: "int", nullable: false),
                    puntos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desempenos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Desempenos_Equipos_Equipoid",
                        column: x => x.Equipoid,
                        principalTable: "Equipos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreJugador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numeroJugador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    posicionid = table.Column<int>(type: "int", nullable: true),
                    Equipoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.id);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_Equipoid",
                        column: x => x.Equipoid,
                        principalTable: "Equipos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadores_Posiciones_posicionid",
                        column: x => x.posicionid,
                        principalTable: "Posiciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Novedades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoDeNovedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    minutoNovedad = table.Column<int>(type: "int", nullable: false),
                    jugadorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedades", x => x.id);
                    table.ForeignKey(
                        name: "FK_Novedades_Jugadores_jugadorid",
                        column: x => x.jugadorid,
                        principalTable: "Jugadores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaPartido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaPartido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equipoLocal = table.Column<int>(type: "int", nullable: false),
                    equipoVisitante = table.Column<int>(type: "int", nullable: false),
                    marcadorInicialEL = table.Column<int>(type: "int", nullable: false),
                    marcadorInicialEV = table.Column<int>(type: "int", nullable: false),
                    Arbitroid = table.Column<int>(type: "int", nullable: true),
                    estadioid = table.Column<int>(type: "int", nullable: true),
                    Novedadid = table.Column<int>(type: "int", nullable: true),
                    Desempenoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Partidos_Arbitros_Arbitroid",
                        column: x => x.Arbitroid,
                        principalTable: "Arbitros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Desempenos_Desempenoid",
                        column: x => x.Desempenoid,
                        principalTable: "Desempenos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Estadios_estadioid",
                        column: x => x.estadioid,
                        principalTable: "Estadios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Novedades_Novedadid",
                        column: x => x.Novedadid,
                        principalTable: "Novedades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Desempenos_Equipoid",
                table: "Desempenos",
                column: "Equipoid");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_DirectorTecnicoid",
                table: "Equipos",
                column: "DirectorTecnicoid");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_Municipioid",
                table: "Equipos",
                column: "Municipioid");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_municipioid",
                table: "Estadios",
                column: "municipioid");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_Equipoid",
                table: "Jugadores",
                column: "Equipoid");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_posicionid",
                table: "Jugadores",
                column: "posicionid");

            migrationBuilder.CreateIndex(
                name: "IX_Novedades_jugadorid",
                table: "Novedades",
                column: "jugadorid");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_Arbitroid",
                table: "Partidos",
                column: "Arbitroid");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_Desempenoid",
                table: "Partidos",
                column: "Desempenoid");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_estadioid",
                table: "Partidos",
                column: "estadioid");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_Novedadid",
                table: "Partidos",
                column: "Novedadid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Arbitros");

            migrationBuilder.DropTable(
                name: "Desempenos");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "Novedades");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Posiciones");

            migrationBuilder.DropTable(
                name: "DirectoresTecnicos");

            migrationBuilder.DropTable(
                name: "Municipios");
        }
    }
}
