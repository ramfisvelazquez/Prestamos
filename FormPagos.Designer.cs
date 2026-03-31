namespace Sistma_de_Prestamos
{
    partial class FormPagos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoAnterior = new System.Windows.Forms.TextBox();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInteresPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNuevoSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMesesRestantes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PAGOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto anterior";
            // 
            // txtMontoAnterior
            // 
            this.txtMontoAnterior.Location = new System.Drawing.Point(174, 92);
            this.txtMontoAnterior.Name = "txtMontoAnterior";
            this.txtMontoAnterior.Size = new System.Drawing.Size(180, 22);
            this.txtMontoAnterior.TabIndex = 2;
            this.txtMontoAnterior.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(174, 163);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(180, 22);
            this.txtCuota.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cuota pagada";
            // 
            // txtInteresPago
            // 
            this.txtInteresPago.Location = new System.Drawing.Point(174, 239);
            this.txtInteresPago.Name = "txtInteresPago";
            this.txtInteresPago.Size = new System.Drawing.Size(180, 22);
            this.txtInteresPago.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Interés";
            // 
            // txtNuevoSaldo
            // 
            this.txtNuevoSaldo.Enabled = false;
            this.txtNuevoSaldo.Location = new System.Drawing.Point(174, 317);
            this.txtNuevoSaldo.Name = "txtNuevoSaldo";
            this.txtNuevoSaldo.Size = new System.Drawing.Size(180, 22);
            this.txtNuevoSaldo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nuevo saldo";
            // 
            // txtMesesRestantes
            // 
            this.txtMesesRestantes.Enabled = false;
            this.txtMesesRestantes.Location = new System.Drawing.Point(174, 386);
            this.txtMesesRestantes.Name = "txtMesesRestantes";
            this.txtMesesRestantes.Size = new System.Drawing.Size(180, 22);
            this.txtMesesRestantes.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Meses restantes";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(85, 482);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 40);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(264, 482);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 40);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // FormPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 568);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMesesRestantes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNuevoSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInteresPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontoAnterior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPagos";
            this.Text = "FormPagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontoAnterior;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInteresPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNuevoSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMesesRestantes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRegistrar;
    }
}