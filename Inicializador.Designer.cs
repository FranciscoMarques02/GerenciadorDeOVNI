namespace GerenciadorDeOvni
{
    partial class Inicializador
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
            this.pibIcone = new System.Windows.Forms.PictureBox();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.txbTripulantes = new System.Windows.Forms.NumericUpDown();
            this.txbAbduzidos = new System.Windows.Forms.NumericUpDown();
            this.lblPlanetaOrigem = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibGrama = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTripulantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAbduzidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibGrama)).BeginInit();
            this.SuspendLayout();
            // 
            // pibIcone
            // 
            this.pibIcone.Image = global::GerenciadorDeOvni.Properties.Resources.ovni;
            this.pibIcone.Location = new System.Drawing.Point(68, 135);
            this.pibIcone.Name = "pibIcone";
            this.pibIcone.Size = new System.Drawing.Size(167, 175);
            this.pibIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibIcone.TabIndex = 0;
            this.pibIcone.TabStop = false;
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripulantes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTripulantes.Location = new System.Drawing.Point(288, 135);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(198, 22);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "MAX TRIPULANTES:";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbduzidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAbduzidos.Location = new System.Drawing.Point(288, 173);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(178, 22);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "MAX ABDUZIDOS:";
            // 
            // txbTripulantes
            // 
            this.txbTripulantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTripulantes.Location = new System.Drawing.Point(529, 132);
            this.txbTripulantes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txbTripulantes.Name = "txbTripulantes";
            this.txbTripulantes.Size = new System.Drawing.Size(215, 29);
            this.txbTripulantes.TabIndex = 3;
            this.txbTripulantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTripulantes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txbAbduzidos
            // 
            this.txbAbduzidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAbduzidos.Location = new System.Drawing.Point(530, 170);
            this.txbAbduzidos.Name = "txbAbduzidos";
            this.txbAbduzidos.Size = new System.Drawing.Size(214, 29);
            this.txbAbduzidos.TabIndex = 4;
            this.txbAbduzidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlanetaOrigem
            // 
            this.lblPlanetaOrigem.AutoSize = true;
            this.lblPlanetaOrigem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetaOrigem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlanetaOrigem.Location = new System.Drawing.Point(288, 215);
            this.lblPlanetaOrigem.Name = "lblPlanetaOrigem";
            this.lblPlanetaOrigem.Size = new System.Drawing.Size(223, 22);
            this.lblPlanetaOrigem.TabIndex = 5;
            this.lblPlanetaOrigem.Text = "PLANETA DE ORIGEM:";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(528, 211);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(216, 32);
            this.cmbPlanetas.TabIndex = 6;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(295, 259);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(449, 41);
            this.btnCriar.TabIndex = 7;
            this.btnCriar.Text = "CRIAR NAVE";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(176, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(441, 40);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "GERENCIADOR DE OVNI";
            // 
            // pibGrama
            // 
            this.pibGrama.BackColor = System.Drawing.Color.SeaGreen;
            this.pibGrama.Location = new System.Drawing.Point(0, 306);
            this.pibGrama.Name = "pibGrama";
            this.pibGrama.Size = new System.Drawing.Size(800, 143);
            this.pibGrama.TabIndex = 9;
            this.pibGrama.TabStop = false;
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pibGrama);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.lblPlanetaOrigem);
            this.Controls.Add(this.txbAbduzidos);
            this.Controls.Add(this.txbTripulantes);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.lblTripulantes);
            this.Controls.Add(this.pibIcone);
            this.Name = "Inicializador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            ((System.ComponentModel.ISupportInitialize)(this.pibIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTripulantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbAbduzidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibGrama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibIcone;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.NumericUpDown txbTripulantes;
        private System.Windows.Forms.NumericUpDown txbAbduzidos;
        private System.Windows.Forms.Label lblPlanetaOrigem;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibGrama;
    }
}