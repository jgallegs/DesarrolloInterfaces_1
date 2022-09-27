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
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmTextBox")
                {
                    DialogResult rs = MessageBox.Show("Desea cerrar el formulario abierto?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        Form2 f = new Form2();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            } else
            {
                Form2 f = new Form2();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Contenedor_Load(object sender, EventArgs e)
        {

        }

        private void btnTriangulos_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "Triangulos")
                {
                    DialogResult rs = MessageBox.Show("Desea cerrar el formulario abierto?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        Triangulos f = new Triangulos();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                Triangulos f = new Triangulos();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "ColorPicker")
                {
                    DialogResult rs = MessageBox.Show("Desea cerrar el formulario abierto?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        ColorPicker f = new ColorPicker();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                ColorPicker f = new ColorPicker();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "ComboBox")
                {
                    DialogResult rs = MessageBox.Show("Desea cerrar el formulario abierto?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        ComboBox f = new ComboBox();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                ComboBox f = new ComboBox();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btnCalendarios_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "Calendarios")
                {
                    DialogResult rs = MessageBox.Show("Desea cerrar el formulario abierto?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        Calendarios f = new Calendarios();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                Calendarios f = new Calendarios();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }
    }
}
