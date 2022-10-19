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
    public partial class FrmEj2 : Form
    {
        public FrmEj2()
        {
            InitializeComponent();
        }

        private void btnIngresarNum_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(Interaction.InputBox("Ingrese el primer numero", "Carga numeros"));
            int numero2 = int.Parse(Interaction.InputBox("Ingrese el segundo numero", "Carga numeros"));
            if (numero1 > numero2)
            {
                int resultadoSuma = numero1 + numero2;
                int resultadoResta = numero1 - numero2;
                MessageBox.Show("La suma de ambos numeros es igual a " + resultadoSuma + "\nLa diferencia entre ambos es igual a " + resultadoResta);
            }
            else
            {
                int resultadoProducto = numero1 * numero2;
                float resultadoDivision = (float) numero1 / (float) numero2;
                MessageBox.Show("El producto entre ambos numeros es igual a " + resultadoProducto + "\nLa division del primero respecto al segundo es igual a " + resultadoDivision); 
            }
        }
    }
}
