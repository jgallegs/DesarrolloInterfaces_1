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

        private void btnTemporizador_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "Temporizador")
                {
                    DialogResult rs = MessageBox.Show("Desea cerrar el formulario abierto?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        Temporizador f = new Temporizador();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                Temporizador f = new Temporizador();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btnGamaCol_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "GamaColores")
                {
                    DialogResult rs = MessageBox.Show("Desea cerrar el formulario abierto?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        GamaColores f = new GamaColores();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                GamaColores f = new GamaColores();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "TextBox")
                {
                    DialogResult rs = MessageBox.Show("Desea cerrar el formulario abierto?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        TextBox f = new TextBox();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
            }
            else
            {
                TextBox f = new TextBox();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }
    }
}
