using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Trabajo_Práctico_Lab_II
{
    class Basico
    {
        protected Calabozo[] calabozo = new Calabozo[3];
        protected bool partida = true;
        protected Ficha[] jugadores;
        public void Jugadores(int cantidad, ref Ficha[] players)
        {
            jugadores = new Ficha[cantidad];
            jugadores = players;
        }
        public virtual bool Turno(ref Ficha cualJugador)
        {
            if (cualJugador.EstadoActual == " un dragón enemigo habita en la cueva, juego perdido.")
                return false;

            if (EstadoDeLaPartida(cualJugador.NuevaPosicion) == false) //pregunta si gano
            {
                cualJugador.EstadoActual = "Ganó.";
                Score.ActualizarScore(cualJugador.Nombre);
                partida = false;
            }
            return true;
        }
        public bool EstadoDeLaPartida(int posicion)
        {
            if (posicion >= 49)
            {
                partida = false;
                return false;
            }
            else
                return true;
        }
        public bool Partida 
        { 
            get { return partida; } 
        }
        public void SetearDungeons(int pos1, int pos2, int pos3)
        {
            for (int i = 0; i < 3; i++)
                calabozo[i] = new Calabozo();

            calabozo[0].Posicion = pos1;
            calabozo[1].Posicion = pos2;
            calabozo[2].Posicion = pos3;
        }
    }
}
