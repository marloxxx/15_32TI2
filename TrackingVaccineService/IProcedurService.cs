﻿using System.Collections.Generic;
using System.ServiceModel;

namespace TrackingVaccineService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProcedurService" in both code and config file together.
    [ServiceContract]
    public interface IProcedurService
    {
        [OperationContract]
        List<Vaccine> GetVaccines();
        [OperationContract]
        Vaccine GetVaccine(int id);
        [OperationContract]
        bool create(Vaccine vaccine);
        [OperationContract]
        bool update(Vaccine vaccine);
        [OperationContract]
        bool delete(int id);
        [OperationContract]
        bool send(int id);
    }
}
