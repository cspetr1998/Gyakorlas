using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irfprojektproba.Entities
{
    public class ButtonClass : Button
    {

        public ButtonClass()
        {
            this.Text = "Hozzáadás";
            this.Width = 100;
            this.Height = 50;
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = System.Drawing.Color.LightGreen;
        }
    }
}
