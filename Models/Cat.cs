using System.Collections.Generic;
using System.Linq;

namespace asp_webapp.Models
{
  public class Cat
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public int NumberOfTraits
    {
      get
      {
        return Traits.Count;
      }
    }

    public ICollection<Trait> Traits { get; set; } = new List<Trait>();
  }
}