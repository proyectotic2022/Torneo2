﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Torneo.App.Persistencia;

namespace Torneo.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Torneo.App.Dominio.Arbitro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("colegio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("documento")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefono")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Arbitros");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Desempeno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("golesEnContra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("golesaFavor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("partidosE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("partidosG")
                        .HasColumnType("int");

                    b.Property<int>("partidosJ")
                        .HasColumnType("int");

                    b.Property<string>("partidosP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Desempenos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.DirectorTecnico", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("documento")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefono")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("DirectoresTecnicos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("desempenoid")
                        .HasColumnType("int");

                    b.Property<int?>("diretoresTecnicoid")
                        .HasColumnType("int");

                    b.Property<int?>("municipioid")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("desempenoid");

                    b.HasIndex("diretoresTecnicoid");

                    b.HasIndex("municipioid");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Estadios");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Jugador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("equipoid")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<int?>("posicionid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("equipoid");

                    b.HasIndex("posicionid");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Novedad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("jugadorid")
                        .HasColumnType("int");

                    b.Property<int>("minuto")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("jugadorid");

                    b.ToTable("Novedades");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Partido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Torneosid")
                        .HasColumnType("int");

                    b.Property<int?>("arbitrosid")
                        .HasColumnType("int");

                    b.Property<int?>("equipoaid")
                        .HasColumnType("int");

                    b.Property<int?>("equipobid")
                        .HasColumnType("int");

                    b.Property<int?>("estadioid")
                        .HasColumnType("int");

                    b.Property<string>("fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("marcadorInicalEL")
                        .HasColumnType("int");

                    b.Property<string>("marcadorInicialEV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Torneosid");

                    b.HasIndex("arbitrosid");

                    b.HasIndex("equipoaid");

                    b.HasIndex("equipobid");

                    b.HasIndex("estadioid");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Posicion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Posiciones");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Torneos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Torneos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Desempeno", "desempeno")
                        .WithMany()
                        .HasForeignKey("desempenoid");

                    b.HasOne("Torneo.App.Dominio.DirectorTecnico", "diretoresTecnico")
                        .WithMany()
                        .HasForeignKey("diretoresTecnicoid");

                    b.HasOne("Torneo.App.Dominio.Municipio", "municipio")
                        .WithMany("Equipos")
                        .HasForeignKey("municipioid");

                    b.Navigation("desempeno");

                    b.Navigation("diretoresTecnico");

                    b.Navigation("municipio");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Jugador", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Equipo", "equipo")
                        .WithMany("jugador")
                        .HasForeignKey("equipoid");

                    b.HasOne("Torneo.App.Dominio.Posicion", "posicion")
                        .WithMany()
                        .HasForeignKey("posicionid");

                    b.Navigation("equipo");

                    b.Navigation("posicion");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Novedad", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Jugador", "jugador")
                        .WithMany()
                        .HasForeignKey("jugadorid");

                    b.Navigation("jugador");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Partido", b =>
                {
                    b.HasOne("Torneo.App.Dominio.Torneos", null)
                        .WithMany("partidos")
                        .HasForeignKey("Torneosid");

                    b.HasOne("Torneo.App.Dominio.Arbitro", "arbitros")
                        .WithMany()
                        .HasForeignKey("arbitrosid");

                    b.HasOne("Torneo.App.Dominio.Equipo", "equipoa")
                        .WithMany()
                        .HasForeignKey("equipoaid");

                    b.HasOne("Torneo.App.Dominio.Equipo", "equipob")
                        .WithMany()
                        .HasForeignKey("equipobid");

                    b.HasOne("Torneo.App.Dominio.Estadio", "estadio")
                        .WithMany()
                        .HasForeignKey("estadioid");

                    b.Navigation("arbitros");

                    b.Navigation("equipoa");

                    b.Navigation("equipob");

                    b.Navigation("estadio");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Equipo", b =>
                {
                    b.Navigation("jugador");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Municipio", b =>
                {
                    b.Navigation("Equipos");
                });

            modelBuilder.Entity("Torneo.App.Dominio.Torneos", b =>
                {
                    b.Navigation("partidos");
                });
#pragma warning restore 612, 618
        }
    }
}
