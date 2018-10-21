using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IrrigationAdvisor.ConfirmIrrigationAdvices
{
    class Program
    {
        static void Main(string[] args)
        {
            string environment = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["Status"]);
            string subject = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["subject"]);
            string message = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["message"]);
            string emailTo = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailTo"]);
            short intervalDays = Convert.ToInt16(System.Configuration.ConfigurationManager.AppSettings["IntervalDays"]);

            // Lista de que relaciona el id de farm y fecha dónde falta confirmación.
            var messages = new List<Tuple<long, DateTime>>();

            try
            {
                using (var context = new IrrigationAdvisorEntities())
                {
                    DateTime referenceDate = context.Status.Where(n => n.Name == environment).First().DateOfReference;

                    var activeCropIrrigationWeathers = context.CropIrrigationWeathers
                                                        .Where(n => n.HarvestDate >= referenceDate)
                                                        .Include(n => n.Irrigations)
                                                        .Include(n => n.IrrigationUnit)
                                                       .ToList();

                    var waterInputs = context.WaterInputs
                                      .ToList()
                                      .Where(n => activeCropIrrigationWeathers.Select(p => p.CropIrrigationWeatherId).Contains(n.CropIrrigationWeatherId))
                                      .ToList();

                    var confirmations = context.Irrigations
                                        .Where(n => n.Type == 6)
                                        .Include(n => n.WaterInput)
                                        .ToList();

                    var dailyRecord = context.DailyRecords
                                      .Include(n => n.Irrigation)
                                      .ToList()
                                      .Where(n => activeCropIrrigationWeathers.Select(p => p.CropIrrigationWeatherId).Contains(n.CropIrrigationWeatherId) && n.IrrigationId > 0)                                   
                                      .ToList();

                    var farmContacts = context.FarmContacts.ToList();

                    foreach (var ciw in activeCropIrrigationWeathers)
                    {
                        var dailyRecordForCiw = dailyRecord
                                               .Where(n => n.CropIrrigationWeatherId == ciw.CropIrrigationWeatherId && 
                                                      n.DailyRecordDateTime < referenceDate && 
                                                      n.DailyRecordDateTime > referenceDate.AddDays(-intervalDays) &&
                                                      (n.Irrigation.Type == 2 || n.Irrigation.Type == 3))
                                               .ToList();

                        foreach (var dr in dailyRecordForCiw)
                        {
                            var currentConfirmation = confirmations.Where(n => n.WaterInput.ExtraDate == dr.DailyRecordDateTime).Any();

                            if (!currentConfirmation)
                            {                                                              
                                messages.Add(new Tuple<long, DateTime>(ciw.IrrigationUnit.FarmId, dr.DailyRecordDateTime));                            
                            }
                        }
                    }

                    if (messages.Any())
                    {
                        List<long> farmProcessed = new List<long>();

                        // Recorro los mensajes que no estan procesados.
                        foreach (var m in messages.Where(n => !farmProcessed.Contains(n.Item1)))
                        {
                            var dates = messages.Where(n => n.Item1 == m.Item1).Select(p => p.Item2).Distinct().ToList();

                            var contacts = context.FarmContacts.Where(n => n.FarmId == m.Item1).ToList();

                            string date = string.Empty;

                            foreach (var d in dates)
                            {
                                date += d.ToString("dd/MM/yyyy") + ", ";
                            }

                            if (contacts.Any())
                            {
                                message = message.Replace("[dates]", date);
                                message = message.Replace("[number]", messages.Where(n => n.Item1 == m.Item1).Count().ToString());

                                var contactList = contacts.Select(n => n.Email).ToList();
                                contactList.Add(emailTo);

                                SendEmails(subject,
                                           message,
                                           contactList);
                            }

                            farmProcessed.Add(m.Item1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                SendEmails("Error en servicio de envío de correos de confirmación",
                            ex.Message + "||| " + ex.StackTrace,
                            new List<string>() { emailTo});
            }
        }

        private static MailMessage GetMailMessage(string subject, string body, List<string> pEmailTo)
        {
            MailMessage mail = new MailMessage();
            string emailFrom = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailFrom"]);

            mail.From = new MailAddress(emailFrom);

            foreach(var m in pEmailTo)
            {
                mail.To.Add(m);
            }
          
            mail.Subject = subject;
            body = body.Replace("[br]", "<br>");
            mail.Body = body;
            mail.IsBodyHtml = true;

            return mail;
        }

        private static SmtpClient GetSmtpClient()
        {
            string smtpAddress = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["smtpAddress"]);
            int portNumber = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["smtpPort"]);
            bool enableSSL = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["ssl"]);
            string emailFrom = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailFrom"]);
            string password = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["password"]);

            SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);

            smtp.Credentials = new NetworkCredential(emailFrom, password);
            smtp.EnableSsl = enableSSL;

            return smtp;
        }


        /// <summary>
        /// TODO: Description of SendEmails
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static void SendEmails(string subject, string body, List<string> pEmail)
        {
            try
            {

                SmtpClient smtp = GetSmtpClient();
                MailMessage mail = GetMailMessage(subject, body, pEmail);

                smtp.Send(mail);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
