using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AngleSharp;
using AngleSharp.Dom;
using System.IO;
using System.Net;
using AngleSharp.Html.Parser;

namespace parser
{
    public static class Parser
    {
        

        public async static void Read()
        {
            HttpWebRequest reqw = (HttpWebRequest)HttpWebRequest.Create("https://finance.i.ua/bank/10/");
            HttpWebResponse resp = (HttpWebResponse)reqw.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.Default);

            var parser = new HtmlParser();
            var document = parser.ParseDocument(resp.GetResponseStream());
            Console.WriteLine(document.DocumentElement.OuterHtml);











        }
    }
}
