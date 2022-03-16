using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class Director
  {
    public Director()
    {
      this.JoinEntities = new HashSet<MovieDirector>();
    }
    public int DirectorId { get; set; }
    public string DirectorName { get; set; }
    public virtual ICollection<MovieDirector> JoinEntities { get; set; }
  }
}