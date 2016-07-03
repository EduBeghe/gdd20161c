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
            this.button1 = new System.Windows.Forms.Button();
            this.gD1C2016DataSet15 = new MercadoEnvio.GD1C2016DataSet15();
            this.publicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicacionesTableAdapter = new MercadoEnvio.GD1C2016DataSet15TableAdapters.PublicacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // publicacionesDataGridView
            // 
            this.publicacionesDataGridView.AllowUserToAddRows = false;
            this.publicacionesDataGridView.AllowUserToDeleteRows = false;
            this.publicacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publicacionesDataGridView.Location = new System.Drawing.Point(12, 195);
            this.publicacionesDataGridView.Name = "publicacionesDataGridView";
            this.publicacionesDataGridView.ReadOnly = true;
            this.publicacionesDataGridView.RowTemplate.Height = 28;
            this.publicacionesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.publicacionesDataGridView.Size = new System.Drawing.Size(523, 275);
            this.publicacionesDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(523, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modificar Publicacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // ListadoPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.publicacionesDataGridView);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button button1;
        private GD1C2016DataSet15 gD1C2016DataSet15;
        private System.Windows.Forms.BindingSource publicacionesBindingSource;
        private GD1C2016DataSet15TableAdapters.PublicacionesTableAdapter publicacionesTableAdapter;
    }
}