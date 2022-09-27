using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesarrolloInterfacesFormularios
{
    public partial class GamaColores : Form
    {
        static int red = 0, green = 0, blue = 0 ;
        private Color color = Color.FromArgb(red, green, blue);
        public GamaColores()
        {
            InitializeComponent();
        }

        private void GamaColores_Load(object sender, EventArgs e)
        {
            pColor.BackColor = color;  
        }

        private void tbGREEN_Scroll(object sender, EventArgs e)
        {
            nudGREEN.Value = (int)tbGREEN.Value;
        }

        private void nudGREEN_ValueChanged(object sender, EventArgs e)
        {
            tbGREEN.Value = (int)nudGREEN.Value;
            green = tbGREEN.Value;
            color = Color.FromArgb(red, green, blue);
            pColor.BackColor = color;
        }

        private void tbBLUE_Scroll(object sender, EventArgs e)
        {
            nudBLUE.Value = (int)tbBLUE.Value;
        }

        private void nudBLUE_ValueChanged(object sender, EventArgs e)
        {
            tbBLUE.Value = (int)nudBLUE.Value;
            blue = tbBLUE.Value;
            color = Color.FromArgb(red, green, blue);
            pColor.BackColor = color;
        }

        private void nudRED_ValueChanged(object sender, EventArgs e)
        {
            tbRED.Value = (int)nudRED.Value;
            red = tbRED.Value;
            color = Color.FromArgb(red, green, blue);
            pColor.BackColor = color;
        }

        private void tbRED_Scroll(object sender, EventArgs e)
        {
            nudRED.Value = (int)tbRED.Value;
        }
    }
}
