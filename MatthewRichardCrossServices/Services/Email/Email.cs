using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using MatthewRichardCrossServices.Helpers;

namespace MatthewRichardCrossServices.Services.Email
{
    public class Email
    {
        public static void SendEmail(String fromAddress, String toAddress, 
            String subject, String text)
        {
            RestClient client = new RestClient(Globals.MailGun_API_URL);

            client.Authenticator = new HttpBasicAuthenticator("api", Globals.MailGun_API_Key);

            RestRequest request = new RestRequest(Globals.MailGun_Domain_Name + "/messages", Method.POST);

            request.AddParameter("from", fromAddress);
            request.AddParameter("to", toAddress);
            request.AddParameter("subject", subject);
            request.AddParameter("text", text);
            
            client.Execute(request);

        }
    }
}
