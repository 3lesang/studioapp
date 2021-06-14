using QLFILM.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM
{
    class Context : DbContext
    {
        public Context()
            : base("name=cnStr")
        {
            Database.SetInitializer<Context>(null);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmActor> FilmActors { get; set; }
        public DbSet<CategoryFilm> CategoryFilms { get; set; }
        public DbSet<DirectorFilm> DirectorFilms { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmActor>()
                .HasRequired(a => a.Actor)
                .WithMany()
                .WillCascadeOnDelete();
            modelBuilder.Entity<CategoryFilm>()
                .HasRequired(a => a.Category)
                .WithMany()
                .WillCascadeOnDelete();
            modelBuilder.Entity<DirectorFilm>()
                .HasRequired(a => a.Director)
                .WithMany()
                .WillCascadeOnDelete();
            base.OnModelCreating(modelBuilder);
        }
    }
}
