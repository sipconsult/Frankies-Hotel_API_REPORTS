using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HIMSDATA.Models;

namespace HIMSDATA.Controllers
{
    public class ClaimsDetailsController : Controller
    {
        private readonly MariaDBContext _context;

        public ClaimsDetailsController(MariaDBContext context)
        {
            _context = context;
        }

        // GET: ClaimsDetails
        public async Task<IActionResult> Index()
        {
           var CountItems =  _context.Companies.ToList().Count();

            var list = await _context.ClaimsDetails.ToListAsync();
            return View(list);
        }

        // GET: ClaimsDetails/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claimsDetail = await _context.ClaimsDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (claimsDetail == null)
            {
                return NotFound();
            }

            return View(claimsDetail);
        }

        // GET: ClaimsDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClaimsDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ServerId,ReferralNo,UpdateStatus,IdInscompany,SyncBatchNo,SyncBatchNoUpdate,SyncBatchDelete,SyncInsert,SyncUpdate,SyncDelete,PriceCurrency,CurrencyRateDate,CurrencyUsdRate,CurrencyOriginalRate,ClaimsDetailsId,InvoiceNo,ClaimTypeRe,DiscPercent,DiscAmount,CoPaymentPercent,CoPaymentAmount,NatureofvisitLimit,TypeofvisitLimit,Visittype,ServiceSpeciality,IsDisputed,UpdateDeleteStatus,Company,AuditUpdate,ProviderDataId,InsCompany,ProviderId,MemberNo,ProviderName,ProviderIdMaster,EmployerId,EmployerCode,UserId,ProcessClaimNo,ProviderRefNo,AttendingOfficer,Diagnosis,DiagnosisCode,IcdCode,EyeOptical,Toothnos,TypeOfVisit,NatureOfVisit,DateOfConsultation,DateOfActualConsultation,DateOfAdmission,DateOfDischarge,ProviderItemId,InsItemCode,AuthorizationRequired,AuthorizationCode,Item,ItemService,ItemServiceType,ItemClass,ItemDaysDiff,Qty,UnitPrice,TotalPrice,QtyAwarded,UnitPriceAwarded,QtyFinance,UnitPriceFinance,DateAddedShort,Dose,DosageForm,Frequency,NoOfDays,Status,Awarded,Comment,CurrentLocation,ActionStatus,Supplied,ValidationKey,ValidationPin,ServerPushStatus,SubmittedStatus,RxMemberId,SmsSent,PaymentStatus,ApprovedQueryStatus,QueryStatus,DelStatus,ProviderIdDataFor,ProviderIdDataForText,DecisionStatus,DecisionReason,DecisionReasonOther,AuditStatus,RxItemName,RxBrandName,RxCartegory,RxPrescriptionName,FinanceAuditStatus,AuditUserId,AuditedBy,PaymentType,PregnancyStatus,PregnancyWeeks,PregnancyExpectedDelivery,FinanceDecisionStatus,FinanceDecisionReason,FinanceDecisionReasonOther,FinancialStatus,ProviderNameDataFor,ReferToAuditor,ClaimType,TopupAmt,ApproveBalance,BatchNo,FinanceAuditUserId,FinanceAuditedBy,SyncInsertCounts,SyncUpdateCounts,BookingNo")] ClaimsDetail claimsDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(claimsDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(claimsDetail);
        }

        // GET: ClaimsDetails/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claimsDetail = await _context.ClaimsDetails.FindAsync(id);
            if (claimsDetail == null)
            {
                return NotFound();
            }
            return View(claimsDetail);
        }

        // POST: ClaimsDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,ServerId,ReferralNo,UpdateStatus,IdInscompany,SyncBatchNo,SyncBatchNoUpdate,SyncBatchDelete,SyncInsert,SyncUpdate,SyncDelete,PriceCurrency,CurrencyRateDate,CurrencyUsdRate,CurrencyOriginalRate,ClaimsDetailsId,InvoiceNo,ClaimTypeRe,DiscPercent,DiscAmount,CoPaymentPercent,CoPaymentAmount,NatureofvisitLimit,TypeofvisitLimit,Visittype,ServiceSpeciality,IsDisputed,UpdateDeleteStatus,Company,AuditUpdate,ProviderDataId,InsCompany,ProviderId,MemberNo,ProviderName,ProviderIdMaster,EmployerId,EmployerCode,UserId,ProcessClaimNo,ProviderRefNo,AttendingOfficer,Diagnosis,DiagnosisCode,IcdCode,EyeOptical,Toothnos,TypeOfVisit,NatureOfVisit,DateOfConsultation,DateOfActualConsultation,DateOfAdmission,DateOfDischarge,ProviderItemId,InsItemCode,AuthorizationRequired,AuthorizationCode,Item,ItemService,ItemServiceType,ItemClass,ItemDaysDiff,Qty,UnitPrice,TotalPrice,QtyAwarded,UnitPriceAwarded,QtyFinance,UnitPriceFinance,DateAddedShort,Dose,DosageForm,Frequency,NoOfDays,Status,Awarded,Comment,CurrentLocation,ActionStatus,Supplied,ValidationKey,ValidationPin,ServerPushStatus,SubmittedStatus,RxMemberId,SmsSent,PaymentStatus,ApprovedQueryStatus,QueryStatus,DelStatus,ProviderIdDataFor,ProviderIdDataForText,DecisionStatus,DecisionReason,DecisionReasonOther,AuditStatus,RxItemName,RxBrandName,RxCartegory,RxPrescriptionName,FinanceAuditStatus,AuditUserId,AuditedBy,PaymentType,PregnancyStatus,PregnancyWeeks,PregnancyExpectedDelivery,FinanceDecisionStatus,FinanceDecisionReason,FinanceDecisionReasonOther,FinancialStatus,ProviderNameDataFor,ReferToAuditor,ClaimType,TopupAmt,ApproveBalance,BatchNo,FinanceAuditUserId,FinanceAuditedBy,SyncInsertCounts,SyncUpdateCounts,BookingNo")] ClaimsDetail claimsDetail)
        {
            if (id != claimsDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(claimsDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClaimsDetailExists(claimsDetail.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(claimsDetail);
        }

        // GET: ClaimsDetails/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var claimsDetail = await _context.ClaimsDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (claimsDetail == null)
            {
                return NotFound();
            }

            return View(claimsDetail);
        }

        // POST: ClaimsDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var claimsDetail = await _context.ClaimsDetails.FindAsync(id);
            _context.ClaimsDetails.Remove(claimsDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClaimsDetailExists(long id)
        {
            return _context.ClaimsDetails.Any(e => e.Id == id);
        }
    }
}
