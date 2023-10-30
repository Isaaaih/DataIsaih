using data.formas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intentosRestantes = 3;

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuario.Length < 3)
            {
                MessageBox.Show("El usuario debe tener al menos 3 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (usuario == "Isai" && contraseña == "isaialv")
                {
                    MessageBox.Show("Bienvenido", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DatosForm datosForm = new DatosForm();
                    datosForm.ShowDialog(); 
                    this.Close();
                }
                else
                {
                    intentosRestantes--;
                    if (intentosRestantes == 0)
                    {
                        btnIniciarSesion.Enabled = false; 
                        MessageBox.Show("Usuario o contraseña incorrectos. Se agotaron los intentos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos. Intentos restantes: " + intentosRestantes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

