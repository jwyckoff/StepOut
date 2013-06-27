using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyGood.StepOut.FitBit
{
    public class Constants
    {
        private Constants() { }

        public static string ApplicationName
        {
            get
            {
                return "JasonTest";
            }
        }

        public static string ConsumerKey
        {
            get
            {
                return "b3d888281c9b4e098c26c6d1ce4e9d57";
            }
        }

        public static string ConsumerSecret 
        {
            get
            {
                return "dc6f84c589c341789967b57e83084572";
            }
        }

        public static string RequestTokenUrl
        {
            get
            {
                return "http://api.fitbit.com/oauth/request_token";
            }
        }

        public static string AccessTokenUrl
        {
            get
            {
                return "http://api.fitbit.com/oauth/access_token";
            }
        }
        public static string AuthorizeUrl
        {
            get
            {
                return "http://www.fitbit.com/oauth/authorize";
            }
        }



    }
}
