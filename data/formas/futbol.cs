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
    public partial class futbol : Form
    {
        public futbol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese el nombre de los tenis.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string modelo = comboBoxModelo.SelectedItem.ToString();
            string talla = comboBoxTalla.SelectedItem.ToString();
            string color = txtColor.Text;
            if (string.IsNullOrWhiteSpace(color))
            {
                MessageBox.Show("Por favor, ingrese el color de los tenis.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataVoley.Rows.Add(nombre, precio, modelo, talla, color);

            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            comboBoxModelo.SelectedIndex = -1;
            comboBoxTalla.SelectedIndex = -1;
            txtColor.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataVoley.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataVoley.SelectedRows)
                {
                    dataVoley.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataVoley.SelectedRows.Count > 0)
            {
                txtNombre.Enabled = true;
                txtPrecio.Enabled = true;
                comboBoxModelo.Enabled = true;
                comboBoxTalla.Enabled = true;
                txtColor.Enabled = true;

                DataGridViewRow selectedRow = dataVoley.SelectedRows[0];
                txtNombre.Text = selectedRow.Cells[0].Value.ToString();
                txtPrecio.Text = selectedRow.Cells[1].Value.ToString();
                comboBoxModelo.SelectedItem = selectedRow.Cells[2].Value;
                comboBoxTalla.SelectedItem = selectedRow.Cells[3].Value;
                txtColor.Text = selectedRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataVoley.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataVoley.SelectedRows[0];
                selectedRow.Cells[0].Value = txtNombre.Text;
                selectedRow.Cells[1].Value = txtPrecio.Text;
                selectedRow.Cells[2].Value = comboBoxModelo.SelectedItem;
                selectedRow.Cells[3].Value = comboBoxTalla.SelectedItem;
                selectedRow.Cells[4].Value = txtColor.Text;

                txtNombre.Enabled = false;
                txtPrecio.Enabled = false;
                comboBoxModelo.Enabled = false;
                comboBoxTalla.Enabled = false;
                txtColor.Enabled = false;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
