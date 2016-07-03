namespace MercadoEnvio.ComprarOfertar
{
    partial class ListadoComprarOfertar
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.publicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
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
            this.publicacionesGrid.Location = new System.Drawing.Point(24, 240);
            this.publicacionesGrid.Name = "publicacionesGrid";
            this.publicacionesGrid.Size = new System.Drawing.Size(405, 228);
            this.publicacionesGrid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ofertar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Filtrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripcion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rubro";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rubro";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(280, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rubro";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(279, 20);
            this.textBox4.TabIndex = 12;
            // 
            // gD1C2016DataSet15
            // 
            // 
            // publicacionesBindingSource
            // 
            // 
            // publicacionesTableAdapter
            // 
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
            // ListadoComprarOfertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 518);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.publicacionesGrid);
            this.Controls.Add(this.label1);
            this.Name = "ListadoComprarOfertar";
            this.Text = "Comprar y Ofertar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesGrid)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.BindingSource publicacionesBindingSource;
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