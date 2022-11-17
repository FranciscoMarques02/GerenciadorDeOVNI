namespace GerenciadorDeOvni
{
    partial class Gerenciador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.grbTripulacao = new System.Windows.Forms.GroupBox();
            this.btnAddTripulante = new System.Windows.Forms.Button();
            this.btnRemovTripulante = new System.Windows.Forms.Button();
            this.grbAbduzido = new System.Windows.Forms.GroupBox();
            this.btnRemovAbduzido = new System.Windows.Forms.Button();
            this.btnAddAbduzido = new System.Windows.Forms.Button();
            this.grbEstatisticas = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblPlanetaAtual = new System.Windows.Forms.Label();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.btnAtualizarPlaneta = new System.Windows.Forms.Button();
            this.btnRetornarPlanetaOrigem = new System.Windows.Forms.Button();
            this.grbTripulacao.SuspendLayout();
            this.grbAbduzido.SuspendLayout();
            this.grbEstatisticas.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(204, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(441, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GERENCIADOR DE OVNI";
            // 
            // btnLigar
            // 
            this.btnLigar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLigar.FlatAppearance.BorderSize = 0;
            this.btnLigar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnLigar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnLigar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLigar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.Location = new System.Drawing.Point(134, 104);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(130, 50);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "LIGAR";
            this.btnLigar.UseVisualStyleBackColor = false;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDesligar.FlatAppearance.BorderSize = 0;
            this.btnDesligar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDesligar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDesligar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesligar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.Location = new System.Drawing.Point(295, 104);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(134, 50);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "DESLIGAR";
            this.btnDesligar.UseVisualStyleBackColor = false;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // grbTripulacao
            // 
            this.grbTripulacao.Controls.Add(this.btnRemovTripulante);
            this.grbTripulacao.Controls.Add(this.btnAddTripulante);
            this.grbTripulacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbTripulacao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTripulacao.Location = new System.Drawing.Point(136, 160);
            this.grbTripulacao.Name = "grbTripulacao";
            this.grbTripulacao.Size = new System.Drawing.Size(293, 140);
            this.grbTripulacao.TabIndex = 3;
            this.grbTripulacao.TabStop = false;
            this.grbTripulacao.Text = "TRIPULAÇÃO";
            // 
            // btnAddTripulante
            // 
            this.btnAddTripulante.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAddTripulante.FlatAppearance.BorderSize = 0;
            this.btnAddTripulante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTripulante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTripulante.Location = new System.Drawing.Point(7, 39);
            this.btnAddTripulante.Name = "btnAddTripulante";
            this.btnAddTripulante.Size = new System.Drawing.Size(268, 43);
            this.btnAddTripulante.TabIndex = 0;
            this.btnAddTripulante.Text = "ADICIONAR";
            this.btnAddTripulante.UseVisualStyleBackColor = false;
            this.btnAddTripulante.Click += new System.EventHandler(this.btnAddTripulante_Click);
            // 
            // btnRemovTripulante
            // 
            this.btnRemovTripulante.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRemovTripulante.FlatAppearance.BorderSize = 0;
            this.btnRemovTripulante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovTripulante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovTripulante.Location = new System.Drawing.Point(7, 88);
            this.btnRemovTripulante.Name = "btnRemovTripulante";
            this.btnRemovTripulante.Size = new System.Drawing.Size(268, 45);
            this.btnRemovTripulante.TabIndex = 1;
            this.btnRemovTripulante.Text = "REMOVER";
            this.btnRemovTripulante.UseVisualStyleBackColor = false;
            this.btnRemovTripulante.Click += new System.EventHandler(this.btnRemovTripulante_Click);
            // 
            // grbAbduzido
            // 
            this.grbAbduzido.Controls.Add(this.btnRemovAbduzido);
            this.grbAbduzido.Controls.Add(this.btnAddAbduzido);
            this.grbAbduzido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbAbduzido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAbduzido.Location = new System.Drawing.Point(136, 317);
            this.grbAbduzido.Name = "grbAbduzido";
            this.grbAbduzido.Size = new System.Drawing.Size(293, 138);
            this.grbAbduzido.TabIndex = 4;
            this.grbAbduzido.TabStop = false;
            this.grbAbduzido.Text = "ABDUZIDOS";
            // 
            // btnRemovAbduzido
            // 
            this.btnRemovAbduzido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRemovAbduzido.FlatAppearance.BorderSize = 0;
            this.btnRemovAbduzido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovAbduzido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovAbduzido.Location = new System.Drawing.Point(7, 89);
            this.btnRemovAbduzido.Name = "btnRemovAbduzido";
            this.btnRemovAbduzido.Size = new System.Drawing.Size(268, 43);
            this.btnRemovAbduzido.TabIndex = 1;
            this.btnRemovAbduzido.Text = "REMOVER";
            this.btnRemovAbduzido.UseVisualStyleBackColor = false;
            this.btnRemovAbduzido.Click += new System.EventHandler(this.btnRemovAbduzido_Click);
            // 
            // btnAddAbduzido
            // 
            this.btnAddAbduzido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAddAbduzido.FlatAppearance.BorderSize = 0;
            this.btnAddAbduzido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAbduzido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAbduzido.Location = new System.Drawing.Point(7, 40);
            this.btnAddAbduzido.Name = "btnAddAbduzido";
            this.btnAddAbduzido.Size = new System.Drawing.Size(268, 43);
            this.btnAddAbduzido.TabIndex = 0;
            this.btnAddAbduzido.Text = "ADICIONAR";
            this.btnAddAbduzido.UseVisualStyleBackColor = false;
            this.btnAddAbduzido.Click += new System.EventHandler(this.btnAddAbduzido_Click);
            // 
            // grbEstatisticas
            // 
            this.grbEstatisticas.Controls.Add(this.lblPlanetaAtual);
            this.grbEstatisticas.Controls.Add(this.lblAbduzidos);
            this.grbEstatisticas.Controls.Add(this.lblTripulantes);
            this.grbEstatisticas.Controls.Add(this.lblStatus);
            this.grbEstatisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbEstatisticas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEstatisticas.Location = new System.Drawing.Point(489, 98);
            this.grbEstatisticas.Name = "grbEstatisticas";
            this.grbEstatisticas.Size = new System.Drawing.Size(274, 195);
            this.grbEstatisticas.TabIndex = 5;
            this.grbEstatisticas.TabStop = false;
            this.grbEstatisticas.Text = "ESTATÍSTICAS";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(16, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(161, 22);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "STATUS: Ligado";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(16, 73);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(140, 22);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes : 1";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(16, 112);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(129, 22);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Abduzidos: 0";
            // 
            // lblPlanetaAtual
            // 
            this.lblPlanetaAtual.AutoSize = true;
            this.lblPlanetaAtual.Location = new System.Drawing.Point(16, 153);
            this.lblPlanetaAtual.Name = "lblPlanetaAtual";
            this.lblPlanetaAtual.Size = new System.Drawing.Size(135, 22);
            this.lblPlanetaAtual.TabIndex = 3;
            this.lblPlanetaAtual.Text = "Planeta atual:";
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.cmbPlaneta);
            this.grbPlaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbPlaneta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPlaneta.Location = new System.Drawing.Point(489, 334);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Size = new System.Drawing.Size(224, 66);
            this.grbPlaneta.TabIndex = 6;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "PLANETA";
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(7, 29);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(187, 30);
            this.cmbPlaneta.TabIndex = 0;
            // 
            // btnAtualizarPlaneta
            // 
            this.btnAtualizarPlaneta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAtualizarPlaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarPlaneta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarPlaneta.Location = new System.Drawing.Point(489, 416);
            this.btnAtualizarPlaneta.Name = "btnAtualizarPlaneta";
            this.btnAtualizarPlaneta.Size = new System.Drawing.Size(224, 33);
            this.btnAtualizarPlaneta.TabIndex = 7;
            this.btnAtualizarPlaneta.Text = "ATUALIZAR";
            this.btnAtualizarPlaneta.UseVisualStyleBackColor = false;
            this.btnAtualizarPlaneta.Click += new System.EventHandler(this.btnAtualizarPlaneta_Click);
            // 
            // btnRetornarPlanetaOrigem
            // 
            this.btnRetornarPlanetaOrigem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRetornarPlanetaOrigem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornarPlanetaOrigem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornarPlanetaOrigem.Location = new System.Drawing.Point(489, 456);
            this.btnRetornarPlanetaOrigem.Name = "btnRetornarPlanetaOrigem";
            this.btnRetornarPlanetaOrigem.Size = new System.Drawing.Size(224, 23);
            this.btnRetornarPlanetaOrigem.TabIndex = 8;
            this.btnRetornarPlanetaOrigem.Text = "RETORNAR AO PLANETA DE ORIGEM";
            this.btnRetornarPlanetaOrigem.UseVisualStyleBackColor = false;
            this.btnRetornarPlanetaOrigem.Click += new System.EventHandler(this.btnRetornarPlanetaOrigem_Click);
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(877, 541);
            this.Controls.Add(this.btnRetornarPlanetaOrigem);
            this.Controls.Add(this.btnAtualizarPlaneta);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbEstatisticas);
            this.Controls.Add(this.grbAbduzido);
            this.Controls.Add(this.grbTripulacao);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.grbTripulacao.ResumeLayout(false);
            this.grbAbduzido.ResumeLayout(false);
            this.grbEstatisticas.ResumeLayout(false);
            this.grbEstatisticas.PerformLayout();
            this.grbPlaneta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.GroupBox grbTripulacao;
        private System.Windows.Forms.Button btnRemovTripulante;
        private System.Windows.Forms.Button btnAddTripulante;
        private System.Windows.Forms.GroupBox grbAbduzido;
        private System.Windows.Forms.Button btnRemovAbduzido;
        private System.Windows.Forms.Button btnAddAbduzido;
        private System.Windows.Forms.GroupBox grbEstatisticas;
        private System.Windows.Forms.Label lblPlanetaAtual;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Button btnAtualizarPlaneta;
        private System.Windows.Forms.Button btnRetornarPlanetaOrigem;
    }
}