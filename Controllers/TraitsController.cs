using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace asp_webapp.Controllers
{
  [ApiController]
  [Route("api/cats/{catId}/traits")]
  public class TraitsController : ControllerBase
  {
    [HttpGet]
    public IActionResult GetTraits(int catId)
    {
      var trait = CatStore.Current.Cats.FirstOrDefault(c => c.Id == catId);

      if (trait == null)
      {
        return NotFound();
      }
      return Ok(trait.Traits);
    }

    [HttpGet("{id}", Name = "GetTrait")]
    public IActionResult GetTrait(int catId, int id)
    {
      var catToFind = CatStore.Current.Cats.FirstOrDefault(c => c.Id == catId);

      if (catToFind == null)
      {
        return NotFound();
      }
      var traitToFind = catToFind.Traits.FirstOrDefault(e => e.Id == id);
      if (traitToFind == null)
      {
        return NotFound();
      }
      return Ok(traitToFind);
    }
  }
}