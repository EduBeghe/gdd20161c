namespace MercadoEnvio.UI.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            this.estadisticaDataGridView = new System.Windows.Forms.DataGridView();
            this.trimestreComboBox = new System.Windows.Forms.ComboBox();
            this.anioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.consultarButton = new System.Windows.Forms.Button();
            this.estadisticaComboBox = new System.Windows.Forms.ComboBox();
            this.visibilidadComboBox = new System.Windows.Forms.ComboBox();
            this.visibilidadesPublicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2016DataSet7 = new MercadoEnvio.GD1C2016DataSet7();
            this.rubroComboBox = new System.Windows.Forms.ComboBox();
            this.rubrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2016DataSet8 = new MercadoEnvio.GD1C2016DataSet8();
            this.visibilidades_PublicacionesTableAdapter = new MercadoEnvio.GD1C2016DataSet7TableAdapters.Visibilidades_PublicacionesTableAdapter();
            this.rubrosTableAdapter = new MercadoEnvio.GD1C2016DataSet8TableAdapters.RubrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadesPublicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listados Estadisticos";
            // 
            // estadisticaDataGridView
            // 
            this.estadisticaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estadisticaDataGridView.Location = new System.Drawing.Point(15, 218);
            this.estadisticaDataGridView.Name = "estadisticaDataGridView";
            this.estadisticaDataGridView.RowTemplate.Height = 28;
            this.estadisticaDataGridView.Size = new System.Drawing.Size(447, 266);
            this.estadisticaDataGridView.TabIndex = 1;
            // 
            // trimestreComboBox
            // 
            this.trimestreComboBox.FormattingEnabled = true;
            this.trimestreComboBox.Items.AddRange(new object[] {
            "1° Trimestre",
            "2° Trimestre",
            "3° Trimestre",
            "4° Trimestre"});
            this.trimestreComboBox.Location = new System.Drawing.Point(12, 121);
            this.trimestreComboBox.Name = "trimestreComboBox";
            this.trimestreComboBox.Size = new System.Drawing.Size(121, 28);
            this.trimestreComboBox.TabIndex = 2;
            // 
            // anioNumericUpDown
            // 
            this.anioNumericUpDown.Location = new System.Drawing.Point(169, 121);
            this.anioNumericUpDown.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.anioNumericUpDown.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.anioNumericUpDown.Name = "anioNumericUpDown";
            this.anioNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.anioNumericUpDown.TabIndex = 3;
            this.anioNumericUpDown.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // consultarButton
            // 
            this.consultarButton.Location = new System.Drawing.Point(337, 121);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(122, 28);
            this.consultarButton.TabIndex = 4;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // estadisticaComboBox
            // 
            this.estadisticaComboBox.FormattingEnabled = true;
            this.estadisticaComboBox.Items.AddRange(new object[] {
            "Vendedores con mayor cantidad de productos no vendidos",
            "Clientes con mayor cantidad de productos comprados",
            "Vendedores con mayor cantidad de facturas",
            "Vendedores con mayor monto facturado"});
            this.estadisticaComboBox.Location = new System.Drawing.Point(12, 66);
            this.estadisticaComboBox.Name = "estadisticaComboBox";
            this.estadisticaComboBox.Size = new System.Drawing.Size(447, 28);
            this.estadisticaComboBox.TabIndex = 5;
            this.estadisticaComboBox.SelectedIndexChanged += new System.EventHandler(this.estadisticaComboBox_SelectedIndexChanged);
            this.estadisticaComboBox.SelectedValueChanged += new System.EventHandler(this.ListadoEstadistico_Load);
            // 
            // visibilidadComboBox
            // 
            this.visibilidadComboBox.DataSource = this.visibilidadesPublicacionesBindingSource;
            this.visibilidadComboBox.DisplayMember = "Descripcion_Visibilidad";
            this.visibilidadComboBox.FormattingEnabled = true;
            this.visibilidadComboBox.Location = new System.Drawing.Point(15, 166);
            this.visibilidadComboBox.Name = "visibilidadComboBox";
            this.visibilidadComboBox.Size = new System.Drawing.Size(211, 28);
            this.visibilidadComboBox.TabIndex = 6;
            this.visibilidadComboBox.ValueMember = "Descripcion_Visibilidad";
            this.visibilidadComboBox.Visible = false;
            // 
            // visibilidadesPublicacionesBindingSource
            // 
            this.visibilidadesPublicacionesBindingSource.DataMember = "Visibilidades_Publicaciones";
            this.visibilidadesPublicacionesBindingSource.DataSource = this.gD1C2016DataSet7;
            // 
            // gD1C2016DataSet7
            // 
            this.gD1C2016DataSet7.DataSetName = "GD1C2016DataSet7";
            this.gD1C2016DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubroComboBox
            // 
            this.rubroComboBox.DataSource = this.rubrosBindingSource;
            this.rubroComboBox.DisplayMember = "Descripcion_Rubro";
            this.rubroComboBox.FormattingEnabled = true;
            this.rubroComboBox.Location = new System.Drawing.Point(242, 166);
            this.rubroComboBox.Name = "rubroComboBox";
            this.rubroComboBox.Size = new System.Drawing.Size(217, 28);
            this.rubroComboBox.TabIndex = 7;
            this.rubroComboBox.ValueMember = "Descripcion_Rubro";
            this.rubroComboBox.Visible = false;
            // 
            // rubrosBindingSource
            // 
            this.rubrosBindingSource.DataMember = "Rubros";
            this.rubrosBindingSource.DataSource = this.gD1C2016DataSet8;
            // 
            // gD1C2016DataSet8
            // 
            this.gD1C2016DataSet8.DataSetName = "GD1C2016DataSet8";
            this.gD1C2016DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visibilidades_PublicacionesTableAdapter
            // 
            this.visibilidades_PublicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // rubrosTableAdapter
            // 
            this.rubrosTableAdapter.ClearBeforeFill = true;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 496);
            this.Controls.Add(this.rubroComboBox);
            this.Controls.Add(this.visibilidadComboBox);
            this.Controls.Add(this.estadisticaComboBox);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.anioNumericUpDown);
            this.Controls.Add(this.trimestreComboBox);
            this.Controls.Add(this.estadisticaDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadistico";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadesPublicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView estadisticaDataGridView;
        private System.Windows.Forms.ComboBox trimestreComboBox;
        private System.Windows.Forms.NumericUpDown anioNumericUpDown;
        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.ComboBox estadisticaComboBox;
        private System.Windows.Forms.ComboBox visibilidadComboBox;
        private System.Windows.Forms.ComboBox rubroComboBox;
        private GD1C2016DataSet7 gD1C2016DataSet7;
        private System.Windows.Forms.BindingSource visibilidadesPublicacionesBindingSource;
        private GD1C2016DataSet7TableAdapters.Visibilidades_PublicacionesTableAdapter visibilidades_PublicacionesTableAdapter;
        private GD1C2016DataSet8 gD1C2016DataSet8;
        private System.Windows.Forms.BindingSource rubrosBindingSource;
        private GD1C2016DataSet8TableAdapters.RubrosTableAdapter rubrosTableAdapter;
    }
}