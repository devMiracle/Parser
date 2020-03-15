using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserApp
{
    public partial class Form1 : Form
    {
        public static string address = "https://finance.i.ua/bank/10/";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = address;
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            listBoxParse.Items.Clear();
            IElement element = Parser.DoTask();
            listBoxParse.Items.Add("USD(покупка): " + element.InnerHtml);
        }

        private void listBoxParse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
