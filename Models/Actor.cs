using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class Actor
  {
    public Actor()
    {
      this.JoinEntities = new HashSet<MovieActor>();
    }
    public int ActorId { get; set; }
    public string ActorName { get; set; }
    public virtual ICollection<MovieActor> JoinEntities { get; set; }
  }
}