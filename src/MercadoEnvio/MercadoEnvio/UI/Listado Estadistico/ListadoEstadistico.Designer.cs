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
            this.label1 = new System.Windows.Forms.Label();
            this.estadisticaDataGridView = new System.Windows.Forms.DataGridView();
            this.trimestreComboBox = new System.Windows.Forms.ComboBox();
            this.anioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.consultarButton = new System.Windows.Forms.Button();
            this.estadisticaComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioNumericUpDown)).BeginInit();
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
            this.estadisticaDataGridView.Location = new System.Drawing.Point(12, 166);
            this.estadisticaDataGridView.Name = "estadisticaDataGridView";
            this.estadisticaDataGridView.RowTemplate.Height = 28;
            this.estadisticaDataGridView.Size = new System.Drawing.Size(447, 243);
            this.estadisticaDataGridView.TabIndex = 1;
            // 
            // trimestreComboBox
            // 
            this.trimestreComboBox.FormattingEnabled = true;
            this.trimestreComboBox.Items.AddRange(new object[] {
            "1° Semestre",
            "2° Semestre"});
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
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 421);
            this.Controls.Add(this.estadisticaComboBox);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.anioNumericUpDown);
            this.Controls.Add(this.trimestreComboBox);
            this.Controls.Add(this.estadisticaDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "ListadoEstadistico";
            this.Text = "Listado Estadistico";
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioNumericUpDown)).EndInit();
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
    }
}