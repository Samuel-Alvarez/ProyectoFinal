﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyLottoRewards.Data;

#nullable disable

namespace MyLottoRewards.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220802224902_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyLottoRewards.Models.Ganancia", b =>
                {
                    b.Property<int>("GananciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Loteria")
                        .HasColumnType("TEXT");

                    b.Property<int>("Monto")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreLoteria")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoJugada")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalGanancia")
                        .HasColumnType("REAL");

                    b.Property<double>("TotalMonto")
                        .HasColumnType("REAL");

                    b.HasKey("GananciaId");

                    b.ToTable("Ganancia");
                });

            modelBuilder.Entity("MyLottoRewards.Models.GananciasDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GananciaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ganancias")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LoteriaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Monto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoJugadaId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("TotalGanancia")
                        .HasColumnType("REAL");

                    b.Property<double>("TotalMonto")
                        .HasColumnType("REAL");

                    b.HasKey("DetalleId");

                    b.HasIndex("GananciaId");

                    b.ToTable("GananciasDetalle");
                });

            modelBuilder.Entity("MyLottoRewards.Models.Loteria", b =>
                {
                    b.Property<int>("LoteriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreLoteria")
                        .HasColumnType("TEXT");

                    b.HasKey("LoteriaId");

                    b.ToTable("Loteria");

                    b.HasData(
                        new
                        {
                            LoteriaId = 1,
                            NombreLoteria = "Quiniela Loteka"
                        },
                        new
                        {
                            LoteriaId = 2,
                            NombreLoteria = "Loteria Nacional"
                        },
                        new
                        {
                            LoteriaId = 3,
                            NombreLoteria = "Quiniela Leidsa"
                        },
                        new
                        {
                            LoteriaId = 4,
                            NombreLoteria = "Quiniela Real"
                        },
                        new
                        {
                            LoteriaId = 5,
                            NombreLoteria = "La Primera"
                        },
                        new
                        {
                            LoteriaId = 6,
                            NombreLoteria = "Pega 3 mas"
                        },
                        new
                        {
                            LoteriaId = 7,
                            NombreLoteria = "Loto Pool"
                        },
                        new
                        {
                            LoteriaId = 8,
                            NombreLoteria = "Loto - Loto Mas"
                        },
                        new
                        {
                            LoteriaId = 9,
                            NombreLoteria = "Loto Real"
                        },
                        new
                        {
                            LoteriaId = 10,
                            NombreLoteria = "Gana Mas"
                        });
                });

            modelBuilder.Entity("MyLottoRewards.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Loteria")
                        .HasColumnType("TEXT");

                    b.Property<int>("Monto")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreLoteria")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoJugada")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalMonto")
                        .HasColumnType("REAL");

                    b.HasKey("TicketId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("MyLottoRewards.Models.TicketsDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LoteriaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Monto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TicketId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoJugadaId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("TotalMonto")
                        .HasColumnType("REAL");

                    b.HasKey("DetalleId");

                    b.HasIndex("TicketId");

                    b.ToTable("TicketsDetalle");
                });

            modelBuilder.Entity("MyLottoRewards.Models.TipoJugada", b =>
                {
                    b.Property<int>("TipoJugadaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreJugada")
                        .HasColumnType("TEXT");

                    b.HasKey("TipoJugadaId");

                    b.ToTable("TipoJugada");

                    b.HasData(
                        new
                        {
                            TipoJugadaId = 1,
                            NombreJugada = "Pale"
                        },
                        new
                        {
                            TipoJugadaId = 2,
                            NombreJugada = "Tripleta"
                        },
                        new
                        {
                            TipoJugadaId = 3,
                            NombreJugada = "Quiniela"
                        },
                        new
                        {
                            TipoJugadaId = 4,
                            NombreJugada = "Super pale"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyLottoRewards.Models.GananciasDetalle", b =>
                {
                    b.HasOne("MyLottoRewards.Models.Ganancia", null)
                        .WithMany("Detalle")
                        .HasForeignKey("GananciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyLottoRewards.Models.TicketsDetalle", b =>
                {
                    b.HasOne("MyLottoRewards.Models.Ticket", null)
                        .WithMany("Detalle")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyLottoRewards.Models.Ganancia", b =>
                {
                    b.Navigation("Detalle");
                });

            modelBuilder.Entity("MyLottoRewards.Models.Ticket", b =>
                {
                    b.Navigation("Detalle");
                });
#pragma warning restore 612, 618
        }
    }
}