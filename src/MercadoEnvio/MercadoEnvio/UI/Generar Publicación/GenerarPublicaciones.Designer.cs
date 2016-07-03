namespace MercadoEnvio.UI.Generar_Publicación
{
    partial class GenerarPublicaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoPublicacionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.vencimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rubroComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.visibilidadComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.responsableTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.permitirPreguntasCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.permitirEnvioCheckBox = new System.Windows.Forms.CheckBox();
            this.gD1C2016DataSet10 = new MercadoEnvio.GD1C2016DataSet10();
            this.tiposPublicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipos_PublicacionesTableAdapter = new MercadoEnvio.GD1C2016DataSet10TableAdapters.Tipos_PublicacionesTableAdapter();
            this.gD1C2016DataSet11 = new MercadoEnvio.GD1C2016DataSet11();
            this.rubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubrosTableAdapter = new MercadoEnvio.GD1C2016DataSet11TableAdapters.RubrosTableAdapter();
            this.gD1C2016DataSet12 = new MercadoEnvio.GD1C2016DataSet12();
            this.visibilidadesPublicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visibilidades_PublicacionesTableAdapter = new MercadoEnvio.GD1C2016DataSet12TableAdapters.Visibilidades_PublicacionesTableAdapter();
            this.gD1C2016DataSet13 = new MercadoEnvio.GD1C2016DataSet13();
            this.estadosPublicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estados_PublicacionesTableAdapter = new MercadoEnvio.GD1C2016DataSet13TableAdapters.Estados_PublicacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposPublicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadesPublicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosPublicacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar Publicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Publicación";
            // 
            // tipoPublicacionComboBox
            // 
            this.tipoPublicacionComboBox.DataSource = this.tiposPublicacionesBindingSource;
            this.tipoPublicacionComboBox.DisplayMember = "Descripcion_Tipo";
            this.tipoPublicacionComboBox.FormattingEnabled = true;
            this.tipoPublicacionComboBox.Location = new System.Drawing.Point(276, 125);
            this.tipoPublicacionComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tipoPublicacionComboBox.Name = "tipoPublicacionComboBox";
            this.tipoPublicacionComboBox.Size = new System.Drawing.Size(288, 28);
            this.tipoPublicacionComboBox.TabIndex = 2;
            this.tipoPublicacionComboBox.ValueMember = "Descripcion_Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(276, 72);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(288, 26);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stock";
            // 
            // stockTextBox
            // 
            this.stockTextBox.Location = new System.Drawing.Point(276, 175);
            this.stockTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(288, 26);
            this.stockTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Publicación";
            // 
            // inicioDateTimePicker
            // 
            this.inicioDateTimePicker.Location = new System.Drawing.Point(276, 229);
            this.inicioDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inicioDateTimePicker.Name = "inicioDateTimePicker";
            this.inicioDateTimePicker.Size = new System.Drawing.Size(288, 26);
            this.inicioDateTimePicker.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vencimiento de Publicación";
            // 
            // vencimientoDateTimePicker
            // 
            this.vencimientoDateTimePicker.Location = new System.Drawing.Point(276, 280);
            this.vencimientoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vencimientoDateTimePicker.Name = "vencimientoDateTimePicker";
            this.vencimientoDateTimePicker.Size = new System.Drawing.Size(286, 26);
            this.vencimientoDateTimePicker.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 334);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Precio";
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(276, 329);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(288, 26);
            this.precioTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rubro";
            // 
            // rubroComboBox
            // 
            this.rubroComboBox.DataSource = this.rubrosBindingSource;
            this.rubroComboBox.DisplayMember = "Descripcion_Rubro";
            this.rubroComboBox.FormattingEnabled = true;
            this.rubroComboBox.Location = new System.Drawing.Point(276, 374);
            this.rubroComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rubroComboBox.Name = "rubroComboBox";
            this.rubroComboBox.Size = new System.Drawing.Size(286, 28);
            this.rubroComboBox.TabIndex = 14;
            this.rubroComboBox.ValueMember = "Descripcion_Rubro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 426);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Visibilidad";
            // 
            // visibilidadComboBox
            // 
            this.visibilidadComboBox.DataSource = this.visibilidadesPublicacionesBindingSource;
            this.visibilidadComboBox.DisplayMember = "Descripcion_Visibilidad";
            this.visibilidadComboBox.FormattingEnabled = true;
            this.visibilidadComboBox.Location = new System.Drawing.Point(276, 422);
            this.visibilidadComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visibilidadComboBox.Name = "visibilidadComboBox";
            this.visibilidadComboBox.Size = new System.Drawing.Size(284, 28);
            this.visibilidadComboBox.TabIndex = 16;
            this.visibilidadComboBox.ValueMember = "Descripcion_Visibilidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 474);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Responsable";
            // 
            // responsableTextBox
            // 
            this.responsableTextBox.Location = new System.Drawing.Point(276, 469);
            this.responsableTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.responsableTextBox.Name = "responsableTextBox";
            this.responsableTextBox.Size = new System.Drawing.Size(284, 26);
            this.responsableTextBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 517);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Estado";
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataSource = this.estadosPublicacionesBindingSource;
            this.estadoComboBox.DisplayMember = "Descripcion_Estado";
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(273, 512);
            this.estadoComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(288, 28);
            this.estadoComboBox.TabIndex = 20;
            this.estadoComboBox.ValueMember = "Descripcion_Estado";
            // 
            // permitirPreguntasCheckBox
            // 
            this.permitirPreguntasCheckBox.AutoSize = true;
            this.permitirPreguntasCheckBox.Location = new System.Drawing.Point(44, 569);
            this.permitirPreguntasCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.permitirPreguntasCheckBox.Name = "permitirPreguntasCheckBox";
            this.permitirPreguntasCheckBox.Size = new System.Drawing.Size(165, 24);
            this.permitirPreguntasCheckBox.TabIndex = 22;
            this.permitirPreguntasCheckBox.Text = "Permitir Preguntas";
            this.permitirPreguntasCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 608);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // permitirEnvioCheckBox
            // 
            this.permitirEnvioCheckBox.AutoSize = true;
            this.permitirEnvioCheckBox.Location = new System.Drawing.Point(273, 569);
            this.permitirEnvioCheckBox.Name = "permitirEnvioCheckBox";
            this.permitirEnvioCheckBox.Size = new System.Drawing.Size(131, 24);
            this.permitirEnvioCheckBox.TabIndex = 24;
            this.permitirEnvioCheckBox.Text = "Permitir Envio";
            this.permitirEnvioCheckBox.UseVisualStyleBackColor = true;
            // 
            // gD1C2016DataSet10
            // 
            this.gD1C2016DataSet10.DataSetName = "GD1C2016DataSet10";
            this.gD1C2016DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposPublicacionesBindingSource
            // 
            this.tiposPublicacionesBindingSource.DataMember = "Tipos_Publicaciones";
            this.tiposPublicacionesBindingSource.DataSource = this.gD1C2016DataSet10;
            // 
            // tipos_PublicacionesTableAdapter
            // 
            this.tipos_PublicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // gD1C2016DataSet11
            // 
            this.gD1C2016DataSet11.DataSetName = "GD1C2016DataSet11";
            this.gD1C2016DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubrosBindingSource
            // 
            this.rubrosBindingSource.DataMember = "Rubros";
            this.rubrosBindingSource.DataSource = this.gD1C2016DataSet11;
            // 
            // rubrosTableAdapter
            // 
            this.rubrosTableAdapter.ClearBeforeFill = true;
            // 
            // gD1C2016DataSet12
            // 
            this.gD1C2016DataSet12.DataSetName = "GD1C2016DataSet12";
            this.gD1C2016DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visibilidadesPublicacionesBindingSource
            // 
            this.visibilidadesPublicacionesBindingSource.DataMember = "Visibilidades_Publicaciones";
            this.visibilidadesPublicacionesBindingSource.DataSource = this.gD1C2016DataSet12;
            // 
            // visibilidades_PublicacionesTableAdapter
            // 
            this.visibilidades_PublicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // gD1C2016DataSet13
            // 
            this.gD1C2016DataSet13.DataSetName = "GD1C2016DataSet13";
            this.gD1C2016DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadosPublicacionesBindingSource
            // 
            this.estadosPublicacionesBindingSource.DataMember = "Estados_Publicaciones";
            this.estadosPublicacionesBindingSource.DataSource = this.gD1C2016DataSet13;
            // 
            // estados_PublicacionesTableAdapter
            // 
            this.estados_PublicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 662);
            this.Controls.Add(this.permitirEnvioCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.permitirPreguntasCheckBox);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.responsableTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.visibilidadComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rubroComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.vencimientoDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inicioDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipoPublicacionComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Generar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposPublicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadesPublicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosPublicacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipoPublicacionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker inicioDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker vencimientoDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox rubroComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox visibilidadComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox responsableTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.CheckBox permitirPreguntasCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox permitirEnvioCheckBox;
        private GD1C2016DataSet10 gD1C2016DataSet10;
        private System.Windows.Forms.BindingSource tiposPublicacionesBindingSource;
        private GD1C2016DataSet10TableAdapters.Tipos_PublicacionesTableAdapter tipos_PublicacionesTableAdapter;
        private GD1C2016DataSet11 gD1C2016DataSet11;
        private System.Windows.Forms.BindingSource rubrosBindingSource;
        private GD1C2016DataSet11TableAdapters.RubrosTableAdapter rubrosTableAdapter;
        private GD1C2016DataSet12 gD1C2016DataSet12;
        private System.Windows.Forms.BindingSource visibilidadesPublicacionesBindingSource;
        private GD1C2016DataSet12TableAdapters.Visibilidades_PublicacionesTableAdapter visibilidades_PublicacionesTableAdapter;
        private GD1C2016DataSet13 gD1C2016DataSet13;
        private System.Windows.Forms.BindingSource estadosPublicacionesBindingSource;
        private GD1C2016DataSet13TableAdapters.Estados_PublicacionesTableAdapter estados_PublicacionesTableAdapter;
    }
}