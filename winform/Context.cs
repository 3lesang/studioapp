using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace winform
{
    public class Context : DbContext
    {
        public Context()
            : base("name=winform")
        {

        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Film> Films { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

    }
}
