namespace MercadoEnvio.ComprarOfertar
{
    partial class ComprarOfertar
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
            this.publicacionesGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gD1C2016DataSet2 = new MercadoEnvio.GD1C2016DataSet2();
            this.publicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicacionesTableAdapter = new MercadoEnvio.GD1C2016DataSet2TableAdapters.PublicacionesTableAdapter();
            this.codPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPublicacionAnteriorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTiposPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codRubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVisibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUsuarioResponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEstadoPublicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisoPreguntasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.entregasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comprar/Ofertar";
            // 
            // publicacionesGrid
            // 
            this.publicacionesGrid.AutoGenerateColumns = false;
            this.publicacionesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publicacionesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPublicacionDataGridViewTextBoxColumn,
            this.codPublicacionAnteriorDataGridViewTextBoxColumn,
            this.descripcionPublicacionDataGridViewTextBoxColumn,
            this.stockPublicacionDataGridViewTextBoxColumn,
            this.fechaPublicacionDataGridViewTextBoxColumn,
            this.fechaVencimientoPublicacionDataGridViewTextBoxColumn,
            this.precioPublicacionDataGridViewTextBoxColumn,
            this.codTiposPublicacionDataGridViewTextBoxColumn,
            this.codRubroDataGridViewTextBoxColumn,
            this.codVisibilidadDataGridViewTextBoxColumn,
            this.costoPublicacionDataGridViewTextBoxColumn,
            this.codUsuarioResponsableDataGridViewTextBoxColumn,
            this.codEstadoPublicacionDataGridViewTextBoxColumn,
            this.permisoPreguntasDataGridViewCheckBoxColumn,
            this.entregasDataGridViewCheckBoxColumn});
            this.publicacionesGrid.DataSource = this.publicacionesBindingSource;
            this.publicacionesGrid.Location = new System.Drawing.Point(34, 203);
            this.publicacionesGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.publicacionesGrid.Name = "publicacionesGrid";
            this.publicacionesGrid.Size = new System.Drawing.Size(608, 354);
            this.publicacionesGrid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 591);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 591);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ofertar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 158);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Filtrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 80);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 26);
            this.textBox1.TabIndex = 6;
            // 
            // gD1C2016DataSet2
            // 
            this.gD1C2016DataSet2.DataSetName = "GD1C2016DataSet2";
            this.gD1C2016DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publicacionesBindingSource
            // 
            this.publicacionesBindingSource.DataMember = "Publicaciones";
            this.publicacionesBindingSource.DataSource = this.gD1C2016DataSet2;
            // 
            // publicacionesTableAdapter
            // 
            this.publicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // codPublicacionDataGridViewTextBoxColumn
            // 
            this.codPublicacionDataGridViewTextBoxColumn.DataPropertyName = "Cod_Publicacion";
            this.codPublicacionDataGridViewTextBoxColumn.HeaderText = "Cod_Publicacion";
            this.codPublicacionDataGridViewTextBoxColumn.Name = "codPublicacionDataGridViewTextBoxColumn";
            this.codPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codPublicacionAnteriorDataGridViewTextBoxColumn
            // 
            this.codPublicacionAnteriorDataGridViewTextBoxColumn.DataPropertyName = "Cod_Publicacion_Anterior";
            this.codPublicacionAnteriorDataGridViewTextBoxColumn.HeaderText = "Cod_Publicacion_Anterior";
            this.codPublicacionAnteriorDataGridViewTextBoxColumn.Name = "codPublicacionAnteriorDataGridViewTextBoxColumn";
            // 
            // descripcionPublicacionDataGridViewTextBoxColumn
            // 
            this.descripcionPublicacionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Publicacion";
            this.descripcionPublicacionDataGridViewTextBoxColumn.HeaderText = "Descripcion_Publicacion";
            this.descripcionPublicacionDataGridViewTextBoxColumn.Name = "descripcionPublicacionDataGridViewTextBoxColumn";
            // 
            // stockPublicacionDataGridViewTextBoxColumn
            // 
            this.stockPublicacionDataGridViewTextBoxColumn.DataPropertyName = "Stock_Publicacion";
            this.stockPublicacionDataGridViewTextBoxColumn.HeaderText = "Stock_Publicacion";
            this.stockPublicacionDataGridViewTextBoxColumn.Name = "stockPublicacionDataGridViewTextBoxColumn";
            // 
            // fechaPublicacionDataGridViewTextBoxColumn
            // 
            this.fechaPublicacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Publicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.HeaderText = "Fecha_Publicacion";
            this.fechaPublicacionDataGridViewTextBoxColumn.Name = "fechaPublicacionDataGridViewTextBoxColumn";
            // 
            // fechaVencimientoPublicacionDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoPublicacionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Vencimiento_Publicacion";
            this.fechaVencimientoPublicacionDataGridViewTextBoxColumn.HeaderText = "Fecha_Vencimiento_Publicacion";
            this.fechaVencimientoPublicacionDataGridViewTextBoxColumn.Name = "fechaVencimientoPublicacionDataGridViewTextBoxColumn";
            // 
            // precioPublicacionDataGridViewTextBoxColumn
            // 
            this.precioPublicacionDataGridViewTextBoxColumn.DataPropertyName = "Precio_Publicacion";
            this.precioPublicacionDataGridViewTextBoxColumn.HeaderText = "Precio_Publicacion";
            this.precioPublicacionDataGridViewTextBoxColumn.Name = "precioPublicacionDataGridViewTextBoxColumn";
            // 
            // codTiposPublicacionDataGridViewTextBoxColumn
            // 
            this.codTiposPublicacionDataGridViewTextBoxColumn.DataPropertyName = "Cod_Tipos_Publicacion";
            this.codTiposPublicacionDataGridViewTextBoxColumn.HeaderText = "Cod_Tipos_Publicacion";
            this.codTiposPublicacionDataGridViewTextBoxColumn.Name = "codTiposPublicacionDataGridViewTextBoxColumn";
            // 
            // codRubroDataGridViewTextBoxColumn
            // 
            this.codRubroDataGridViewTextBoxColumn.DataPropertyName = "Cod_Rubro";
            this.codRubroDataGridViewTextBoxColumn.HeaderText = "Cod_Rubro";
            this.codRubroDataGridViewTextBoxColumn.Name = "codRubroDataGridViewTextBoxColumn";
            // 
            // codVisibilidadDataGridViewTextBoxColumn
            // 
            this.codVisibilidadDataGridViewTextBoxColumn.DataPropertyName = "Cod_Visibilidad";
            this.codVisibilidadDataGridViewTextBoxColumn.HeaderText = "Cod_Visibilidad";
            this.codVisibilidadDataGridViewTextBoxColumn.Name = "codVisibilidadDataGridViewTextBoxColumn";
            // 
            // costoPublicacionDataGridViewTextBoxColumn
            // 
            this.costoPublicacionDataGridViewTextBoxColumn.DataPropertyName = "Costo_Publicacion";
            this.costoPublicacionDataGridViewTextBoxColumn.HeaderText = "Costo_Publicacion";
            this.costoPublicacionDataGridViewTextBoxColumn.Name = "costoPublicacionDataGridViewTextBoxColumn";
            // 
            // codUsuarioResponsableDataGridViewTextBoxColumn
            // 
            this.codUsuarioResponsableDataGridViewTextBoxColumn.DataPropertyName = "Cod_Usuario_Responsable";
            this.codUsuarioResponsableDataGridViewTextBoxColumn.HeaderText = "Cod_Usuario_Responsable";
            this.codUsuarioResponsableDataGridViewTextBoxColumn.Name = "codUsuarioResponsableDataGridViewTextBoxColumn";
            // 
            // codEstadoPublicacionDataGridViewTextBoxColumn
            // 
            this.codEstadoPublicacionDataGridViewTextBoxColumn.DataPropertyName = "Cod_Estado_Publicacion";
            this.codEstadoPublicacionDataGridViewTextBoxColumn.HeaderText = "Cod_Estado_Publicacion";
            this.codEstadoPublicacionDataGridViewTextBoxColumn.Name = "codEstadoPublicacionDataGridViewTextBoxColumn";
            // 
            // permisoPreguntasDataGridViewCheckBoxColumn
            // 
            this.permisoPreguntasDataGridViewCheckBoxColumn.DataPropertyName = "Permiso_Preguntas";
            this.permisoPreguntasDataGridViewCheckBoxColumn.HeaderText = "Permiso_Preguntas";
            this.permisoPreguntasDataGridViewCheckBoxColumn.Name = "permisoPreguntasDataGridViewCheckBoxColumn";
            // 
            // entregasDataGridViewCheckBoxColumn
            // 
            this.entregasDataGridViewCheckBoxColumn.DataPropertyName = "Entregas";
            this.entregasDataGridViewCheckBoxColumn.HeaderText = "Entregas";
            this.entregasDataGridViewCheckBoxColumn.Name = "entregasDataGridViewCheckBoxColumn";
            // 
            // ComprarOfertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 645);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.publicacionesGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ComprarOfertar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView publicacionesGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private GD1C2016DataSet2 gD1C2016DataSet2;
        private System.Windows.Forms.BindingSource publicacionesBindingSource;
        private GD1C2016DataSet2TableAdapters.PublicacionesTableAdapter publicacionesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPublicacionAnteriorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTiposPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codRubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVisibilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUsuarioResponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEstadoPublicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permisoPreguntasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn entregasDataGridViewCheckBoxColumn;
    }
}