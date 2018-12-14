using HtmlAgilityPack;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Cloudrip
{
    public static class HTTPClient
    {
        private static CookieContainer cookieCon = new CookieContainer();



        public static string SendGET(string url)
        {
            string output = "";

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.CookieContainer = cookieCon;
                var response = (HttpWebResponse)request.GetResponse();
                output = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch { }

            return output;
        }
        public static string SendPOST(string url, Dictionary<string, string> param)
        {
            string output = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            string postData = "";
            bool first = true;

            foreach (string key in param.Keys)
            {
                if (!first)
                {
                    postData += "&";
                }
                else
                {

                    first = false;
                }
                postData += key + "=" + param[key];
            }

            byte[] data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.CookieContainer = cookieCon;
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            output = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return output;
        }

        public static HtmlNodeCollection GetElementsByTag(string html, string tag)
        {
            HtmlDocument doc = CreateHtmlDoc(html);

            return doc.DocumentNode.SelectNodes("//" + tag);
        }

        public static HtmlNodeCollection GetElementsByClassInName(string html, string className, string tag = "*")
        {
            HtmlDocument doc = CreateHtmlDoc(html);

            return doc.DocumentNode.SelectNodes("//" + tag + "[contains(@class, 's')]");
        }
        public static HtmlNodeCollection GetElementsByClass(string html, string className, string tag = "*")
        {
            HtmlDocument doc = CreateHtmlDoc(html);

            return doc.DocumentNode.SelectNodes("//" + tag + "[@class='" + className + "']");
        }

        private static HtmlDocument CreateHtmlDoc(string html)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            return doc;
        }
    }
}
