namespace Nomina
{
    partial class frmPago
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtHorasRegulares = new System.Windows.Forms.TextBox();
            this.txtHorasExtra = new System.Windows.Forms.TextBox();
            this.txtDobleTurno = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnRecarga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago por horas regulares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pago por horas extra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pago por doble turno";
            // 
            // txtHorasRegulares
            // 
            this.txtHorasRegulares.Location = new System.Drawing.Point(75, 39);
            this.txtHorasRegulares.Name = "txtHorasRegulares";
            this.txtHorasRegulares.Size = new System.Drawing.Size(121, 20);
            this.txtHorasRegulares.TabIndex = 3;
            // 
            // txtHorasExtra
            // 
            this.txtHorasExtra.Location = new System.Drawing.Point(75, 89);
            this.txtHorasExtra.Name = "txtHorasExtra";
            this.txtHorasExtra.Size = new System.Drawing.Size(121, 20);
            this.txtHorasExtra.TabIndex = 4;
            // 
            // txtDobleTurno
            // 
            this.txtDobleTurno.Location = new System.Drawing.Point(75, 138);
            this.txtDobleTurno.Name = "txtDobleTurno";
            this.txtDobleTurno.Size = new System.Drawing.Size(121, 20);
            this.txtDobleTurno.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(35, 174);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRecarga
            // 
            this.btnRecarga.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRecarga.Location = new System.Drawing.Point(159, 174);
            this.btnRecarga.Name = "btnRecarga";
            this.btnRecarga.Size = new System.Drawing.Size(75, 23);
            this.btnRecarga.TabIndex = 7;
            this.btnRecarga.Text = "Recargar Datos";
            this.btnRecarga.UseVisualStyleBackColor = true;
            this.btnRecarga.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmPago
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRecarga;
            this.ClientSize = new System.Drawing.Size(278, 218);
            this.Controls.Add(this.btnRecarga);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtDobleTurno);
            this.Controls.Add(this.txtHorasExtra);
            this.Controls.Add(this.txtHorasRegulares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tasas de pago por hora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHorasRegulares;
        private System.Windows.Forms.TextBox txtHorasExtra;
        private System.Windows.Forms.TextBox txtDobleTurno;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnRecarga;
    }
}