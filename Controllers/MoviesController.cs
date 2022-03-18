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
      var wiki = _db.MovieWiki.Where(m => m.MovieId == id);
      List<Director> directors = _db.Directors.ToList();
      List<Director> directorList = _db.Directors.ToList();
      foreach(MovieWiki w in wiki)
      {
        foreach(Director director in directors)
        {
          if (director.DirectorId == w.DirectorId)
          {
            directorList.Remove(director);
          }
        }
      }
      ViewBag.DirectorId = new SelectList(directorList, "DirectorId", "DirectorName");
      ViewBag.num = directorList.Count();
      var thisMovie = _db.Movies.FirstOrDefault(movie => movie.MovieId == id);
      return View(thisMovie);
    }

    [HttpPost]
    public ActionResult AddDirector(int MovieId, int DirectorId)
    {
      if (DirectorId != 0 && !_db.MovieWiki.Any(f => f.MovieId == MovieId && f.DirectorId == DirectorId))
      {
        _db.MovieWiki.Add(new MovieWiki() { DirectorId = DirectorId, MovieId = MovieId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = MovieId });
    }

    public ActionResult AddActor(int id)
    {
      var wiki = _db.MovieWiki.Where(m => m.MovieId == id);
      List<Actor> actors = _db.Actors.ToList();
      List<Actor> actorList = _db.Actors.ToList();
      foreach(MovieWiki w in wiki)
      {
        foreach(Actor actor in actors)
        {
          if (actor.ActorId == w.ActorId)
          {
            actorList.Remove(actor);
          }
        }
      }
      ViewBag.ActorId = new SelectList(actorList, "ActorId", "ActorName");
      ViewBag.num = actorList.Count();
      var thisMovie = _db.Movies.FirstOrDefault(movie => movie.MovieId == id);
      return View(thisMovie);
    }

    [HttpPost]
    public ActionResult AddActor(int MovieId, int ActorId)
    {
      if (ActorId != 0 && !_db.MovieWiki.Any(f => f.MovieId == MovieId && f.ActorId == ActorId))
      {
        _db.MovieWiki.Add(new MovieWiki() { ActorId = ActorId, MovieId = MovieId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = MovieId });
    }

    public ActionResult AddComposer(int id)
    {
      var wiki = _db.MovieWiki.Where(m => m.MovieId == id);
      List<Composer> composers = _db.Composers.ToList();
      List<Composer> composerList = _db.Composers.ToList();
      foreach(MovieWiki w in wiki)
      {
        foreach(Composer composer in composers)
        {
          if (composer.ComposerId == w.ComposerId)
          {
            composerList.Remove(composer);
          }
        }
      }
      ViewBag.ComposerId = new SelectList(composerList, "ComposerId", "ComposerName");
      ViewBag.num = composerList.Count();
      var thisMovie = _db.Movies.FirstOrDefault(movie => movie.MovieId == id);
      return View(thisMovie);
    }

    [HttpPost]
    public ActionResult AddComposer(int MovieId, int ComposerId)
    {
      if (ComposerId != 0 && !_db.MovieWiki.Any(f => f.MovieId == MovieId && f.ComposerId == ComposerId))
      {
        _db.MovieWiki.Add(new MovieWiki() { ComposerId = ComposerId, MovieId = MovieId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = MovieId });
    }

    [HttpPost]
    public ActionResult DeleteJoin(int joinId)
    {
      var joinEntry = _db.MovieWiki.FirstOrDefault(entry => entry.MovieWikiId == joinId);
      _db.MovieWiki.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}