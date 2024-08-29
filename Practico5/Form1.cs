using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.RowTemplate.Height = 80;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar una imagen predeterminada en el PictureBox
            /*try
            {
                string rutaPredeterminada = Path.Combine(Application.StartupPath, "Fotos", "Avatar1.jpg");
                pictureBox1.Image = Image.FromFile(rutaPredeterminada);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Imagen predeterminada no encontrada: " + ex.Message);
            }*/

           
        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            // Configurar el OpenFileDialog para seleccionar imágenes
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp"
            };

            // Mostrar el cuadro de diálogo y verificar si el usuario selecciona un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta completa del archivo seleccionado
                string rutaImagen = openFileDialog.FileName;

                // Mostrar la imagen en el PictureBox
                pictureBox1.Image = Image.FromFile(rutaImagen);

                // Mostrar la ruta de la imagen en el TextBox TxtFoto
                TFoto.Text = rutaImagen;
            }
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            // Validar que el nombre y apellido sean correctos
            FormatearTexto(TNombre);
            FormatearTexto(TApellido);

            //Validacion de Saldo 
            if (string.IsNullOrWhiteSpace(TSaldo.Text) || !decimal.TryParse(TSaldo.Text, out decimal saldo) || saldo < 0)
            {
                MessageBox.Show("Por favor, ingrese un saldo válido (mayor o igual a 0).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TSaldo.Focus();
            }

            //Validacion  de Fecha de Nacimiento
            DateTime fechaNacimiento = dateTimePicker1.Value;

            if (fechaNacimiento > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser una fecha futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Focus();
            }

            //Validacion Sexo 
            if (!RBHombre.Checked && !RBMujer.Checked)
            {
                MessageBox.Show("Por favor, seleccione un sexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validar si todos los campos cumplen las condiciones
            if (CamposValidos())
            {
                string apellido = TApellido.Text;
                string nombre = TNombre.Text;
                fechaNacimiento = dateTimePicker1.Value;
                string sexo = RBHombre.Checked ? "Hombre" : "Mujer";
                saldo = Convert.ToDecimal(TSaldo.Text);
                string rutaFoto = string.IsNullOrWhiteSpace(TFoto.Text)
                                  ? Path.Combine(Application.StartupPath, "Fotos", "Avatar1.jpg")
                                  : TFoto.Text;

                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                row.Cells["Apellido"].Value = apellido;
                row.Cells["Nombre"].Value = nombre;
                row.Cells["FechaNacimiento"].Value = fechaNacimiento.ToShortDateString();
                row.Cells["Sexo"].Value = sexo;
                row.Cells["Saldo"].Value = saldo;
                row.Cells["Foto"].Value = Image.FromFile(rutaFoto);
                row.Cells["Ruta"].Value = rutaFoto;

                if (saldo < 50)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }

                LimpiarFormulario();
            }
        }

        private bool CamposValidos()
        {
            // Validar si todos los campos cumplen las condiciones
            bool nombreValido = !string.IsNullOrWhiteSpace(TNombre.Text) && TNombre.Text.Length > 1;
            bool apellidoValido = !string.IsNullOrWhiteSpace(TApellido.Text) && TApellido.Text.Length > 1;
            bool saldoValido = !string.IsNullOrWhiteSpace(TSaldo.Text) && decimal.TryParse(TSaldo.Text, out decimal saldo) && saldo >= 0;
            bool fechaValida = dateTimePicker1.Value <= DateTime.Now;
            bool sexoValido = RBHombre.Checked || RBMujer.Checked;

            return nombreValido && apellidoValido && saldoValido && fechaValida && sexoValido;
        }

        private void LimpiarFormulario()
        {
            TNombre.Clear();
            TApellido.Clear();
            TSaldo.Clear();
            TFoto.Clear();
            RBHombre.Checked = false;
            RBMujer.Checked = false;
            dateTimePicker1.Value = DateTime.Now;

            // Mantener la imagen predeterminada
            if (string.IsNullOrWhiteSpace(TFoto.Text))
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Fotos", "Avatar1.jpg"));
            }
        }

        private void FormatearTexto(TextBox textBox)
        {
            // Validar si el TextBox tiene contenido
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return;
            }

            // Obtener el texto del TextBox
            string texto = textBox.Text;

            // Validar si el texto es alfabético (permitiendo espacios y guiones)
            if (!texto.All(c => char.IsLetter(c) || c == ' ' || c == '-'))
            {
                MessageBox.Show("Por favor, ingrese solo letras, espacios y guiones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = string.Empty; // Limpiar el TextBox si contiene caracteres no alfabéticos
                return;
            }

            // Dividir el texto en palabras
            string[] palabras = texto.Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

            // Convertir cada palabra a mayúscula en la primera letra y minúscula en las demás
            for (int i = 0; i < palabras.Length; i++)
            {
                palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
            }

            // Reconstruir el texto con las palabras formateadas, respetando los separadores originales (espacios y guiones)
            string textoFormateado = string.Join(" ", texto.Split(' ')
                                    .Select(s => string.Join("-", s.Split('-')
                                    .Select(p => char.ToUpper(p[0]) + p.Substring(1).ToLower()))));

            // Asignar el texto formateado al TextBox
            textBox.Text = textoFormateado;

            // Colocar el cursor al final del texto
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void TNombre_Leave(object sender, EventArgs e)
        {
            FormatearTexto((TextBox)sender);
        }

        private void TApellido_Leave(object sender, EventArgs e)
        {
            FormatearTexto((TextBox)sender);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna de Eliminar y que el índice de la fila sea válido
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                // Verificar si la fila no es la nueva fila sin confirmar
                if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    // Confirmar si el usuario desea eliminar el registro
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Desactivar temporalmente el manejo del evento para evitar múltiples mensajes
                        dataGridView1.CellContentClick -= DataGridView1_CellContentClick;

                        // Eliminar la fila seleccionada
                        dataGridView1.Rows.RemoveAt(e.RowIndex);

                        // Volver a activar el manejo del evento
                        dataGridView1.CellContentClick += DataGridView1_CellContentClick;
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar una fila nueva sin confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
