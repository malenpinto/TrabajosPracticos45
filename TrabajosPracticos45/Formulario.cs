using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico4
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void BGenerarFuncion_Click(object sender, EventArgs e)
        {
            // Variables para almacenar los valores desde y hasta
            int desde, hasta;

            // Validación: Verifica que los TextBox no estén vacíos y que contengan solo números
            if (string.IsNullOrWhiteSpace(TDesde.Text) || !int.TryParse(TDesde.Text, out desde))
            {
                MessageBox.Show("Ingrese un valor numérico válido en 'Desde'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(THasta.Text) || !int.TryParse(THasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese un valor numérico válido en 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiar el ListBox antes de agregar los números
            LBListaNumeros.Items.Clear();

            // Validación: Asegúrate de que 'desde' sea menor o igual a 'hasta'
            if (desde <= hasta)
            {
                // Generar los números y agregarlos al ListBox
                for (int i = desde; i <= hasta; i++)
                {
                    LBListaNumeros.Items.Add(i);
                }
            } 
            else 
            { 
                MessageBox.Show("'Desde' debe ser menor o igual a 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de la tecla
            }
        }

        private void THasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de la tecla
            }
        }

        private void BNumPares_Click(object sender, EventArgs e)
        {
            // Variables para almacenar los valores desde y hasta
            int desde, hasta;

            // Validación: Verifica que los TextBox no estén vacíos y que contengan solo números
            if (string.IsNullOrWhiteSpace(TDesde.Text) || !int.TryParse(TDesde.Text, out desde))
            {
                MessageBox.Show("Ingrese un valor numérico válido en 'Desde'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(THasta.Text) || !int.TryParse(THasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese un valor numérico válido en 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiar el ListBox antes de agregar los números
            LBListaNumeros.Items.Clear();

            // Validación: Asegúrate de que 'desde' sea menor o igual a 'hasta'
            if (desde <= hasta)
            {
                // Generar los números pares y agrega a la ListBox
                for (int i = desde; i <= hasta; i++)
                {
                    if (i%2 == 0)
                    {
                        LBListaNumeros.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("'Desde' debe ser menor o igual a 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BNumImpares_Click(object sender, EventArgs e)
        {
            // Variables para almacenar los valores desde y hasta
            int desde, hasta;

            // Validación: Verifica que los TextBox no estén vacíos y que contengan solo números
            if (string.IsNullOrWhiteSpace(TDesde.Text) || !int.TryParse(TDesde.Text, out desde))
            {
                MessageBox.Show("Ingrese un valor numérico válido en 'Desde'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(THasta.Text) || !int.TryParse(THasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese un valor numérico válido en 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiar el ListBox antes de agregar los números
            LBListaNumeros.Items.Clear();

            // Validación: Asegúrate de que 'desde' sea menor o igual a 'hasta'
            if (desde <= hasta)
            {
                // Generar los números pares y agrega a la ListBox
                for (int i = desde; i <= hasta; i++)
                {
                    if (i % 2 != 0)
                    {
                        LBListaNumeros.Items.Add(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("'Desde' debe ser menor o igual a 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BNumPrimos_Click(object sender, EventArgs e)
        {
            //Variables para almacenar los valores desde y hasta
            int desde, hasta;

            //Validación: Verifica que los TextBox no esten vacios y que contengan solo números
            if (string.IsNullOrWhiteSpace(TDesde.Text) || !int.TryParse(TDesde.Text, out desde))
            {
                MessageBox.Show("Ingrese un valor numérico válido en 'Desde'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(THasta.Text) || !int.TryParse(THasta.Text, out hasta))
            {
                MessageBox.Show("Ingrese un valor numérico válido en 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LBListaNumeros.Items.Clear();

            if(desde <= hasta)
            {
                for(int i = desde;i <= hasta; i++)
                {
                    if (EsPrimo(i))
                    {
                        LBListaNumeros.Items.Add(i);
                    }
                }
            }
        }

        // Función auxiliar para verificar si un número es primo
        private bool EsPrimo(int numero) 
        {
            if(numero <= 1) return false;// 1 o números menores no son primos
            if (numero == 2) return true;// 2 es el único número par que es primo

            // Verificamos divisibilidad solo hasta la raíz cuadrada del número
            for (int i = 2; i <= Math.Sqrt(numero); i++) 
            {
                if(numero % i == 0) // Si es divisible por 'i', no es primo
                {
                    return false;
                }
            }
            return true; // Si no se encuentra ningún divisor, el número es primo
        }
    }
}
