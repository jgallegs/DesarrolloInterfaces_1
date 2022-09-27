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
    public partial class Temporizador : Form
    {
        public Temporizador()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                if (txtArriba.Text.Length > 0)
                {
                    txtAbajo.Text = txtArriba.Text;
                    txtArriba.Text = null;
                }
                else
                {
                    txtArriba.Text = txtAbajo.Text;
                    txtAbajo.Text = null;
                }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtArriba.Text.Length > 0 || txtAbajo.Text.Length > 0)
            {
                btnStart.Visible = false;
                btnStop.Visible = true;
                nudIntervalo.ReadOnly = true;
                tTemporizador.Interval = (int)(nudIntervalo.Value);
                tTemporizador.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Visible = false;
            btnStart.Visible = true;
            nudIntervalo.ReadOnly = false;
        }

        private void txtAbajo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
