using System.Web.Mvc;
using System.Web.Security;
using TrackingVaccineClient.AuthenticationService;
using TrackingVaccineService;

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
        public ActionResult Login(User user)
        {
            if (string.IsNullOrEmpty(user.username))
            {
                ModelState.AddModelError("username", "Username tidak boleh kosong");
            }
            if (string.IsNullOrEmpty(user.password))
            {
                ModelState.AddModelError("password", "Password tidak boleh kosong");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            AuthenticationServiceClient client = new AuthenticationService.AuthenticationServiceClient();
            bool result = client.Login(user.username, user.password);
            if (result)
            {
                FormsAuthentication.SetAuthCookie(user.username, false);
                User newUser = client.GetUser(user.username);
                // set session
                Session["username"] = newUser.username;
                Session["success"] = "Login berhasil";
                if (newUser.role == "produsen")
                {
                    return RedirectToAction("Index", "Procedur");
                }
                if (newUser.role == "bpom")
                {
                    return RedirectToAction("Index", "BPOM");
                }
                if (newUser.role == "rumahsakit")
                {
                    return RedirectToAction("Index", "Hospital");
                }
                if (newUser.role == "pemerintah")
                {
                    return RedirectToAction("Index", "Government");
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("login", "Username atau password salah");
                return View();
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(FormCollection formCollection)
        {
            string username = formCollection["username"];
            string password = formCollection["password"];
            string NIK = formCollection["NIK"];
            string name = formCollection["name"];
            int age = int.Parse(formCollection["age"]);
            string address = formCollection["address"];
            string gender = formCollection["gender"];
            if (string.IsNullOrEmpty(username))
            {
                ModelState.AddModelError("username", "Username tidak boleh kosong");
            }
            if (string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError("password", "Password tidak boleh kosong");
            }
            if (string.IsNullOrEmpty(NIK))
            {
                ModelState.AddModelError("NIK", "NIK tidak boleh kosong");
            }
            if (string.IsNullOrEmpty(name))
            {
                ModelState.AddModelError("name", "Nama tidak boleh kosong");
            }
            if (age < 0)
            {
                ModelState.AddModelError("age", "Umur tidak boleh kosong");
            }
            if (string.IsNullOrEmpty(address))
            {
                ModelState.AddModelError("address", "Alamat tidak boleh kosong");
            }
            if (string.IsNullOrEmpty(gender))
            {
                ModelState.AddModelError("gender", "Jenis Kelamin tidak boleh kosong");
            }
            // Contoh pengembalian tampilan jika validasi tidak berhasil
            if (!ModelState.IsValid)
            {
                return View();
            }

            AuthenticationServiceClient client = new AuthenticationServiceClient();
            try
            {
                client.Register(username, password, NIK, name, age, address, gender);
                Session["success"] = "Registrasi berhasil";
                return RedirectToAction("Login", "Home");
            }
            catch (System.Exception)
            {
                return View();
            }

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