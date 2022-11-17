using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOvni
{
    public partial class Gerenciador : Form
    {
        // OVNI global:
        BibliotecaOVNI.OVNI ovni;
        
        // Construtor:
        public Gerenciador(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
            // Atrinbuir o ovni local para o global:
            this.ovni = ovni;
            AtualizarInterface();
            // Popular o combobox:
            cmbPlaneta.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        private void AtualizarInterface()
        {
            // Exibir ou ocultar os groupBoxes:
            grbTripulacao.Visible = ovni.Situacao;
            grbPlaneta.Visible = ovni.Situacao;
            grbEstatisticas.Visible = ovni.Situacao;
            grbAbduzido.Visible = ovni.Situacao;
            // Exibir ou ocultar os botões:
            btnDesligar.Visible = ovni.Situacao;
            btnLigar.Visible = !ovni.Situacao;
            btnAtualizarPlaneta.Visible = ovni.Situacao;
            btnRetornarPlanetaOrigem.Visible = ovni.Situacao;

            // Atualizar o planeta do combobox:
            cmbPlaneta.SelectedItem = ovni.PlanetaAtual;

            // Atualizar as estatísticas:
            lblTripulantes.Text = "Tripulantes: " + ovni.QtdTripulantes;
            lblAbduzidos.Text = "Abduzidos: " + ovni.QtdAbduzidos;
            lblPlanetaAtual.Text = "Planeta atual: " + ovni.PlanetaAtual;
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            ovni.Ligar();
            AtualizarInterface();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            ovni.Desligar();
            AtualizarInterface();
        }

        private void btnAddTripulante_Click(object sender, EventArgs e)
        {
            // Mesma coisa que if (ovni.AdicionarTripulante() == false)
            if (!ovni.AdicionarTripulante())
            {
                MessageBox.Show("Número máximo atingido!", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInterface();
        }

        private void btnAddAbduzido_Click(object sender, EventArgs e)
        {
            if (!ovni.Abduzir())
            {
                MessageBox.Show("Número máximo atingido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInterface();
        }

        private void btnRemovTripulante_Click(object sender, EventArgs e)
        {
            if (!ovni.RemoverTripulante())
            {
                MessageBox.Show("Número mínimo atingido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInterface();
        }

        private void btnRemovAbduzido_Click(object sender, EventArgs e)
        {
            if (!ovni.Desabduzir())
            {
                MessageBox.Show("Número mínimo atingido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInterface();
        }

        private void btnAtualizarPlaneta_Click(object sender, EventArgs e)
        {
            ovni.MudarPlaneta(cmbPlaneta.Text);

            AtualizarInterface();
        }

        private void btnRetornarPlanetaOrigem_Click(object sender, EventArgs e)
        {
            if (!ovni.RetornarAoPlanetaDeOrigem())
            {
                MessageBox.Show("Você já está no planeta de origem!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarInterface();
        }
    }
}
