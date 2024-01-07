using MintaZH2.Entities;
using MintaZH2.Osztályok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MintaZH2
{
    public partial class Form1 : Form
    {
        List<Product> _products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            GetProducts();
            DisplayProduct();
        }

        private void DisplayProduct()
        {
            var topPosition = 0;
            var sortedProducts = from p in _products
                                 orderby p.Title
                                 select p;
            foreach (var item in sortedProducts)
            {
                item.Left = 0;
                item.Top = topPosition;
                Controls.Add(item);
                topPosition += item.Height;
            }
        }

        private void GetProducts()
        {
            var xml = new XmlDocument();
            xml.LoadXml(GetXML("Menu.xml"));

            foreach (XmlElement element in xml.DocumentElement)
            {
                var name = element.SelectSingleNode("name").InnerText;
                var calories = element.SelectSingleNode("calories").InnerText;
                var description = element.SelectSingleNode("description").InnerText;
                var type = element.SelectSingleNode("type").InnerText;

                if (type == "food")
                {
                    var p = new Food()
                    {
                        Title = name,
                        Calories = int.Parse(calories),
                        Description = description
                    };
                    _products.Add(p);
                }
                else
                {
                    var p = new Drink()
                    {
                        Title = name,
                        Calories = int.Parse(calories)
                    };
                    _products.Add(p);
                }
            }

        }

        private string GetXML(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                var xml = sr.ReadToEnd();
                return xml;

            }
        }
    }
}
