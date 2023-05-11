using System.Web.Mvc;

namespace TrackingVaccineClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            AuthenticationService.AuthenticationServiceClient client = new AuthenticationService.AuthenticationServiceClient();
            bool result = client.Login(username, password);
            if (result)
            {
                Session["username"] = username;
                return RedirectToAction("Index", "Procedur");
            }
            else
            {
                ViewBag.Message = "Login failed";
                return View();
            }
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}