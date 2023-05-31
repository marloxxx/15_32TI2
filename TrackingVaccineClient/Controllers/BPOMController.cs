using System.Web.Mvc;

namespace TrackingVaccineClient.Controllers
{
    public class BPOMController : Controller
    {
        // GET: BPOM
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult validate(string NIK)
        {
            GovermentService.GovermentServiceClient client = new GovermentService.GovermentServiceClient();
            bool result = client.validate(NIK);
            if (result)
            {
                Session["success"] = "NIK valid";
            }
            else
            {
                Session["error"] = "NIK tidak valid";
            }
            return RedirectToAction("Index", "BPOM");
        }
    }
}