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
    public class ClientiController : Controller
    {
        private BibliotecaContext db = new BibliotecaContext();

        // GET: Clienti
        public async Task<ActionResult> Index(string nume)
        {
            var clienti = from c in db.Clienti select c;
            if (!String.IsNullOrEmpty(nume))
            {
                clienti = clienti.Where(c => c.Nume.Contains(nume));
            }
            return View(clienti);
        }

        // GET: Clienti/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = await db.Clienti.FindAsync(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            var today = DateTime.Today;
            int yearOfBirth = 1990;
            if(client.CNP[0].Equals('1') || client.CNP[0].Equals('2'))
            {
                yearOfBirth = int.Parse(client.CNP.Substring(1, 2)) + 1900;
            }

            if (client.CNP[0].Equals('5') || client.CNP[0].Equals('6'))
            {
                yearOfBirth = int.Parse(client.CNP.Substring(1, 2)) + 2000;
            }

            int monthOfBirth = int.Parse(client.CNP.Substring(3, 2));
            int dayOfBirth = int.Parse(client.CNP.Substring(5, 2));
            DateTime dateOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age)) age--;
            string dateOfBirthStr = dateOfBirth.ToString("dd-MMMM-yyyy");
            
            float[] penalties = new float[client.Imprumuturi.Count];
            int count = 0;
            foreach (var impr in client.Imprumuturi)
            {
                if (impr.DataImprumut.AddDays(7) < DateTime.Today)
                {
                    impr.IsDue = true;
                }
                else
                {
                    impr.IsDue = false;
                }
                if (impr.IsDue)
                {
                    penalties[count] = ((today - impr.DataImprumut).Days * 2);
                }
                count++;
            }

            ViewBag.dateOfBirth = dateOfBirthStr;
            ViewBag.age = age.ToString();
            ViewBag.penalties = penalties;
            return View(client);
        }

        // GET: Clienti/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clienti/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ClientId,Nume,CNP,Adresa,Telefon")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Clienti.Add(client);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(client);
        }

        // GET: Clienti/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = await db.Clienti.FindAsync(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clienti/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ClientId,Nume,CNP,Adresa,Telefon")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(client);
        }

        // GET: Clienti/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = await db.Clienti.FindAsync(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clienti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Client client = await db.Clienti.FindAsync(id);
            db.Clienti.Remove(client);
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
