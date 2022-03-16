using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Filmography.Models;
using System.Collections.Generic;
using System.Linq;

namespace Filmography.Controllers
{
  public class ActorsController : Controller
  {
    private readonly FilmographyContext _db;

    public ActorsController(FilmographyContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Actors.ToList());
    }

  }
}