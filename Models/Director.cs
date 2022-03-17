using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class Director
  {
    public Director()
    {
      this.JoinEntities2 = new HashSet<MovieDirector>();
    }
    public int DirectorId { get; set; }
    public string DirectorName { get; set; }
    public virtual ICollection<MovieDirector> JoinEntities2 { get; set; }
  }
}