using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class Composer
  {
    public Composer()
    {
      this.JoinEntities = new HashSet<Producer>();
    }
    public int ComposerId { get; set; }
    public string ComposerName { get; set; }
    public virtual ICollection<Producer> JoinEntities { get; set; }
  }
}