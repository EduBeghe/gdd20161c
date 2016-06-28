namespace MercadoEnvio.UI.ABM_Visibilidad
{
    partial class ListadoVisibilidad
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
            this.nobreTextBox = new System.Windows.Forms.TextBox();
            this.visibilidadesGrid = new System.Windows.Forms.DataGridView();
            this.codVisibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionVisibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVisibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comisionEntregasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoVisibilidadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.visibilidadesPublicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2016DataSet1 = new MercadoEnvio.GD1C2016DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.visibilidades_PublicacionesTableAdapter = new MercadoEnvio.GD1C2016DataSet1TableAdapters.Visibilidades_PublicacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadesPublicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visibilidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Visibilidad";
            // 
            // nobreTextBox
            // 
            this.nobreTextBox.Location = new System.Drawing.Point(252, 92);
            this.nobreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nobreTextBox.Name = "nobreTextBox";
            this.nobreTextBox.Size = new System.Drawing.Size(348, 26);
            this.nobreTextBox.TabIndex = 2;
            // 
            // visibilidadesGrid
            // 
            this.visibilidadesGrid.AllowUserToAddRows = false;
            this.visibilidadesGrid.AllowUserToDeleteRows = false;
            this.visibilidadesGrid.AutoGenerateColumns = false;
            this.visibilidadesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visibilidadesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codVisibilidadDataGridViewTextBoxColumn,
            this.descripcionVisibilidadDataGridViewTextBoxColumn,
            this.precioVisibilidadDataGridViewTextBoxColumn,
            this.porcentajeDataGridViewTextBoxColumn,
            this.comisionEntregasDataGridViewTextBoxColumn,
            this.estadoVisibilidadDataGridViewCheckBoxColumn});
            this.visibilidadesGrid.DataSource = this.visibilidadesPublicacionesBindingSource;
            this.visibilidadesGrid.Location = new System.Drawing.Point(44, 198);
            this.visibilidadesGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.visibilidadesGrid.MultiSelect = false;
            this.visibilidadesGrid.Name = "visibilidadesGrid";
            this.visibilidadesGrid.ReadOnly = true;
            this.visibilidadesGrid.Size = new System.Drawing.Size(558, 337);
            this.visibilidadesGrid.TabIndex = 3;
            this.visibilidadesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visibilidadesGrid_CellContentClick);
            // 
            // codVisibilidadDataGridViewTextBoxColumn
            // 
            this.codVisibilidadDataGridViewTextBoxColumn.DataPropertyName = "Cod_Visibilidad";
            this.codVisibilidadDataGridViewTextBoxColumn.HeaderText = "Cod_Visibilidad";
            this.codVisibilidadDataGridViewTextBoxColumn.Name = "codVisibilidadDataGridViewTextBoxColumn";
            this.codVisibilidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionVisibilidadDataGridViewTextBoxColumn
            // 
            this.descripcionVisibilidadDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Visibilidad";
            this.descripcionVisibilidadDataGridViewTextBoxColumn.HeaderText = "Descripcion_Visibilidad";
            this.descripcionVisibilidadDataGridViewTextBoxColumn.Name = "descripcionVisibilidadDataGridViewTextBoxColumn";
            this.descripcionVisibilidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioVisibilidadDataGridViewTextBoxColumn
            // 
            this.precioVisibilidadDataGridViewTextBoxColumn.DataPropertyName = "Precio_Visibilidad";
            this.precioVisibilidadDataGridViewTextBoxColumn.HeaderText = "Precio_Visibilidad";
            this.precioVisibilidadDataGridViewTextBoxColumn.Name = "precioVisibilidadDataGridViewTextBoxColumn";
            this.precioVisibilidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcentajeDataGridViewTextBoxColumn
            // 
            this.porcentajeDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje";
            this.porcentajeDataGridViewTextBoxColumn.HeaderText = "Porcentaje";
            this.porcentajeDataGridViewTextBoxColumn.Name = "porcentajeDataGridViewTextBoxColumn";
            this.porcentajeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comisionEntregasDataGridViewTextBoxColumn
            // 
            this.comisionEntregasDataGridViewTextBoxColumn.DataPropertyName = "Comision_Entregas";
            this.comisionEntregasDataGridViewTextBoxColumn.HeaderText = "Comision_Entregas";
            this.comisionEntregasDataGridViewTextBoxColumn.Name = "comisionEntregasDataGridViewTextBoxColumn";
            this.comisionEntregasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoVisibilidadDataGridViewCheckBoxColumn
            // 
            this.estadoVisibilidadDataGridViewCheckBoxColumn.DataPropertyName = "Estado_Visibilidad";
            this.estadoVisibilidadDataGridViewCheckBoxColumn.HeaderText = "Estado_Visibilidad";
            this.estadoVisibilidadDataGridViewCheckBoxColumn.Name = "estadoVisibilidadDataGridViewCheckBoxColumn";
            this.estadoVisibilidadDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // visibilidadesPublicacionesBindingSource
            // 
            this.visibilidadesPublicacionesBindingSource.DataMember = "Visibilidades_Publicaciones";
            this.visibilidadesPublicacionesBindingSource.DataSource = this.gD1C2016DataSet1;
            // 
            // gD1C2016DataSet1
            // 
            this.gD1C2016DataSet1.DataSetName = "GD1C2016DataSet1";
            this.gD1C2016DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 598);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 598);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Inhabilitar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // visibilidades_PublicacionesTableAdapter
            // 
            this.visibilidades_PublicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // ListadoVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 652);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.visibilidadesGrid);
            this.Controls.Add(this.nobreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListadoVisibilidad";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadesPublicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nobreTextBox;
        private System.Windows.Forms.DataGridView visibilidadesGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private GD1C2016DataSet1 gD1C2016DataSet1;
        private System.Windows.Forms.BindingSource visibilidadesPublicacionesBindingSource;
        private GD1C2016DataSet1TableAdapters.Visibilidades_PublicacionesTableAdapter visibilidades_PublicacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVisibilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionVisibilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVisibilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisionEntregasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoVisibilidadDataGridViewCheckBoxColumn;
    }
}