using Microsoft.EntityFrameworkCore;

namespace Filmography.Models
{
  public class FilmographyContext : DbContext
  {
    public DbSet<Actor> Actors { get; set; }
    //public DbSet<Composer> Composers { get; set; }
    public DbSet<Director> Directors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieActor> MovieActor { get; set; }
    public DbSet<MovieDirector> MovieDirector { get; set; }
    // public DbSet<MovieComposer> MovieComposer { get; set; }

    public FilmographyContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}