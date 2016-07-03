namespace MercadoEnvio.UI.Generar_Publicación
{
    partial class ListadoPublicaciones
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
            this.publicacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.modificarButton = new System.Windows.Forms.Button();
            this.gD1C2016DataSet15 = new MercadoEnvio.GD1C2016DataSet15();
            this.publicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicacionesTableAdapter = new MercadoEnvio.GD1C2016DataSet15TableAdapters.PublicacionesTableAdapter();
            this.activarButton = new System.Windows.Forms.Button();
            this.finalizarButton = new System.Windows.Forms.Button();
            this.pausarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Publicaciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // publicacionesDataGridView
            // 
            this.publicacionesDataGridView.AllowUserToAddRows = false;
            this.publicacionesDataGridView.AllowUserToDeleteRows = false;
            this.publicacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publicacionesDataGridView.Location = new System.Drawing.Point(8, 42);
            this.publicacionesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.publicacionesDataGridView.MultiSelect = false;
            this.publicacionesDataGridView.Name = "publicacionesDataGridView";
            this.publicacionesDataGridView.ReadOnly = true;
            this.publicacionesDataGridView.RowTemplate.Height = 28;
            this.publicacionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.publicacionesDataGridView.Size = new System.Drawing.Size(596, 179);
            this.publicacionesDataGridView.TabIndex = 1;
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(8, 225);
            this.modificarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(146, 27);
            this.modificarButton.TabIndex = 2;
            this.modificarButton.Text = "Modificar Publicacion";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gD1C2016DataSet15
            // 
            this.gD1C2016DataSet15.DataSetName = "GD1C2016DataSet15";
            this.gD1C2016DataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publicacionesBindingSource
            // 
            this.publicacionesBindingSource.DataMember = "Publicaciones";
            this.publicacionesBindingSource.DataSource = this.gD1C2016DataSet15;
            // 
            // publicacionesTableAdapter
            // 
            this.publicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // activarButton
            // 
            this.activarButton.Location = new System.Drawing.Point(158, 225);
            this.activarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activarButton.Name = "activarButton";
            this.activarButton.Size = new System.Drawing.Size(146, 27);
            this.activarButton.TabIndex = 3;
            this.activarButton.Text = "Activar Publicacion";
            this.activarButton.UseVisualStyleBackColor = true;
            // 
            // finalizarButton
            // 
            this.finalizarButton.Location = new System.Drawing.Point(308, 225);
            this.finalizarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.finalizarButton.Name = "finalizarButton";
            this.finalizarButton.Size = new System.Drawing.Size(146, 27);
            this.finalizarButton.TabIndex = 4;
            this.finalizarButton.Text = "Finalizar Publicacion";
            this.finalizarButton.UseVisualStyleBackColor = true;
            // 
            // pausarButton
            // 
            this.pausarButton.Location = new System.Drawing.Point(458, 225);
            this.pausarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pausarButton.Name = "pausarButton";
            this.pausarButton.Size = new System.Drawing.Size(146, 27);
            this.pausarButton.TabIndex = 5;
            this.pausarButton.Text = "Pausar Publicacion";
            this.pausarButton.UseVisualStyleBackColor = true;
            // 
            // ListadoPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 259);
            this.Controls.Add(this.pausarButton);
            this.Controls.Add(this.finalizarButton);
            this.Controls.Add(this.activarButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.publicacionesDataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListadoPublicaciones";
            this.Text = "ListadoPublicaciones";
            this.Load += new System.EventHandler(this.ListadoPublicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView publicacionesDataGridView;
        private System.Windows.Forms.Button modificarButton;
        private GD1C2016DataSet15 gD1C2016DataSet15;
        private System.Windows.Forms.BindingSource publicacionesBindingSource;
        private GD1C2016DataSet15TableAdapters.PublicacionesTableAdapter publicacionesTableAdapter;
        private System.Windows.Forms.Button activarButton;
        private System.Windows.Forms.Button finalizarButton;
        private System.Windows.Forms.Button pausarButton;
    }
}