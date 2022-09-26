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
    public partial class Triangulos : Form
    {
        public Triangulos()
        {
            InitializeComponent();
        }

        private void Triangulos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLadoA.Text.Length != 0 && txtLadoB.Text.Length != 0 && txtLadoC.Text.Length != 0)
            {
                try
                {
                    double la = Convert.ToDouble(txtLadoA.Text.Trim());
                    double lb = Convert.ToDouble(txtLadoB.Text.Trim());
                    double lc = Convert.ToDouble(txtLadoC.Text.Trim());
                    if (la == lb && lb == lc)
                    {
                        lblResultado.Text = "Es un triángulo equilátero";
                    }
                    else if (((la == lb) && (lb != lc)) || ((lb == lc) && (la != lb)))
                    {
                        lblResultado.Text = "Es un triángulo isósceles";
                    }
                    else
                    {
                        lblResultado.Text = "Es un triángulo escaleno";
                    }
                } catch (FormatException ex)
                {
                    MessageBox.Show("Las cajas de texto solo admiten valores numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                lblResultado.Text = "Todos los cuadros de texto deben tener un valor.";
            }
        }
    }
}
