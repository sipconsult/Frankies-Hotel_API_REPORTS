using SIP_NightAudit_Service.Service.HimsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP_NightAudit_Service.Service.ServiceModels
{
  public  class ServiceHelper
    {
        HimsDBContext _himsDBContext;

        public ServiceHelper(HimsDBContext himsDBContext)
        {
            _himsDBContext = himsDBContext;
        }



        public Member getMemberByPocilyNo(String policyNo)

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


        public long getMemberIdByPolicyNo(string policyNo)
        {
            long memberId = 0;

            using (var context = new HimsDBContext())
            {
                try
                {
                    var member = context.Members.Where(a => a.PolicyNo.Equals(policyNo)).SingleOrDefault();

                    memberId = member.MemberId;
                }
                catch (Exception)
                {

                }

            }

            return memberId;
        }


        public long getProductItemIdByName(string name)
        {
            long memberId = 0;

            using (var context = new HimsDBContext())
            {
                try
                {
                    var product = context.ProductItems.Where(a => a.Name.Equals(name)).SingleOrDefault();

                    memberId = product.Id;
                }
                catch (Exception)
                {

                }

            }

            return memberId;
        }
    }
}
