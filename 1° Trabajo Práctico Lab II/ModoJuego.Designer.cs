namespace _1__Trabajo_Práctico_Lab_II
{
    partial class ModoJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModoJuego));
            this.pbxMapa = new System.Windows.Forms.PictureBox();
            this.lbxSeguimiento = new System.Windows.Forms.ListBox();
            this.lbNombreMapa = new System.Windows.Forms.Label();
            this.btnDado = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.fichaVirtual1 = new System.Windows.Forms.Panel();
            this.fichaVirtual2 = new System.Windows.Forms.Panel();
            this.fichaJugador = new System.Windows.Forms.Panel();
            this.fichaVirtual3 = new System.Windows.Forms.Panel();
            this.fichaDragon1V3 = new System.Windows.Forms.Panel();
            this.fichaDragon1J = new System.Windows.Forms.Panel();
            this.fichaDragon1V2 = new System.Windows.Forms.Panel();
            this.fichaDragon1V1 = new System.Windows.Forms.Panel();
            this.fichaDragon2V3 = new System.Windows.Forms.Panel();
            this.fichaDragon2J = new System.Windows.Forms.Panel();
            this.fichaDragon2V2 = new System.Windows.Forms.Panel();
            this.fichaDragon2V1 = new System.Windows.Forms.Panel();
            this.fichaDungeon1 = new System.Windows.Forms.Panel();
            this.fichaDungeon2 = new System.Windows.Forms.Panel();
            this.fichaDungeon3 = new System.Windows.Forms.Panel();
            this.lbDadoResultado = new System.Windows.Forms.Label();
            this.btnDragon = new System.Windows.Forms.Button();
            this.lbxNegro = new System.Windows.Forms.ListBox();
            this.lbNombreJugador = new System.Windows.Forms.Label();
            this.lbxRojo = new System.Windows.Forms.ListBox();
            this.lbxAzul = new System.Windows.Forms.ListBox();
            this.lbxVerde = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMapa
            // 
            this.pbxMapa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMapa.BackgroundImage")));
            this.pbxMapa.ErrorImage = null;
            this.pbxMapa.InitialImage = null;
            this.pbxMapa.Location = new System.Drawing.Point(24, 85);
            this.pbxMapa.Name = "pbxMapa";
            this.pbxMapa.Size = new System.Drawing.Size(1000, 695);
            this.pbxMapa.TabIndex = 0;
            this.pbxMapa.TabStop = false;
            this.pbxMapa.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbxSeguimiento
            // 
            this.lbxSeguimiento.AllowDrop = true;
            this.lbxSeguimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbxSeguimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxSeguimiento.Font = new System.Drawing.Font("Norse", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSeguimiento.FormattingEnabled = true;
            this.lbxSeguimiento.ItemHeight = 30;
            this.lbxSeguimiento.Location = new System.Drawing.Point(1063, 85);
            this.lbxSeguimiento.Name = "lbxSeguimiento";
            this.lbxSeguimiento.Size = new System.Drawing.Size(363, 392);
            this.lbxSeguimiento.TabIndex = 1;
            this.lbxSeguimiento.SelectedIndexChanged += new System.EventHandler(this.lbxSeguimiento_SelectedIndexChanged);
            // 
            // lbNombreMapa
            // 
            this.lbNombreMapa.AutoSize = true;
            this.lbNombreMapa.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreMapa.Font = new System.Drawing.Font("Norse", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreMapa.Location = new System.Drawing.Point(12, 12);
            this.lbNombreMapa.Name = "lbNombreMapa";
            this.lbNombreMapa.Size = new System.Drawing.Size(614, 70);
            this.lbNombreMapa.TabIndex = 2;
            this.lbNombreMapa.Text = "Zona: Páramo de Arathiuee";
            // 
            // btnDado
            // 
            this.btnDado.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDado.Font = new System.Drawing.Font("Norse", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDado.Location = new System.Drawing.Point(1063, 711);
            this.btnDado.Name = "btnDado";
            this.btnDado.Size = new System.Drawing.Size(119, 55);
            this.btnDado.TabIndex = 4;
            this.btnDado.Text = "Dado";
            this.btnDado.UseVisualStyleBackColor = false;
            this.btnDado.Click += new System.EventHandler(this.btnDado_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAtras.Font = new System.Drawing.Font("Norse", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(24, 785);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(192, 35);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Abandonar Partida";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.BackColor = System.Drawing.Color.OrangeRed;
            this.btnResultados.Enabled = false;
            this.btnResultados.Font = new System.Drawing.Font("Norse", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.Location = new System.Drawing.Point(1110, 713);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(290, 66);
            this.btnResultados.TabIndex = 6;
            this.btnResultados.Text = "Ver Resultados";
            this.btnResultados.UseVisualStyleBackColor = false;
            this.btnResultados.Visible = false;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // fichaVirtual1
            // 
            this.fichaVirtual1.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.Virtual1;
            this.fichaVirtual1.Location = new System.Drawing.Point(1231, 29);
            this.fichaVirtual1.Name = "fichaVirtual1";
            this.fichaVirtual1.Size = new System.Drawing.Size(46, 50);
            this.fichaVirtual1.TabIndex = 7;
            this.fichaVirtual1.Visible = false;
            // 
            // fichaVirtual2
            // 
            this.fichaVirtual2.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.Virtual2;
            this.fichaVirtual2.Location = new System.Drawing.Point(1283, 29);
            this.fichaVirtual2.Name = "fichaVirtual2";
            this.fichaVirtual2.Size = new System.Drawing.Size(46, 50);
            this.fichaVirtual2.TabIndex = 8;
            this.fichaVirtual2.Visible = false;
            // 
            // fichaJugador
            // 
            this.fichaJugador.BackColor = System.Drawing.Color.Transparent;
            this.fichaJugador.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.Player;
            this.fichaJugador.Location = new System.Drawing.Point(1179, 29);
            this.fichaJugador.Name = "fichaJugador";
            this.fichaJugador.Size = new System.Drawing.Size(46, 50);
            this.fichaJugador.TabIndex = 9;
            this.fichaJugador.Visible = false;
            this.fichaJugador.Paint += new System.Windows.Forms.PaintEventHandler(this.fichaJugador_Paint);
            // 
            // fichaVirtual3
            // 
            this.fichaVirtual3.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.Virtual3;
            this.fichaVirtual3.Location = new System.Drawing.Point(1335, 29);
            this.fichaVirtual3.Name = "fichaVirtual3";
            this.fichaVirtual3.Size = new System.Drawing.Size(46, 50);
            this.fichaVirtual3.TabIndex = 9;
            this.fichaVirtual3.Visible = false;
            // 
            // fichaDragon1V3
            // 
            this.fichaDragon1V3.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.DragonVirtual3;
            this.fichaDragon1V3.Location = new System.Drawing.Point(1335, 123);
            this.fichaDragon1V3.Name = "fichaDragon1V3";
            this.fichaDragon1V3.Size = new System.Drawing.Size(46, 50);
            this.fichaDragon1V3.TabIndex = 12;
            this.fichaDragon1V3.Visible = false;
            // 
            // fichaDragon1J
            // 
            this.fichaDragon1J.BackColor = System.Drawing.Color.Transparent;
            this.fichaDragon1J.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.DragonPlayer;
            this.fichaDragon1J.Location = new System.Drawing.Point(1179, 123);
            this.fichaDragon1J.Name = "fichaDragon1J";
            this.fichaDragon1J.Size = new System.Drawing.Size(46, 50);
            this.fichaDragon1J.TabIndex = 13;
            this.fichaDragon1J.Visible = false;
            // 
            // fichaDragon1V2
            // 
            this.fichaDragon1V2.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.DragonVirtual2;
            this.fichaDragon1V2.Location = new System.Drawing.Point(1283, 123);
            this.fichaDragon1V2.Name = "fichaDragon1V2";
            this.fichaDragon1V2.Size = new System.Drawing.Size(46, 50);
            this.fichaDragon1V2.TabIndex = 11;
            this.fichaDragon1V2.Visible = false;
            // 
            // fichaDragon1V1
            // 
            this.fichaDragon1V1.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.DragonVirtual1;
            this.fichaDragon1V1.Location = new System.Drawing.Point(1231, 123);
            this.fichaDragon1V1.Name = "fichaDragon1V1";
            this.fichaDragon1V1.Size = new System.Drawing.Size(46, 50);
            this.fichaDragon1V1.TabIndex = 10;
            this.fichaDragon1V1.Visible = false;
            // 
            // fichaDragon2V3
            // 
            this.fichaDragon2V3.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.DragonVirtual3;
            this.fichaDragon2V3.Location = new System.Drawing.Point(1335, 193);
            this.fichaDragon2V3.Name = "fichaDragon2V3";
            this.fichaDragon2V3.Size = new System.Drawing.Size(46, 50);
            this.fichaDragon2V3.TabIndex = 12;
            this.fichaDragon2V3.Visible = false;
            // 
            // fichaDragon2J
            // 
            this.fichaDragon2J.BackColor = System.Drawing.Color.Transparent;
            this.fichaDragon2J.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.DragonPlayer;
            this.fichaDragon2J.Location = new System.Drawing.Point(1179, 193);
            this.fichaDragon2J.Name = "fichaDragon2J";
            this.fichaDragon2J.Size = new System.Drawing.Size(46, 50);
            this.fichaDragon2J.TabIndex = 13;
            this.fichaDragon2J.Visible = false;
            // 
            // fichaDragon2V2
            // 
            this.fichaDragon2V2.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.DragonVirtual2;
            this.fichaDragon2V2.Location = new System.Drawing.Point(1283, 193);
            this.fichaDragon2V2.Name = "fichaDragon2V2";
            this.fichaDragon2V2.Size = new System.Drawing.Size(46, 50);
            this.fichaDragon2V2.TabIndex = 11;
            this.fichaDragon2V2.Visible = false;
            // 
            // fichaDragon2V1
            // 
            this.fichaDragon2V1.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.DragonVirtual1;
            this.fichaDragon2V1.Location = new System.Drawing.Point(1231, 193);
            this.fichaDragon2V1.Name = "fichaDragon2V1";
            this.fichaDragon2V1.Size = new System.Drawing.Size(46, 50);
            this.fichaDragon2V1.TabIndex = 10;
            this.fichaDragon2V1.Visible = false;
            // 
            // fichaDungeon1
            // 
            this.fichaDungeon1.BackColor = System.Drawing.Color.Transparent;
            this.fichaDungeon1.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.Dungeon;
            this.fichaDungeon1.Location = new System.Drawing.Point(1123, 298);
            this.fichaDungeon1.Name = "fichaDungeon1";
            this.fichaDungeon1.Size = new System.Drawing.Size(90, 86);
            this.fichaDungeon1.TabIndex = 13;
            this.fichaDungeon1.Visible = false;
            // 
            // fichaDungeon2
            // 
            this.fichaDungeon2.BackColor = System.Drawing.Color.Transparent;
            this.fichaDungeon2.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.Dungeon;
            this.fichaDungeon2.Location = new System.Drawing.Point(1231, 298);
            this.fichaDungeon2.Name = "fichaDungeon2";
            this.fichaDungeon2.Size = new System.Drawing.Size(90, 86);
            this.fichaDungeon2.TabIndex = 14;
            this.fichaDungeon2.Visible = false;
            // 
            // fichaDungeon3
            // 
            this.fichaDungeon3.BackColor = System.Drawing.Color.Transparent;
            this.fichaDungeon3.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.Dungeon;
            this.fichaDungeon3.Location = new System.Drawing.Point(1336, 298);
            this.fichaDungeon3.Name = "fichaDungeon3";
            this.fichaDungeon3.Size = new System.Drawing.Size(90, 86);
            this.fichaDungeon3.TabIndex = 14;
            this.fichaDungeon3.Visible = false;
            // 
            // lbDadoResultado
            // 
            this.lbDadoResultado.AutoSize = true;
            this.lbDadoResultado.BackColor = System.Drawing.Color.Transparent;
            this.lbDadoResultado.Font = new System.Drawing.Font("Norse", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDadoResultado.ForeColor = System.Drawing.Color.Cyan;
            this.lbDadoResultado.Location = new System.Drawing.Point(1224, 727);
            this.lbDadoResultado.Name = "lbDadoResultado";
            this.lbDadoResultado.Size = new System.Drawing.Size(0, 39);
            this.lbDadoResultado.TabIndex = 15;
            // 
            // btnDragon
            // 
            this.btnDragon.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDragon.Enabled = false;
            this.btnDragon.Font = new System.Drawing.Font("Norse", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDragon.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnDragon.Location = new System.Drawing.Point(1063, 772);
            this.btnDragon.Name = "btnDragon";
            this.btnDragon.Size = new System.Drawing.Size(119, 55);
            this.btnDragon.TabIndex = 16;
            this.btnDragon.Text = "Dragón";
            this.btnDragon.UseVisualStyleBackColor = false;
            this.btnDragon.Visible = false;
            this.btnDragon.Click += new System.EventHandler(this.btnDragon_Click);
            // 
            // lbxNegro
            // 
            this.lbxNegro.BackColor = System.Drawing.Color.DarkGray;
            this.lbxNegro.Font = new System.Drawing.Font("Norse", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxNegro.FormattingEnabled = true;
            this.lbxNegro.ItemHeight = 30;
            this.lbxNegro.Location = new System.Drawing.Point(1063, 511);
            this.lbxNegro.Name = "lbxNegro";
            this.lbxNegro.Size = new System.Drawing.Size(296, 34);
            this.lbxNegro.TabIndex = 17;
            // 
            // lbNombreJugador
            // 
            this.lbNombreJugador.AutoSize = true;
            this.lbNombreJugador.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreJugador.Font = new System.Drawing.Font("Norse", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreJugador.Location = new System.Drawing.Point(1056, 669);
            this.lbNombreJugador.Name = "lbNombreJugador";
            this.lbNombreJugador.Size = new System.Drawing.Size(221, 41);
            this.lbNombreJugador.TabIndex = 3;
            this.lbNombreJugador.Text = "Nombre Jugador";
            // 
            // lbxRojo
            // 
            this.lbxRojo.BackColor = System.Drawing.Color.Red;
            this.lbxRojo.Font = new System.Drawing.Font("Norse", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRojo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbxRojo.FormattingEnabled = true;
            this.lbxRojo.ItemHeight = 30;
            this.lbxRojo.Location = new System.Drawing.Point(1063, 551);
            this.lbxRojo.Name = "lbxRojo";
            this.lbxRojo.Size = new System.Drawing.Size(296, 34);
            this.lbxRojo.TabIndex = 18;
            // 
            // lbxAzul
            // 
            this.lbxAzul.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbxAzul.Font = new System.Drawing.Font("Norse", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAzul.FormattingEnabled = true;
            this.lbxAzul.ItemHeight = 30;
            this.lbxAzul.Location = new System.Drawing.Point(1063, 591);
            this.lbxAzul.Name = "lbxAzul";
            this.lbxAzul.Size = new System.Drawing.Size(296, 34);
            this.lbxAzul.TabIndex = 19;
            this.lbxAzul.Visible = false;
            // 
            // lbxVerde
            // 
            this.lbxVerde.BackColor = System.Drawing.Color.LightGreen;
            this.lbxVerde.Font = new System.Drawing.Font("Norse", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxVerde.FormattingEnabled = true;
            this.lbxVerde.ItemHeight = 30;
            this.lbxVerde.Location = new System.Drawing.Point(1063, 631);
            this.lbxVerde.Name = "lbxVerde";
            this.lbxVerde.Size = new System.Drawing.Size(296, 34);
            this.lbxVerde.TabIndex = 20;
            this.lbxVerde.Visible = false;
            // 
            // ModoJuego
            // 
            this.AcceptButton = this.btnDado;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnAtras;
            this.ClientSize = new System.Drawing.Size(1501, 846);
            this.Controls.Add(this.lbxVerde);
            this.Controls.Add(this.lbxAzul);
            this.Controls.Add(this.lbxRojo);
            this.Controls.Add(this.lbxNegro);
            this.Controls.Add(this.btnDragon);
            this.Controls.Add(this.lbDadoResultado);
            this.Controls.Add(this.fichaDungeon3);
            this.Controls.Add(this.fichaDungeon2);
            this.Controls.Add(this.fichaDragon2V3);
            this.Controls.Add(this.fichaDungeon1);
            this.Controls.Add(this.fichaDragon1V3);
            this.Controls.Add(this.fichaDragon2J);
            this.Controls.Add(this.fichaDragon2V2);
            this.Controls.Add(this.fichaDragon1J);
            this.Controls.Add(this.fichaDragon2V1);
            this.Controls.Add(this.fichaDragon1V2);
            this.Controls.Add(this.fichaDragon1V1);
            this.Controls.Add(this.fichaVirtual3);
            this.Controls.Add(this.fichaJugador);
            this.Controls.Add(this.fichaVirtual2);
            this.Controls.Add(this.fichaVirtual1);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnDado);
            this.Controls.Add(this.lbNombreJugador);
            this.Controls.Add(this.lbNombreMapa);
            this.Controls.Add(this.lbxSeguimiento);
            this.Controls.Add(this.pbxMapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModoJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModoBasico";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtras;
        internal System.Windows.Forms.PictureBox pbxMapa;
        internal System.Windows.Forms.ListBox lbxSeguimiento;
        internal System.Windows.Forms.Label lbNombreMapa;
        internal System.Windows.Forms.Button btnDado;
        internal System.Windows.Forms.Button btnResultados;
        internal System.Windows.Forms.Panel fichaVirtual1;
        internal System.Windows.Forms.Panel fichaVirtual2;
        internal System.Windows.Forms.Panel fichaJugador;
        internal System.Windows.Forms.Panel fichaVirtual3;
        internal System.Windows.Forms.Panel fichaDragon1V3;
        internal System.Windows.Forms.Panel fichaDragon1J;
        internal System.Windows.Forms.Panel fichaDragon1V2;
        internal System.Windows.Forms.Panel fichaDragon1V1;
        internal System.Windows.Forms.Panel fichaDragon2V3;
        internal System.Windows.Forms.Panel fichaDragon2J;
        internal System.Windows.Forms.Panel fichaDragon2V2;
        internal System.Windows.Forms.Panel fichaDragon2V1;
        internal System.Windows.Forms.Panel fichaDungeon1;
        internal System.Windows.Forms.Panel fichaDungeon2;
        internal System.Windows.Forms.Panel fichaDungeon3;
        internal System.Windows.Forms.Label lbDadoResultado;
        internal System.Windows.Forms.Button btnDragon;
        private System.Windows.Forms.ListBox lbxNegro;
        internal System.Windows.Forms.Label lbNombreJugador;
        private System.Windows.Forms.ListBox lbxRojo;
        private System.Windows.Forms.ListBox lbxAzul;
        private System.Windows.Forms.ListBox lbxVerde;
    }
}