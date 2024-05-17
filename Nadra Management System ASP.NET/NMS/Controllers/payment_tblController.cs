using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NMS.abstractFActory;
using NMS.Models;
using NMS.brige_Method;



namespace NMS.Controllers
{
    public class payment_tblController : Controller
    {
        private NadraDbContext db = new NadraDbContext();

        // GET: payment_tbl
        public ActionResult Index()
        {
            var payment_tbl = db.payment_tbl.Include(p => p.account_tbl).Include(p => p.cnic_info_tbl);
            return View(payment_tbl.ToList());
        }

        // GET: payment_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            payment_tbl payment_tbl = db.payment_tbl.Find(id);
            if (payment_tbl == null)
            {
                return HttpNotFound();
            }
            return View(payment_tbl);
        }

        // GET: payment_tbl/Create
        public ActionResult Create()
        {


            Payment oder = new CardPayment();
            oder._IPaymentSystem = new HBL_Payment_System();
            oder.MakePayment();

            oder._IPaymentSystem = new ALhahbi_payment_system();
            oder.MakePayment();


            Console.ReadKey();
            ViewBag.Account_id = new SelectList(db.account_tbl, "account_id", "accound_No");
            ViewBag.cnic_id = new SelectList(db.cnic_info_tbl, "cnic_id", "cnic_no");
            return View();
        }

        // POST: payment_tbl/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Payment_id,charges,payment_type,Account_id,cnic_id")] payment_tbl payment_tbl)
        {
            if (ModelState.IsValid)
            {
                //IPaymentFactory Factory = new PaymentSystemFactory().create(payment_tbl);
                //PaymentSystem ps = new PaymentSystem(Factory);
                //payment_tbl.payment_type = ps.GetPaymentdetails();
                db.payment_tbl.Add(payment_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Account_id = new SelectList(db.account_tbl, "account_id", "accound_No", payment_tbl.Account_id);
            ViewBag.cnic_id = new SelectList(db.cnic_info_tbl, "cnic_id", "cnic_no", payment_tbl.cnic_id);
            return View(payment_tbl);
        }

        // GET: payment_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            payment_tbl payment_tbl = db.payment_tbl.Find(id);
            if (payment_tbl == null)
            {
                return HttpNotFound();
            }
            ViewBag.Account_id = new SelectList(db.account_tbl, "account_id", "accound_No", payment_tbl.Account_id);
            ViewBag.cnic_id = new SelectList(db.cnic_info_tbl, "cnic_id", "cnic_no", payment_tbl.cnic_id);
            return View(payment_tbl);
        }

        // POST: payment_tbl/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Payment_id,charges,payment_type,Account_id,cnic_id")] payment_tbl payment_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(payment_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Account_id = new SelectList(db.account_tbl, "account_id", "accound_No", payment_tbl.Account_id);
            ViewBag.cnic_id = new SelectList(db.cnic_info_tbl, "cnic_id", "cnic_no", payment_tbl.cnic_id);
            return View(payment_tbl);
        }

        // GET: payment_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            payment_tbl payment_tbl = db.payment_tbl.Find(id);
            if (payment_tbl == null)
            {
                return HttpNotFound();
            }
            return View(payment_tbl);
        }

        // POST: payment_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            payment_tbl payment_tbl = db.payment_tbl.Find(id);
            db.payment_tbl.Remove(payment_tbl);
            db.SaveChanges();
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
