namespace Desafio2
{
    partial class FrmEj2
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
            this.btnIngresarNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarNum
            // 
            this.btnIngresarNum.Location = new System.Drawing.Point(217, 30);
            this.btnIngresarNum.Name = "btnIngresarNum";
            this.btnIngresarNum.Size = new System.Drawing.Size(188, 54);
            this.btnIngresarNum.TabIndex = 0;
            this.btnIngresarNum.Text = "Ingresar Numero";
            this.btnIngresarNum.UseVisualStyleBackColor = true;
            this.btnIngresarNum.Click += new System.EventHandler(this.btnIngresarNum_Click);
            // 
            // FrmEj2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresarNum);
            this.Name = "FrmEj2";
            this.Text = "FrmEj2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarNum;
    }
}