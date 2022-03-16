using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class Actor
  {
    public Actor()
    {
      this.JoinEntities = new HashSet<Producer>();
    }
    public int ActorId { get; set; }
    public string ActorName { get; set; }
    public virtual ICollection<Producer> JoinEntities { get; set; }
  }
}