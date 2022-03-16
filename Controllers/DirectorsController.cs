using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Filmography.Models;
using System.Collections.Generic;
using System.Linq;

namespace Filmography.Controllers
{
  public class DirectorsController : Controller
  {
    private readonly FilmographyContext _db;

    public DirectorsController(FilmographyContext db)
    {
      _db = db;
    }

  }
}