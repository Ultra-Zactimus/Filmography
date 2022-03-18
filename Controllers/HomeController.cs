using Microsoft.AspNetCore.Mvc;

namespace Filmography.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}