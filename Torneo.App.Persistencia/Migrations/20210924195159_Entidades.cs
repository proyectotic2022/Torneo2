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
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documento = table.Column<int>(type: "int", nullable: false),
                    telefono = table.Column<int>(type: "int", nullable: false),
                    colegio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Desempenos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    partidosJ = table.Column<int>(type: "int", nullable: false),
                    partidosG = table.Column<int>(type: "int", nullable: false),
                    partidosE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    partidosP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    golesaFavor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    golesEnContra = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desempenos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DirectoresTecnicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documento = table.Column<int>(type: "int", nullable: false),
                    telefono = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectoresTecnicos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posiciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Torneos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Torneos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diretoresTecnicoid = table.Column<int>(type: "int", nullable: true),
                    municipioid = table.Column<int>(type: "int", nullable: true),
                    desempenoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Equipos_Desempenos_desempenoid",
                        column: x => x.desempenoid,
                        principalTable: "Desempenos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_DirectoresTecnicos_diretoresTecnicoid",
                        column: x => x.diretoresTecnicoid,
                        principalTable: "DirectoresTecnicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Municipios_municipioid",
                        column: x => x.municipioid,
                        principalTable: "Municipios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numero = table.Column<int>(type: "int", nullable: false),
                    equipoid = table.Column<int>(type: "int", nullable: true),
                    posicionid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.id);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_equipoid",
                        column: x => x.equipoid,
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
                name: "Partidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marcadorInicalEL = table.Column<int>(type: "int", nullable: false),
                    marcadorInicialEV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    arbitrosid = table.Column<int>(type: "int", nullable: true),
                    equipoaid = table.Column<int>(type: "int", nullable: true),
                    equipobid = table.Column<int>(type: "int", nullable: true),
                    estadioid = table.Column<int>(type: "int", nullable: true),
                    Torneosid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Partidos_Arbitros_arbitrosid",
                        column: x => x.arbitrosid,
                        principalTable: "Arbitros",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_equipoaid",
                        column: x => x.equipoaid,
                        principalTable: "Equipos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_equipobid",
                        column: x => x.equipobid,
                        principalTable: "Equipos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Estadios_estadioid",
                        column: x => x.estadioid,
                        principalTable: "Estadios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Torneos_Torneosid",
                        column: x => x.Torneosid,
                        principalTable: "Torneos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Novedades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    minuto = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_desempenoid",
                table: "Equipos",
                column: "desempenoid");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_diretoresTecnicoid",
                table: "Equipos",
                column: "diretoresTecnicoid");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_municipioid",
                table: "Equipos",
                column: "municipioid");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_equipoid",
                table: "Jugadores",
                column: "equipoid");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_posicionid",
                table: "Jugadores",
                column: "posicionid");

            migrationBuilder.CreateIndex(
                name: "IX_Novedades_jugadorid",
                table: "Novedades",
                column: "jugadorid");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_arbitrosid",
                table: "Partidos",
                column: "arbitrosid");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_equipoaid",
                table: "Partidos",
                column: "equipoaid");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_equipobid",
                table: "Partidos",
                column: "equipobid");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_estadioid",
                table: "Partidos",
                column: "estadioid");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_Torneosid",
                table: "Partidos",
                column: "Torneosid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Novedades");

            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Arbitros");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "Torneos");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Posiciones");

            migrationBuilder.DropTable(
                name: "Desempenos");

            migrationBuilder.DropTable(
                name: "DirectoresTecnicos");

            migrationBuilder.DropTable(
                name: "Municipios");
        }
    }
}
