
namespace EJ.PlazoFijo.GUI
{
    partial class FormPlazoFijo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoPF = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTasaInt = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lstPlazoFijo = new System.Windows.Forms.ListBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlta);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnSimular);
            this.groupBox1.Controls.Add(this.txtMontoFinal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtInteres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCapital);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTasaInt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTipoPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComTotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMontoTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lstPlazoFijo);
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 365);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PLAZOS FIJOS DADOS DE ALTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Plazo Fijo";
            // 
            // cmbTipoPF
            // 
            this.cmbTipoPF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPF.FormattingEnabled = true;
            this.cmbTipoPF.Location = new System.Drawing.Point(133, 38);
            this.cmbTipoPF.Name = "cmbTipoPF";
            this.cmbTipoPF.Size = new System.Drawing.Size(140, 21);
            this.cmbTipoPF.TabIndex = 1;
            this.cmbTipoPF.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPF_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tasa Interés";
            // 
            // txtTasaInt
            // 
            this.txtTasaInt.Enabled = false;
            this.txtTasaInt.Location = new System.Drawing.Point(133, 70);
            this.txtTasaInt.Name = "txtTasaInt";
            this.txtTasaInt.ReadOnly = true;
            this.txtTasaInt.Size = new System.Drawing.Size(140, 20);
            this.txtTasaInt.TabIndex = 3;
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(133, 108);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(140, 20);
            this.txtCapital.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capital a invertir";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(133, 143);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(140, 20);
            this.txtDias.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Días";
            // 
            // txtInteres
            // 
            this.txtInteres.Enabled = false;
            this.txtInteres.Location = new System.Drawing.Point(133, 179);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.ReadOnly = true;
            this.txtInteres.Size = new System.Drawing.Size(140, 20);
            this.txtInteres.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Interés a recibir";
            // 
            // txtMontoFinal
            // 
            this.txtMontoFinal.Enabled = false;
            this.txtMontoFinal.Location = new System.Drawing.Point(133, 217);
            this.txtMontoFinal.Name = "txtMontoFinal";
            this.txtMontoFinal.ReadOnly = true;
            this.txtMontoFinal.Size = new System.Drawing.Size(140, 20);
            this.txtMontoFinal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Monto final";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(18, 259);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(155, 29);
            this.btnSimular.TabIndex = 12;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(180, 259);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 29);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(18, 305);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(255, 29);
            this.btnAlta.TabIndex = 14;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lstPlazoFijo
            // 
            this.lstPlazoFijo.FormattingEnabled = true;
            this.lstPlazoFijo.Location = new System.Drawing.Point(6, 38);
            this.lstPlazoFijo.Name = "lstPlazoFijo";
            this.lstPlazoFijo.Size = new System.Drawing.Size(408, 199);
            this.lstPlazoFijo.TabIndex = 0;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(183, 268);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(178, 20);
            this.txtMontoTotal.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Monto Total";
            // 
            // txtComTotal
            // 
            this.txtComTotal.Location = new System.Drawing.Point(183, 314);
            this.txtComTotal.Name = "txtComTotal";
            this.txtComTotal.Size = new System.Drawing.Size(178, 20);
            this.txtComTotal.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Comisión Total";
            // 
            // FormPlazoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPlazoFijo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPlazoFijo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtMontoFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTasaInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtComTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstPlazoFijo;
    }
}

