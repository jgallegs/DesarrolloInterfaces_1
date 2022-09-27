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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (txtColor.Text.Length > 0)
            {
                cbDDL.Items.Add(txtColor.Text);
            }
        }

        private void cbDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUltimoColor.Text = cbDD.Text;
        }

        private void cbDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUltimoColor.Text = cbDDL.Text;
        }

        private void cbS_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUltimoColor.Text = cbS.Text;
        }
    }
}
