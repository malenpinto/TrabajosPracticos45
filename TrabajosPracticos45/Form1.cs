using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosPracticos45
{
    public partial class Form1 : Form
    {
        public Form1()
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
            TBListaNumeros.Items.Clear();

            // Validación: Asegúrate de que 'desde' sea menor o igual a 'hasta'
            if (desde <= hasta)
            {
                // Generar los números y agregarlos al ListBox
                for (int i = desde; i <= hasta; i++)
                {
                    TBListaNumeros.Items.Add(i);
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
    }
}
