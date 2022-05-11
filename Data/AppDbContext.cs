using Microsoft.EntityFrameworkCore;
using OnlineTicketSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTicketSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors_Movies>().HasKey(act_mov => new
            {
                act_mov.ActorId,
                act_mov.MovieId
            });

            modelBuilder.Entity<Actors_Movies>().HasOne(m => m.Movie).WithMany(act_mov => act_mov.Actors_Movies).HasForeignKey(m => 
            m.MovieId);

            modelBuilder.Entity<Actors_Movies>().HasOne(a => a.Actors).WithMany(act_mov => act_mov.Actor_Movie).HasForeignKey(a =>
            a.ActorId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actors> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actors_Movies> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producers> Producers { get; set; }

    }
}
