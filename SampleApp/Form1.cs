using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Fitbit.Api;

namespace SampleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WyGood.StepOut.Class1.DoFacebook();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Example of getting the Auth credentials for the first time by directoring the
            //user to the fitbit site to get a PIN. 
            var consumerKey = "b3d888281c9b4e098c26c6d1ce4e9d57";
            var consumerSecret = "dc6f84c589c341789967b57e83084572";
            var requestTokenUrl = "http://api.fitbit.com/oauth/request_token";
            var accessTokenUrl = "http://api.fitbit.com/oauth/access_token";
            var authorizeUrl = "http://www.fitbit.com/oauth/authorize";

            var a = new Authenticator(consumerKey, consumerSecret, requestTokenUrl, accessTokenUrl, authorizeUrl);
            var url = a.GetAuthUrlToken();

            System.Diagnostics.Process.Start(url);

            Console.WriteLine("Enter the verification code from the website");
            var pin = verificationCodeTextBox.Text;

            var credentials = a.GetAuthCredentialFromPin(pin);


            //If you already have your credentials stored then rather than getting the users PIN again
            //you could just start here
            var fitbit = new FitbitClient(consumerKey, consumerSecret, credentials.AuthToken, credentials.AuthTokenSecret);
            var profile = fitbit.GetUserProfile();
            Console.WriteLine("Your last weight was {0}", profile.Weight);

            Console.ReadLine();

        }
    }
}
