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
    public partial class FrmEj3 : Form
    {
        public FrmEj3()
        {
            InitializeComponent();
        }

        private void btnIngresarNotas_Click(object sender, EventArgs e)
        {
            float nota1 = float.Parse(Interaction.InputBox("Ingrese nota del primer parcial", "Carga de notas"));
            float nota2 = float.Parse(Interaction.InputBox("Ingrese nota del segundo parcial", "Carga de notas"));
            if (nota1 >=4 && nota2>=4)
            {
                MessageBox.Show("Felicidades, ha aprobado la materia.");
            }
            else if(nota1 >=4 && nota2 < 4)
            {
                MessageBox.Show("Usted debe recuperar el segundo parcial");
            }
            else if(nota1<4 && nota2 >= 4)
            {
                MessageBox.Show("Usted debe recuperar el primer parcial");
            }
            else
            {
                MessageBox.Show("Usted debe recuperar ambos parciales");
            }
        }
    }
}
