using Hims.Lib.HimsModels;
using Hims.Lib.Models;
using Hims.Lib.RxModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hims.Lib.ServiceModels
{
 public abstract  class ClaimProcess
    {


        public void LoadClaims()
        {
            using (var rxCtx = new RxDBContext())
            {
                var list = rxCtx.ClaimsDetails.ToList();

                foreach (var claim in list)
                {
                    HimsModels.ClaimsDetail claimsDetail = new HimsModels.ClaimsDetail()
                    {
                     ActionStatus = claim.ActionStatus,
                     ApproveBalance = claim.ApproveBalance,
                     ApprovedQueryStatus = claim.ApprovedQueryStatus,
                     AttendingOfficer = claim.AttendingOfficer,
                     AuditedBy = claim.AuditedBy,
                     AuditStatus = claim.AuditStatus,
                   //  AuditTime = claim.A
                     AuditUpdate = claim.AuditUpdate,
                     AuditUserId = claim.AuditUserId,
                     AuthorizationCode = claim.AuthorizationCode,
                     AuthorizationRequired = claim.AuthorizationRequired,
                     Awarded = claim.Awarded,
                     BatchNo = claim.BatchNo,
                     BookingNo = claim.BookingNo,
                    // ClaimsDetailsId = claim.ClaimsDetailsId,
                     ClaimType = claim.ClaimType,
                     ClaimTypeRe = claim.ClaimTypeRe,
                     Comment = claim.Comment,
                     Company = claim.Company,
                    //CoPaymentAmount = claim.CoPaymentAmount,
                    // CoPaymentPercent = claim.CoPaymentPercent,
                    // CurrencyOriginalRate = claim.CurrencyOriginalRate,
                     CurrencyRateDate = claim.CurrencyRateDate,
                    // CurrencyUsdRate = claim.CurrencyUsdRate,
                     CurrentLocation = claim.CurrentLocation,
                     //DateAdded = claim.D
                     DateAddedShort = claim.DateAddedShort,
                     DateOfActualConsultation = claim.DateOfActualConsultation,
                     DateOfAdmission = claim.DateOfAdmission,
                     DateOfConsultation = claim.DateOfConsultation,
                     DateOfDischarge = claim.DateOfDischarge,
                     DecisionReason = claim.DecisionReason,
                     DecisionReasonOther = claim.DecisionReasonOther,
                     DecisionStatus = claim.DecisionStatus,
                     DelStatus = claim.DelStatus,
                     Diagnosis = claim.Diagnosis,
                     DiagnosisCode = claim.DiagnosisCode,
                    // DiscAmount = claim.DiscAmount,
                    // DiscPercent = claim.DiscPercent,
                   //  DisputedDate = claim.

                     DosageForm = claim.DosageForm,
                     Dose = claim.Dose,
                     EmployerCode = claim.EmployerCode,
                     EmployerId = claim.EmployerId,
                     EyeOptical = claim.EyeOptical,
                     FinanceAuditedBy = claim.FinanceAuditedBy,
                     FinanceAuditStatus = claim.FinanceAuditStatus,
                     //FinanceAuditTime = claim.
                     FinanceAuditUserId = claim.FinanceAuditUserId,
                     FinanceDecisionReason = claim.FinanceDecisionReason,
                     FinanceDecisionReasonOther = claim.FinanceDecisionReasonOther,
                     FinanceDecisionStatus = claim.FinanceDecisionStatus,
                     FinancialStatus = claim.FinancialStatus,
                     Frequency = claim.Frequency,
                     IcdCode = claim.IcdCode,
                     Id = claim.Id,
                     IdInscompany = claim.IdInscompany,
                     InsCompany = claim.InsCompany,
                     InsItemCode = claim.InsItemCode,
                     InvoiceNo = claim.InvoiceNo,
                     IsDisputed = claim.IsDisputed,
                     Item = claim.Item,
                     ItemClass = claim.ItemClass,
                     ItemDaysDiff = claim.ItemDaysDiff,
                     ItemService = claim.ItemService,
                     ItemServiceType = claim.ItemServiceType,
                     MemberNo = claim.MemberNo,
                     NatureOfVisit = claim.NatureOfVisit,
                     NatureofvisitLimit = claim.NatureofvisitLimit,
                     NoOfDays = claim.NoOfDays,
                     PaymentStatus = claim.PaymentStatus,
                     PaymentType = claim.PaymentType,
                     PregnancyExpectedDelivery = claim.PregnancyExpectedDelivery,
                     PregnancyStatus = claim.PregnancyStatus,
                     PregnancyWeeks = claim.PregnancyWeeks,
                     PriceCurrency = claim.PriceCurrency,
                     ProcessClaimNo = claim.ProcessClaimNo,
                     ProviderDataId = claim.ProviderDataId,
                    // ProviderId = claim.ProviderId,
                     ProviderIdDataFor = claim.ProviderIdDataFor,
                     ProviderIdDataForText = claim.ProviderIdDataForText,
                     ProviderIdMaster = claim.ProviderIdMaster,
                     ProviderItemId = claim.ProviderItemId,
                     ProviderName = claim.ProviderName,
                     ProviderNameDataFor = claim.ProviderNameDataFor,
                     ProviderRefNo = claim.ProviderRefNo,
                     //PushTime = claim.Pu
                     Qty = claim.Qty,
                     QtyAwarded = claim.QtyAwarded,
                     QtyFinance = claim.QtyFinance,
                     QueryStatus = claim.QueryStatus,
                     ReferralNo = claim.ReferralNo,
                     ReferToAuditor = claim.ReferToAuditor,
                     RxBrandName = claim.RxBrandName,
                     RxCartegory = claim.RxCartegory,
                     RxItemName = claim.RxItemName,
                     RxMemberId = claim.RxMemberId,
                     RxPrescriptionName = claim.RxPrescriptionName,
                     ServerId = claim.ServerId,
                     ServerPushStatus = claim.ServerPushStatus,
                    // ServerTimeUpdate = claim.S
                     ServiceSpeciality = claim.ServiceSpeciality,
                     SmsSent = claim.SmsSent,
                     Status = claim.Status,
                     SubmittedStatus = claim.SubmittedStatus,
                    // SubmitTime = claim.S
                     Supplied = claim.Supplied,
                     SyncBatchDelete = claim.SyncBatchDelete,
                     SyncBatchNo = claim.SyncBatchNo,
                     SyncBatchNoUpdate = claim.SyncBatchNoUpdate,
                    // SyncDelete = claim.SyncDelete,
                      Toothnos = claim.Toothnos,
                     //TopupAmt = claim.TopupAmt,
                      TotalPrice = claim.TotalPrice,
                      TypeOfVisit = claim.TypeOfVisit,
                     // TopupAmt = claim.TopupAmt,
                      TypeofvisitLimit = claim.TypeofvisitLimit,
                     UnitPrice = claim.UnitPrice,
                     UnitPriceAwarded = claim.UnitPriceAwarded,
                     UnitPriceFinance = claim.UnitPriceFinance,
                     UpdateStatus = claim.UpdateStatus,
                     UserId = claim.UserId,
                     Visittype = claim.Visittype,
                     ValidationKey = claim.ValidationKey,
                     ValidationPin = claim.ValidationPin             
                 
                    };
                        
                  using (var himsCtx = new HimsDBContext())
                    {
                        himsCtx.ClaimsDetails.Add(claimsDetail);
                        himsCtx.SaveChanges();
                    }

                 
                }
            }


        }

        public void process()
        {
            using (var rxCtx = new RxDBContext())
            {
                var rxCLaimsList = rxCtx.ClaimsDetails.ToList();
      
                var currentBatch = new List<RxModels.ClaimsDetail>();
                var batchAmountReceived = 0.0;
                var batchAmountPaid = 0.0;
               //Loop the claim list from himsDB
                foreach (var claim in rxCLaimsList)
                {
                    var currentproviderId = claim.ProviderId;
                    var currentMonth = claim.DateAddedShort?.ToString("MM-yyyy");

                    if (claim.ProviderId == currentproviderId && currentMonth == claim.DateAddedShort?.ToString("MM-yyyy"))
                    {
                        // Addition of Amounts

                        batchAmountReceived = (double)(batchAmountReceived + claim.TotalPrice);
                        batchAmountPaid = (double)(batchAmountPaid + claim.TotalPrice);

                        // Create Batch

                        using (var ctx = new HimsDBContext())
                        {
                            Batch addBatch = new Batch()
                            {
                                BatchDate = DateTime.Now,
                                ClaimType = claim.ClaimType,
                                // get Month from Date
                                ClaimMonth = (DateTime)claim.DateAddedShort,
                                //Remarks = claim.Rema
                                ProviderId = claim.ProviderId,
                                // ClientId = claim.
                                //BookNo = claim.BookingNo,
                                AmountReceived = (decimal)batchAmountReceived,
                                AmountPaid = (decimal?)batchAmountPaid

                            };

                            ctx.Batches.Add(addBatch);
                            ctx.SaveChanges();

                            var currentBatchId = addBatch.BatchId;

                            // Create batch for a particular Provider by Month

                           currentBatch.Add(claim);

                        foreach (var currentBatchClaim in currentBatch)
                            {
                                var currentProcessClaimNo = currentBatchClaim.ProcessClaimNo;

                                // check if it's the same claim

                                if (currentProcessClaimNo == currentBatchClaim.ProcessClaimNo)
                                {

                                    // Save claim in HIMS DB
                                    Claim addCLaim = new Claim()
                                    {
                                        BatchId = currentBatchId,
                                        ServiceDate = (DateTime)currentBatchClaim.DateAddedShort,
                                        MemberId = (int)getMemberIdByPolicyNo(currentBatchClaim.MemberNo),
                                        ClientBenefits = (int?)getProductItemIdByName(currentBatchClaim.TypeOfVisit),
                                        DetentionDate = currentBatchClaim.DateOfAdmission,
                                        AdmissionDate = currentBatchClaim.DateOfActualConsultation,
                                        DismissialDate = currentBatchClaim.DateOfDischarge,
                                        InvoiceNo = currentBatchClaim.InvoiceNo,
                                        Physician = currentBatchClaim.AttendingOfficer,
                                      //  ProductId = currentBatchClaim.Bene
                                    };


                                   ctx.Claims.Add(addCLaim);
                                    ctx.SaveChanges();
                                }
                            }

                        }
                    

                        
                    }
                }
            }


        }



        public long getMemberIdByPolicyNo(string policyNo)
        {
            long memberId = 0 ;

            using(var context = new HimsDBContext())
            {
                try
                {
                    var member = context.Members.Where(a => a.PolicyNo.Equals(policyNo)).SingleOrDefault();

                    memberId = member.MemberId;
                }
                catch(Exception)
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
