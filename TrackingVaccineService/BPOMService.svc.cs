using System;
using System.Linq;

namespace TrackingVaccineService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BPOMService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BPOMService.svc or BPOMService.svc.cs at the Solution Explorer and start debugging.
    public class BPOMService : IBPOMService
    {
        public bool Arrived(int id)
        {
            var entities = new TRACKING_VAKSIN_15Entities();
            // update status
            var query = (from vaccine in entities.Vaccines
                         where vaccine.id == id
                         select vaccine).FirstOrDefault();
            if (query != null)
            {
                query.status = 2;
                entities.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Used(string code, string NIK)
        {
            var entities = new TRACKING_VAKSIN_15Entities();
            // update status vaccine
            var vaccine1 = (from vaccine in entities.Vaccines
                            where vaccine.code == code
                            select vaccine).FirstOrDefault();
            if (vaccine1 == null)
            {
                return false;
            }
            vaccine1.status = 3;
            // update status resident
            var resident1 = (from resident in entities.Residents
                             where resident.NIK == NIK
                             select resident
            ).FirstOrDefault();
            if (resident1 == null)
            {
                return false;
            }
            resident1.status = 0;

            // insert to vaccine usage
            VaccineUsage usage = new VaccineUsage();
            usage.vaccine_id = vaccine1.id;
            usage.resident_id = resident1.NIK;
            usage.used_at = DateTime.Now;
            entities.VaccineUsages.Add(usage);
            entities.SaveChanges();
            return true;
        }

        public bool Verify(int id)
        {
            var entities = new TRACKING_VAKSIN_15Entities();
            // update registered_number and registered_date
            var query = (from vaccine in entities.Vaccines
                         where vaccine.id == id
                         select vaccine).FirstOrDefault();
            if (query != null)
            {
                // make to "RN001"
                query.registered_number = "RN" + query.id.ToString().PadLeft(3, '0');
                query.registered_date = DateTime.Now;
                query.status = 1;
                entities.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
