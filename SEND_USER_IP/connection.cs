using System.Collections.Specialized;
using System.Net;

namespace SEND_USER_IP
{
    internal class connection
    {
        public static byte[] post(string uri, NameValueCollection pair)
        {
            using (WebClient wc = new WebClient())
            {
                return wc.UploadValues(uri, pair);
            }
        }
    }
}