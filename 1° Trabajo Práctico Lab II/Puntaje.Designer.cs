namespace _1__Trabajo_Práctico_Lab_II
{
    partial class Puntaje
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
            this.lbxPuntaje = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxPuntaje
            // 
            this.lbxPuntaje.BackColor = System.Drawing.Color.Gray;
            this.lbxPuntaje.Font = new System.Drawing.Font("Norse", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPuntaje.FormattingEnabled = true;
            this.lbxPuntaje.ItemHeight = 41;
            this.lbxPuntaje.Location = new System.Drawing.Point(17, 12);
            this.lbxPuntaje.Name = "lbxPuntaje";
            this.lbxPuntaje.Size = new System.Drawing.Size(282, 332);
            this.lbxPuntaje.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Norse", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Puntaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_1__Trabajo_Práctico_Lab_II.Properties.Resources.FONDO_MENU;
            this.ClientSize = new System.Drawing.Size(322, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxPuntaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Puntaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puntaje";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox lbxPuntaje;
        private System.Windows.Forms.Button button1;
    }
}