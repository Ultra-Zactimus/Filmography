﻿// <auto-generated />
using Filmography.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Filmography.Migrations
{
    [DbContext(typeof(FilmographyContext))]
    partial class FilmographyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Filmography.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ActorName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Filmography.Models.Composer", b =>
                {
                    b.Property<int>("ComposerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ComposerName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ComposerId");

                    b.ToTable("Composers");
                });

            modelBuilder.Entity("Filmography.Models.Director", b =>
                {
                    b.Property<int>("DirectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DirectorName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DirectorId");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("Filmography.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("MovieName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Filmography.Models.MovieWiki", b =>
                {
                    b.Property<int>("MovieWikiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("ComposerId")
                        .HasColumnType("int");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("MovieWikiId");

                    b.HasIndex("ActorId");

                    b.HasIndex("ComposerId");

                    b.HasIndex("DirectorId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieWiki");
                });

            modelBuilder.Entity("Filmography.Models.MovieWiki", b =>
                {
                    b.HasOne("Filmography.Models.Actor", "Actor")
                        .WithMany("JoinEntities")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Filmography.Models.Composer", "Composer")
                        .WithMany("JoinEntities")
                        .HasForeignKey("ComposerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Filmography.Models.Director", "Director")
                        .WithMany("JoinEntities")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Filmography.Models.Movie", "Movie")
                        .WithMany("JoinEntities")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Composer");

                    b.Navigation("Director");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Filmography.Models.Actor", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Filmography.Models.Composer", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Filmography.Models.Director", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Filmography.Models.Movie", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
