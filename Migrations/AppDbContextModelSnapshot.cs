﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineTicketSystem.Data;

namespace OnlineTicketSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineTicketSystem.Models.Actors", b =>
                {
                    b.Property<int>("ActId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutAct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActPictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("OnlineTicketSystem.Models.Actors_Movies", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Actors_Movies");
                });

            modelBuilder.Entity("OnlineTicketSystem.Models.Cinemas", b =>
                {
                    b.Property<int>("CinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionCin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CinId");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("OnlineTicketSystem.Models.Movie", b =>
                {
                    b.Property<int>("MovId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<int?>("ProducersProdId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("MovId");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProducersProdId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("OnlineTicketSystem.Models.Producers", b =>
                {
                    b.Property<int>("ProdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProdDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProdFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProdPictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProdId");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("OnlineTicketSystem.Models.Actors_Movies", b =>
                {
                    b.HasOne("OnlineTicketSystem.Models.Actors", "Actors")
                        .WithMany("Actor_Movie")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineTicketSystem.Models.Movie", "Movie")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actors");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("OnlineTicketSystem.Models.Movie", b =>
                {
                    b.HasOne("OnlineTicketSystem.Models.Cinemas", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineTicketSystem.Models.Producers", "Producers")
                        .WithMany("Movies")
                        .HasForeignKey("ProducersProdId");

                    b.Navigation("Cinema");

                    b.Navigation("Producers");
                });

            modelBuilder.Entity("OnlineTicketSystem.Models.Actors", b =>
                {
                    b.Navigation("Actor_Movie");
                });

            modelBuilder.Entity("OnlineTicketSystem.Models.Cinemas", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("OnlineTicketSystem.Models.Movie", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("OnlineTicketSystem.Models.Producers", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
