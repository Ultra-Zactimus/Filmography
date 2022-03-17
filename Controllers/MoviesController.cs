using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Filmography.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Filmography.Controllers
{
  public class MoviesController : Controller
  {
    private readonly FilmographyContext _db;

    public MoviesController(FilmographyContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Movie> model = _db.Movies.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Movie movie)
    {
      _db.Movies.Add(movie);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisMovie = _db.Movies
        .Include(movie => movie.JoinEntities)
        .ThenInclude(join => join.Actor)
        .Include(movie => movie.JoinEntities)
        .ThenInclude(join => join.Director)
        .Include(movie => movie.JoinEntities)
        .ThenInclude(join => join.Composer)
        .FirstOrDefault(movie => movie.MovieId == id);
      return View(thisMovie);
    } 

    public ActionResult Edit(int id)
    {
      var thisMovie = _db.Movies.FirstOrDefault(movie => movie.MovieId == id);
      return View(thisMovie);
    }

    [HttpPost]
    public ActionResult Edit(Movie movie)
    {
      _db.Entry(movie).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      var thisMovie = _db.Movies.FirstOrDefault(movie => movie.MovieId == id);
      return View(thisMovie);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisMovie =_db.Movies.FirstOrDefault(movie => movie.MovieId == id);
      _db.Movies.Remove(thisMovie);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    
    public ActionResult AddDirector(int id)
    {
      var thisDirector =_db.Directors.FirstOrDefault(director => director.DirectorId == id);
      var thisMovieWiki = _db.MovieWiki.Where(MovieWiki => MovieWiki.MovieId == id);
      
      List<Movie> movies = _db.Movies.ToList();
      List<Movie> movieList = _db.Movies.ToList();
      foreach (MovieWiki movieDirector in thisMovieWiki)
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
      ViewBag.DirectorId = new SelectList(_db.Directors, "DirectorId", "DirectorName");
      return View(thisDirector);
    }

    [HttpPost]
    public ActionResult AddDirector(Movie movie, int DirectorId)
    {
      if(DirectorId != 0)
      {
      _db.MovieWiki.Add(new MovieWiki() { DirectorId = DirectorId, MovieId = movie.MovieId });
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = movie.MovieId });
    }
  }
}