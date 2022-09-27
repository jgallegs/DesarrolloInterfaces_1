namespace DesarrolloInterfacesFormularios
{
    partial class Temporizador
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
            this.components = new System.ComponentModel.Container();
            this.tTemporizador = new System.Windows.Forms.Timer(this.components);
            this.txtArriba = new System.Windows.Forms.TextBox();
            this.txtAbajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudIntervalo = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // tTemporizador
            // 
            this.tTemporizador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtArriba
            // 
            this.txtArriba.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtArriba.Location = new System.Drawing.Point(169, 45);
            this.txtArriba.Name = "txtArriba";
            this.txtArriba.Size = new System.Drawing.Size(260, 33);
            this.txtArriba.TabIndex = 0;
            this.txtArriba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAbajo
            // 
            this.txtAbajo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAbajo.Location = new System.Drawing.Point(169, 106);
            this.txtAbajo.Name = "txtAbajo";
            this.txtAbajo.Size = new System.Drawing.Size(260, 33);
            this.txtAbajo.TabIndex = 1;
            this.txtAbajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAbajo.TextChanged += new System.EventHandler(this.txtAbajo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indica el intervalo, en segundos, que\r\nquieres que cambie la palabra de un\r\ncuadr" +
    "o de texto a otro:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudIntervalo
            // 
            this.nudIntervalo.Location = new System.Drawing.Point(235, 241);
            this.nudIntervalo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudIntervalo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntervalo.Name = "nudIntervalo";
            this.nudIntervalo.Size = new System.Drawing.Size(114, 23);
            this.nudIntervalo.TabIndex = 3;
            this.nudIntervalo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 450);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStop.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(528, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(84, 450);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Temporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudIntervalo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAbajo);
            this.Controls.Add(this.txtArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Temporizador";
            this.Text = "Temporizador";
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tTemporizador;
        private TextBox txtArriba;
        private TextBox txtAbajo;
        private Label label1;
        private NumericUpDown nudIntervalo;
        private Button btnStart;
        private Button btnStop;
    }
}