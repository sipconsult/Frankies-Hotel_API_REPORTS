using Hims.Lib.HimsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hims.Lib.ServiceModels
{
  public  class ServiceHelper
    {
        HimsDBContext _himsDBContext;
        public ServiceHelper(HimsDBContext himsDBContext)
        {
            _himsDBContext = himsDBContext;
        }



        public  Member getmemberIdByPocilyNo(String policyNo)

        {
            var member = _himsDBContext.Members.Where(a => a.PolicyNo.Equals(policyNo)).SingleOrDefault();

            return member;
        }

        public Diagnosis getDIagnisisByCode(String code)

        {
            var diagnosis = _himsDBContext.Diagnoses.Where(a => a.DiagnosisCode.Equals(code)).SingleOrDefault();

            return diagnosis;
        }

        public Treatment getTreatementByCode(String code)

        {
            var treatement = _himsDBContext.Treatments.Where(a => a.Code.Equals(code)).SingleOrDefault();

            return treatement;
        }
    }
}
