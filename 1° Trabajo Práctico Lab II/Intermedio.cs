using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Trabajo_Práctico_Lab_II
{
    class Intermedio : Basico
    {
        public override bool Turno(ref Ficha cualJugador)
        {
            //pregunta si se topo con dragon aliado
            if ((cualJugador.NuevaPosicion == cualJugador.PosicionDragonFuego) || (cualJugador.NuevaPosicion == cualJugador.PosicionDragonHielo))
            {
                cualJugador.EstadoActual = "encontró un dragón aliado!";
                cualJugador.NuevaPosicion += 5;
                return base.Turno(ref cualJugador);
            }

            //pregunta si se topo con dragon enemigo
            foreach (Ficha ficha in jugadores)
            {
                if ((cualJugador.NuevaPosicion == ficha.PosicionDragonFuego) || (cualJugador.NuevaPosicion == ficha.PosicionDragonHielo))
                {
                    cualJugador.EstadoActual = "encontró un dragón enemigo!";
                    cualJugador.NuevaPosicion -= 5;
                    return base.Turno(ref cualJugador);
                }
            }
            //sino
            return base.Turno(ref cualJugador);
        }
    }
}
