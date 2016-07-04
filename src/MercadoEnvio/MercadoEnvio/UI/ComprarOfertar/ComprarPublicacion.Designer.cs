namespace MercadoEnvio.UI.ComprarOfertar
{
    partial class ComprarPublicacion
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
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.FormaDePagoComboBox = new System.Windows.Forms.ComboBox();
            this.formasDePagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gD1C2016DataSet17 = new MercadoEnvio.GD1C2016DataSet17();
            this.formasDePagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formas_De_PagoTableAdapter = new MercadoEnvio.GD1C2016DataSet17TableAdapters.Formas_De_PagoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.formasDePagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasDePagoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(117, 37);
            this.cantidadTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(145, 20);
            this.cantidadTextBox.TabIndex = 0;
            this.cantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadTextBox_KeyPress);
            // 
            // FormaDePagoComboBox
            // 
            this.FormaDePagoComboBox.DataSource = this.formasDePagoBindingSource1;
            this.FormaDePagoComboBox.DisplayMember = "Descripcion_Forma";
            this.FormaDePagoComboBox.FormattingEnabled = true;
            this.FormaDePagoComboBox.Location = new System.Drawing.Point(117, 68);
            this.FormaDePagoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FormaDePagoComboBox.Name = "FormaDePagoComboBox";
            this.FormaDePagoComboBox.Size = new System.Drawing.Size(145, 21);
            this.FormaDePagoComboBox.TabIndex = 1;
            this.FormaDePagoComboBox.ValueMember = "Descripcion_Forma";
            // 
            // formasDePagoBindingSource
            // 
            this.formasDePagoBindingSource.DataMember = "Formas_De_Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comprar Publicacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Forma de Pago";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirmar Compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gD1C2016DataSet17
            // 
            this.gD1C2016DataSet17.DataSetName = "GD1C2016DataSet17";
            this.gD1C2016DataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formasDePagoBindingSource1
            // 
            this.formasDePagoBindingSource1.DataMember = "Formas_De_Pago";
            this.formasDePagoBindingSource1.DataSource = this.gD1C2016DataSet17;
            // 
            // formas_De_PagoTableAdapter
            // 
            this.formas_De_PagoTableAdapter.ClearBeforeFill = true;
            // 
            // ComprarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormaDePagoComboBox);
            this.Controls.Add(this.cantidadTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ComprarPublicacion";
            this.Text = "ComprarPublicacion";
            this.Load += new System.EventHandler(this.ComprarPublicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formasDePagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formasDePagoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.ComboBox FormaDePagoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource formasDePagoBindingSource;
        private GD1C2016DataSet17 gD1C2016DataSet17;
        private System.Windows.Forms.BindingSource formasDePagoBindingSource1;
        private GD1C2016DataSet17TableAdapters.Formas_De_PagoTableAdapter formas_De_PagoTableAdapter;
    }
}