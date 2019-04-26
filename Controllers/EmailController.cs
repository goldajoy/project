using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace AirbncleanWeb.Controllers
{
    public class EmailController : BaseController
    {
        internal object SendJobPostimgEmail(long JobId, long UserId, List<long> emailListCleanerId)
        {
            if (emailListCleanerId.Count > 0)
            {
                var content = "";
                var job = _entities.tJobs.Where(z => z.JobId == JobId).FirstOrDefault();
                if (job != null)
                {
                    var user = _entities.tRegistrations.FirstOrDefault(z => z.Id == UserId);
                    if (user != null)
                    {

                        if (job.WorkType == (int)ClassLibrary.Enum.WorkType.MeetORgreet)
                        {
                            content = "A new Meet/Great job has been posted by " + user.FirstName ?? "a user";
                        }
                        else
                        {
                            content = "A new Cleaning job has been posted by " + user.FirstName ?? "a user";
                        }

                        foreach (var id in emailListCleanerId)
                        {
                            var cleaner = _entities.tRegistrations.FirstOrDefault(z => z.Id == id);
                            if (cleaner != null)
                            {
                                try
                                {
                                    var filePath = System.Web.Hosting.HostingEnvironment.MapPath(@"~/EmailTemplate/JobPosting.html");

                                    var emailTemplate = System.IO.File.ReadAllText(filePath);

                                    var mBody = emailTemplate.Replace("{{cleanername}}", cleaner.FirstName).Replace("{{content}}", content);

                                    var result = Send("New Job Posted", mBody, cleaner.FirstName ?? string.Empty, new System.Collections.ArrayList { cleaner.Email });
                                }
                                catch (Exception ex)
                                {

                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        internal static bool Send(string subject, string mailbody, string receiverName, System.Collections.ArrayList list_emails)
        {
            var status = false;

            SmtpClient client = new SmtpClient();
            string userName = "airbnclean2k17@gmail.com";
            string password = "User@123";
            string fromName = "Airbnclean";
            MailAddress address = new MailAddress(userName, fromName);


            foreach (string mailList in list_emails)
            {
                MailMessage message = new MailMessage();
                message.To.Add(new MailAddress(mailList, receiverName));
                //message.To.Add(new MailAddress("premjith.srishti@gmail.com", receiverName));
                message.From = address;
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = mailbody;
                client.Host = "smtp.gmail.com";//ConfigurationManager.AppSettings["smptpserver"];
                client.Port = 587;//Convert.ToInt32(ConfigurationManager.AppSettings["port"]);
                //client.Port = 465;
                client.EnableSsl = true;
                client.UseDefaultCredentials = true;
                //client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential(userName, password);
                try
                {
                    client.Send(message);
                    status = true;
                }
                catch (Exception e)
                {
                    status = false;
                }
            }
            return status;
        }

    }
}
