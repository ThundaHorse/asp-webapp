using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace asp_webapp.Controllers
{
  [ApiController]
  [Route("api/cats")]
  public class CatsController : ControllerBase
  {
    [HttpGet]
    public IActionResult GetCats()
    {
      return Ok(CatStore.Current.Cats);
    }

    [HttpGet("{id}")]
    public IActionResult GetAction(int id)
    {
      var catToReturn = CatStore.Current.Cats.FirstOrDefault(c => c.Id == id);

      if (catToReturn == null)
      {
        return NotFound();
      }
      return Ok(catToReturn);
    }
  }
}