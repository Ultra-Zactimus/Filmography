using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class Composer
  {
    public Composer()
    {
      this.JoinEntities = new HashSet<MovieWiki>();
    }
    public int ComposerId { get; set; }
    public string ComposerName { get; set; }
    public virtual ICollection<MovieWiki> JoinEntities { get; set; }
  }
}