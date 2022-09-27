namespace DesarrolloInterfacesFormularios
{
    partial class Calendarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaElegida = new System.Windows.Forms.TextBox();
            this.dtpCalendarioPicker = new System.Windows.Forms.DateTimePicker();
            this.mcCalendario = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha elegida:";
            // 
            // txtFechaElegida
            // 
            this.txtFechaElegida.Location = new System.Drawing.Point(182, 79);
            this.txtFechaElegida.Name = "txtFechaElegida";
            this.txtFechaElegida.Size = new System.Drawing.Size(341, 23);
            this.txtFechaElegida.TabIndex = 1;
            // 
            // dtpCalendarioPicker
            // 
            this.dtpCalendarioPicker.Location = new System.Drawing.Point(323, 162);
            this.dtpCalendarioPicker.Name = "dtpCalendarioPicker";
            this.dtpCalendarioPicker.Size = new System.Drawing.Size(200, 23);
            this.dtpCalendarioPicker.TabIndex = 2;
            this.dtpCalendarioPicker.ValueChanged += new System.EventHandler(this.dtpCalendarioPicker_ValueChanged);
            // 
            // mcCalendario
            // 
            this.mcCalendario.Location = new System.Drawing.Point(50, 162);
            this.mcCalendario.Name = "mcCalendario";
            this.mcCalendario.TabIndex = 3;
            this.mcCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCalendario_DateChanged);
            // 
            // Calendarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mcCalendario);
            this.Controls.Add(this.dtpCalendarioPicker);
            this.Controls.Add(this.txtFechaElegida);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calendarios";
            this.Text = "Calendarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFechaElegida;
        private DateTimePicker dtpCalendarioPicker;
        private MonthCalendar mcCalendario;
    }
}