using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Trabajo_Práctico_Lab_II
{
    class Experto : Basico
    {
        public override bool Turno(ref Ficha cualJugador)
        {
            foreach(Calabozo dungeon in calabozo)
            {
                //pregunta si se topo con una dungeon
                if (cualJugador.NuevaPosicion == dungeon.Posicion)
                {
                    cualJugador.EstadoActual = " se perdió dentro de un calabozo, pierde un turno.";

                    //pregunta si se topo con dragon aliado
                    if ((cualJugador.NuevaPosicion == cualJugador.PosicionDragonFuego) || (cualJugador.NuevaPosicion == cualJugador.PosicionDragonHielo))
                    {
                        cualJugador.EstadoActual = " se perdió dentro de un calabozo, un dragón aliado ayuda!";
                        return base.Turno(ref cualJugador);
                    }
                    //pregunta si se topo con dragon enemigo
                    foreach (Ficha ficha in jugadores)
                    {
                        if ((cualJugador.NuevaPosicion == ficha.PosicionDragonFuego) || (cualJugador.NuevaPosicion == ficha.PosicionDragonHielo))
                        {
                            cualJugador.EstadoActual = " un dragón enemigo habita en la cueva, juego perdido.";
                            return base.Turno(ref cualJugador);
                        }
                    }
                }
            }
            
            return base.Turno(ref cualJugador);
        }
    }
}
