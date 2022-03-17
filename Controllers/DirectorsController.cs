using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Filmography.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Filmography.Controllers
{
  public class DirectorsController : Controller
  {
    private readonly FilmographyContext _db;

    public DirectorsController(FilmographyContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(_db.Directors.ToList());
    }

        public ActionResult Create()
    {
      ViewBag.MoviId = new SelectList(_db.Movies, "MovieId", "MovieName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Director director, int MovieId)
    {
      _db.Directors.Add(director);
      _db.SaveChanges();
      if (MovieId != 0)
      {
        _db.MovieDirector.Add(new MovieDirector() { MovieId = MovieId, DirectorId = director.DirectorId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisDirector = _db.Directors
          .Include(director => director.JoinEntities2)
          .ThenInclude(join => join.Movie)
          .FirstOrDefault(director => director.DirectorId == id);
      return View(thisDirector);
    }

    public ActionResult Edit(int id)
    {
      var thisDirector = _db.Directors.FirstOrDefault(director => director.DirectorId == id);
      ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "MovieName");
      return View(thisDirector);
    }

    [HttpPost]
    public ActionResult Edit(Director director, int MovieId)
    {
      if (MovieId != 0)
      {
        _db.MovieDirector.Add(new MovieDirector() { MovieId = MovieId, DirectorId = director.DirectorId });
      }
      _db.Entry(director).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddMovie(int id)
    {
      var thisDirector = _db.Directors.FirstOrDefault(director => director.DirectorId == id);
      var thisMovieDirector = _db.MovieDirector.Where(moviedirector => moviedirector.DirectorId == id);
      
      List<Movie> movies = _db.Movies.ToList();
      List<Movie> movieList = _db.Movies.ToList();

      foreach (MovieDirector movieDirector in thisMovieDirector)
      {
        foreach(Movie movie in movies)
        {
          if (movie.MovieId == movieDirector.MovieId)
          {
            movieList.Remove(movie);
          }
        }
      }
      ViewBag.MovieId = new SelectList(movieList, "MovieId", "MovieName");
      ViewBag.movieList = movieList.Count;
      return View(thisDirector);

      // var thisDirector= _db.Directors.FirstOrDefault(director => director.DirectorId == id);
      // ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "MovieName");
      // return View(thisDirector);
    }

    [HttpPost]
    public ActionResult AddMovie(Director director, int MovieId)
    {
      if (MovieId != 0)
      {
        _db.MovieDirector.Add(new MovieDirector() { MovieId = MovieId, DirectorId = director.DirectorId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisDirector = _db.Directors.FirstOrDefault(director => director.DirectorId == id);
      return View(thisDirector);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisDirector = _db.Directors.FirstOrDefault(director => director.DirectorId == id);
      _db.Directors.Remove(thisDirector);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteCategory(int joinId)
    {
      var joinEntry = _db.MovieDirector.FirstOrDefault(entry => entry.MovieDirectorId == joinId);
      _db.MovieDirector.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}