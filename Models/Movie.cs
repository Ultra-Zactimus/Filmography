using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class Movie
  {
    public Movie()
    {
      this.JoinEntities = new HashSet<Producer>();
    }
    public int MovieId { get; set; }
    public string MovieName { get; set; }
    public string Description { get; set; }
    public virtual ICollection<Producer> JoinEntities { get; set; }
  }
}