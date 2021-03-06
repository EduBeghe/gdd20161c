﻿namespace MercadoEnvio.UI.ABM_Rol
{
    partial class Listado
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
            this.rolesList = new System.Windows.Forms.DataGridView();
            this.codRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoRolDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2016DataSet = new MercadoEnvio.GD1C2016DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rolesTableAdapter = new MercadoEnvio.GD1C2016DataSetTableAdapters.RolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rolesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rolesList
            // 
            this.rolesList.AllowUserToAddRows = false;
            this.rolesList.AllowUserToDeleteRows = false;
            this.rolesList.AutoGenerateColumns = false;
            this.rolesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codRolDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.estadoRolDataGridViewCheckBoxColumn});
            this.rolesList.DataSource = this.rolesBindingSource;
            this.rolesList.Location = new System.Drawing.Point(8, 88);
            this.rolesList.Margin = new System.Windows.Forms.Padding(2);
            this.rolesList.MultiSelect = false;
            this.rolesList.Name = "rolesList";
            this.rolesList.ReadOnly = true;
            this.rolesList.RowTemplate.Height = 28;
            this.rolesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesList.Size = new System.Drawing.Size(352, 216);
            this.rolesList.TabIndex = 0;
            // 
            // codRolDataGridViewTextBoxColumn
            // 
            this.codRolDataGridViewTextBoxColumn.DataPropertyName = "Cod_Rol";
            this.codRolDataGridViewTextBoxColumn.HeaderText = "Cod_Rol";
            this.codRolDataGridViewTextBoxColumn.Name = "codRolDataGridViewTextBoxColumn";
            this.codRolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoRolDataGridViewCheckBoxColumn
            // 
            this.estadoRolDataGridViewCheckBoxColumn.DataPropertyName = "Estado_Rol";
            this.estadoRolDataGridViewCheckBoxColumn.HeaderText = "Estado_Rol";
            this.estadoRolDataGridViewCheckBoxColumn.Name = "estadoRolDataGridViewCheckBoxColumn";
            this.estadoRolDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.gD1C2016DataSet;
            // 
            // gD1C2016DataSet
            // 
            this.gD1C2016DataSet.DataSetName = "GD1C2016DataSet";
            this.gD1C2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dar de Baja Rol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 308);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Rol";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Roles";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(143, 36);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(217, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 61);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 338);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rolesList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Listado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rolesList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button button3;
        private GD1C2016DataSet gD1C2016DataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private GD1C2016DataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoRolDataGridViewCheckBoxColumn;
    }
}