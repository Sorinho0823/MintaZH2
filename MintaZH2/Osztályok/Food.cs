using MintaZH2.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaZH2.Osztályok
{
    class Food : Product
    {
        public string Description { get; set; }
        public Food()
        {
            Click += Food_Click;
        }

        private void Food_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0}\n{1}", Title, Description));
        }
        protected override void Display()
        {
            if (Calories<750)
            {
                BackColor = Color.LightGreen;
            }
            if (Calories>1000)
            {
                BackColor = Color.Salmon;

            }
            else
            {
                BackColor = Color.LightYellow;
            }
        }

    }
}
