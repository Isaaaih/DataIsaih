using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data.formas
{
    public partial class DatosForm : Form
    {
        public DatosForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            string edad = txtEdad.Text;
            string genero = GetSelectedGender();
            string escolaridad = cmbEscolaridad.SelectedItem?.ToString();
            string estado = cmbEstado.SelectedItem?.ToString();

            // Validación de campos completados
            if (string.IsNullOrWhiteSpace(apellidos) || string.IsNullOrWhiteSpace(nombres) ||
                string.IsNullOrWhiteSpace(edad) || string.IsNullOrWhiteSpace(genero) ||
                string.IsNullOrWhiteSpace(escolaridad) || string.IsNullOrWhiteSpace(estado))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Abre el formulario "formaMenu" y oculta el formulario actual
                this.Hide();
                formaMenu datosForm = new formaMenu();
                datosForm.ShowDialog(); // Muestra la pantalla principal (DatosForm)
                this.Close();
            }
        }

        private string GetSelectedGender()
        {
            if (chkHombre.Checked)
            {
                return "Hombre";
            }
            else if (chkMujer.Checked)
            {
                return "Mujer";
            }
            else
            {
                return "Otro";
            }
        }
    }
}


