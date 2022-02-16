using System;
using System.Collections;
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
    public partial class Jugar : Form
    {
        ModoJuego juego;
        Menu menu;
        public Jugar()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            menu = new Menu();
            menu.ShowDialog();
            Close();
        }
        private void btnBasico_Click(object sender, EventArgs e)
        {
            juego = new ModoJuego("Basico", Convert.ToInt32(txbCantVirtual.Text), txbNombre.Text);
            juego.pbxMapa.BackgroundImage = _1__Trabajo_Práctico_Lab_II.Properties.Resources.Basic_map;
            juego.btnDado.Enabled = true;

            Hide();
            juego.ShowDialog();
        }

        private void btnIntermedio_Click(object sender, EventArgs e)
        {
            juego = new ModoJuego("Intermedio", Convert.ToInt32(txbCantVirtual.Text), txbNombre.Text);
            juego.pbxMapa.BackgroundImage = _1__Trabajo_Práctico_Lab_II.Properties.Resources.intermedio;
            juego.btnDado.Enabled = true;

            Hide();
            juego.ShowDialog();
        }

        private void btnExperto_Click(object sender, EventArgs e)
        {
            juego = new ModoJuego("Experto", Convert.ToInt32(txbCantVirtual.Text), txbNombre.Text);
            juego.pbxMapa.BackgroundImage = _1__Trabajo_Práctico_Lab_II.Properties.Resources.experto;
            juego.btnDado.Enabled = true;

            Hide();
            juego.ShowDialog();
        }

        private void Jugar_Load(object sender, EventArgs e)
        {

        }

        private void txbCantVirtual_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
