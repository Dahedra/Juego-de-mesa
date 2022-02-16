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
using System.Media;

namespace _1__Trabajo_Práctico_Lab_II
{
    public partial class ModoJuego : Form
    {
        Basico tablero;
        Ficha[] jugadores;
        Random random = new Random();
        Jugar jugar;
        int dado;
        int nivelDemo = 1;
        string modo;

        /* JUGADORES */
        int cualJugador = 1;
        int cantJugadores;
        double posJ = 0, posV1 = 0, posV2 = 0, posV3 = 0;
        int aux, aux2;

        //POSICIONES TABLERO
        int[] posX = new int[10];
        int[] posY = new int[5];

        //DRAGONES Y DUNGEONS
        double posDragon, pos1Dungeon, pos2Dungeon, pos3Dungeon;

        public ModoJuego(string modo, int cantidad, string nombre) //CONSTRUCTOR JUEGO
        {
            InitializeComponent();

            int i = 1;
            this.modo = modo;
            cantJugadores = cantidad + 1; //cantidad de jugadores virtuales + jugador
            jugadores = new Ficha[cantJugadores];

            jugadores[0] = new Jugador(nombre);

            for (i = 1 ; i < cantJugadores; i++)
                jugadores[i] = new Virtual(i - 1);
            
            i = 1;
            while (i <= cantJugadores)
            {
                //muestra el color de cada jugador
                switch (i) 
                {
                    case 1:
                        lbxNegro.Items.Add(jugadores[0].Nombre + " juega con ficha negra.");
                        break;
                    case 2:
                        lbxRojo.Items.Add(jugadores[1].Nombre + " juega con ficha roja.");
                        break;
                    case 3:
                        {
                            lbxAzul.Visible = true;
                            lbxAzul.Items.Add(jugadores[2].Nombre + " juega con ficha azul.");
                            break;
                        }
                    case 4:
                        {
                            lbxVerde.Visible = true;
                            lbxVerde.Items.Add(jugadores[3].Nombre + " juega con ficha verde.");
                            break;
                        }
                }
                i++;
            }

            PosicionarFichas();
            
            if (modo == "Basico")
            {
                tablero = new Basico();

            }

            else if (modo == "Intermedio")
            {
                tablero = new Intermedio();
                tablero.Jugadores(cantJugadores, ref jugadores);
                PosicionarDragones();
            }

            else if (modo == "Experto")
            {
                tablero = new Experto();
                tablero.Jugadores(cantJugadores, ref jugadores);
                PosicionarDragones();
                PosicionarDungeons();
            }
        }
        public ModoJuego() //CONSTRUCTOR DEMO
        {
            InitializeComponent();

            cantJugadores = 2;
            jugadores = new Ficha[cantJugadores];

            for (int i = 0; i < cantJugadores; i++)
                jugadores[i] = new Virtual(i);

            lbxNegro.Items.Add(jugadores[0].Nombre + " juega con ficha negra.");
            lbxRojo.Items.Add(jugadores[1].Nombre + " juega con ficha roja.");

            btnDado.Text = "Demo";
        }


        private void Jugar()
        {
            dado = random.Next(1, 7);
            Dado(dado);
            
            if (tablero.Turno(ref jugadores[cualJugador - 1])) //pregunta si puede mover la ficha
            {
                MoverFichas();
                lbxSeguimiento.Items.Add(jugadores[cualJugador - 1].Nombre + " tiró: " + dado.ToString() + " y se movió: " + dado.ToString());
                lbxSeguimiento.Items.Add(jugadores[cualJugador - 1].Nombre + " " + jugadores[cualJugador - 1].EstadoActual);

                if (jugadores[cualJugador - 1].EstadoActual == "encontró un dragón aliado!")
                {
                    lbxSeguimiento.Items.Add(jugadores[cualJugador - 1].Nombre + " avanza 5 casillas.");

                    Dado(5);
                    MoverFichas();
                }

                if (jugadores[cualJugador - 1].EstadoActual == "encontró un dragón enemigo!")
                {
                    lbxSeguimiento.Items.Add(jugadores[cualJugador - 1].Nombre + " retrocede 5 casillas.");

                    Dado(-5);
                    MoverFichas();
                }

                lbxSeguimiento.Items.Add("\n");
                cualJugador++;
            }
            else
                cualJugador++; //sino pasa turno

            if (cualJugador == cantJugadores + 1) //resetea la ronda
                cualJugador = 1;
        }
        private void CorrerDemo()
        {
            switch(nivelDemo)
            {
                case 1:
                    {
                        tablero = new Basico();
                        PosicionarFichas();

                        while (tablero.Partida) //pregunta si la partida sigue
                        {
                            Jugar();
                        }

                        lbNombreMapa.Text = "Demo Finalizada";
                        lbNombreJugador.Text = "Correr Demo Intermedio?";
                        nivelDemo++;

                        pbxMapa.BackgroundImage = _1__Trabajo_Práctico_Lab_II.Properties.Resources.intermedio;
                        break;
                    }
                case 2:
                    {
                        jugadores[0].NuevaPosicion = 1;
                        jugadores[1].NuevaPosicion = 1;
                        posJ = 0; posV1 = 0;
                        lbxSeguimiento.Items.Clear();

                        tablero = new Intermedio();
                        PosicionarFichas();
                        PosicionarDragones();
                        tablero.Jugadores(cantJugadores, ref jugadores);

                        while (tablero.Partida) //pregunta si la partida sigue
                        {
                            Jugar();

                            PosicionarDragones();
                        }

                        lbNombreMapa.Text = "Demo Finalizada";
                        lbNombreJugador.Text = "Correr Demo Experto?";
                        nivelDemo++;

                        pbxMapa.BackgroundImage = _1__Trabajo_Práctico_Lab_II.Properties.Resources.experto;
                        break;
                    }
                case 3:
                    {
                        jugadores[0].NuevaPosicion = 1;
                        jugadores[1].NuevaPosicion = 1;
                        posJ = 0; posV1 = 0;
                        lbxSeguimiento.Items.Clear();

                        tablero = new Experto();
                        PosicionarFichas();
                        PosicionarDragones();
                        PosicionarDungeons();
                        tablero.Jugadores(cantJugadores, ref jugadores);

                        while (tablero.Partida) //pregunta si la partida sigue
                        {
                            Jugar();

                            PosicionarDragones();
                        }

                        lbNombreMapa.Text = "Demo Finalizada";
                        btnDado.Enabled = false;
                        btnResultados.Enabled = true;
                        nivelDemo = 0; ;
                        break;
                    }
            }
        }
        private void CorrerJuego()
        {
            if (tablero.Partida) //pregunta si la partida sigue
            {
                Jugar();
            }

            else //muestra el boton de resultados
            {
                btnDado.Enabled = false;
                btnDado.Visible = false;
                btnResultados.Enabled = true;
                btnResultados.Visible = true;
                lbDadoResultado.Text = "";
            }
        }
        private void PosicionarFichas()
        {
            //setear tablero
            posX[0] = 27;
            for (int x = 1; x < 10; x++)
                posX[x] = (100 * x) + 27;

            posY[0] = 100;
            for (int y = 1; y < 5; y++)
                posY[y] = (139 * y) + 100;

            //setea jugadores
            int i = 1;
            while(i <= cantJugadores)
            {
                switch (i)
                {
                    case 1:
                        {
                            fichaJugador.Left = 27;
                            fichaJugador.Top = 100;
                            fichaJugador.Visible = true;
                            break;
                        }
                    case 2:
                        {
                            fichaVirtual1.Left = 75;
                            fichaVirtual1.Top = 100;
                            fichaVirtual1.Visible = true;
                            break;
                        }
                    case 3:
                        {
                            fichaVirtual2.Left = 27;
                            fichaVirtual2.Top = 165;
                            fichaVirtual2.Visible = true;
                            break;
                        }
                    case 4:
                        {
                            fichaVirtual3.Left = 75;
                            fichaVirtual3.Top = 165;
                            fichaVirtual3.Visible = true;
                            break;
                        }
                }
                i++;
            }
        }
        private void MoverFichas()
        {
            switch (cualJugador)
            {
                case 1:
                    {
                        aux = Convert.ToInt32(((posJ / 10) - (Math.Floor(posJ / 10))) * 10);
                        aux2 = Convert.ToInt32(Math.Floor(posJ / 10));

                        fichaJugador.Left = posX[aux];
                        fichaJugador.Top = posY[aux2];
                        break;
                    }
                case 2:
                    {
                        aux = Convert.ToInt32(((posV1 / 10) - (Math.Floor(posV1 / 10))) * 10);
                        aux2 = Convert.ToInt32(Math.Floor(posV1 / 10));

                        fichaVirtual1.Left = 47 + posX[aux];
                        fichaVirtual1.Top = posY[aux2];
                        break;
                    }
                case 3:
                    {
                        aux = Convert.ToInt32(((posV2 / 10) - (Math.Floor(posV2 / 10))) * 10);
                        aux2 = Convert.ToInt32(Math.Floor(posV2 / 10));

                        fichaVirtual2.Left = 47 + posX[aux];
                        fichaVirtual2.Top = 65 + posY[aux2];
                        break;
                    }
                case 4:
                    {
                        aux = Convert.ToInt32(((posV3 / 10) - (Math.Floor(posV3 / 10))) * 10);
                        aux2 = Convert.ToInt32(Math.Floor(posV3 / 10));

                        fichaVirtual3.Left = posX[aux];
                        fichaVirtual3.Top = 65 + posY[aux2];
                        break;
                    }
            }
        }
        private void Dado(int dado)
        {

            switch (cualJugador)
            {
                case 1:
                    {
                        posJ += dado;

                        if (posJ < 0)
                            posJ = 0;
                        if (posJ > 49)
                            posJ = 49;

                        jugadores[0].NuevaPosicion = (int)posJ;
                        break;
                    }
                case 2:
                    {
                        posV1 += dado;

                        if (posV1 < 0)
                            posV1 = 0;
                        if (posV1 > 49)
                            posV1 = 49;

                        jugadores[1].NuevaPosicion = (int)posV1;
                        break;
                    }
                case 3:
                    {
                        posV2 += dado;

                        if (posV2 < 0)
                            posV2 = 0;
                        if (posV2 > 49)
                            posV2 = 49;

                        jugadores[2].NuevaPosicion = (int)posV2;
                        break;
                    }
                case 4:
                    {
                        posV3 += dado;

                        if (posV3 < 0)
                            posV3 = 0;
                        if (posV3 > 49)
                            posV3 = 49;

                        jugadores[3].NuevaPosicion = (int)posV3;
                        break;
                    }
            }
        }
        private void PosicionarDragones() 
        {
            int i = 1;
            while (i <= cantJugadores * 2)
            {
                switch (i)
                {
                    case 1:
                        {
                            posDragon = random.Next(1, 50);
                            jugadores[0].dragonFuego.Posicion = Convert.ToInt32(posDragon);

                            aux = Convert.ToInt32(((posDragon / 10) - (Math.Floor(posDragon / 10))) * 10);
                            aux2 = Convert.ToInt32(Math.Floor(posDragon / 10));

                            fichaDragon1J.Left = posX[aux];
                            fichaDragon1J.Top = posY[aux2];
                            fichaDragon1J.Visible = true;
                            break;
                        }
                    case 2:
                        {
                            posDragon = random.Next(1, 50);
                            jugadores[0].dragonHielo.Posicion = Convert.ToInt32(posDragon);

                            aux = Convert.ToInt32(((posDragon / 10) - (Math.Floor(posDragon / 10))) * 10);
                            aux2 = Convert.ToInt32(Math.Floor(posDragon / 10));

                            fichaDragon2J.Left = posX[aux];
                            fichaDragon2J.Top = posY[aux2];
                            fichaDragon2J.Visible = true;
                            break;
                        }
                    case 3:
                        {
                            posDragon = random.Next(1, 50);
                            jugadores[1].dragonFuego.Posicion = Convert.ToInt32(posDragon);

                            aux = Convert.ToInt32(((posDragon / 10) - (Math.Floor(posDragon / 10))) * 10);
                            aux2 = Convert.ToInt32(Math.Floor(posDragon / 10));

                            fichaDragon1V1.Left = posX[aux];
                            fichaDragon1V1.Top = posY[aux2];
                            fichaDragon1V1.Visible = true;
                            break;
                        }
                    case 4:
                        {
                            posDragon = random.Next(1, 50);
                            jugadores[1].dragonHielo.Posicion = Convert.ToInt32(posDragon);

                            aux = Convert.ToInt32(((posDragon / 10) - (Math.Floor(posDragon / 10))) * 10);
                            aux2 = Convert.ToInt32(Math.Floor(posDragon / 10));

                            fichaDragon2V1.Left = posX[aux];
                            fichaDragon2V1.Top = posY[aux2];
                            fichaDragon2V1.Visible = true;
                            break;
                        }
                    case 5:
                        {
                            posDragon = random.Next(1, 50);
                            jugadores[2].dragonFuego.Posicion = Convert.ToInt32(posDragon);

                            aux = Convert.ToInt32(((posDragon / 10) - (Math.Floor(posDragon / 10))) * 10);
                            aux2 = Convert.ToInt32(Math.Floor(posDragon / 10));

                            fichaDragon1V2.Left = posX[aux];
                            fichaDragon1V2.Top = posY[aux2];
                            fichaDragon1V2.Visible = true;
                            break;
                        }
                    case 6:
                        {
                            posDragon = random.Next(1, 50);
                            jugadores[2].dragonHielo.Posicion = Convert.ToInt32(posDragon);

                            aux = Convert.ToInt32(((posDragon / 10) - (Math.Floor(posDragon / 10))) * 10);
                            aux2 = Convert.ToInt32(Math.Floor(posDragon / 10));

                            fichaDragon2V2.Left = posX[aux];
                            fichaDragon2V2.Top = posY[aux2];
                            fichaDragon2V2.Visible = true;
                            break;
                        }
                    case 7:
                        {
                            posDragon = random.Next(1, 50);
                            jugadores[3].dragonFuego.Posicion = Convert.ToInt32(posDragon);

                            aux = Convert.ToInt32(((posDragon / 10) - (Math.Floor(posDragon / 10))) * 10);
                            aux2 = Convert.ToInt32(Math.Floor(posDragon / 10));

                            fichaDragon1V3.Left = posX[aux];
                            fichaDragon1V3.Top = posY[aux2];
                            fichaDragon1V3.Visible = true;
                            break;
                        }
                    case 8:
                        {
                            posDragon = random.Next(1, 50);
                            jugadores[3].dragonHielo.Posicion = Convert.ToInt32(posDragon);

                            aux = Convert.ToInt32(((posDragon / 10) - (Math.Floor(posDragon / 10))) * 10);
                            aux2 = Convert.ToInt32(Math.Floor(posDragon / 10));

                            fichaDragon2V3.Left = posX[aux];
                            fichaDragon2V3.Top = posY[aux2];
                            fichaDragon2V3.Visible = true;
                            break;
                        }
                }
                i++;
            }
        }

        private void lbxSeguimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PosicionarDungeons()
        {
            int i = 1;
            while (i <= 3)
            {
                switch (i)
                {
                    case 1:
                        {
                            pos1Dungeon = random.Next(1, 50);

                            aux = Convert.ToInt32(((pos1Dungeon / 10) - (Math.Floor(pos1Dungeon / 10))) * 10);
                            aux2 = Convert.ToInt32(Math.Floor(pos1Dungeon / 10));

                            fichaDungeon1.Left = posX[aux];
                            fichaDungeon1.Top = posY[aux2] + 10;
                            fichaDungeon1.Visible = true;
                            break;
                        }
                    case 2:
                        {
                            pos2Dungeon = random.Next(1, 50);
                            while (pos2Dungeon == pos1Dungeon)
                                pos2Dungeon = random.Next(1, 50);

                            aux = Convert.ToInt32(((pos2Dungeon / 10) - (Math.Floor(pos2Dungeon / 10))) * 10);
                            aux2 = Convert.ToInt32(Math.Floor(pos2Dungeon / 10));

                            fichaDungeon2.Left = posX[aux];
                            fichaDungeon2.Top = posY[aux2];
                            fichaDungeon2.Visible = true;
                            break;
                        }
                    case 3:
                        {
                            pos3Dungeon = random.Next(1, 50);
                            while(pos3Dungeon == pos2Dungeon || pos3Dungeon == pos1Dungeon)
                                pos3Dungeon = random.Next(1, 50);

                            aux = Convert.ToInt32(((pos3Dungeon / 10) - (Math.Floor(pos3Dungeon / 10))) * 10);
                            aux2 = Convert.ToInt32(Math.Floor(pos3Dungeon / 10));

                            fichaDungeon3.Left = posX[aux];
                            fichaDungeon3.Top = posY[aux2];
                            fichaDungeon3.Visible = true;
                            break;
                        }
                }
                i++;
            }

            tablero.SetearDungeons((int)pos1Dungeon, (int)pos2Dungeon, (int)pos3Dungeon);
        } 


        private void btnDado_Click(object sender, EventArgs e)
        {
            if (btnDado.Text == "Demo")
                CorrerDemo();
            else if (modo == "Basico")
            {
                CorrerJuego();
            }
            else if (modo == "Intermedio")
            {
                CorrerJuego();
                btnDado.Enabled = false;
                btnDragon.Enabled = true;
                btnDragon.Visible = true;
            }
            else if (modo == "Experto")
            {
                CorrerJuego();
                btnDado.Enabled = false;
                btnDragon.Enabled = true;
                btnDragon.Visible = true;
            }
        }
        private void btnDragon_Click(object sender, EventArgs e)
        {
            PosicionarDragones();
            btnDado.Enabled = true;
            btnDragon.Enabled = false;
            btnDragon.Visible = false;
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {     
            jugar = new Jugar();

            Hide();
            jugar.ShowDialog();
        }
        private void btnResultados_Click(object sender, EventArgs e)
        {
            Score.MostrarScore();
        }


        private void fichaJugador_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
