using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Filmography.Models;
using System.Collections.Generic;
using System.Linq;
using System;

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

    public ActionResult Create()
    {
      ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "MovieName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Actor actor, int MovieId)
    {
      _db.Actors.Add(actor);
      _db.SaveChanges();
      if (MovieId != 0)
      {
        _db.MovieWiki.Add(new MovieWiki() { MovieId = MovieId, ActorId = actor.ActorId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisActor = _db.Actors
          .Include(actor => actor.JoinEntities)
          .ThenInclude(join => join.Movie)
          .FirstOrDefault(actor => actor.ActorId == id);
      return View(thisActor);
    }

    public ActionResult Edit(int id)
    {
      var thisActor = _db.Actors.FirstOrDefault(actor => actor.ActorId == id);
      ViewBag.MovieId = new SelectList(_db.Movies, "CMoviesId", "MovieName");
      return View(thisActor);
    }

    [HttpPost]
    public ActionResult Edit(Actor actor, int MovieId)
    {
      if (MovieId != 0)
      {
        _db.MovieWiki.Add(new MovieWiki() { MovieId = MovieId, ActorId = actor.ActorId });
      }
      _db.Entry(actor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddMovie(int id)
    {
      var thisActor = _db.Actors.FirstOrDefault(actor => actor.ActorId == id);
      var thisMovieWiki = _db.MovieWiki.Where(moviewiki => moviewiki.ActorId == id);
      
      List<Movie> movies = _db.Movies.ToList();
      List<Movie> movieList = _db.Movies.ToList();

      foreach (MovieWiki movieWiki in thisMovieWiki)
      {
        foreach(Movie movie in movies)
        {
          if (movie.MovieId == movieWiki.MovieId)
          {
            movieList.Remove(movie);
          }
        }
      }
      ViewBag.MovieId = new SelectList(movieList, "MovieId", "MovieName");
      ViewBag.movieList = movieList.Count;
      return View(thisActor);


      // var thisActor = _db.Actors.FirstOrDefault(actor => actor.ActorId == id);
      // ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "MovieName");
      // return View(thisActor);
    }

    [HttpPost]
    public ActionResult AddMovie(Actor actor, int MovieId)
    {
      if (MovieId != 0)
      {
        _db.MovieWiki.Add(new MovieWiki() { MovieId = MovieId, ActorId = actor.ActorId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisActor = _db.Actors.FirstOrDefault(actor => actor.ActorId == id);
      return View(thisActor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisActor = _db.Actors.FirstOrDefault(actor => actor.ActorId == id);
      _db.Actors.Remove(thisActor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteMovie(int joinId)
    {
      var joinEntry = _db.MovieWiki.FirstOrDefault(entry => entry.MovieWikiId == joinId);
      _db.MovieWiki.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}