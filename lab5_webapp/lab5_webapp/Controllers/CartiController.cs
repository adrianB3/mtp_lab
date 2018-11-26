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
    public class CartiController : Controller
    {
        private BibliotecaContext db = new BibliotecaContext();

        // GET: Carti
        public async Task<ActionResult> Index(string an1, string an2)
        {
            var carti = from c in db.Carti select c;
            if(!String.IsNullOrEmpty(an1) && !String.IsNullOrEmpty(an2))
            {
                int an11 = int.Parse(an1);
                int an22 = int.Parse(an2);
                if (an11 <= an22)
                {
                    carti = carti.Where(c => c.AnAparitie >= an11 && c.AnAparitie <= an22);
                }
            }           
            return View(carti);
        }

        // GET: Carti/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carte carte = await db.Carti.FindAsync(id);
            if (carte == null)
            {
                return HttpNotFound();
            }
            return View(carte);
        }

        // GET: Carti/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carti/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CarteId,Titlu,Autor,Editura,AnAparitie")] Carte carte)
        {
            if (ModelState.IsValid)
            {
                db.Carti.Add(carte);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(carte);
        }

        // GET: Carti/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carte carte = await db.Carti.FindAsync(id);
            if (carte == null)
            {
                return HttpNotFound();
            }
            return View(carte);
        }

        // POST: Carti/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CarteId,Titlu,Autor,Editura,AnAparitie")] Carte carte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carte).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(carte);
        }

        // GET: Carti/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carte carte = await db.Carti.FindAsync(id);
            if (carte == null)
            {
                return HttpNotFound();
            }
            return View(carte);
        }

        // POST: Carti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Carte carte = await db.Carti.FindAsync(id);
            db.Carti.Remove(carte);
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
