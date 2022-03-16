using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class Movie
  {
    public Movie()
    {
      this.JoinEntities = new HashSet<MovieActor>();
      this.JoinEntities2 = new HashSet<MovieDirector>();
    }
    public int MovieId { get; set; }
    public string MovieName { get; set; }
    public string Description { get; set; }
    public virtual ICollection<MovieActor> JoinEntities { get; set; }
    public virtual ICollection<MovieDirector> JoinEntities2 { get; set; }
  }
}