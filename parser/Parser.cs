using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            //Console.WriteLine(document.DocumentElement.OuterHtml);

            //"h3:has(> span#Распространение_по_странам_и_территориям) + table > tbody"
            IElement tableElement = document.QuerySelector("div #data_container");

            Console.WriteLine(tableElement.QuerySelector("tbody").InnerHtml);










        }
    }
}
