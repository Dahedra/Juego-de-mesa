using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Trabajo_Práctico_Lab_II
{
    class Ficha
    {
        string estadoActual = "Continua";
        int posicion = 1;
        protected string nombre;
        internal Dragon dragonFuego = new Dragon();
        internal Dragon dragonHielo = new Dragon();

        public string Nombre
        {
            get { return nombre; }
        }
        public string EstadoActual 
        { 
            get { return estadoActual; } 

            set { estadoActual = value; } 
        }
        public int NuevaPosicion 
        { 
            get { return posicion; } 
            set { posicion = value; } 
        }
        public int PosicionDragonFuego
        {
            get { return dragonFuego.Posicion; }
        }
        public int PosicionDragonHielo
        {
            get { return dragonHielo.Posicion; }
        }
    }
}
