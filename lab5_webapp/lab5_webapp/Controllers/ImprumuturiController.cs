using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lab5_webapp.Models;

namespace lab5_webapp.Controllers
{
    public class ImprumuturiController : Controller
    {
        private BibliotecaContext db = new BibliotecaContext();

        // GET: Imprumuturi
        public async Task<ActionResult> Index()
        {
            var imprumuturi = db.Imprumuturi.Include(i => i.Carte).Include(i => i.Client);
            return View(await imprumuturi.ToListAsync());
        }

        // GET: Imprumuturi/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imprumut imprumut = await db.Imprumuturi.FindAsync(id);
            if (imprumut == null)
            {
                return HttpNotFound();
            }
            return View(imprumut);
        }

        // GET: Imprumuturi/Create
        public ActionResult Create()
        {
            ViewBag.CarteId = new SelectList(db.Carti, "CarteId", "Titlu");
            ViewBag.ClientId = new SelectList(db.Clienti, "ClientId", "Nume");
            return View();
        }

        // POST: Imprumuturi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ImprumutId,ClientId,CarteId,DataImprumut")] Imprumut imprumut)
        {
            if (ModelState.IsValid)
            {
                db.Imprumuturi.Add(imprumut);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CarteId = new SelectList(db.Carti, "CarteId", "Titlu", imprumut.CarteId);
            ViewBag.ClientId = new SelectList(db.Clienti, "ClientId", "Nume", imprumut.ClientId);
            return View(imprumut);
        }

        // GET: Imprumuturi/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imprumut imprumut = await db.Imprumuturi.FindAsync(id);
            if (imprumut == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarteId = new SelectList(db.Carti, "CarteId", "Titlu", imprumut.CarteId);
            ViewBag.ClientId = new SelectList(db.Clienti, "ClientId", "Nume", imprumut.ClientId);
            return View(imprumut);
        }

        // POST: Imprumuturi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ImprumutId,ClientId,CarteId,DataImprumut")] Imprumut imprumut)
        {
            if (ModelState.IsValid)
            {
                db.Entry(imprumut).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CarteId = new SelectList(db.Carti, "CarteId", "Titlu", imprumut.CarteId);
            ViewBag.ClientId = new SelectList(db.Clienti, "ClientId", "Nume", imprumut.ClientId);
            return View(imprumut);
        }

        // GET: Imprumuturi/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Imprumut imprumut = await db.Imprumuturi.FindAsync(id);
            if (imprumut == null)
            {
                return HttpNotFound();
            }
            return View(imprumut);
        }

        // POST: Imprumuturi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Imprumut imprumut = await db.Imprumuturi.FindAsync(id);
            db.Imprumuturi.Remove(imprumut);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
