namespace MercadoEnvio.UI.ABM_Visibilidad
{
    partial class AltaVisibilidad
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
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PorcentajeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comisionTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta Visibilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(216, 82);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(254, 26);
            this.descripcionTextBox.TabIndex = 3;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(216, 142);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(253, 26);
            this.precioTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Porcentaje";
            // 
            // PorcentajeTextBox
            // 
            this.PorcentajeTextBox.Location = new System.Drawing.Point(216, 203);
            this.PorcentajeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PorcentajeTextBox.Name = "PorcentajeTextBox";
            this.PorcentajeTextBox.Size = new System.Drawing.Size(253, 26);
            this.PorcentajeTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Comisión Entregas";
            // 
            // comisionTextBox
            // 
            this.comisionTextBox.Location = new System.Drawing.Point(216, 266);
            this.comisionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comisionTextBox.Name = "comisionTextBox";
            this.comisionTextBox.Size = new System.Drawing.Size(254, 26);
            this.comisionTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltaVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 385);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comisionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PorcentajeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AltaVisibilidad";
            this.Text = "AltaVisibilidad";
            this.Load += new System.EventHandler(this.AltaVisibilidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PorcentajeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox comisionTextBox;
        private System.Windows.Forms.Button button1;
    }
}