using MintaZH2.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaZH2.Osztályok
{
    class Drink : Product
    {
        protected override void Display()
        {
            BackColor = Color.LightBlue;
        }
    }
}
