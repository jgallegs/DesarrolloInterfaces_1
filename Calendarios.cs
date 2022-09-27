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
    public partial class Calendarios : Form
    {
        public Calendarios()
        {
            InitializeComponent();
        }

        private void dtpCalendarioPicker_ValueChanged(object sender, EventArgs e)
        {
            txtFechaElegida.Text = dtpCalendarioPicker.Value.ToShortDateString();
            mcCalendario.SetDate(dtpCalendarioPicker.Value);
        }

        private void mcCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFechaElegida.Text = mcCalendario.SelectionRange.Start.ToShortDateString();
            dtpCalendarioPicker.Value = mcCalendario.SelectionRange.Start;
        }
    }
}
