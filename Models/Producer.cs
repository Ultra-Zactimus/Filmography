using System.Collections.Generic;
using System.Linq;

namespace Filmography.Models
{
  public class Producer
  {
    public Producer()
    {
      this.JoinEntities = new HashSet<Producer>();
    }
    public int ProducerId { get; set; }
    public string ProducerName { get; set; }
    public virtual ICollection<Producer> JoinEntities { get; set; }
  }
}