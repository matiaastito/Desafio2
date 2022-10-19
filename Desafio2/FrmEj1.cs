using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Desafio2
{
    public partial class FrmEj1 : Form
    {
        public FrmEj1()
        {
            InitializeComponent();
        }

        private void btnIngresarNota_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingresar nota del alumno. Debe ser un numero entre 0 y 10");
            float nota = float.Parse(Interaction.InputBox("Nota: ", "Carga de nota"));
            while (nota < 0 || nota > 10)
            {
                MessageBox.Show("La nota ingresada no es valida. Pruebe nuevamente.");
                nota = float.Parse(Interaction.InputBox("Nota: ", "Carga de nota"));
            }
            if (nota >= 7)
            {
                MessageBox.Show("El alumno ha promocionado.");
            }
            else if (nota >= 4)
            {
                MessageBox.Show("El alumno ha aprobado.");
            }
            else
            {
                MessageBox.Show("El alumno deberá recuperar.");
            }
        }
    }
}
