namespace MercadoEnvio.ABM_Rol
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
            this.ListaRolesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.AltaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Rol";
            // 
            // NombreRolTextBox
            // 
            this.NombreRolTextBox.Location = new System.Drawing.Point(197, 76);
            this.NombreRolTextBox.Name = "NombreRolTextBox";
            this.NombreRolTextBox.Size = new System.Drawing.Size(234, 26);
            this.NombreRolTextBox.TabIndex = 2;
            // 
            // ListaRolesCheckedListBox
            // 
            this.ListaRolesCheckedListBox.FormattingEnabled = true;
            this.ListaRolesCheckedListBox.Location = new System.Drawing.Point(31, 119);
            this.ListaRolesCheckedListBox.Name = "ListaRolesCheckedListBox";
            this.ListaRolesCheckedListBox.Size = new System.Drawing.Size(400, 403);
            this.ListaRolesCheckedListBox.TabIndex = 3;
            // 
            // AltaButton
            // 
            this.AltaButton.Location = new System.Drawing.Point(31, 542);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(400, 39);
            this.AltaButton.TabIndex = 4;
            this.AltaButton.Text = "Dar de Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            this.AltaButton.Click += new System.EventHandler(this.AltaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 594);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.ListaRolesCheckedListBox);
            this.Controls.Add(this.NombreRolTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreRolTextBox;
        private System.Windows.Forms.CheckedListBox ListaRolesCheckedListBox;
        private System.Windows.Forms.Button AltaButton;
    }
}