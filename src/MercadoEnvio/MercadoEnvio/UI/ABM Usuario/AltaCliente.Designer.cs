﻿namespace MercadoEnvio.UI.ABM_Usuario
{
    partial class AltaCliente
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numeroCalleTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.dptoTextBox = new System.Windows.Forms.TextBox();
            this.nroPisoTextBox = new System.Windows.Forms.TextBox();
            this.calleTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.cpTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Teléfono";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numeroCalleTextBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.localidadTextBox);
            this.groupBox1.Controls.Add(this.dptoTextBox);
            this.groupBox1.Controls.Add(this.nroPisoTextBox);
            this.groupBox1.Controls.Add(this.calleTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(32, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección";
            // 
            // numeroCalleTextBox
            // 
            this.numeroCalleTextBox.Location = new System.Drawing.Point(121, 44);
            this.numeroCalleTextBox.Name = "numeroCalleTextBox";
            this.numeroCalleTextBox.Size = new System.Drawing.Size(207, 20);
            this.numeroCalleTextBox.TabIndex = 9;
            this.numeroCalleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroCalleTextBox_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Número Calle";
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.Location = new System.Drawing.Point(121, 121);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.Size = new System.Drawing.Size(206, 20);
            this.localidadTextBox.TabIndex = 7;
            // 
            // dptoTextBox
            // 
            this.dptoTextBox.Location = new System.Drawing.Point(121, 94);
            this.dptoTextBox.Name = "dptoTextBox";
            this.dptoTextBox.Size = new System.Drawing.Size(206, 20);
            this.dptoTextBox.TabIndex = 6;
            // 
            // nroPisoTextBox
            // 
            this.nroPisoTextBox.Location = new System.Drawing.Point(121, 68);
            this.nroPisoTextBox.Name = "nroPisoTextBox";
            this.nroPisoTextBox.Size = new System.Drawing.Size(206, 20);
            this.nroPisoTextBox.TabIndex = 5;
            this.nroPisoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nroPisoTextBox_KeyPress);
            // 
            // calleTextBox
            // 
            this.calleTextBox.Location = new System.Drawing.Point(122, 19);
            this.calleTextBox.Name = "calleTextBox";
            this.calleTextBox.Size = new System.Drawing.Size(206, 20);
            this.calleTextBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Localidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Departamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Número de Piso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Calle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Código Postal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Fecha de Nacimiento";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(152, 36);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(226, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(151, 62);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(226, 20);
            this.apellidoTextBox.TabIndex = 12;
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(152, 91);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(226, 20);
            this.dniTextBox.TabIndex = 13;
            this.dniTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dniTextBox_KeyPress);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(151, 120);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(226, 20);
            this.mailTextBox.TabIndex = 15;
            this.mailTextBox.TextChanged += new System.EventHandler(this.mailTextBox_TextChanged);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(151, 148);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(226, 20);
            this.telefonoTextBox.TabIndex = 16;
            this.telefonoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonoTextBox_KeyPress);
            // 
            // cpTextBox
            // 
            this.cpTextBox.Location = new System.Drawing.Point(153, 351);
            this.cpTextBox.Name = "cpTextBox";
            this.cpTextBox.Size = new System.Drawing.Size(226, 20);
            this.cpTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(153, 384);
            this.fechaNacimientoDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(226, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 21;
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 447);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cpTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox dptoTextBox;
        private System.Windows.Forms.TextBox nroPisoTextBox;
        private System.Windows.Forms.TextBox calleTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox cpTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numeroCalleTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
    }
}