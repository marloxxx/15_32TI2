using System.Linq;

namespace TrackingVaccineService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthenticationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthenticationService.svc or AuthenticationService.svc.cs at the Solution Explorer and start debugging.
    public class AuthenticationService : IAuthenticationService
    {
        public bool Login(string username, string password)
        {
            var entities = new TRACKING_VAKSIN_15Entities();
            var query = (from user in entities.Users
                         where user.username == username && user.password == password
                         select user).FirstOrDefault();
            if (query != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Register(string username, string password, string NIK, string name, int age, string address, string gender)
        {
            var entities = new TRACKING_VAKSIN_15Entities();
            var query = (from user in entities.Users
                         where user.username == username
                         select user).FirstOrDefault();
            if (query != null)
            {
                return false;
            }

            User newUser = new User();
            newUser.username = username;
            newUser.password = password;
            newUser.role = "user";
            // save
            entities.Users.Add(newUser);
            entities.SaveChanges();

            Resident resident = new Resident();
            resident.NIK = NIK;
            resident.name = name;
            resident.age = age;
            resident.address = address;
            resident.gender = gender;
            // save
            entities.Residents.Add(resident);
            entities.SaveChanges();

            return true;
        }

    }

}
