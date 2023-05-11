using System.Web.Mvc;
using TrackingVaccineClient.ProcedurService;

namespace TrackingVaccineClient.Controllers
{
    public class ProcedurController : Controller
    {
        // GET: Procedur
        public ActionResult Index()
        {
            ProcedurServiceClient procedurService = new ProcedurServiceClient();
            var vaccines = procedurService.GetVaccines();
            return View(vaccines);
        }

        // GET: Procedur/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Procedur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Procedur/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                ProcedurServiceClient procedurService = new ProcedurServiceClient();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Procedur/Edit/5
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: Procedur/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Procedur/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: Procedur/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
