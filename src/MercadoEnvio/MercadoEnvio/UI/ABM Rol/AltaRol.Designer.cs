﻿namespace MercadoEnvio.ABM_Rol
{
    partial class AltaRol
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
            this.NombreRolTextBox = new System.Windows.Forms.TextBox();
            this.ListaFuncionalidadesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.AltaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Rol";
            // 
            // NombreRolTextBox
            // 
            this.NombreRolTextBox.Location = new System.Drawing.Point(131, 49);
            this.NombreRolTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NombreRolTextBox.Name = "NombreRolTextBox";
            this.NombreRolTextBox.Size = new System.Drawing.Size(157, 20);
            this.NombreRolTextBox.TabIndex = 2;
            // 
            // ListaFuncionalidadesCheckedListBox
            // 
            this.ListaFuncionalidadesCheckedListBox.FormattingEnabled = true;
            this.ListaFuncionalidadesCheckedListBox.Location = new System.Drawing.Point(21, 77);
            this.ListaFuncionalidadesCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ListaFuncionalidadesCheckedListBox.Name = "ListaFuncionalidadesCheckedListBox";
            this.ListaFuncionalidadesCheckedListBox.Size = new System.Drawing.Size(268, 259);
            this.ListaFuncionalidadesCheckedListBox.TabIndex = 3;
            this.ListaFuncionalidadesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.ListaRolesCheckedListBox_SelectedIndexChanged);
            // 
            // AltaButton
            // 
            this.AltaButton.Location = new System.Drawing.Point(21, 352);
            this.AltaButton.Margin = new System.Windows.Forms.Padding(2);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(267, 25);
            this.AltaButton.TabIndex = 4;
            this.AltaButton.Text = "Dar de Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            this.AltaButton.Click += new System.EventHandler(this.AltaButton_Click);
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 386);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.ListaFuncionalidadesCheckedListBox);
            this.Controls.Add(this.NombreRolTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaRol";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AltaRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreRolTextBox;
        private System.Windows.Forms.CheckedListBox ListaFuncionalidadesCheckedListBox;
        private System.Windows.Forms.Button AltaButton;
    }
}