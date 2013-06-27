using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;

namespace WyGood.StepOut
{
    public class Class1
    {

        public static void DoFacebook()
        {

            FacebookClient facebookClient = new FacebookClient();
            dynamic result = facebookClient.Get("oauth/access_token", new 
            {
                client_id = "537452296325126",
                client_secret = "aa2ce963862cc139e64c1339f28bdfdd",
                grant_type = "client_credentials"
            });



            dynamic me = facebookClient.Get("me");
            var id = me.id;
            var name = me.name;
        }

    }
}
