namespace DesarrolloInterfacesFormularios
{
    partial class GamaColores
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRED = new System.Windows.Forms.NumericUpDown();
            this.nudGREEN = new System.Windows.Forms.NumericUpDown();
            this.nudBLUE = new System.Windows.Forms.NumericUpDown();
            this.tbRED = new System.Windows.Forms.TrackBar();
            this.tbGREEN = new System.Windows.Forms.TrackBar();
            this.tbBLUE = new System.Windows.Forms.TrackBar();
            this.pColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudRED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBLUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBLUE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rojo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Azul:";
            // 
            // nudRED
            // 
            this.nudRED.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudRED.Location = new System.Drawing.Point(131, 47);
            this.nudRED.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRED.Name = "nudRED";
            this.nudRED.Size = new System.Drawing.Size(59, 29);
            this.nudRED.TabIndex = 3;
            this.nudRED.ValueChanged += new System.EventHandler(this.nudRED_ValueChanged);
            // 
            // nudGREEN
            // 
            this.nudGREEN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudGREEN.Location = new System.Drawing.Point(131, 109);
            this.nudGREEN.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGREEN.Name = "nudGREEN";
            this.nudGREEN.Size = new System.Drawing.Size(59, 29);
            this.nudGREEN.TabIndex = 4;
            this.nudGREEN.ValueChanged += new System.EventHandler(this.nudGREEN_ValueChanged);
            // 
            // nudBLUE
            // 
            this.nudBLUE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudBLUE.Location = new System.Drawing.Point(131, 167);
            this.nudBLUE.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBLUE.Name = "nudBLUE";
            this.nudBLUE.Size = new System.Drawing.Size(59, 29);
            this.nudBLUE.TabIndex = 5;
            this.nudBLUE.ValueChanged += new System.EventHandler(this.nudBLUE_ValueChanged);
            // 
            // tbRED
            // 
            this.tbRED.Location = new System.Drawing.Point(225, 47);
            this.tbRED.Maximum = 255;
            this.tbRED.Name = "tbRED";
            this.tbRED.Size = new System.Drawing.Size(343, 45);
            this.tbRED.TabIndex = 6;
            this.tbRED.Scroll += new System.EventHandler(this.tbRED_Scroll);
            // 
            // tbGREEN
            // 
            this.tbGREEN.Location = new System.Drawing.Point(225, 108);
            this.tbGREEN.Maximum = 255;
            this.tbGREEN.Name = "tbGREEN";
            this.tbGREEN.Size = new System.Drawing.Size(343, 45);
            this.tbGREEN.TabIndex = 7;
            this.tbGREEN.Scroll += new System.EventHandler(this.tbGREEN_Scroll);
            // 
            // tbBLUE
            // 
            this.tbBLUE.AccessibleDescription = "tbBLUE";
            this.tbBLUE.Location = new System.Drawing.Point(225, 167);
            this.tbBLUE.Maximum = 255;
            this.tbBLUE.Name = "tbBLUE";
            this.tbBLUE.Size = new System.Drawing.Size(343, 45);
            this.tbBLUE.TabIndex = 8;
            this.tbBLUE.Scroll += new System.EventHandler(this.tbBLUE_Scroll);
            // 
            // pColor
            // 
            this.pColor.Location = new System.Drawing.Point(48, 232);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(520, 169);
            this.pColor.TabIndex = 9;
            // 
            // GamaColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.tbBLUE);
            this.Controls.Add(this.tbGREEN);
            this.Controls.Add(this.tbRED);
            this.Controls.Add(this.nudBLUE);
            this.Controls.Add(this.nudGREEN);
            this.Controls.Add(this.nudRED);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamaColores";
            this.Text = "GamaColores";
            this.Load += new System.EventHandler(this.GamaColores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBLUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBLUE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nudRED;
        private NumericUpDown nudGREEN;
        private NumericUpDown nudBLUE;
        private TrackBar tbRED;
        private TrackBar tbGREEN;
        private TrackBar tbBLUE;
        private Panel pColor;
    }
}