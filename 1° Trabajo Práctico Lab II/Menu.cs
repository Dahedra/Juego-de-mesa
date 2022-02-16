using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1__Trabajo_Práctico_Lab_II
{
    public partial class Menu : Form
    {
        Jugar jugar = new Jugar();

        public Menu()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jugar.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModoJuego juego = new ModoJuego();
            juego.pbxMapa.BackgroundImage = _1__Trabajo_Práctico_Lab_II.Properties.Resources.Basic_map;
            juego.btnDado.Enabled = true;

            Hide();
            juego.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            Score.MostrarScore();
        }
    }
}
