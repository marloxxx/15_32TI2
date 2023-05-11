using System.Collections.Generic;
using System.Linq;

namespace TrackingVaccineService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProcedurService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProcedurService.svc or ProcedurService.svc.cs at the Solution Explorer and start debugging.
    public class ProcedurService : IProcedurService
    {

        public List<Vaccine> GetVaccines()
        {
            var entities = new TRACKING_VAKSIN_15Entities();
            var query = (from vaccine in entities.Vaccines
                         select vaccine).ToList();
            return query;
        }

        public bool create(Vaccine vaccine)
        {
            var entities = new TRACKING_VAKSIN_15Entities();
            entities.Vaccines.Add(vaccine);
            entities.SaveChanges();
            return true;
        }

        public bool delete(string code)
        {
            var entities = new TRACKING_VAKSIN_15Entities();
            var query = (from vaccine in entities.Vaccines
                         where vaccine.code == code
                         select vaccine).FirstOrDefault();
            if (query != null)
            {
                entities.Vaccines.Remove(query);
                entities.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool update(Vaccine vaccine)
        {
            var entities = new TRACKING_VAKSIN_15Entities();
            var query = (from v in entities.Vaccines
                         where v.id == vaccine.id
                         select v).FirstOrDefault();
            if (query != null)
            {
                query.code = vaccine.code;
                entities.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
