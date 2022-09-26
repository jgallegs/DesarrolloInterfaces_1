namespace DesarrolloInterfacesFormularios
{
    partial class ColorPicker
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
            this.lblMain = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnLetra = new System.Windows.Forms.Button();
            this.txtPruebaColores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMain.Location = new System.Drawing.Point(43, 45);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(361, 25);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Elige el color de fondo de este formulario";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(43, 114);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(174, 38);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "COLOR";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnLetra
            // 
            this.btnLetra.Location = new System.Drawing.Point(239, 114);
            this.btnLetra.Name = "btnLetra";
            this.btnLetra.Size = new System.Drawing.Size(174, 38);
            this.btnLetra.TabIndex = 2;
            this.btnLetra.Text = "TIPO DE LETRA";
            this.btnLetra.UseVisualStyleBackColor = true;
            this.btnLetra.Click += new System.EventHandler(this.btnLetra_Click);
            // 
            // txtPruebaColores
            // 
            this.txtPruebaColores.Location = new System.Drawing.Point(43, 173);
            this.txtPruebaColores.Name = "txtPruebaColores";
            this.txtPruebaColores.Size = new System.Drawing.Size(370, 23);
            this.txtPruebaColores.TabIndex = 3;
            this.txtPruebaColores.Text = "PROBANDO...";
            this.txtPruebaColores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "y el tipo de letra del cuadro de texto:";
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPruebaColores);
            this.Controls.Add(this.btnLetra);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColorPicker";
            this.Text = "ColorPicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMain;
        private Button btnColor;
        private Button btnLetra;
        private TextBox txtPruebaColores;
        private Label label1;
    }
}