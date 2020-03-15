using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ParserApp
{
    public static class Parser
    {
        public static IElement DoTask()
        {

            HttpWebRequest reqw =
                (HttpWebRequest)HttpWebRequest.Create(Form1.address);
            HttpWebResponse resp = (HttpWebResponse)reqw.GetResponse(); //создаем объект отклика
            StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.Default);

            var parser = new HtmlParser();
            var document = parser.ParseDocument(resp.GetResponseStream());
            IElement tableElement = document.QuerySelector(".data_container > table > tbody > tr > td > .value > span");
            Console.WriteLine(tableElement.InnerHtml);
            //int count = 0;
            //int totalInfected = 0;
            //int totalDead = 0;
            //int totalRecovered = 0;
            //var rows = tableElement.QuerySelectorAll("tr");
            //foreach (var item in rows)
            //{
            //    if (count != 0 && count != rows.Count() - 1)
            //    {
            //        try
            //        {
            //            if (!item.Children[0].InnerHtml.Contains("Макао"))
            //            {
            //                totalInfected +=
            //                (item.Children[1].InnerHtml != "") ? Int32.Parse(item.Children[1].InnerHtml) : 0;
            //                totalDead +=
            //                    (item.Children[3].InnerHtml != "") ? Int32.Parse(item.Children[3].InnerHtml) : 0;
            //                totalRecovered +=
            //                    (item.Children[4].InnerHtml != "") ? Int32.Parse(item.Children[4].InnerHtml) : 0;
            //            }
            //        }
            //        catch (Exception)
            //        {

            //            // throw;
            //        }
            //        // Console.WriteLine(item.Children[1].InnerHtml);
            //        // Console.WriteLine();
            //    }

            //    count++;
            //}
            //Console.WriteLine(totalInfected);
            //Console.WriteLine(totalDead);
            //Console.WriteLine(totalRecovered);

            //var deadPt = ((double)totalDead / (double)totalInfected) * 100d;
            //var recPt = ((double)totalRecovered / (double)totalInfected) * 100d;
            //Console.WriteLine(deadPt);
            //Console.WriteLine(recPt);


            

            sr.Close();
            return tableElement;
        }
    }
}
