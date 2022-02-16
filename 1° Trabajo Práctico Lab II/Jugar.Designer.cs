namespace _1__Trabajo_Práctico_Lab_II
{
    partial class Jugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugar));
            this.btnBasico = new System.Windows.Forms.Button();
            this.btnIntermedio = new System.Windows.Forms.Button();
            this.btnExperto = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCantVirtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBasico
            // 
            this.btnBasico.BackColor = System.Drawing.Color.Orange;
            this.btnBasico.Font = new System.Drawing.Font("Norse", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasico.Location = new System.Drawing.Point(77, 122);
            this.btnBasico.Name = "btnBasico";
            this.btnBasico.Size = new System.Drawing.Size(167, 50);
            this.btnBasico.TabIndex = 0;
            this.btnBasico.Text = "Básico";
            this.btnBasico.UseVisualStyleBackColor = false;
            this.btnBasico.Click += new System.EventHandler(this.btnBasico_Click);
            // 
            // btnIntermedio
            // 
            this.btnIntermedio.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnIntermedio.Font = new System.Drawing.Font("Norse", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntermedio.Location = new System.Drawing.Point(77, 187);
            this.btnIntermedio.Name = "btnIntermedio";
            this.btnIntermedio.Size = new System.Drawing.Size(167, 50);
            this.btnIntermedio.TabIndex = 1;
            this.btnIntermedio.Text = "Intermedio";
            this.btnIntermedio.UseVisualStyleBackColor = false;
            this.btnIntermedio.Click += new System.EventHandler(this.btnIntermedio_Click);
            // 
            // btnExperto
            // 
            this.btnExperto.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnExperto.Font = new System.Drawing.Font("Norse", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExperto.Location = new System.Drawing.Point(77, 253);
            this.btnExperto.Name = "btnExperto";
            this.btnExperto.Size = new System.Drawing.Size(167, 50);
            this.btnExperto.TabIndex = 2;
            this.btnExperto.Text = "Experto";
            this.btnExperto.UseVisualStyleBackColor = false;
            this.btnExperto.Click += new System.EventHandler(this.btnExperto_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Gray;
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAtras.Font = new System.Drawing.Font("Norse", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(77, 344);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(167, 50);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.Color.SeaShell;
            this.txbNombre.Location = new System.Drawing.Point(52, 75);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 4;
            // 
            // txbCantVirtual
            // 
            this.txbCantVirtual.BackColor = System.Drawing.Color.SeaShell;
            this.txbCantVirtual.Location = new System.Drawing.Point(181, 74);
            this.txbCantVirtual.Name = "txbCantVirtual";
            this.txbCantVirtual.Size = new System.Drawing.Size(100, 20);
            this.txbCantVirtual.TabIndex = 5;
            this.txbCantVirtual.TextChanged += new System.EventHandler(this.txbCantVirtual_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Norse", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Norse", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "IA";
            // 
            // Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnAtras;
            this.ClientSize = new System.Drawing.Size(321, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCantVirtual);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnExperto);
            this.Controls.Add(this.btnIntermedio);
            this.Controls.Add(this.btnBasico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugar";
            this.Load += new System.EventHandler(this.Jugar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbCantVirtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnBasico;
        internal System.Windows.Forms.Button btnIntermedio;
        internal System.Windows.Forms.Button btnExperto;
        internal System.Windows.Forms.Button btnAtras;
    }
}