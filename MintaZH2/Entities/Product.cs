using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaZH2.Entities
{
    abstract class  Product : Button
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value;
                Text = Title;

            }
        }
        private int _calories;

        public int Calories
        {
            get { return _calories; }
            set { _calories = value;
                Display();
                    }
        }

        public Product()
        {
            Height = 50;
            Width = 150;
        }
        protected abstract void Display();
        


    }
}
