using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class MovieWiki
  {
    public int MovieWikiId { get; set; }
    public int MovieId { get; set; }
    public int? ActorId { get; set; }
    public int? DirectorId { get; set; }
    public int? ComposerId { get; set; }
    public Movie Movie { get; set; }
    public Actor Actor { get; set; }
    public Director Director { get; set; }
    public Composer Composer { get; set; }
  }
}