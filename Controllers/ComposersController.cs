using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Filmography.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Filmography.Controllers
{
  public class ComposersController : Controller
  {
    private readonly FilmographyContext _db;

    public ComposersController(FilmographyContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Composers.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "MovieName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Composer composer, int MovieId)
    {
      _db.Composers.Add(composer);
      _db.SaveChanges();
      // if (MovieId != 0)
      // {
      //   _db.MovieWiki.Add(new MovieWiki() { MovieId = MovieId, ComposerId = composer.ComposerId });
      //   _db.SaveChanges();
      // }
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisComposer = _db.Composers
          .Include(composer => composer.JoinEntities)
          .ThenInclude(join => join.Movie)
          .FirstOrDefault(composer => composer.ComposerId == id);
      return View(thisComposer);
    }

    public ActionResult Edit(int id)
    {
      var thisComposer = _db.Composers.FirstOrDefault(composer => composer.ComposerId == id);
      ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "MovieName");
      return View(thisComposer);
    }

    [HttpPost]
    public ActionResult Edit(Composer composer, int MovieId)
    {
      if (MovieId != 0)
      {
        _db.MovieWiki.Add(new MovieWiki() { MovieId = MovieId, ComposerId = composer.ComposerId });
      }
      _db.Entry(composer).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddMovie(int id)
    {
      var wiki = _db.MovieWiki.Where(MovieWiki => MovieWiki.ComposerId == id);
      List<Movie> movies = _db.Movies.ToList();
      List<Movie> movieList = _db.Movies.ToList();
      foreach(MovieWiki w in wiki)
      {
        foreach(Movie movie in movies)
        {
          if (movie.MovieId == w.MovieId)
          {
            movieList.Remove(movie);
          }
        }
      }
      ViewBag.MovieId = new SelectList(movieList, "MovieId", "MovieName");
      ViewBag.movieList = movieList.Count;
      var thisComposer = _db.Composers.FirstOrDefault(composer => composer.ComposerId == id);
      return View(thisComposer);
    }

    [HttpPost]
    public ActionResult AddMovie(Composer composer, int MovieId)
    {
      if (MovieId != 0)
      {
        _db.MovieWiki.Add(new MovieWiki() { MovieId = MovieId, ComposerId = composer.ComposerId });
        _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisComposer = _db.Composers.FirstOrDefault(composer => composer.ComposerId == id);
      return View(thisComposer);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisComposer = _db.Composers.FirstOrDefault(composer => composer.ComposerId == id);
      _db.Composers.Remove(thisComposer);
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