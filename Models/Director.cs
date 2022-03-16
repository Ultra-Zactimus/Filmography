using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class Director
  {
    public Director()
    {
      this.JoinEntities = new HashSet<Producer>();
    }
    public int DirectorId { get; set; }
    public string DirectorName { get; set; }
    public virtual ICollection<Producer> JoinEntities { get; set; }
  }
}