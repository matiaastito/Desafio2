namespace Desafio2
{
    partial class FrmEj3
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
            this.btnIngresarNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarNotas
            // 
            this.btnIngresarNotas.Location = new System.Drawing.Point(240, 104);
            this.btnIngresarNotas.Name = "btnIngresarNotas";
            this.btnIngresarNotas.Size = new System.Drawing.Size(222, 63);
            this.btnIngresarNotas.TabIndex = 0;
            this.btnIngresarNotas.Text = "Ingresar Notas Parciales";
            this.btnIngresarNotas.UseVisualStyleBackColor = true;
            this.btnIngresarNotas.Click += new System.EventHandler(this.btnIngresarNotas_Click);
            // 
            // FrmEj3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresarNotas);
            this.Name = "FrmEj3";
            this.Text = "FrmEj3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarNotas;
    }
}