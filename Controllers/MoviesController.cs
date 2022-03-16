using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Filmography.Models;
using System.Collections.Generic;
using System.Linq;

namespace Filmography.Controllers
{
  public class MoviesController : Controller
  {
    private readonly FilmographyContext _db;

    public MoviesController(FilmographyContext db)
    {
      _db = db;
    }

  }
}