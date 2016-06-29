namespace MercadoEnvio.UI.ABM_Usuario
{
    partial class BuscadorEmpresas
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
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cuitTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.empresasGrid = new System.Windows.Forms.DataGridView();
            this.gD1C2016DataSet5 = new MercadoEnvio.GD1C2016DataSet5();
            this.detallesEmpresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalles_EmpresasTableAdapter = new MercadoEnvio.GD1C2016DataSet5TableAdapters.Detalles_EmpresasTableAdapter();
            this.codEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDomicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codRubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoEmpresaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empresasGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesEmpresasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscador de Empresas";
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.Location = new System.Drawing.Point(138, 81);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(282, 20);
            this.razonSocialTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CUIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // cuitTextBox
            // 
            this.cuitTextBox.Location = new System.Drawing.Point(138, 107);
            this.cuitTextBox.Name = "cuitTextBox";
            this.cuitTextBox.Size = new System.Drawing.Size(282, 20);
            this.cuitTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(138, 133);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(281, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // empresasGrid
            // 
            this.empresasGrid.AutoGenerateColumns = false;
            this.empresasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empresasGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEmpresaDataGridViewTextBoxColumn,
            this.codUsuarioDataGridViewTextBoxColumn,
            this.razonSocialDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.codDomicilioDataGridViewTextBoxColumn,
            this.codPostalDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.cUITDataGridViewTextBoxColumn,
            this.codRubroDataGridViewTextBoxColumn,
            this.estadoEmpresaDataGridViewCheckBoxColumn});
            this.empresasGrid.DataSource = this.detallesEmpresasBindingSource;
            this.empresasGrid.Location = new System.Drawing.Point(12, 213);
            this.empresasGrid.Name = "empresasGrid";
            this.empresasGrid.Size = new System.Drawing.Size(433, 126);
            this.empresasGrid.TabIndex = 7;
            // 
            // gD1C2016DataSet5
            // 
            this.gD1C2016DataSet5.DataSetName = "GD1C2016DataSet5";
            this.gD1C2016DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detallesEmpresasBindingSource
            // 
            this.detallesEmpresasBindingSource.DataMember = "Detalles_Empresas";
            this.detallesEmpresasBindingSource.DataSource = this.gD1C2016DataSet5;
            // 
            // detalles_EmpresasTableAdapter
            // 
            this.detalles_EmpresasTableAdapter.ClearBeforeFill = true;
            // 
            // codEmpresaDataGridViewTextBoxColumn
            // 
            this.codEmpresaDataGridViewTextBoxColumn.DataPropertyName = "Cod_Empresa";
            this.codEmpresaDataGridViewTextBoxColumn.HeaderText = "Cod_Empresa";
            this.codEmpresaDataGridViewTextBoxColumn.Name = "codEmpresaDataGridViewTextBoxColumn";
            this.codEmpresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codUsuarioDataGridViewTextBoxColumn
            // 
            this.codUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Cod_Usuario";
            this.codUsuarioDataGridViewTextBoxColumn.HeaderText = "Cod_Usuario";
            this.codUsuarioDataGridViewTextBoxColumn.Name = "codUsuarioDataGridViewTextBoxColumn";
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "Razon_Social";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "Razon_Social";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // codDomicilioDataGridViewTextBoxColumn
            // 
            this.codDomicilioDataGridViewTextBoxColumn.DataPropertyName = "Cod_Domicilio";
            this.codDomicilioDataGridViewTextBoxColumn.HeaderText = "Cod_Domicilio";
            this.codDomicilioDataGridViewTextBoxColumn.Name = "codDomicilioDataGridViewTextBoxColumn";
            // 
            // codPostalDataGridViewTextBoxColumn
            // 
            this.codPostalDataGridViewTextBoxColumn.DataPropertyName = "Cod_Postal";
            this.codPostalDataGridViewTextBoxColumn.HeaderText = "Cod_Postal";
            this.codPostalDataGridViewTextBoxColumn.Name = "codPostalDataGridViewTextBoxColumn";
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            // 
            // cUITDataGridViewTextBoxColumn
            // 
            this.cUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT";
            this.cUITDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cUITDataGridViewTextBoxColumn.Name = "cUITDataGridViewTextBoxColumn";
            // 
            // codRubroDataGridViewTextBoxColumn
            // 
            this.codRubroDataGridViewTextBoxColumn.DataPropertyName = "Cod_Rubro";
            this.codRubroDataGridViewTextBoxColumn.HeaderText = "Cod_Rubro";
            this.codRubroDataGridViewTextBoxColumn.Name = "codRubroDataGridViewTextBoxColumn";
            // 
            // estadoEmpresaDataGridViewCheckBoxColumn
            // 
            this.estadoEmpresaDataGridViewCheckBoxColumn.DataPropertyName = "Estado_Empresa";
            this.estadoEmpresaDataGridViewCheckBoxColumn.HeaderText = "Estado_Empresa";
            this.estadoEmpresaDataGridViewCheckBoxColumn.Name = "estadoEmpresaDataGridViewCheckBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "Inhabilitar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BuscadorEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 381);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.empresasGrid);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.cuitTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.razonSocialTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BuscadorEmpresas";
            this.Text = "BuscadorEmpresas";
            this.Load += new System.EventHandler(this.BuscadorEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresasGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesEmpresasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cuitTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DataGridView empresasGrid;
        private GD1C2016DataSet5 gD1C2016DataSet5;
        private System.Windows.Forms.BindingSource detallesEmpresasBindingSource;
        private GD1C2016DataSet5TableAdapters.Detalles_EmpresasTableAdapter detalles_EmpresasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDomicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codRubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoEmpresaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}