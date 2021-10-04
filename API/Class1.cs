using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord.Webhook
{
    public class Webhook
    {
        
        





        public void SendMessage(string webhook, string message, string profilepictureurl, string Username)
        {



         NameValueCollection discordValues = new NameValueCollection();
        WebClient dWebClient = new WebClient();
            discordValues.Add("username", Username);
            discordValues.Add("avatar_url", profilepictureurl);
            discordValues.Add("content", message);

            dWebClient.UploadValues(webhook, discordValues);



        }
    }
}
