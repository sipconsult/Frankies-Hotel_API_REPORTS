using SIP_NightAudit_Service.Service.ServiceModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace SIP_NightAudit_Service.Service
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<AuditProcess> _logger;

        private IConfiguration _iConfiguration;




        public Worker(ILogger<AuditProcess> logger,
                       IConfiguration configuration)
        {
            _logger = logger;
            _iConfiguration = configuration;

        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            //var tt = $"The service has started at: {DateTimeOffset.Now}";

            //SendEmail("Sales, Wins, Cancellation push service Notification", tt);

            _logger.LogInformation("The service has started at: {time}", DateTimeOffset.Now);
            return base.StartAsync(cancellationToken);
        }



        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                AuditProcess auditProcess = new AuditProcess(_logger);
                auditProcess.TimeChecker();
                //auditProcess.LoadServices();

                //Hims Setup Service
                //claimProcess.LoadClients();

                ////Hims Support Service
                //claimProcess.LoadProviderPrescription();
                //claimProcess.LoadClaimComments();
                //claimProcess.CheckClaimStatus();

                //claimProcess.LoadQueryDiagnosis();
                //claimProcess.LoadDiagnosis();
                //claimProcess.LoadTreatments();
                //claimProcess.LoadMembers();
                //claimProcess.LoadProviders();
                //claimProcess.LoadProducts();





                //Hims  Service

                //claimProcess.LoadClaims();
                //claimProcess.LoadRxPayments();


                int delayTime = _iConfiguration.GetValue<int>("Parameters:DelayTime");

                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(delayTime, stoppingToken);
            }
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {

            //var tt = $"The service has stopped at: {DateTimeOffset.Now}";

            //SendEmail("Sales, Wins, Cancellation push service Notification", tt);

            _logger.LogInformation("The service has stopped at: {time}", DateTimeOffset.Now);
            return base.StopAsync(cancellationToken);
        }


        public void SendEmail(string subject, string message)
        {


            var smtpServerAdress = _iConfiguration.GetValue<string>("SmtpConfiguration:EmailSmtp");
            var smtpPort = _iConfiguration.GetValue<int>("SmtpConfiguration:EmailPort");
            var smtpPassword = _iConfiguration.GetValue<string>("SmtpConfiguration:PwdEmail");
            var smtpUsername = _iConfiguration.GetValue<string>("SmtpConfiguration:EmailAddress");
            var monitorEmail = _iConfiguration.GetValue<string>("SmtpConfiguration:MonitorMail");
            var sEnableSsl = _iConfiguration.GetValue<bool>("SmtpConfiguration:EnableSsl");


            var to = new List<string>();

            to = monitorEmail.Split(new char[] { ';', ',' }).ToList();



            if (string.IsNullOrWhiteSpace(subject))
            {
                subject = "Sales, Wins, Cancellation push service Notification";
            }
            if (string.IsNullOrWhiteSpace(message))
            {
                message = $"{subject} Kindly check the server.";
            }
            using (var smtpCleint = new SmtpClient(smtpServerAdress, smtpPort))
            {
                smtpCleint.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtpCleint.UseDefaultCredentials = false;
                smtpCleint.Credentials =
                    (System.Net.ICredentialsByHost)new System.Net.NetworkCredential(smtpUsername, smtpPassword);
                smtpCleint.EnableSsl = sEnableSsl;
                var mailmessage = new MailMessage();
                mailmessage.Body = message;
                mailmessage.Subject = subject;
                mailmessage.IsBodyHtml = false;
                mailmessage.From = new MailAddress(smtpUsername);
                foreach (var item in to)
                {
                    mailmessage.To.Add(item);
                }
                smtpCleint.Send(mailmessage);
            }
        }
    }
}
