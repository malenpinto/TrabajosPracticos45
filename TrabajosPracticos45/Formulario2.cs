using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practico4
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
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
            UpdateChart("GenerarFuncion");
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
                    if (i % 2 == 0)
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
            UpdateChart("Pares");
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
            UpdateChart("Impares");
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

            if (desde <= hasta)
            {
                for (int i = desde; i <= hasta; i++)
                {
                    if (EsPrimo(i))
                    {
                        LBListaNumeros.Items.Add(i);
                    }
                }
            }
            UpdateChart("Primos");
        }

        // Función auxiliar para verificar si un número es primo
        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;// 1 o números menores no son primos
            if (numero == 2) return true;// 2 es el único número par que es primo

            // Verificamos divisibilidad solo hasta la raíz cuadrada del número
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) // Si es divisible por 'i', no es primo
                {
                    return false;
                }
            }
            return true; // Si no se encuentra ningún divisor, el número es primo
        }


        private void UpdateChart(string tipo)
        {
            chart1.Series.Clear(); // Limpiar las series anteriores
            Series serie = new Series("Números");

            // Cambiar el tipo de gráfico según el tipo de números seleccionado
            switch (tipo)
            {
                case "Pares":
                    serie.ChartType = SeriesChartType.Column; // Gráfico de columnas para números pares
                    break;
                case "Impares":
                    serie.ChartType = SeriesChartType.Line; // Gráfico de líneas para números impares
                    break;
                case "Primos":
                    serie.ChartType = SeriesChartType.Point; // Gráfico de puntos para números primos
                    break;
                case "GenerarFuncion":
                    serie.ChartType = SeriesChartType.Area; // Gráfico de área como ejemplo para "Generar Función"
                    break;
                default:
                    serie.ChartType = SeriesChartType.Column; // Gráfico por defecto
                    break;
            }

            // Agregar los valores al gráfico
            foreach (var item in LBListaNumeros.Items)
            {
                serie.Points.AddXY(item, Convert.ToInt32(item));
            }

            chart1.Series.Add(serie);
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

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TDesde.Clear();
            THasta.Clear();
            LBListaNumeros.Items.Clear();
            chart1.Series.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
