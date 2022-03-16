using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class MovieWiki
  {
    public int MovieWikiId { get; set; }
    public int MovieId { get; set; }
    // public int DirectorId { get; set; }
    public int ActorId { get; set; }
    // public int ComposerId { get; set; }

    public virtual Movie Movie { get; set; }
    // public virtual Director Director { get; set; }
    public virtual Actor Actor { get; set; }
    // public virtual Composer Composer { get; set; }
  }
}