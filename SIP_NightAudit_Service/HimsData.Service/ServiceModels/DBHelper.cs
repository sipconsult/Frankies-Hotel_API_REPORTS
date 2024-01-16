using SIP_NightAudit_Service.Service.RxModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP_NightAudit_Service.Service.ServiceModels
{
   public class DBHelper
    {
        private RxDBContext rxDBContext;

        private DbContextOptions<RxDBContext> GetAllRxOptions()
        {
            var optionBuilder = new DbContextOptionsBuilder<RxDBContext>();

            optionBuilder.UseMySQL("server=127.0.0.1; port=3306; database=rxclaim_insurance; user id=root; password=; Persist Security Info=False;Convert Zero Datetime=True; Connect Timeout=300");

            return optionBuilder.Options;
        }

    }
}
