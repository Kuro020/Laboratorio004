
namespace Laboratorio004.View
{
    partial class Main
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(113, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(104, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Digite um número";
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(113, 63);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(100, 23);
            this.tbxNumero.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(244, 63);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultado.Location = new System.Drawing.Point(113, 106);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(206, 70);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 231);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.lblTitulo);
            this.KeyPreview = true;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de calculo quadrado";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}