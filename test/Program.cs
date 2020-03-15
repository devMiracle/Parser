
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Read();
        }
        public async static void Read()
        {
            HttpWebRequest reqw =
                (HttpWebRequest)HttpWebRequest.Create("https://ru.wikipedia.org/wiki/%D0%92%D1%81%D0%BF%D1%8B%D1%88%D0%BA%D0%B0_COVID-19");
            HttpWebResponse resp = (HttpWebResponse)reqw.GetResponse(); //создаем объект отклика
            StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.Default);

            var parser = new HtmlParser();
            var document = parser.ParseDocument(resp.GetResponseStream());
            //Console.WriteLine(document.DocumentElement.OuterHtml);
            IElement tableElement =
                document.QuerySelector("h3:has(> span#Распространение_по_странам_и_территориям) + table > tbody");
            Console.WriteLine(tableElement.QuerySelector("tbody").InnerHtml);









        }
    }
}
