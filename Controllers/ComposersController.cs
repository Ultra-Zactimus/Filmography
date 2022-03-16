using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Filmography.Models;
using System.Collections.Generic;
using System.Linq;

namespace Filmography.Controllers
{
  public class ComposersController : Controller
  {
    private readonly FilmographyContext _db;

    public ComposersController(FilmographyContext db)
    {
      _db = db;
    }

  }
}