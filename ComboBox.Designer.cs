namespace DesarrolloInterfacesFormularios
{
    partial class ComboBox
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
            this.cbDD = new System.Windows.Forms.ComboBox();
            this.cbDDL = new System.Windows.Forms.ComboBox();
            this.cbS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUltimoColor = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estilo DropDown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(228, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estilo DropDownList";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(430, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estilo Simple";
            // 
            // cbDD
            // 
            this.cbDD.FormattingEnabled = true;
            this.cbDD.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Negro",
            "Rojo",
            "Verde"});
            this.cbDD.Location = new System.Drawing.Point(45, 92);
            this.cbDD.Name = "cbDD";
            this.cbDD.Size = new System.Drawing.Size(155, 23);
            this.cbDD.TabIndex = 3;
            // 
            // cbDDL
            // 
            this.cbDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDDL.FormattingEnabled = true;
            this.cbDDL.Items.AddRange(new object[] {
            "Verde"});
            this.cbDDL.Location = new System.Drawing.Point(219, 92);
            this.cbDDL.Name = "cbDDL";
            this.cbDDL.Size = new System.Drawing.Size(169, 23);
            this.cbDDL.TabIndex = 4;
            // 
            // cbS
            // 
            this.cbS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbS.FormattingEnabled = true;
            this.cbS.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul",
            "Negro"});
            this.cbS.Location = new System.Drawing.Point(419, 92);
            this.cbS.Name = "cbS";
            this.cbS.Size = new System.Drawing.Size(121, 150);
            this.cbS.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Muestra el último color elegido:";
            // 
            // txtUltimoColor
            // 
            this.txtUltimoColor.Location = new System.Drawing.Point(294, 259);
            this.txtUltimoColor.Name = "txtUltimoColor";
            this.txtUltimoColor.Size = new System.Drawing.Size(174, 23);
            this.txtUltimoColor.TabIndex = 7;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(59, 334);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(160, 23);
            this.txtColor.TabIndex = 8;
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(248, 329);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(184, 30);
            this.btnAddColor.TabIndex = 9;
            this.btnAddColor.Text = "Añadir al DropDownList";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtUltimoColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbS);
            this.Controls.Add(this.cbDDL);
            this.Controls.Add(this.cbDD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComboBox";
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.ComboBox cbDD;
        private System.Windows.Forms.ComboBox cbDDL;
        private System.Windows.Forms.ComboBox cbS;
        private Label label4;
        private TextBox txtUltimoColor;
        private TextBox txtColor;
        private Button btnAddColor;
    }
}