using System.Web.Mvc;
using TrackingVaccineClient.Models;
using TrackingVaccineClient.ProcedurService;
using TrackingVaccineService;

namespace TrackingVaccineClient.Controllers
{
    public class ProcedurController : Controller
    {
        // GET: Procedur
        public ActionResult Index(Session session)
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
        public ActionResult Create(Vaccine vaccine)
        {
            if (string.IsNullOrEmpty(vaccine.code))
            {
                ModelState.AddModelError("code", "Code tidak boleh kosong");
            }
            if (ModelState.IsValid)
            {
                ProcedurServiceClient procedurService = new ProcedurServiceClient();
                procedurService.create(vaccine);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Procedur/Edit/5
        public ActionResult Edit(string id)
        {
            ProcedurServiceClient procedurService = new ProcedurServiceClient();
            var vaccine = procedurService.GetVaccine(int.Parse(id));
            return View(vaccine);
        }

        // POST: Procedur/Edit/5
        [HttpPost]
        public ActionResult Edit(Vaccine vaccine)
        {
            if (string.IsNullOrEmpty(vaccine.code))
            {
                ModelState.AddModelError("code", "Code tidak boleh kosong");
            }
            if (ModelState.IsValid)
            {
                ProcedurServiceClient procedurService = new ProcedurServiceClient();
                procedurService.update(vaccine);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        public ActionResult Delete(string id)
        {
            ProcedurServiceClient procedurService = new ProcedurServiceClient();
            procedurService.delete(int.Parse(id));
            return RedirectToAction("Index");
        }
    }
}
