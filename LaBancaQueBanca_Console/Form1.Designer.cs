namespace LaBancaQueBanca_Console
{
    partial class Form1
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
            this.lstTiposPrestamos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtTNA = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCuotaCapital = new System.Windows.Forms.TextBox();
            this.txtCuotaInteres = new System.Windows.Forms.TextBox();
            this.txtCuotaTotal = new System.Windows.Forms.TextBox();
            this.txtComisionTotal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTiposPrestamos
            // 
            this.lstTiposPrestamos.FormattingEnabled = true;
            this.lstTiposPrestamos.Location = new System.Drawing.Point(12, 51);
            this.lstTiposPrestamos.Name = "lstTiposPrestamos";
            this.lstTiposPrestamos.Size = new System.Drawing.Size(175, 277);
            this.lstTiposPrestamos.TabIndex = 0;
            this.lstTiposPrestamos.SelectedIndexChanged += new System.EventHandler(this.lstTiposPrestamos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "linea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TNA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "plazo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "TIPOS PRESTAMO";
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(265, 51);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(100, 20);
            this.txtLinea.TabIndex = 6;
            // 
            // txtTNA
            // 
            this.txtTNA.Location = new System.Drawing.Point(265, 93);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.Size = new System.Drawing.Size(100, 20);
            this.txtTNA.TabIndex = 7;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(265, 135);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 8;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(265, 177);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(100, 20);
            this.txtPlazo.TabIndex = 9;
            this.txtPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlazo_KeyPress);
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(223, 223);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(142, 35);
            this.btnSimular.TabIndex = 10;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "cuota (capital)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "cuota (interes)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "cuota TOTAL";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(235, 381);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(110, 45);
            this.btnAlta.TabIndex = 14;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(443, 60);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(246, 225);
            this.lstPrestamos.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "COMISION TOTAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(515, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Prestamos dados de alta";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCuotaTotal);
            this.panel1.Controls.Add(this.txtCuotaInteres);
            this.panel1.Controls.Add(this.txtCuotaCapital);
            this.panel1.Location = new System.Drawing.Point(1, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 397);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtComisionTotal);
            this.panel2.Location = new System.Drawing.Point(427, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 340);
            this.panel2.TabIndex = 19;
            // 
            // txtCuotaCapital
            // 
            this.txtCuotaCapital.Location = new System.Drawing.Point(292, 236);
            this.txtCuotaCapital.Name = "txtCuotaCapital";
            this.txtCuotaCapital.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaCapital.TabIndex = 0;
            // 
            // txtCuotaInteres
            // 
            this.txtCuotaInteres.Location = new System.Drawing.Point(292, 270);
            this.txtCuotaInteres.Name = "txtCuotaInteres";
            this.txtCuotaInteres.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaInteres.TabIndex = 1;
            // 
            // txtCuotaTotal
            // 
            this.txtCuotaTotal.Location = new System.Drawing.Point(294, 307);
            this.txtCuotaTotal.Name = "txtCuotaTotal";
            this.txtCuotaTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaTotal.TabIndex = 2;
            // 
            // txtComisionTotal
            // 
            this.txtComisionTotal.Location = new System.Drawing.Point(140, 297);
            this.txtComisionTotal.Name = "txtComisionTotal";
            this.txtComisionTotal.Size = new System.Drawing.Size(100, 20);
            this.txtComisionTotal.TabIndex = 0;
            this.txtComisionTotal.TextChanged += new System.EventHandler(this.txtComisionTotal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txtPlazo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtTNA);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTiposPrestamos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTiposPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtTNA;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCuotaCapital;
        private System.Windows.Forms.TextBox txtCuotaTotal;
        private System.Windows.Forms.TextBox txtCuotaInteres;
        private System.Windows.Forms.TextBox txtComisionTotal;
    }
}

