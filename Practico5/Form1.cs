using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            // Configurar el OpenFileDialog para seleccionar imágenes
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

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
    }
}
