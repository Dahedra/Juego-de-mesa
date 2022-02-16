using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Trabajo_Práctico_Lab_II
{
    internal static class Score
    {
        static ArrayList nombres = new ArrayList(4);
        static ArrayList puntaje = new ArrayList(4);
        internal static void ActualizarScore(string nombre)
        {
            if (nombres.Contains(nombre))
                puntaje[nombre.IndexOf(nombre)] = (int)puntaje[nombre.IndexOf(nombre)] + 1;

            else
            {
                nombres.Add(nombre);
                puntaje.Add(1);
            }
        }
        internal static void MostrarScore()
        {
            Puntaje resultados = new Puntaje();

            for (int i = 0; i < nombres.Count; i++)
            {
                resultados.lbxPuntaje.Items.Add(nombres[i] + " ganó " + puntaje[i].ToString());
            }

            resultados.ShowDialog();
        }
    }
}
