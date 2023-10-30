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
    public partial class formaMenu : Form
    {
        public formaMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tenisVoleibolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            voleibol datosForm = new voleibol();
            datosForm.ShowDialog(); 
            this.Close();
        }

        private void tenisFutbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            futbol datosForm = new futbol();
            datosForm.ShowDialog(); 
            this.Close();
        }
    }
}
