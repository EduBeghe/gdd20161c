namespace MercadoEnvio.UI.ABM_Rol
{
    partial class ModificarRol
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
            this.FuncionalidadesListBox = new System.Windows.Forms.CheckedListBox();
            this.modificarButton = new System.Windows.Forms.Button();
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FuncionalidadesListBox
            // 
            this.FuncionalidadesListBox.FormattingEnabled = true;
            this.FuncionalidadesListBox.Location = new System.Drawing.Point(12, 120);
            this.FuncionalidadesListBox.Name = "FuncionalidadesListBox";
            this.FuncionalidadesListBox.Size = new System.Drawing.Size(379, 298);
            this.FuncionalidadesListBox.TabIndex = 0;
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(12, 434);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(379, 37);
            this.modificarButton.TabIndex = 1;
            this.modificarButton.Text = "Modificar Rol";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.AutoSize = true;
            this.estadoCheckBox.Location = new System.Drawing.Point(141, 78);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(78, 24);
            this.estadoCheckBox.TabIndex = 2;
            this.estadoCheckBox.Text = "Activo";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(141, 41);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(250, 26);
            this.nombreTextBox.TabIndex = 6;
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 483);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estadoCheckBox);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.FuncionalidadesListBox);
            this.Name = "ModificarRol";
            this.Text = "ModificarRol";
            this.Load += new System.EventHandler(this.ModificarRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox FuncionalidadesListBox;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.CheckBox estadoCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}