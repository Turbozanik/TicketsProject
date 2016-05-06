using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrainApplication.Database;

namespace TrainApplication.Controllers
{
    public class TrainController : Controller
    {
        private TrainEntities db = new TrainEntities();

        // GET: Train/TrainIndex
        public ActionResult TrainIndex()
        {
            return View(db.Trains.ToList());
        }

        /*
        // GET: Train/TrainDetails/5
        public ActionResult TrainDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Train train = db.Trains.Find(id);
            if (train == null)
            {
                return HttpNotFound();
            }
            return View(train);
        }
        */

        // GET: Train/TrainCreate
        public ActionResult TrainCreate()
        {
            return View();
        }

        // POST: Train/TrainCreate
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TrainCreate([Bind(Include = "Id,GovId,Capacity,Title,Description,Routes")] Train train)
        {
            if (ModelState.IsValid)
            {
                db.Trains.Add(train);
                db.SaveChanges();
                DisplaySuccessMessage("Has append a Train record");
                return RedirectToAction("TrainIndex");
            }

            DisplayErrorMessage();
            return View(train);
        }

        // GET: Train/TrainEdit/5
        public ActionResult TrainEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Train train = db.Trains.Find(id);
            if (train == null)
            {
                return HttpNotFound();
            }
            return View(train);
        }

        // POST: TrainTrain/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TrainEdit([Bind(Include = "Id,GovId,Capacity,Title,Description,Routes")] Train train)
        {
            if (ModelState.IsValid)
            {
                db.Entry(train).State = EntityState.Modified;
                db.SaveChanges();
                DisplaySuccessMessage("Has update a Train record");
                return RedirectToAction("TrainIndex");
            }
            DisplayErrorMessage();
            return View(train);
        }

        // GET: Train/TrainDelete/5
        public ActionResult TrainDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Train train = db.Trains.Find(id);
            if (train == null)
            {
                return HttpNotFound();
            }
            return View(train);
        }

        // POST: Train/TrainDelete/5
        [HttpPost, ActionName("TrainDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult TrainDeleteConfirmed(int id)
        {
            Train train = db.Trains.Find(id);
            db.Trains.Remove(train);
            db.SaveChanges();
            DisplaySuccessMessage("Has delete a Train record");
            return RedirectToAction("TrainIndex");
        }

        private void DisplaySuccessMessage(string msgText)
        {
            TempData["SuccessMessage"] = msgText;
        }

        private void DisplayErrorMessage()
        {
            TempData["ErrorMessage"] = "Save changes was unsuccessful.";
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
