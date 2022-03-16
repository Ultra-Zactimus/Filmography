// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc;
// using Filmography.Models;
// using System.Collections.Generic;
// using System.Linq;
// using System;

// namespace Filmography.Controllers
// {
//   public class ComposersController : Controller
//   {
//     private readonly FilmographyContext _db;

//     public ComposersController(FilmographyContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       return View(_db.Composers.ToList());
//     }

//     public ActionResult Create()
//     {
//       ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "MovieName");
//       return View();
//     }

//     [HttpPost]
//     public ActionResult Create(Composer composer, int MovieId)
//     {
//       _db.Composers.Add(composer);
//       _db.SaveChanges();
//       if (MovieId != 0)
//       {
//         _db.MovieComposer.Add(new MovieComposer() { MovieId = MovieId, ComposerId = composer.ComposerId });
//         _db.SaveChanges();
//       }
//       return RedirectToAction("Index");
//     }

//     public ActionResult Details(int id)
//     {
//       var thisComposer = _db.Composers
//           .Include(composer => composer.JoinEntities)
//           .ThenInclude(join => join.Composer)
//           .FirstOrDefault(composer => composer.ComposerId == id);
//       return View(thisComposer);
//     }

//     public ActionResult Edit(int id)
//     {
//       var thisComposer = _db.Composers.FirstOrDefault(composer => composer.ComposerId == id);
//       ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "MovieName");
//       return View(thisComposer);
//     }

//     [HttpPost]
//     public ActionResult Edit(Composer composer, int MovieId)
//     {
//       if (MovieId != 0)
//       {
//         _db.MovieComposer.Add(new MovieComposer() { MovieId = MovieId, ComposerId = composer.ComposerId });
//       }
//       _db.Entry(composer).State = EntityState.Modified;
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     public ActionResult AddMovie(int id)
//     {
//       var thisComposer = _db.Composers.FirstOrDefault(composer => composer.ComposerId == id);
//       ViewBag.MovieId = new SelectList(_db.Movies, "MovieId", "MovieName");
//       return View(thisComposer);
//     }

//     [HttpPost]
//     public ActionResult AddMovie(Composer composer, int MovieId)
//     {
//       if (MovieId != 0)
//       {
//         _db.MovieComposer.Add(new MovieComposer() { MovieId = MovieId, ComposerId = composer.ComposerId });
//         _db.SaveChanges();
//       }
//       return RedirectToAction("Index");
//     }

//     public ActionResult Delete(int id)
//     {
//       var thisComposer = _db.Composers.FirstOrDefault(composer => composer.ComposerId == id);
//       return View(thisComposer);
//     }

//     [HttpPost, ActionName("Delete")]
//     public ActionResult DeleteConfirmed(int id)
//     {
//       var thisComposer = _db.Composers.FirstOrDefault(composer => composer.ComposerId == id);
//       _db.Composers.Remove(thisComposer);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }

//     [HttpPost]
//     public ActionResult DeleteMovie(int joinId)
//     {
//       var joinEntry = _db.MovieComposer.FirstOrDefault(entry => entry.MovieComposerId == joinId);
//       _db.MovieComposer.Remove(joinEntry);
//       _db.SaveChanges();
//       return RedirectToAction("Index");
//     }
//   }
// }